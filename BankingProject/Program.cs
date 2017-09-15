using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining;
using BankingProject;

namespace Banking {
	class Program {

		//check push
		void Run() {
			Account checking = new Account("Checking");
			checking.Deposit(300.00);

			Savings savings = new Savings("Savings with Interest", 0.1); // creates a new instance of Savings with name and interest rate
			savings.Deposit(18000.00);
			savings.PayMonthlyInterest();

			//creates an array containing all properties of savings and checking account properties
			// then prints properties of both accounts
			List<Account> myAccounts = new List<Account>();
			myAccounts.Add(savings);
			myAccounts.Add(checking);
			foreach (var account in myAccounts) {
				Console.WriteLine(account.ToPrint());
			}
			// some account class methods
			checking.Withdraw(20.00);
			savings.Transfer(100.00, checking);
			foreach (var account in myAccounts) {
				Console.WriteLine(account.ToPrint());
			}
		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}