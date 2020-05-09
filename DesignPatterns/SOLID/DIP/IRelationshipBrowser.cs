using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.DIP
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
