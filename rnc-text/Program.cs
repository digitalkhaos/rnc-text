using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rnc_text
{
    class Program
    {
        static void PrintMenu()
        {
            string Menu = "************************" +
                          "1 - List names in file." +
                          "2 - Add name to list." +
                          "3 - Remove name from list." +
                          "4 - Statistics (not implemented)." +
                          "? - This menu (Help)." +
                          "x - Exit." +
                          "*************************";
            try
            {
                Console.WriteLine(Menu);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            const string path = @"c:\rnc_list";

            try
            {
                var lines = new List<string>();

                using var streamReader = new StreamReader(path, Encoding.UTF8);
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                /*
                while((line = streamReader.ReadLine()) != null)
                {
                    foreach(line in streamReader)
                        NameEntry entry = new NameEntry(line);   
                }
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            PrintMenu();
            CommandPrompt.ShowPrompt();
        }

        private static class CommandPrompt
        {
            private static readonly string _prompt = "-->";

            public static int ShowPrompt()
            {
                try
                {
                    Console.WriteLine(_prompt);

                    return 0;
                }

                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                    return 1;
                }
                
            }
            
        }
    }

    public class NameEntry
    {
        //private readonly int _id;
        private readonly string _name;
        //private readonly int _timesChosen;
        //private readonly DateTime _lastChosenDateTime;
        
        public NameEntry(string name)
        {
            _name = name;
        }

        
        /*
         * public NameEntry(string name, DateTime nowDateTime)
         
        {
            _name = name;
            //_lastChosenDateTime = nowDateTime;
            //_timesChosen += 1;
        }
        */

        public string Name
        {
            get;
            set;  //something has to happen here I think, some type of protection?
        }

        /*
        public int TimeChosen
        {
            get;
            set;
        }
        */
    }
}
