using DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Tests
{
    [TestClass]
    public class EfEquipmentDalTests
    {
        [TestMethod]

        public void TestGetAll()
        {
            EfEquipmentDal efEquipmentDal = new EfEquipmentDal();
            Assert.IsTrue(efEquipmentDal.GetAll().Any());
        }

    }
}
