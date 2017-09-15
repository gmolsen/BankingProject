using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxTechnicalTraining;


namespace Deposit {
	[TestClass]
	public class DepositTest {
		[TestMethod]
		public void TestDeposit0() {
			Account checking = new Account();
			checking.Deposit(0);
			var result = checking.CheckBalance();
			Assert.AreEqual(0, result);
		}
		[TestMethod]
		public void TestDeposit1() {
			Account checking = new Account();
			checking.Deposit(-1);
			var result = checking.CheckBalance();
			Assert.AreEqual(0, result);
		}
		[TestMethod]
		public void TestDeposit2() {
			Account checking = new Account();
			checking.Deposit(int.MinValue);
			var result = checking.CheckBalance();
			Assert.AreEqual(0, result);
		}
		[TestMethod]
		public void TestDeposit3() {
			Account checking = new Account();
			checking.Deposit(int.MaxValue);
			var result = checking.CheckBalance();
			Assert.AreEqual(int.MaxValue, result);
		}
		[TestMethod]
		public void TestDeposit4() {
			Account checking = new Account();
			checking.Deposit(615992514);
			var result = checking.CheckBalance();
			Assert.AreEqual(615992514, result);
		}
		[TestMethod]
		public void TestDeposit5() {
			Account checking = new Account();
			checking.Deposit(54002069);
			var result = checking.CheckBalance();
			Assert.AreEqual(54002069, result);
		}
		[TestMethod]
		public void TestDeposit6() {
			Account checking = new Account();
			checking.Deposit(698029789);
			var result = checking.CheckBalance();
			Assert.AreEqual(698029789, result);
		}
		[TestMethod]
		public void TestDeposit7() {
			Account checking = new Account();
			checking.Deposit(853504267);
			var result = checking.CheckBalance();
			Assert.AreEqual(853504267, result);
		}
		[TestMethod]
		public void TestDeposit8() {
			Account checking = new Account();
			checking.Deposit(517118197);
			var result = checking.CheckBalance();
			Assert.AreEqual(517118197, result);
		}
		[TestMethod]
		public void TestDeposit9() {
			Account checking = new Account();
			checking.Deposit(50590217);
			var result = checking.CheckBalance();
			Assert.AreEqual(50590217, result);
		}
		[TestMethod]
		public void TestDeposit10() {
			Account checking = new Account();
			checking.Deposit(1);
			var result = checking.CheckBalance();
			Assert.AreEqual(1, result);
		}
	}
	[TestClass]
	public class WithdrawTest {
		[TestMethod]
		public void TestWithdraw0() {
			Account checking = new Account();
			checking.Deposit(1);
			checking.Withdraw(-1);
			var result = checking.CheckBalance();
			Assert.AreEqual(1, result);
		}
		[TestMethod]
		public void TestWithdraw1() {
			Account checking = new Account();
			checking.Withdraw(100);
			var result = checking.CheckBalance();
			Assert.AreEqual(0, result);
		}
		[TestMethod]
		public void TestWithdraw2() {
			Account checking = new Account();
			checking.Deposit(1);
			checking.Withdraw(0);
			var result = checking.CheckBalance();
			Assert.AreEqual(1, result);
		}
		[TestMethod]
		public void TestWithdraw3() {
			Account checking = new Account();
			checking.Deposit(100);
			checking.Withdraw(25);
			var result = checking.CheckBalance();
			Assert.AreEqual(75, result);
		}
		[TestMethod]
		public void TestWithdraw4() {
			Account checking = new Account();
			checking.Deposit(100);
			checking.Withdraw(125);
			var result = checking.CheckBalance();
			Assert.AreEqual(100, result);
		}
	}
}
