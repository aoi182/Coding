using System.Collections.Generic;
using System.Linq;
using DesignPatterns.SOLID.OCP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class SOLID_OCP_UnitTest
    {
        ICollection<Product> products = new[]
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Three", Color.Green, Size.Large),
                new Product("House", Color.Blue, Size.Large)
            };

        [TestMethod]
        public void SOLID_OCP_Test1()
        {
            IEnumerable<string> expectedProductNames = new List<string>();

            var betterFilter = new BetterFilter();

            List<string> filteredProductNamesByColor = new List<string>(3);

            foreach (var item in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                filteredProductNamesByColor.Add(item.Name);
            }

            expectedProductNames = products.Where(q => q.Color == Color.Green)
                .Select(q => q.Name);

            Assert.IsTrue(HelperTest.AreEquals(expectedProductNames, filteredProductNamesByColor.ToArray(), order: true));
        }

        [TestMethod]
        public void SOLID_OCP_Test2()
        {
            var betterFilter = new BetterFilter();

            var filteredProductNamesByColorAndSize = new List<string>();

            var smallGreenSpec = new ColorSpecification(Color.Green) & new SizeSpecification(Size.Small);

            foreach (var item in betterFilter.Filter(products, smallGreenSpec))
            {
                filteredProductNamesByColorAndSize.Add(item.Name);
            }

            IEnumerable<string> expectedProductNames = products.Where(q => q.Color == Color.Green && q.Size == Size.Small)
                .Select(q => q.Name);

            Assert.IsTrue(HelperTest.AreEquals(expectedProductNames, filteredProductNamesByColorAndSize.ToArray(), order: true));
        }

        [TestMethod]
        public void SOLID_OCP_Test3()
        {
            var betterFilter = new BetterFilter();

            var filteredProductNamesByColorAndSize = new List<string>();

            var smallGreenSpec = new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Small));

            foreach (var item in betterFilter.Filter(products, smallGreenSpec))
            {
                filteredProductNamesByColorAndSize.Add(item.Name);
            }

            IEnumerable<string> expectedProductNames = products.Where(q => q.Color == Color.Green && q.Size == Size.Small)
                .Select(q => q.Name);

            Assert.IsTrue(HelperTest.AreEquals(expectedProductNames, filteredProductNamesByColorAndSize.ToArray(), order: true));
        }

        [TestMethod]
        public void SOLID_OCP_Test4()
        {
            var betterFilter = new BetterFilter();

            var filteredProductNamesByColorAndSize = new List<string>();

            var largeGreenSpec = Color.Green.And(Size.Small);

            foreach (var item in betterFilter.Filter(products, largeGreenSpec))
            {
                filteredProductNamesByColorAndSize.Add(item.Name);
            }

            IEnumerable<string> expectedProductNames = products.Where(q => q.Color == Color.Green && q.Size == Size.Small)
                .Select(q => q.Name);

            Assert.IsTrue(HelperTest.AreEquals(expectedProductNames, filteredProductNamesByColorAndSize.ToArray(), order: true));
        }
    }
}