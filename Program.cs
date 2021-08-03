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



        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Empls[] empl = new Empls[3];
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
                //   когда нажать Y, ввод массива закончится
                Console.Write("if you want to end the array press Y if no press N");
                if (Console.ReadLine() == "Y") ; break;
                // if   (Console.ReadLine() == "Y");
                //{ continue; }







            }

            Console.WriteLine("select an action: a = Min salary of employees; b = Max salary of employees; c = AVR age of employees; d = Vivod spiska, e= ");
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



                        break;

                    case "b":

                        decimal max = empl[0].salary;
                        for (int t = 0; t < empl.Length; t++)
                        {
                            if (max < empl[t].salary)
                                max = empl[t].salary;

                        }

                        Console.WriteLine($"Max salary = {max}");
                        break;

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


                    for (int i = 0; i < empl.Length; i++)
                    {

                        Console.WriteLine(empl);

                    }
                    Console.WriteLine();


                    //   Console.WriteLine(empl[n, a, s, d]);


                    // break;



                    // case "e":


                    // Console.Write(String.Format("{0,4}", Empls[n, a, s, d]));
                    break;


                        default:
                        Console.WriteLine("Wrong latter");
                        break;


                }
                Console.ReadKey();
           // }
        }
    }
}






