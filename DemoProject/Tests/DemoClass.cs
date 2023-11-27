using DemoProject.PageObject;
using DemoProject.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace DemoProject.Tests
{
    public class DemoClass:BaseClass
    {
        [Test]
        public void PurchaseProduct()
        {
            LoginPage lp = new LoginPage(getDriver());
            IWebElement wb = lp.getLogout();
            Assert.IsFalse(wb.Displayed);
            lp.getLogin().Click();
            lp.getUserName().SendKeys(Constants.usernamevalue);
            lp.getPassword().SendKeys(Constants.passwordvalue);
            string password = Constants.passwordvalue;
            lp.getLoginButton().Click();
            Assert.AreNotEqual(password, Constants.wrongpassword);
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
            lp.PurchaseButton().Click();
            lp.ConfirmButton().Click();
        }
        [Test]
        public void CancelProduct()
        {
            LoginPage lp = new LoginPage(getDriver());
            IWebElement wb = lp.getLogout();
            Assert.IsFalse(wb.Displayed);
            lp.getLogin().Click();
            lp.getUserName().SendKeys(Constants.usernamevalue);
            lp.getPassword().SendKeys(Constants.passwordvalue);
            string password = Constants.passwordvalue;
            lp.getLoginButton().Click();
            Assert.AreEqual(password, Constants.passwordvalue);
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
    }
}
