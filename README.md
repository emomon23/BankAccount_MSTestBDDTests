BankAccount_MSTestBDDTests
==========================
So you want to do BDD testing and you'd like to use NSpec or SpecFlow but the boss / team say 'no way!' 

You've been told to write tests for you code using MS Test, but you team isn't on board for anything more than that.  

This project attempts to take the lesson's learned from spec flow, that is, breaking up each given (prereq), when (act), and than (assert) into a seperate step and assembling
various steps into new tests.

Start by looking at the Given_A_Bank_Account_With_A_100_Dollar_Balance.cs file to see how this approach is actually used.

Then look in the BankAccount.Steps folder to see how the steps were implemented.
