using Chapter17Final.AcoountProfiles;
//
namespace Chapter17Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new RegularAccount() { Balance = 10000 };
            acc1.CalculateInterest();
            Console.WriteLine($"Interest: {acc1.Interest}");

            var acc2 = new SalaryAccount() { Balance = 50000 };
            acc2.CalculateInterest();
            Console.WriteLine($"Interest: {acc2.Interest}");

            Calculator.Calculate(acc1);
            Calculator.Calculate(acc2);

            Console.WriteLine($"Interest: {acc1.Interest}");
            Console.WriteLine($"Interest: {acc2.Interest}");
        }
    }
}