using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BankAccount.Steps
{
	public class BankAccountWhen
	{
		public BankingModel.BankAccount account { get; set; }
		public Exception WhenException { get; set; }

		public BankAccountWhen(BankingModel.BankAccount acct)
		{
			this.account = acct;
		}

		public void Withdrawing_Funds(double fundsToWithdraw)
		{
			try
			{
				account.Withdraw(fundsToWithdraw);
			}
			catch (Exception exp)
			{
				this.WhenException = exp;
			}
		}
	}
}
