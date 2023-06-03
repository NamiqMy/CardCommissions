using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BankCard
{
    public class Program 
    {
        static void Main(string[] args)
        {
           
            CardInfo cardinfo = new CardInfo();

            cardinfo.HolderName = "Namiq";
            cardinfo.HolderSurname = "Yaqubov";
            cardinfo.CVV = 123;
            cardinfo.CardNumber = "1234567898765421";
            cardinfo.Balance = 5000;                    

            Console.WriteLine(cardinfo);
          
        }
    }
}