using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingModel;

namespace UnitTestProject1.BankAccount.Steps
{
	public class BankAccountGiven
	{
	    internal BankAccountGiven() { }

		public BankingModel.BankAccount account { get; set; }
				
		public void With_An_InitialBalance(double initialBalance)
		{
			account = new BankingModel.BankAccount(initialBalance, null);
		}

		public void With_OverdraftProtection(double maxOverDraftProtection, double currentOverdraftLoan)
		{
			account.AvailableOverdraftProtection = maxOverDraftProtection;
			account.OverdraftLoanAmt = currentOverdraftLoan;
		}

	}
}
