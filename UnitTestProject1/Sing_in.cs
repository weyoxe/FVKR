using System;
using System.Reflection.Emit;
using FVKR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Sing_in

    {
        Autorization c = new Autorization();

        [TestMethod]
        public void CheckEmpty()
        {
            string usermane = "";
            string password = "";
            string actual = c.CheckAutorization(usermane, password);
            string expected = "Введите данные!";
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void CheckCorrectLogin()
        {
            string usermane = "admin";
            string password = "12345";
            string actual = c.LoginCheck(usermane, password);
            string expected = "Успешный вход";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckUnCorrectLogin()
        {
            string usermane = "tfgyhu";
            string password = "gvhbnkm,l";
            string actual = c.LoginCheck(usermane, password);
            string expected = "Ошибка!Проверьте корректность введенныйх данных!";
            Assert.AreEqual(expected, actual);
        }

    }
}
