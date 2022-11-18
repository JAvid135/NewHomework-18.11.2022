using System;
using System.Collections.Generic;
using Task_4.Models;

namespace Task_4
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Employee tipinden listiniz olacaq. Yashi 20-40 arasinda olan ishcilerin maashlarinin ededi ortasini tapan method yazin.
            //=======================================================================================================================


            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee {FullName = "Residli Nicat", Age = 30 , Salary = 800 });
            employees.Add(new Employee { FullName = "Nurlanli Resah", Age = 19, Salary = 1000 });
            employees.Add(new Employee { FullName = "Babayev Yaver", Age = 23, Salary = 500 });
            employees.Add(new Employee { FullName = "Eliyeva Guler", Age = 40, Salary = 1800 });

            double sum = 0;
            int count = 0;
            var result = employees.FindAll(m => m.Age > 20 && m.Age < 40);
            foreach(Employee emp in result)
            {
                sum+=emp.Salary;
                count++;
                
            }
            Console.WriteLine(sum/count);


        }
    }
}
