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
    public class Functions
    {

        public void OpenTestApp(IWebDriver driver)
        {
            driver.Url = "http://automationpractice.com/index.php";

        }

        public void Register(IWebDriver driver, TimeSpan timeSpan, WebDriverWait wait)
        {
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email_create")).SendKeys("example@company.com");
            driver.FindElement(By.Id("SubmitCreate")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("id_gender2")));
            Thread.Sleep(5000);
            driver.FindElement(By.Id("id_gender2")).Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("Monica");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Maged");
            driver.FindElement(By.Id("passwd")).SendKeys("Password");
            driver.FindElement(By.Id("days")).SendKeys("1");
            driver.FindElement(By.Id("months")).SendKeys("1");
            driver.FindElement(By.Id("years")).SendKeys("2000");
            driver.FindElement(By.Id("newsletter")).Click();

            driver.FindElement(By.Id("firstname")).SendKeys("adress firstname");
            driver.FindElement(By.Id("lastname")).SendKeys("adress lastname");
            driver.FindElement(By.Id("address1")).SendKeys("Street address, P.O. Box, Company name");
            driver.FindElement(By.Id("city")).SendKeys("Cairo");
            driver.FindElement(By.Id("id_state")).SendKeys("Alabama");
            driver.FindElement(By.Id("postcode")).SendKeys("123");
            driver.FindElement(By.Id("id_country")).SendKeys("United States");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("0122345678");
            driver.FindElement(By.Id("alias")).SendKeys("mail@alias.com");
            driver.FindElement(By.Id("submitAccount")).Submit();
        }


        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("example@company.com");
            driver.FindElement(By.Id("passwd")).SendKeys("Password");
            driver.FindElement(By.Id("SubmitLogin")).Submit();
        }


        public void Buy(IWebDriver driver, TimeSpan timeSpan, WebDriverWait wait)
        {

            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@title='List']")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-id-product='1']")));

            driver.FindElement(By.XPath("//*[@data-id-product='1']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@title='Continue shopping']")));

            driver.FindElement(By.XPath("//*[@title='Continue shopping']")).Click();

            driver.FindElement(By.XPath("//*[@data-id-product='4']")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@title='Proceed to checkout']")));
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@title='Proceed to checkout']")).Click();


        }


        public void CheckOut(IWebDriver driver, TimeSpan timeSpan, WebDriverWait wait)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@title='Proceed to checkout']")));

            driver.FindElement(By.XPath("//*[@title='Proceed to checkout']")).Click();
           //STOP HERE
        }

        public void End(IWebDriver driver)
        {
            driver.Close();

        }

    }
}
