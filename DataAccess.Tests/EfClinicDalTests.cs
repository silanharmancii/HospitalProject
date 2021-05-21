using DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Tests
{
    [TestClass]
    public class EfClinicDalTests
    {
        [TestMethod]

        public void TestGetAll()
        {
            EfClinicDal efClinicDal = new EfClinicDal();
            Assert.IsTrue(efClinicDal.GetAll().Any());
        }
    }
}
