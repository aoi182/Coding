using System;
using DesignPatterns.SOLID.SRP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SOLID_SRP_Test()
        {
            var journal = new Journal();
            journal.AddEntry("I cried today.");
            journal.AddEntry("I ate a bug.");

            var pm = new PersistenceManager();
            pm.SaveToFile(journal, "my-journal.txt", true);
        }
    }
}
