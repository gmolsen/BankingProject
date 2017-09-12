using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using statement
using MaxTechnicalTraining;

namespace BankingProject {
	/// <summary>
	/// Savings account is a derived class of the base class Account
	/// </summary>
	public class Savings : Account {
		public double IntRate;
		// method calculates monthly interest and deposits into account
		public void PayMonthlyInterest() {
			Deposit(IntRate * Balance);
		}
		//overrides ToPrint() method from Account class
		public override string ToPrint() {
			return base.ToPrint() + $":::{IntRate}% interest";

			//rest of Savings account properties / methods are called from Account base class
		}
		public Savings() : base() {

		}

		// goes to the constructor in the account class with one string parameter
		public Savings(string name) : base(name) { }

		public Savings(string name, double intRate) : base(name) {
			IntRate = intRate;
		}

			}
		}

