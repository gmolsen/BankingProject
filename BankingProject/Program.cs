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
			Account checking = new Account();
			checking.SetName("Checking");
			checking.Deposit(300.00);

			Savings savings = new Savings();
			savings.SetName("Savings");
			savings.Deposit(18000.00);
			savings.PayMonthlyInterest();

			//creates an array containing all properties of savings and checking accounts
			// then prints properties of both accounts
			List<Account> myAccounts = new List<Account>();
			myAccounts.Add(savings);
			myAccounts.Add(checking);
			foreach (var account in myAccounts) {
				Console.WriteLine(account.ToPrint());
			}

		}


		static void Main(string[] args) {
			new Program().Run();
		}
	}
}