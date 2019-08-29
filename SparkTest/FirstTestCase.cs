using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras;
using OpenQA.Selenium.Support.UI;


namespace SparkTest
{
    public class FirstTestCase
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            TimeSpan timeSpan = TimeSpan.FromSeconds(1000);
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(driver, timeSpan);
            Functions f = new Functions();
            f.OpenTestApp(driver);
            f.Register(driver, timeSpan, wait);
            f.Buy(driver, timeSpan, wait);
            f.CheckOut(driver, timeSpan, wait);
            f.Login(driver);
            f.End(driver);

        }


    }
}
