using FixedDepositCoreLib.Model;
using HDFCBankClientApp.FestivalPolicy;

namespace HDFCBankClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FixedDeposit fd1 = new FixedDeposit(1001, "Anekant", 100000, 10,new NewYearPolicy());
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}