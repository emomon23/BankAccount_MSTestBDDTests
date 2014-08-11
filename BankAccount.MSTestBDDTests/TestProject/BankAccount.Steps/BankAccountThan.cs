using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.BankAccount.Steps
{
	public class BankAccountThan
	{
		BankAccountWhen when;

		public BankAccountThan(BankAccountWhen when)
		{
			this.when = when;
		}

		public void CurrentBalance_Should_Be(double amt)
		{
			Assert.AreEqual(amt, this.when.account.CurrentBalance);
		}

		public void OverdraftLoanAmt_Should_Be(double amt)
		{
			Assert.AreEqual(amt, this.when.account.OverdraftLoanAmt);
		}

		public void AnExceptionShouldBeThrown()
		{
			Assert.IsNotNull(this.when.WhenException, "An Exception was not thrown as expected");
		}
	}
}
