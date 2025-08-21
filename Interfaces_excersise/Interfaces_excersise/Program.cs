namespace Interfaces_excersise
{

    /* Exercise:
        Create an interface IPayable with method GetPaymentAmount()
        Implement it in classes: Invoice (amount due) and SalariedEmployee (monthly salary)
        Write a program that processes a list of IPayable objects and prints total payments
       Goal: Interfaces, polymorphism, collections, and abstraction.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            
            List<IPayable> payableItems = new List<IPayable>
            {
                new Invoice(100.00m),
                new SalariedEmployee(3000.00m)
            };

            decimal totalPayment = 0;

            foreach (IPayable item in payableItems)
            {
                totalPayment += item.GetPaymentAmount();
            }

            Console.WriteLine($"Total Payments: {totalPayment}");
        }
    }
    interface IPayable
    {
        decimal GetPaymentAmount();
    }

    public class Invoice : IPayable
    {
        private decimal amountDue;

        public Invoice(decimal amount)
        {
            amountDue = amount;
        }

        public decimal GetPaymentAmount()
        {
            return amountDue;
        }
    }

    public class SalariedEmployee : IPayable
    {
        private decimal monthlySalary;

        public SalariedEmployee(decimal salary)
        {
            monthlySalary = salary;
        }

        public decimal GetPaymentAmount()
        {
            return monthlySalary;
        }
    } 
}