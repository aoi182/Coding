using System.IO;

namespace DesignPatterns.SOLID.SRP
{
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
