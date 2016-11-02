using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIn.CheckIn;


namespace UnitTestProject
{
    [TestClass]
    public class CheckInTests
    {
        private CheckInModel model = new CheckInModel();

        [TestMethod]
        public void ValidFirstName()
        {
            string name = "Евгений";
            Assert.IsNull(model.CheckFirstName(name));
        }

        [TestMethod]
        public void InValidFirstName()
        {
            string name = "11fef3";
            Assert.IsNotNull(model.CheckFirstName(name));
        }

        [TestMethod]
        public void ValidLastName()
        {
            string name = "Иванов";
            Assert.IsNull(model.CheckLastName(name));
        }

        [TestMethod]
        public void InValidLastName()
        {
            string name = "11fef3";
            Assert.IsNotNull(model.CheckLastName(name));
        }

        [TestMethod]
        public void ValidMail()
        {
            string mail = "aaa@mail.ru";
            Assert.IsNull(model.CorrectMailFormat(mail));
        }

        [TestMethod]
        public void InValidMail()
        {
            string mail = "aaamail.ru";
            Assert.IsNotNull(model.CorrectMailFormat(mail));
        }

        [TestMethod]
        public void ValidPass()
        {
            string pass1 = "111";
            string pass2 = "111";
            Assert.IsNull(model.CheckPass(pass1, pass2));
        }

        [TestMethod]
        public void InValidPass()
        {
            string pass1 = "111";
            string pass2 = "112";
            Assert.IsNotNull(model.CheckPass(pass1, pass2));
        }
    }
}
