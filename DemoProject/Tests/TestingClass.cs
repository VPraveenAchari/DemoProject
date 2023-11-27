using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using DemoProject.Utilities;
using DemoProject.PageObject;

namespace DemoProject.Tests
{
    public class TestingClass:BaseClass
    {
       /* [Test]
        public void TestingApplication2()
        {
            LoginPage lp = new LoginPage(getDriver());
            IWebElement wb = lp.getLogout();
            Assert.IsFalse(wb.Displayed);
            lp.getLogin().Click();
            lp.getUserName().SendKeys(Constants.usernamevalue);
            lp.getPassword().SendKeys(Constants.wrongpassword);
            //lp.getPassword().SendKeys(Constants.wrongpassword);
            string password = Constants.wrongpassword;
            lp.getLoginButton().Click();
            //Assert.AreEqual(password, Constants.wrongpassword);
            if(password==Constants.wrongpassword)
            {
                TestContext.Progress.WriteLine("Wrong Password entered");
            }
            else
            {
                WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(Constants.logoutid)));
                lp.getProduct().Click();
                lp.AddProduct().Click();
                lp.Cartbutton().Click();
                lp.PlaceOrder().Click();
                lp.UserName().SendKeys(Constants.userName);
                lp.UserCountry().SendKeys(Constants.userCountry);
                lp.UserCity().SendKeys(Constants.userCity);
                lp.UserCard().SendKeys(Constants.userCard);
                lp.UserMonth().SendKeys(Constants.userMonth);
                lp.UserYear().SendKeys(Constants.userYear);
                lp.CancelButton().Click();
            }
        }*/
    }
}
