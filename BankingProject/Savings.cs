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
		private double IntRate = 0.05;
		private double amount = 0;
		// method calculates monthly interest and deposits into account
		public void PayMonthlyInterest() {
			amount += IntRate * Balance;
			Deposit(amount);
		}
		//overrides ToPrint() method from Account class
		public override string ToPrint() {
			return base.ToPrint() + $":::{IntRate}% interest";

			//rest of Savings account properties / methods are called from Account base class
		}

			}
		}

