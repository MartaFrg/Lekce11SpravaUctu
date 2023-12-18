using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce11SpravaUctu
{
    internal class Account
    {
        private int _accountNumber;
        private string _ownerName;
        private int _balance;

        public Account(int accountNumber, string ownerName)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = 0;
        }
        public int AccountNumber { get { return _accountNumber; } }
        public string OwnerName { get { return _ownerName; } }
        public int Balance { 
            get { return _balance;}
            private set
            {
                    _balance = value;
            }
        
        }
        public void Deposit(int vklad)
        {
            if (vklad < 0)
            {
                throw new ZapornyVkladException("Balance", "Vklad je záporné číslo.", vklad);
            }
            try
            {
                Balance += vklad;
            }
            catch (ZapornyVkladException ex)
            {
                Console.WriteLine($"Záporná částka vkladu: {vklad}, {ex.Message}");
            }
            Console.WriteLine("Vloženo na účet " + vklad);
            Console.WriteLine("Celkem na účtu: " + Balance);
        }
        public void Withdraw(int vyber)
        {
            if (vyber < 0)
            {
                throw new ZapornyVyberException("Balance", "Výběr je záporné číslo.", vyber);
            }
            try
            {
                if (Balance >= vyber) {
                    Balance -= vyber;
                    Console.WriteLine("Vybráno z účtu " + vyber);
                }
                else { Console.WriteLine("Nedostatek prostředků na účtu");
                    Console.WriteLine("pokusili jste se vybrat "+vyber);
                }
            }
            catch (ZapornyVkladException ex)
            {
                Console.WriteLine($"Záporná částka výběru: {vyber}, {ex.Message}, {ex.Cas}");
            }
            Console.WriteLine("Celkem na účtu: " + Balance);
        }

    }
}
