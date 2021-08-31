using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lines = Convert.ToInt32(ConfigurationManager.AppSettings["NoOfLines"].ToString());

                if (ConfigurationManager.AppSettings["Trigger"] == "0")
                {
                    if(lines != 0) 
                    {
                        Triangle(lines);
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please Set the Number of lines in the App Config File");
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }                   
                }
                else if(ConfigurationManager.AppSettings["Trigger"] == "1")
                {
                    if (lines != 0)
                    {
                        InverseTriangle(lines);
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please Set the Number of lines in the App Config File");
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }
                }
                else if (ConfigurationManager.AppSettings["Trigger"] == "2")
                {
                    if (lines != 0 )
                    {
                        Triangle(lines);
                        Console.WriteLine("------------------------------------------"+System.DateTime.Now.ToString()+ "------------------------------------------"+Environment.NewLine);
                        InverseTriangle(lines);
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please Set the Number of lines in the App Config File");
                        Console.WriteLine("Press any Key to exit");
                        Console.ReadKey();
                    }                   
                }
                else if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["Trigger"]))
                {
                    Console.WriteLine("Please Set the Trigger value in the App Config File");
                    Console.WriteLine("Press any Key to exit");
                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Message : " + Environment.NewLine + ex.Message);
                Console.WriteLine("Press any Key to exit");
                Console.ReadKey();
            }
           

        }
        public static void Triangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void InverseTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int k = num; k >= 1; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
