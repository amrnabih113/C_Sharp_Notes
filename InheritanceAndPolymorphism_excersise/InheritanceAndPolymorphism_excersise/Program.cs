namespace InheritanceAndPolymorphism_excersise
{

    /* Exercise:
         * Create a base class Employee with properties: Name, Salary and method CalculateBonus() (virtual)
         * Create derived classes Manager and Developer overriding CalculateBonus() differently
         * Test by creating a list of employees and printing their bonuses
     * Goal: Practice inheritance, virtual/override, polymorphism, collections.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Amr Nabih",
                Salary = 50000,

            };

            Manager manager = new Manager()
            {
                Name = "Ahmed Hazem",
                Salary = 80000
            };

            Developer developer = new Developer()
            {
                Name = "AbdElrahman Wael",
                Salary = 60000
            };

            Console.WriteLine($"The Employee {employee.Name}'s bonus is: {employee.CalculateBonus()}");
            Console.WriteLine($"The Employee {manager.Name}'s bonus is: {manager.CalculateBonus()}");
            Console.WriteLine($"The Employee {developer.Name}'s bonus is: {developer.CalculateBonus()}");


        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public virtual decimal CalculateBonus()
        {
            return Salary * 0.5m; 
        }
    }

    class Manager : Employee
    {
        public override decimal CalculateBonus()
        {
            return Salary * 0.10m; 
        }
    }

    class Developer : Employee
    {
        public override decimal CalculateBonus()
        {
            return Salary * 0.20m; 
        }
    }
}