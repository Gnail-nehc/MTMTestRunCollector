using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfsService.Models;

namespace TfsService
{
	public interface ITfsService
	{
		TfsTeamProjectCollection ConnectToTfs(out string selectedProject);

		IList<string> GetAllBuildDefinitionsFromProject(TfsTeamProjectCollection tpc, string selectedProject);

		IBuildDetail[] GetAllBuildsFromSelectedBuildDefinition(TfsTeamProjectCollection tpc, string selectedProject, string buildDefinitionName);

		IEnumerable<ITestRun> GetAllTestRunsFromSelectedBuild(TfsTeamProjectCollection tpc, string selectedProject, Uri buildUri);

		IList<TestResult> GetTestResultsFromTestRun(TfsTeamProjectCollection tpc, string selectedProject, int testRunId, out int recordCount);

		StatisticInfo GetStatisticsFromTestRun(TfsTeamProjectCollection tpc, string selectedProject, int testRunId);
	}
}
