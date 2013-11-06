namespace ReportAutomation
{
	partial class mainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToTeamProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxBD = new System.Windows.Forms.ComboBox();
			this.comboBoxB = new System.Windows.Forms.ComboBox();
			this.comboBoxTR = new System.Windows.Forms.ComboBox();
			this.labelSI = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBoxTotalTests = new System.Windows.Forms.TextBox();
			this.textBoxCompletedTests = new System.Windows.Forms.TextBox();
			this.textBoxPassedTests = new System.Windows.Forms.TextBox();
			this.textBoxFailedTests = new System.Windows.Forms.TextBox();
			this.textBoxInProgressTests = new System.Windows.Forms.TextBox();
			this.textBoxPendingTests = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(872, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.AutoToolTip = true;
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToTeamProjectsToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.settingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.settingToolStripMenuItem.Text = "Setting";
			// 
			// connectToTeamProjectsToolStripMenuItem
			// 
			this.connectToTeamProjectsToolStripMenuItem.Name = "connectToTeamProjectsToolStripMenuItem";
			this.connectToTeamProjectsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.connectToTeamProjectsToolStripMenuItem.Text = "Connect to Team Projects...";
			this.connectToTeamProjectsToolStripMenuItem.Click += new System.EventHandler(this.connectToTeamProjectsToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(311, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Build Definition:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Build In Use:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(311, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Test Run:";
			// 
			// comboBoxBD
			// 
			this.comboBoxBD.FormattingEnabled = true;
			this.comboBoxBD.Location = new System.Drawing.Point(395, 33);
			this.comboBoxBD.Name = "comboBoxBD";
			this.comboBoxBD.Size = new System.Drawing.Size(304, 21);
			this.comboBoxBD.TabIndex = 4;
			this.comboBoxBD.SelectedIndexChanged += new System.EventHandler(this.comboBoxBD_SelectedIndexChanged);
			// 
			// comboBoxB
			// 
			this.comboBoxB.FormattingEnabled = true;
			this.comboBoxB.Location = new System.Drawing.Point(395, 62);
			this.comboBoxB.Name = "comboBoxB";
			this.comboBoxB.Size = new System.Drawing.Size(304, 21);
			this.comboBoxB.TabIndex = 5;
			this.comboBoxB.SelectedIndexChanged += new System.EventHandler(this.comboBoxB_SelectedIndexChanged);
			// 
			// comboBoxTR
			// 
			this.comboBoxTR.FormattingEnabled = true;
			this.comboBoxTR.Location = new System.Drawing.Point(395, 90);
			this.comboBoxTR.Name = "comboBoxTR";
			this.comboBoxTR.Size = new System.Drawing.Size(304, 21);
			this.comboBoxTR.TabIndex = 6;
			this.comboBoxTR.SelectedIndexChanged += new System.EventHandler(this.comboBoxTR_SelectedIndexChanged);
			// 
			// labelSI
			// 
			this.labelSI.AutoSize = true;
			this.labelSI.Location = new System.Drawing.Point(12, 58);
			this.labelSI.Name = "labelSI";
			this.labelSI.Size = new System.Drawing.Size(103, 13);
			this.labelSI.TabIndex = 8;
			this.labelSI.Text = "Tests Statistic Info. :";
			this.labelSI.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(15, 74);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(29, 13);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "Total";
			this.textBox1.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(50, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(56, 13);
			this.textBox2.TabIndex = 16;
			this.textBox2.Text = "Completed";
			this.textBox2.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(112, 74);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(42, 13);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "Passed";
			this.textBox3.Visible = false;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Location = new System.Drawing.Point(159, 74);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(36, 13);
			this.textBox4.TabIndex = 16;
			this.textBox4.Text = "Failed";
			this.textBox4.Visible = false;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Location = new System.Drawing.Point(198, 74);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(56, 13);
			this.textBox5.TabIndex = 16;
			this.textBox5.Text = "In Progress";
			this.textBox5.Visible = false;
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Location = new System.Drawing.Point(261, 74);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(43, 13);
			this.textBox6.TabIndex = 16;
			this.textBox6.Text = "Pending";
			this.textBox6.Visible = false;
			// 
			// textBoxTotalTests
			// 
			this.textBoxTotalTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxTotalTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTotalTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTotalTests.Location = new System.Drawing.Point(15, 94);
			this.textBoxTotalTests.Name = "textBoxTotalTests";
			this.textBoxTotalTests.ReadOnly = true;
			this.textBoxTotalTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxTotalTests.TabIndex = 17;
			this.textBoxTotalTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxCompletedTests
			// 
			this.textBoxCompletedTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxCompletedTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCompletedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCompletedTests.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.textBoxCompletedTests.Location = new System.Drawing.Point(63, 94);
			this.textBoxCompletedTests.Name = "textBoxCompletedTests";
			this.textBoxCompletedTests.ReadOnly = true;
			this.textBoxCompletedTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxCompletedTests.TabIndex = 17;
			this.textBoxCompletedTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxPassedTests
			// 
			this.textBoxPassedTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxPassedTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassedTests.ForeColor = System.Drawing.Color.YellowGreen;
			this.textBoxPassedTests.Location = new System.Drawing.Point(114, 94);
			this.textBoxPassedTests.Name = "textBoxPassedTests";
			this.textBoxPassedTests.ReadOnly = true;
			this.textBoxPassedTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxPassedTests.TabIndex = 17;
			this.textBoxPassedTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxFailedTests
			// 
			this.textBoxFailedTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxFailedTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxFailedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFailedTests.ForeColor = System.Drawing.Color.Red;
			this.textBoxFailedTests.Location = new System.Drawing.Point(159, 94);
			this.textBoxFailedTests.Name = "textBoxFailedTests";
			this.textBoxFailedTests.ReadOnly = true;
			this.textBoxFailedTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxFailedTests.TabIndex = 17;
			this.textBoxFailedTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxInProgressTests
			// 
			this.textBoxInProgressTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxInProgressTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxInProgressTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInProgressTests.ForeColor = System.Drawing.Color.Silver;
			this.textBoxInProgressTests.Location = new System.Drawing.Point(212, 94);
			this.textBoxInProgressTests.Name = "textBoxInProgressTests";
			this.textBoxInProgressTests.ReadOnly = true;
			this.textBoxInProgressTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxInProgressTests.TabIndex = 17;
			this.textBoxInProgressTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxPendingTests
			// 
			this.textBoxPendingTests.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxPendingTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPendingTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPendingTests.ForeColor = System.Drawing.Color.Yellow;
			this.textBoxPendingTests.Location = new System.Drawing.Point(264, 94);
			this.textBoxPendingTests.Name = "textBoxPendingTests";
			this.textBoxPendingTests.ReadOnly = true;
			this.textBoxPendingTests.Size = new System.Drawing.Size(29, 13);
			this.textBoxPendingTests.TabIndex = 17;
			this.textBoxPendingTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(15, 126);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(845, 288);
			this.dataGridView.TabIndex = 18;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(872, 428);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.textBoxPendingTests);
			this.Controls.Add(this.textBoxInProgressTests);
			this.Controls.Add(this.textBoxFailedTests);
			this.Controls.Add(this.textBoxPassedTests);
			this.Controls.Add(this.textBoxCompletedTests);
			this.Controls.Add(this.textBoxTotalTests);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelSI);
			this.Controls.Add(this.comboBoxTR);
			this.Controls.Add(this.comboBoxB);
			this.Controls.Add(this.comboBoxBD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Automation";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToTeamProjectsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxBD;
		private System.Windows.Forms.ComboBox comboBoxB;
		private System.Windows.Forms.ComboBox comboBoxTR;
		private System.Windows.Forms.Label labelSI;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBoxTotalTests;
		private System.Windows.Forms.TextBox textBoxCompletedTests;
		private System.Windows.Forms.TextBox textBoxPassedTests;
		private System.Windows.Forms.TextBox textBoxFailedTests;
		private System.Windows.Forms.TextBox textBoxInProgressTests;
		private System.Windows.Forms.TextBox textBoxPendingTests;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}

