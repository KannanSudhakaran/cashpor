using FixedDepositCoreLib.Model;
using UnitonBankClientApp.QuarterlyPolicy;

namespace UnitonBankClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Anekant", 100000, 10,new QuarterOnePolicy());
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}