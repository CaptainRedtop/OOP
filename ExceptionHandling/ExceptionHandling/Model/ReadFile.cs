using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Model
{
    internal class ReadFile
    {
        /// <summary>
        /// Reading log file and counting log entries
        /// </summary>
        /// <returns></returns>
        internal int ReadLogFile()
        {
            string logFilePath = @"C:\Users\klich\source\repos\CaptainRedtop\OOP\ExceptionHandling\ExceptionHandling\bin\Debug\net6.0\log.txt";
            string searchCriteria = "Log";
            string line;
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader(logFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchCriteria))
                        {
                            count++;
                        }
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            Console.ReadKey();
            return count;
        }

    }
}
