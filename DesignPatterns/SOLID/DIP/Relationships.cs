using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.SOLID.DIP
{
    public class Relationships : IRelationshipBrowser// low-level
    {
        private List<(Person, RelationshipType, Person)> relations = new List<(Person, RelationshipType, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationshipType.Parent, child));
            relations.Add((child, RelationshipType.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name && x.Item2 == RelationshipType.Parent).Select(r => r.Item3);
        }
    }
}