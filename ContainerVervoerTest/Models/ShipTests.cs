using System.Collections.Generic;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoerTest.Models
{
    [TestClass()]
    public class ShipTests
    {
        private Ship _ship;
        private List<Place> _places;

        [TestInitialize]
        public void TestInitialize()
        {
            _places = new List<Place>();
            for (int i = 1; i < 7; i++)
                _places.Add(new Place(i));
            FillPlaces();
            _ship = new Ship(_places, 900000);
        }

        public void FillPlaces()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int ii = 0; ii < 4; ii++)
                    _places[i].AddContainer(new Container(false, true, 30000));
            }

            _places[0].AddContainer(new Container(true, false, 30000));
            _places[1].AddContainer(new Container(false, true, 30000));
        }

        [TestMethod()]
        public void CalculateBalanceTest()
        {
            var percentage = _ship.CalculateBalance();
            Assert.AreEqual(percentage, 0); // Perfectly balanced.
        }
    }
}