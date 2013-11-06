using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TfsService.Models;

namespace TfsService
{
	public class TfsService : ITfsService
	{
		public TfsTeamProjectCollection ConnectToTfs(out string selectedProject)
		{
			TfsTeamProjectCollection tpc = null;
			var tfsPP = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);
			tfsPP.ShowDialog();
			if (null != tfsPP.SelectedProjects)
			{
				tpc = tfsPP.SelectedTeamProjectCollection;
				selectedProject = tfsPP.SelectedProjects[0].Name;
			}
			else
			{
				selectedProject = "";
			}
			return tpc;
		}

		public IList<string> GetAllBuildDefinitionsFromProject(TfsTeamProjectCollection tpc, string selectedProject)
		{
			var bs = tpc.GetService<IBuildServer>();
			var bds = bs.QueryBuildDefinitions(selectedProject);
			IList<string> bdNames = new List<string>();
			foreach (var bd in bds)
			{
				//bd.Refresh();
				bdNames.Add(bd.Name);
			}
			return bdNames;
		}

		public IBuildDetail[] GetAllBuildsFromSelectedBuildDefinition(TfsTeamProjectCollection tpc, string selectedProject, string buildDefinitionName)
		{
			var bs = tpc.GetService<IBuildServer>();
			var detailSpec = bs.CreateBuildDetailSpec(selectedProject);
			detailSpec.MaxBuildsPerDefinition = 10;
			detailSpec.QueryOrder = BuildQueryOrder.FinishTimeDescending;
			detailSpec.DefinitionSpec.Name = buildDefinitionName;
			detailSpec.Status = BuildStatus.All;
			var builds = bs.QueryBuilds(detailSpec).Builds;
			//foreach (var build in builds)
			//{
			//	build.RefreshAllDetails();
			//}
			return builds;
		}

		private void AddTestResultByTestoutcome(ITestRun testRun, IList<TestOutcome> outcomeList, ref IList<TestResult> list)
		{
			foreach (var outcome in outcomeList)
			{
				foreach (var tr in testRun.QueryResultsByOutcome(outcome))
				{
					TestResult instance = new TestResult
					{
						TestCaseId = tr.TestCaseId,
						TestCaseTitle = tr.TestCaseTitle,
						State = tr.State,
						Outcome = tr.Outcome,
						DateStarted = tr.DateStarted,
						DateCompleted = tr.DateCompleted,
						ErrorMsg = tr.ErrorMessage,
						LogUri = tr.Attachments.FirstOrDefault().Uri.AbsoluteUri,
					};
					list.Add(instance);
				}
			}
		}

		public IEnumerable<ITestRun> GetAllTestRunsFromSelectedBuild(TfsTeamProjectCollection tpc, string selectedProject, Uri buildUri)
		{
			var tms = tpc.GetService<ITestManagementService>();
			return tms.GetTeamProject(selectedProject).TestRuns.ByBuild(buildUri);
		}

		public IList<TestResult> GetTestResultsFromTestRun(TfsTeamProjectCollection tpc, string selectedProject, int testRunId, out int recordCount)
		{
			var tms = tpc.GetService<ITestManagementService>();
			var testRun = tms.GetTeamProject(selectedProject).TestRuns.Find(testRunId);
			IList<TestResult> resultList = new List<TestResult>();
			IList<TestOutcome> outcomes = new List<TestOutcome> 
				{
					TestOutcome.Passed,TestOutcome.Failed,TestOutcome.Error,TestOutcome.Warning,TestOutcome.Aborted,TestOutcome.Blocked,TestOutcome.Inconclusive,TestOutcome.Timeout,
				};
			testRun.Refresh();
			testRun.RefreshLogEntries();
			AddTestResultByTestoutcome(testRun, outcomes, ref resultList);
			recordCount = resultList.Count();
			return resultList;
		}

		public StatisticInfo GetStatisticsFromTestRun(TfsTeamProjectCollection tpc, string selectedProject, int testRunId)
		{
			var tms = tpc.GetService<ITestManagementService>();
			var testRun = tms.GetTeamProject(selectedProject).TestRuns.Find(testRunId);
			testRun.Refresh();
			testRun.RefreshLogEntries();
			var statistics = testRun.Statistics;
			var instance = new StatisticInfo
			{
				TotalTests = statistics.TotalTests,
				CompletedTests = statistics.CompletedTests,
				PassedTests = statistics.PassedTests,
				FailedTests = statistics.FailedTests,
				InProgressTests = statistics.InProgressTests,
				PendingTests = statistics.PendingTests,
			};
			return instance;
		}
	}
}
