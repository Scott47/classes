using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Scott's Tots", new DateTime(2021, 11, 17));

            // Create three employees
            Employee jayna = new Employee()
            {
                FirstName = "Jayna",
                LastName = "Leitze",
                Title = "Boss",
                StartDate = new DateTime(2021, 11, 17)
            };
            Employee mario = new Employee()
            {
                FirstName = "Mario",
                LastName = "Compopiano",
                Title = "Boss",
                StartDate = new DateTime(2021, 11, 17)
            };
            Employee shawn = new Employee()
            {
                FirstName = "Shawn",
                LastName = "Conerton",
                Title = "Super Boss",
                StartDate = new DateTime(2021, 11, 17)
            };
            // Assign the employees to the company
            myCompany.Employees.Add(jayna);
            myCompany.Employees.Add(shawn);
            myCompany.Employees.Add(mario);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.ListEmployees();
        }
    }
}