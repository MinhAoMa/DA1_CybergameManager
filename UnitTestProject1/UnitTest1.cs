using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Net;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IAccountBUS acc = new AccountBUS();
            SqlDataReader rdr = acc.checkItem_ID(Convert.ToInt32(""),"p123","Quản lý");
            Assert.IsTrue(rdr.Read());
        }
        [TestMethod]
        public void TestMethod2()
        {
            IAccountBUS acc = new AccountBUS();
            SqlDataReader rdr = acc.checkItem_ID(001, "p123", "Quản lý");
            Assert.IsFalse(rdr.Read());
        }
    }
}
