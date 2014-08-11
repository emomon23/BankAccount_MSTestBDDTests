using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BankAccount.Steps
{
	public class BankAccountTest
	{
		private BankAccountGiven accountGiven;
		private BankAccountWhen accountWhen;
		private BankAccountThan accountThan;

		public BankAccountGiven givenAnAccount
		{
			get
			{
				if (this.accountGiven == null)
				{
					this.accountGiven = new BankAccountGiven();
				}

				return this.accountGiven;
			}
		}

		public BankAccountWhen when
		{
			get
			{
				//given must be called before when or than, make sure that has happened
				if (this.accountGiven == null || this.accountGiven.account == null)
				{
					throw new Exception("You must call BankAccountTest.given.... before calling when!");
				}

				if (this.accountWhen == null)
				{
					this.accountWhen = new BankAccountWhen(this.accountGiven.account);
				}

				return this.accountWhen;
			}
		}

		public BankAccountThan than
		{
			get
			{
				//given must be called before when or than, make sure that has happened
				if (this.accountGiven == null || this.accountGiven.account == null || this.accountWhen == null)
				{
					throw new Exception("You must call BankAccountTest.given / when .... before calling than!");
				}

				if (this.accountThan == null)
				{
					this.accountThan = new BankAccountThan(this.accountWhen);
				}

				return this.accountThan;
			}
		}
	}	
			
}
