using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "source.txt";

                if (File.Exists(filePath)) {
                    // Write file
                    using (StreamWriter writer = new StreamWriter(filePath, append: true))
                    {
                        writer.WriteLine("Hello, this is line 1.");
                        writer.WriteLine("This is line 2.");
                    }

                    // Read file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string content = reader.ReadToEnd();
                        Console.WriteLine(content);
                    }
                }
                else
                    throw new FileNotFoundException("This file was not found.");

                Console.ReadLine();
            }
            catch(Exception e) {
                Console.WriteLine("Something wrong in your application : " 
                    + e.Message.ToString());
                Console.ReadLine();
            }
            finally {
                Console.WriteLine("Application Execution Completed!");
                Console.ReadLine();
            }
;        }
    }
}
