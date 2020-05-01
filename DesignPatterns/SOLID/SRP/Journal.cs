using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.SOLID.SRP
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        // just for count total # of entries
        private static int count = 0;

        public void AddEntry(string text) => entries.Add($"{++count}: {text}");

        public void RemoveEntry(int index) => entries.RemoveAt(index);

        public override string ToString()
        {
            return string.Join("\n", entries);
        }
    }

    public class PersistenceManager
    {
        public void SaveToFile(Journal journal, string fullFileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fullFileName))
            {
                File.WriteAllText(fullFileName, journal.ToString());
            }
        }
    }
}
