using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TfsService.Models
{
	public class StatisticInfo
	{
		public int TotalTests { get; set; }

		public int CompletedTests { get; set; }

		public int PassedTests { get; set; }

		public int FailedTests { get; set; }

		public int InProgressTests { get; set; }

		public int PendingTests { get; set; }
	}
}
