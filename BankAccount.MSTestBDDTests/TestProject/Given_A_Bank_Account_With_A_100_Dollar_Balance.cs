using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.BankAccount.Steps;
namespace UnitTestProject1
{
	[TestClass]
	public class Given_A_Bank_Account_With_A_100_Dollar_Balance
	{
		BankAccountTest testSteps = new BankAccountTest();

		[TestMethod]
		public void When_WithDrawing_99_Dollars_The_Balance_Should_Be_1_Dollar()
		{
			testSteps.givenAnAccount.With_An_InitialBalance(100);
			testSteps.when.Withdrawing_Funds(99);
			testSteps.than.CurrentBalance_Should_Be(1);
		}

		[TestMethod]
		public void When_Withdrawing_Excessive_Funds_An_Exception_Should_Be_Thrown()
		{
			testSteps.givenAnAccount.With_An_InitialBalance(100);
			testSteps.when.Withdrawing_Funds(101);
			testSteps.than.AnExceptionShouldBeThrown();
		}

		[TestMethod]
		public void When_Withdrawing_Into_Allowable_Overdraft_Protection()
		{
			testSteps.givenAnAccount.With_An_InitialBalance(10);
			testSteps.givenAnAccount.With_OverdraftProtection(2000, 1000);
			
			testSteps.when.Withdrawing_Funds(200);
		
			testSteps.than.CurrentBalance_Should_Be(0);
			testSteps.than.OverdraftLoanAmt_Should_Be(1190);
		}

		[TestMethod]
		public void When_Exceeding_Overdraft_Protection()
		{
			testSteps.givenAnAccount.With_An_InitialBalance(0);
			testSteps.givenAnAccount.With_OverdraftProtection(2000, 1000);

			testSteps.when.Withdrawing_Funds(1200);

			testSteps.than.AnExceptionShouldBeThrown();
		}
	}
}
