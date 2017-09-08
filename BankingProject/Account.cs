using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Account {
		//Properties goe shere
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

		public void Deposit(double amount) {
			if (IsAmountInvalid(amount) == true) {
				Console.WriteLine("The amount must be greater than zero.");
				return;
			}
			Balance += amount;
		}
		public void Withdraw (double amount) {
			if (IsAmountInvalid(amount) == true) {
				Console.WriteLine("The amount must be greater than zero.");
				return;
			}
		}
		public double CheckBalance() {
				return Balance;
		}
		public void SetName(string name) {
			Name = name;
		}
	}
}
