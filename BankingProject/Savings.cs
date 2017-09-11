using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining;

namespace BankingProject {
	public class Savings : Account {
		private double IntRate;
		public override string ToPrint() {
			return base.ToPrint() + $"::{IntRate}";
		}
		 public double PayMonthlyInterest() {
			public bool Deposit(double amount) {
				if (IsAmountInvalid(amount) == true) {
					Console.WriteLine("The amount must be greater than zero.");
					return false;
				}
				Balance += amount;
				return true;

			}
		}
	}
}
