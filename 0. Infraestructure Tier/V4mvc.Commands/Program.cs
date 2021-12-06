using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace V4mvc.Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Stopwatch stopwatch = new Stopwatch();
            string elapsed;
            while (!exit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please select command option(and -1 to exit):");
                Console.WriteLine("1.\tFill SP Folder && Generate Merged File");
                Console.WriteLine("2.\tCompare Repo SPs against Current obtained SPs");

                try
                {
                    int index = Int32.Parse(Console.ReadLine());

                    switch (index)
                    {
                        case -1:
                            exit = true;
                            Console.WriteLine("Exiting...");
                            System.Threading.Thread.Sleep(5000);
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            stopwatch.Restart();
                            var saver = new Classes.SqlStoredProceduresSaver();
                            if (saver.Run())
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("========================================================");
                                stopwatch.Stop();
                                elapsed = Classes.Utils.nearestUnitTime(stopwatch.ElapsedMilliseconds);
                                Console.WriteLine(String.Format("Filtered SQL files generated successfully.Time elapsed:{0}\n", elapsed));
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("========================================================");
                                Console.WriteLine("Filtered SQL files could not be generated.");
                            }
                            Console.WriteLine("Please press ENTER to continue:");
                            Console.Read();
                            break;
                        case 2:                           
                            break;
                    }
                    
                }
                catch (Exception exc)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exception:" + exc.Message);
                    exit = true;
                    Console.WriteLine("Exiting...");
                    System.Threading.Thread.Sleep(5000);
                }

                

            }
            
        }
    }
}
