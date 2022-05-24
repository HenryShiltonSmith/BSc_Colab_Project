using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using year3_collaborative_project.classes;

namespace unit_tests_ws304502
{
    using BCrypt = BCrypt.Net.BCrypt;
    [TestClass]
    public class encryption_test
    {
        [TestMethod]
        public void EncryptionTest()
        {
            clsEncryption objEncryption = new clsEncryption();

            string _sPassword = "ThisIsaPassword!";
            string _sEncrypted = objEncryption.EncryptPassword(_sPassword);

            Assert.IsTrue(BCrypt.Verify(_sPassword, _sEncrypted));            
        }
    }
}
