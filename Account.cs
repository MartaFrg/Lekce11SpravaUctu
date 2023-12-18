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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance", "Záporný stav účtu.");
                }
                _balance = value;
            }
        
        }
        public void Deposit(int vklad)
        {
            if (vklad < 0)
            {
                throw new ZapornyVkladException("Balance", "Vklad je záporné číslo.", vklad);
            }

                Balance += vklad;
            Console.WriteLine("Vloženo na účet " + vklad);
            Console.WriteLine("Celkem na účtu: " + Balance);
            //Balance = -50;
        }
        public void Withdraw(int vyber)
        {
            if (vyber < 0)
            {
                throw new ZapornyVyberException("Balance", "Výběr je záporné číslo.", vyber);
            }
                if (Balance >= vyber) {
                    Balance -= vyber;
                    Console.WriteLine("Vybráno z účtu " + vyber);
                }
                else { Console.WriteLine("Nedostatek prostředků na účtu");
                    Console.WriteLine("pokusili jste se vybrat "+vyber);
                }
            Console.WriteLine("Celkem na účtu: " + Balance);
        }

    }
}
