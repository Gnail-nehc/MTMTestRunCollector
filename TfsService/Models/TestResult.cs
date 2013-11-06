using Microsoft.TeamFoundation.TestManagement.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TfsService.Models
{
	public class TestResult
	{
		public int TestCaseId { get; set; }

		public string TestCaseTitle { get; set; }

		public TestResultState State { get; set; }

		public TestOutcome Outcome { get; set; }

		public DateTime DateStarted { get; set; }

		public DateTime DateCompleted { get; set; }

		public string ErrorMsg { get; set; }

		public string LogUri { get; set; }
	}
}
