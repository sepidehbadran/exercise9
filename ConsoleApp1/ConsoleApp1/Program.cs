// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number of Employees: ");
        int n=int.Parse(Console.ReadLine());
        string Min1name = "";
        int Min1hours = int.MaxValue;
        string Min2name = "";
        int Min2hours = int.MinValue;
        string Min3name = "";
        int Min3hours = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("number Employee" + (i + 1) + " please enter:");
            string EmploeeName = Console.ReadLine();
            Console.WriteLine("Employee working hours " + EmploeeName + " please enter :");
            int hoursworked = int.Parse(Console.ReadLine());
            if (hoursworked < Min1hours)
            {
                Min3hours = Min2hours;
                Min3name = Min2name;
                Min2hours = Min1hours;
                Min2name = Min1name;
                Min1hours = hoursworked;
                Min1name = EmploeeName;
            }
            else if (hoursworked < Min2hours)
            {
                Min3hours = Min2hours;
                Min3name = Min2name;
                Min2hours = hoursworked;
                Min1name = EmploeeName;
                Min2name = EmploeeName;
            }
            else if (hoursworked < Min3hours) {
                Min3hours = hoursworked;
                Min3name= EmploeeName;
                Console.WriteLine("three Employees with the lowest working hours:");
                Console.WriteLine(Min1name + " - " + Min1hours + " time");
                Console.WriteLine(Min2name + " - " + Min2hours + " time ");
                Console.WriteLine(Min3name + " - " + Min3hours + " time ");
                

             
                

           
          }
        } 

           
    }
}