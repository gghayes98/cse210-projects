using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Develop02
{
    public  class Journal
    {
        List<Entry> _entries = new List<Entry>();

        public void AddEntry(String prompt)
        {
            Console.WriteLine(prompt);
            string _entry = Console.ReadLine();
            Entry _newEntry = new Entry(DateTime.Now.ToShortDateString(), prompt, _entry);
            _entries.Add(_newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
                }
            }
        }

        public void Load(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                Entry _newEntry = new Entry(parts[0], parts[1], parts[2]);

                _entries.Add(_newEntry);
            }
        }
    }
}
