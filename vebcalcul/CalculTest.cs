using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using vebcalcul;

namespace Webcalc
{
    [TestFixture]
    class CalculTest
    {
        Program calc = new Program();
        IWebDriver drive;

        [TestCase("5", "3", "8")]
        [TestCase("2", "2", "4")]
        public void TestPlus(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/%D0%90%D0%B4%D0%BC%D0%B8%D0%BD%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%82%D0%BE%D1%80/Desktop/HW14-master/refactored/index.html");

            drive.FindElement(By.Id(num1)).Click();
            drive.FindElement(By.Id("+")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);
            drive.Quit();
        }
        [TestCase("7", "2", "5")]
        [TestCase("9", "4", "5")]
        public void TestMinus(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/%D0%90%D0%B4%D0%BC%D0%B8%D0%BD%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%82%D0%BE%D1%80/Desktop/HW14-master/refactored/index.html");

            drive.FindElement(By.Id(num1)).Click();

            drive.FindElement(By.Id("-")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }
        [TestCase("2", "2", "4")]
        [TestCase("9", "5", "45")]
        public void TestUmn(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/%D0%90%D0%B4%D0%BC%D0%B8%D0%BD%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%82%D0%BE%D1%80/Desktop/HW14-master/refactored/index.html");

            drive.FindElement(By.Id(num1)).Click();

            drive.FindElement(By.Id("*")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }
        [TestCase("7", "7", "1")]
        [TestCase("6", "3", "2")]
        public void TestDel(string num1, string num2, string exp)
        {
            drive = new ChromeDriver();
            drive.Navigate().GoToUrl("file:///C:/Users/%D0%90%D0%B4%D0%BC%D0%B8%D0%BD%D0%B8%D1%81%D1%82%D1%80%D0%B0%D1%82%D0%BE%D1%80/Desktop/HW14-master/refactored/index.html");
            drive.FindElement(By.Id(num1)).Click();
            drive.FindElement(By.Id("/")).Click();
            drive.FindElement(By.Id(num2)).Click();
            drive.FindElement(By.Id("equal")).Click();
            IWebElement output = drive.FindElement(By.Id("15"));
            string act = output.GetAttribute("value");
            Assert.AreEqual(exp, act);

        }

        [TearDown]
        public void TearDown()
        {
            drive.Quit();
        }
    }
}
