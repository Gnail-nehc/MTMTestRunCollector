using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TfsService;

namespace ReportAutomation
{
	public partial class mainForm : Form
	{
		public mainForm()
		{
			InitializeComponent();
		}
		private TfsTeamProjectCollection tpc;

		private string selectedProject;

		public ITfsService Service
		{
			get
			{
				return new TfsService.TfsService();
			}
		}

		private void connectToTeamProjectsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.tpc = Service.ConnectToTfs(out selectedProject);
			IList<string> bds = Service.GetAllBuildDefinitionsFromProject(tpc, selectedProject);
			string uiaBD = "Automation_Build";
			bds.Remove(uiaBD);
			bds.Insert(0, uiaBD);
			comboBoxBD.DataSource = bds;
			settingToolStripMenuItem.Enabled = false;
		}

		private void comboBoxBD_SelectedIndexChanged(object sender, EventArgs e)
		{
			var comboBD = sender as ComboBox;
			string bd = comboBoxBD.SelectedItem as string;
			var builds = Service.GetAllBuildsFromSelectedBuildDefinition(tpc, selectedProject, bd);
			if (null != builds && builds.Count() > 0)
			{
				comboBoxB.DataSource = builds;
				comboBoxB.DisplayMember = "BuildNumber";
			}
			else
			{
				comboBoxTR.DataSource = null;
			}
		}

		private void comboBoxB_SelectedIndexChanged(object sender, EventArgs e)
		{
			var comboB = sender as ComboBox;
			var build = comboBoxB.SelectedValue as IBuildDetail;
			if (null != build)
			{
				var trs = Service.GetAllTestRunsFromSelectedBuild(tpc, selectedProject, build.Uri).ToList();
				if (trs.Count > 0)
				{
					comboBoxTR.DataSource = trs;
					comboBoxTR.DisplayMember = "DateCompleted";
				}
				else
				{
					comboBoxTR.DataSource = null;
				}
			}
		}

		private void comboBoxTR_SelectedIndexChanged(object sender, EventArgs e)
		{
			var comboTR = sender as ComboBox;
			var testRun = comboTR.SelectedValue as ITestRun;
			if (null != testRun)
			{
				int runId = testRun.Id;
				var si = Service.GetStatisticsFromTestRun(tpc, selectedProject, runId);
				if (null != si)
				{
					labelSI.Visible = true;
					textBox1.Visible = true;
					textBox2.Visible = true;
					textBox3.Visible = true;
					textBox4.Visible = true;
					textBox5.Visible = true;
					textBox6.Visible = true;

					textBoxTotalTests.Text = si.TotalTests.ToString();
					textBoxCompletedTests.Text = si.CompletedTests.ToString();
					textBoxPassedTests.Text = si.PassedTests.ToString();
					textBoxFailedTests.Text = si.FailedTests.ToString();
					textBoxInProgressTests.Text = si.InProgressTests.ToString();
					textBoxPendingTests.Text = si.PendingTests.ToString();
				}
				int count;
				var results = Service.GetTestResultsFromTestRun(tpc, selectedProject, runId, out count);
				if (null != results && results.Count > 0)
				{
					dataGridView.DataSource = results;
				}
			}
			else
			{
				labelSI.Visible = false;
				textBox1.Visible = false;
				textBox2.Visible = false;
				textBox3.Visible = false;
				textBox4.Visible = false;
				textBox5.Visible = false;
				textBox6.Visible = false;
				textBoxTotalTests.Text = "";
				textBoxCompletedTests.Text = "";
				textBoxPassedTests.Text = "";
				textBoxFailedTests.Text = "";
				textBoxInProgressTests.Text = "";
				textBoxPendingTests.Text = "";
				dataGridView.DataSource = null;
			}
		}



		

	}
}
