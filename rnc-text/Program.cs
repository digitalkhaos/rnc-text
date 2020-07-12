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
            Console.WriteLine("Main Menu\n");
            Console.WriteLine();
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
        }
    }

    public class NameEntry
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _timesChosen;
        private readonly DateTime _lastChosenDateTime;
        public NameEntry(string name)
        {
            _name = name;
        }

        public NameEntry(string name, DateTime nowDateTime)
        {
            _name = name;
            _lastChosenDateTime = nowDateTime;
            _timesChosen += 1;
        }

        public string Name
        {
            get;
            private set;
        }

        public int TimeChosen
        {
            get;
            set;
        }
    }
}
