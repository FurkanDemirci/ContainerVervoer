using System.Collections.Generic;
using ContainerVervoer;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoerTest.Models
{
    [TestClass()]
    public class PlaceTests
    {
        private Place _place1;
        private Place _place2;
        private Place _place3;
        private Place _place4;
        private Place _place5;
        private Place _place6;

        private Container _container;

        [TestInitialize]
        public void TestInitialize()
        {
            _place1 = new Place(1);
            _place2 = new Place(2);
            _place3 = new Place(3);
            _place4 = new Place(4);
            _place5 = new Place(5);
            _place6 = new Place(6);
        }

        [TestMethod()]
        public void PlaceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddContainerTest()
        {
            _container = new Container(false, false, 4000);
            var added = _place1.AddContainer(_container);
            Assert.IsTrue(added);
        }

        [TestMethod()]
        public void DeleteContainerTest()
        {
            _container = new Container(false, false, 4000);
            var deleted = _place1.DeleteContainer(_container);
            Assert.IsTrue(deleted);
        }

        [TestMethod()]
        public void SetPositionTest()
        {
            Service service = new Service(6, 900000);
            List<Container> containers = new List<Container>();

            for (int i = 0; i < 5; i++)
                containers.Add(new Container(true, false, 30000));
            containers.Add(new Container(true, false, 30000));

            foreach (var container in containers)
                _place1.AddContainer(container);

            _container = new Container(false, false, 4000);
            _place1.SetPosition();

            Assert.AreEqual(_place1.Containers[5].Valuable, true);
        }
    }
}