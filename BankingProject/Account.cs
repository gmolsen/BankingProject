using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	/// <summary>
	///  The account class simulates an account at a bank.
	/// </summary>
	class Account {
		//Properties
		/// <summary>
		///  Contains the value of the next instance account number
		/// </summary>
		private static int nextAccountNumber = 96434;
		/// <summary>
		/// number that account number increments by when creating new account
		/// </summary>
		private const int incrementAccountNumber = 74747;
		private double Balance = 0;
		private string Name = "Checking";
		private int Number = 0;
		// methods go here
		private bool IsAmountInvalid (double amount) {
			if (amount > 0) {
				return false ;
			} else {
				return true;
			}
		}
		/// <summary>
		/// Adds money into an account
		/// </summary>
		/// <param name="amount">The money to deposit</param>
		/// <returns>Returns true if deposit is successful, otherwise false.</returns>
		public bool Deposit(double amount) {
			if (IsAmountInvalid(amount) == true) {
				Console.WriteLine("The amount must be greater than zero.");
				return false;
			}
			Balance += amount;
			return true;

		}
		/// <summary>
		/// Withdraws money from an account
		/// </summary>
		/// <param name="amount">The money to deposit</param>
		/// <returns>Returns true if withdraw is successful, otherwise false.</returns>
		public bool Withdraw (double amount) {
			if (IsAmountInvalid(amount) == true) {
				Console.WriteLine("The amount must be greater than zero.");
				return false;
			}
			if (amount > CheckBalance()) {
				Console.WriteLine("Insufficient funds.");
				return false;
			} else {
				Balance -= amount;
				return true;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="amount"></param>
		/// <param name="ToAccount"></param>
		/// <returns></returns>
		public bool Transfer(double amount, Account ToAccount) {
			if (Withdraw(amount)) { //calls instance
				ToAccount.Deposit(amount);
				return true;
			} else {
				return false; // homework, withdraw succeeds and deposit fails
			}
		}
		public double CheckBalance() {
				return Balance;
		}
		public int getNumber() {
			return Number;
		}
		public void SetName(string name) {
			Name = name;
		}

		private void SetNumber (int number) {

		}

		public string GetName() {
			return Name;
		}
		// default constructor
		public Account() {
			Number = nextAccountNumber;
			nextAccountNumber += incrementAccountNumber;
		}
		public Account (string name) {
			Name = name;
			Number = nextAccountNumber++;
			nextAccountNumber += incrementAccountNumber;
		}
	}
}
