using OCPViolation.Model;

namespace OCPViolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Anekant", 100000, 10, FestivalTypes.NORMAL);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}