using System;

namespace Lekce11SpravaUctu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(123456789, "Marta Frgalová");
            try
            {
            account1.Deposit(5000);
            account1.Withdraw(4500);
            account1.Withdraw(1000);
            //account1.Deposit(-3000);
            account1.Withdraw(-500);
            }
            catch (ZapornyVkladException ex)
            {
                Console.WriteLine($"Záporná částka vkladu v {ex.Cas}: {ex.Message}, ");
                Console.WriteLine($"Uživatel se pokusil vložit {ex.Vklad}");
            }
            catch (ZapornyVyberException ex)
            {
                Console.WriteLine($"Záporná částka výběru v {ex.Cas}: {ex.Message}, ");
                Console.WriteLine($"Uživatel se pokusil vybrat {ex.Vyber}");
            }
        }
    }
}
