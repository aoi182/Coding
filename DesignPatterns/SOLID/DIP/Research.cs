using System.Collections.Generic;

namespace DesignPatterns.SOLID.DIP
{
    public class Research // high-level
    {
        public IEnumerable<Person> DoResearch(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                yield return p;
            }
        }
    }
}