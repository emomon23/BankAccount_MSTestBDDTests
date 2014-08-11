using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class BankAccount
    {
		private double currentBalance;
		
		private iBankingModelConfiguration config;

		public BankAccount(double initialAmt, iBankingModelConfiguration config)
		{
			//This class should use the config instance instead of System.Configuration.ConfigurationManager.AppSetting["SomeSetting"].ToString();
			this.currentBalance = initialAmt;
			this.config = config;
		}

		public double AvailableOverdraftProtection { get; set; }
		public double OverdraftLoanAmt { get; set; }

		public bool HasOverdraftProtection
		{
			get
			{
				return this.AvailableOverdraftProtection > 0;
			}
		}

		
		public void Withdraw(double amt)
		{
			if (amt > this.currentBalance)
			{
				//We're in overdraft territory! 
				if (amt > ((this.AvailableOverdraftProtection - this.OverdraftLoanAmt) + this.currentBalance))
				{
					throw new Exception("Not enough funds!");
				}

				//Borrow needed funds from overdraft as an 'over draft loan'
				double overdraftLoan = amt - currentBalance;
				this.currentBalance += overdraftLoan;
				this.OverdraftLoanAmt += overdraftLoan;
			}

			this.currentBalance -= amt;
		}

		public double CurrentBalance
		{
			get
			{
				return this.currentBalance;
			}
		}
			
		
    }
}
