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
			Account checking = new Account("My checking account.");
			Account savings = new Savings("My savings account.");
			checking.SetName("Checking 1");
			checking.Deposit(200.00);
			savings.Deposit(0.37);
			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			checking.Transfer(50.00, savings);

			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.Transfer(50.00, checking);

			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");
		}


		static void Main(string[] args) {
			new Program().Run();
		}
	}
}