using System;
using System.Collections.Generic;
using ContainerVervoer;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoerTest
{
    [TestClass()]
    public class ServiceTests
    {
        private List<Container> _containers;
        private Service _service;
        private int _weight;

        [TestInitialize]
        public void TestInitialize()
        {
            _containers = new List<Container>();
            _weight = 900000;
        }

        /// <summary>
        /// Weight exceeding over maximum capacity.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ExceptionHandler))]
        public void HighWeightTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 40; i++)
                _containers.Add(new Container(false, false, 30000));

            _service.QuickChecker(_containers);
        }

        /// <summary>
        /// Weight lower then the minWeight.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ExceptionHandler))]
        public void LowWeightTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 4; i++)
                _containers.Add(new Container(false, false, 30000));

            _service.QuickChecker(_containers);
        }

        /// <summary>
        /// Sets containers.
        /// </summary>
        [TestMethod()]
        public void SetContainersTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 2; i++)
                _containers.Add(new Container(false, false, 30000));

            var setted = _service.SetContainers(_containers);
            Assert.IsTrue(setted);
        }

        /// <summary>
        /// Trying to get weight without filling the places.
        /// </summary>
        [TestMethod()]
        public void CalculateWeightTest()
        {
            _service = new Service(6, _weight);
            var weight = _service.CalculateWeight();
            Assert.AreEqual(weight, 0);
        }

        /// <summary>
        /// Places alwasy returns 6 intitialized places.
        /// </summary>
        [TestMethod()]
        public void GetPlacesTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 30; i++)
                _containers.Add(new Container(false, false, 30000));

            var places = _service.GetPlaces();
            Assert.AreEqual(places.Count, 6);
        }

        /// <summary>
        /// 30 containers with a weight of 30000 is possible to balance it to 0%.
        /// </summary>
        [TestMethod()]
        public void GetShipBalanceTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 30; i++)
                _containers.Add(new Container(false, false, 30000));
            _service.SetContainers(_containers);
            var balance = _service.GetShipBalance();
            Assert.AreEqual(balance, 0);
        }
    }
}