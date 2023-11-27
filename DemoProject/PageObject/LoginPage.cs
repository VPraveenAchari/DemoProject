using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoProject.PageObject
{
    public class LoginPage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = Constants.loginId)]
        public IWebElement loginId;
        [FindsBy(How = How.Id, Using = Constants.logoutid)]
        private IWebElement logoutId;
        [FindsBy(How = How.Id, Using = Constants.username)]
        public IWebElement username;
        [FindsBy(How = How.Id, Using = Constants.password)]
        public IWebElement password;
        [FindsBy(How = How.CssSelector, Using = Constants.loginButton)]
        public IWebElement loginButton;
        [FindsBy(How = How.LinkText, Using = Constants.product)]
        public IWebElement product;
        [FindsBy(How = How.XPath, Using = Constants.addProduct)]
        public IWebElement addProduct;
        [FindsBy(How = How.XPath, Using = Constants.cartButton)]
        public IWebElement cartButton;
        [FindsBy(How = How.XPath, Using = Constants.placeOrder)]
        public IWebElement placeOrder;
        [FindsBy(How = How.Id, Using = Constants.usName)]
        public IWebElement usName;
        [FindsBy(How = How.Id, Using = Constants.usCountry)]
        public IWebElement usCountry;
        [FindsBy(How = How.XPath, Using = Constants.usCity)]
        public IWebElement usCity;
        [FindsBy(How = How.Id, Using = Constants.usCard)]
        public IWebElement usCard;
        [FindsBy(How = How.Id, Using = Constants.usMonth)]
        public IWebElement usMonth;
        [FindsBy(How = How.Id, Using = Constants.usYear)]
        public IWebElement usYear;
        [FindsBy(How = How.XPath, Using = Constants.purchaseButton)]
        public IWebElement purchaseButton;
        [FindsBy(How = How.XPath, Using = Constants.confirmButton)]
        public IWebElement confirmButton;
        [FindsBy(How = How.CssSelector, Using = Constants.cancelButton)]
        public IWebElement cancelButton;

        public IWebElement getLogin() { return loginId; }
        public IWebElement getLogout() { return logoutId; }
        public IWebElement getUserName() { return username; }
        public IWebElement getPassword() { return password; }
        public IWebElement getLoginButton() { return loginButton; }
        public IWebElement getProduct() { return product; }
        public IWebElement AddProduct() { return addProduct; }
        public IWebElement Cartbutton() { return cartButton; }
        public IWebElement PlaceOrder() { return placeOrder; }
        public IWebElement UserName() { return usName; }
        public IWebElement UserCountry() { return usCountry; }
        public IWebElement UserCity() { return usCity; }
        public IWebElement UserCard() { return usCard; }
        public IWebElement UserMonth() { return usMonth; }
        public IWebElement UserYear() { return usYear; }
        public IWebElement PurchaseButton() { return purchaseButton; }
        public IWebElement ConfirmButton() { return confirmButton; }
        public IWebElement CancelButton() { return cancelButton; }
    }
}
