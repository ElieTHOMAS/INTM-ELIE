using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        
        public static void SchoolMeans(string input, string output)
        {
          //  using (Stream s = new FileStream(" result.csv ", FileMode.Create)) ;
          string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(input)) 
                {
                    using (TextReader reader = new StreamReader(inputStream)) 
                    {
                        List<string> ent = new List <string>();
                        //Read the first line of text
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            ent.Add(line);

                        }
                        //close the file
                        Console.ReadLine();
                    }
                    
                }
            }
               
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
