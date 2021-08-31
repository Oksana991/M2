using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas
{

    struct Empls

    {
        public string name;
        public int age;
        public decimal salary;
        public string dep;

        public Empls(string n, int a, decimal s, string d)
        {
            name = n; age = a; salary = s; dep = d;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age} Salary = {salary} Departmrnt {dep} ");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {

            int size = 1;
            Empls[] empl = new Empls[size];


            for (int i = 0; i < empl.Length; i++)

            {
                Console.Write("Enter name employee: ");
                string n = Console.ReadLine();
                Console.Write("Enter age employee: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter salary amount employee: ");
                decimal s = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter department: ");
                string d = Console.ReadLine();
                empl[i] = new Empls(n, a, s, d);
                int count = empl.Length;
                if (count != 0)
                {
                    Array.Resize(ref empl, empl.Length + 1);
                }//   когда нажать Y, ввод массива закончится
                Console.Write("if you want to end the array press Y if no press N\n");
                if (Console.ReadLine() == "Y") break;


                // if (count)
                //  {
                //      empl = CopyEmployL
                // }


            }
            metka:
            Console.WriteLine("select an action: " +
                "\n a = Min salary of employees; " +
                "\n b = Max salary of employees;" +
                "\n c = AVR age of employees; " +
                "\n d = Output to the console of all employees," +
                "\n e = Output to the console of all employees by department " +
                "\n f = Search by name"+
                "\n g = Press g to exit");
           

            string selection = Console.ReadLine();
            


            switch (selection)

            {
                case "a":
                    decimal min = empl[0].salary;

                    for (int t = 0; t < empl.Length; t++)
                    {
                        if (min > empl[t].salary)
                            min = empl[t].salary;
                    }
                    Console.WriteLine($"Min salary ={min}");

                    goto metka;

                    
                case "b":
                    decimal max = empl[0].salary;
                    for (int t = 0; t < empl.Length; t++)
                    {
                        if (max < empl[t].salary)
                            max = empl[t].salary;
                    }
                    Console.WriteLine($"Max salary = {max}");
                    goto metka;

                    
                case "c":
                    int avg = 0;
                    int agetotal = 0;
                    for (int t = 0; t < empl.Length; t++)
                    {
                        agetotal += empl[t].age;
                    }
                    avg = agetotal / empl.Length;
                    Console.WriteLine($"AVG = {avg}");
                    break;
                case "d":
                    foreach (Empls e in empl)
                    {
                        e.DisplayInfo();
                    }
                    goto metka;
                    
                case "e":

                    Console.WriteLine($"Name of department ");
                    var depName = Console.ReadLine();
                    foreach (Empls e in empl)
                    {
                        if (e.dep.Contains(depName))
                        {
                            e.DisplayInfo();
                        }
                    }
                    
                        goto metka;
                    
                    
                case "f":

                    Console.WriteLine("\n\nName of employy:");
                    var Nameempl = Console.ReadLine();
                    foreach (Empls e in empl)
                    {
                        if (e.dep.Contains(Nameempl))
                        {
                            e.DisplayInfo();
                        }
                    }
                    goto metka;

                case "g":
                    return;


                default:
                    Console.WriteLine("Wrong latter");
                    goto metka;
                    
            }
            Console.ReadKey();
        }
    }
}






