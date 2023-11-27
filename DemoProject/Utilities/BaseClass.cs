using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using NUnit.Framework.Interfaces;
using System.Drawing;

namespace DemoProject.Utilities
{
    public class BaseClass
    {
        public ExtentReports extent;
        public ExtentTest test;
        public IWebDriver driver;
        String browserName;
        [OneTimeSetUp]
        public void SetUp()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectory + "//report.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Username", "Praveen");
        }
        [SetUp]
        public void StartBrowser()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            browserName = TestContext.Parameters["browserName"];
            if (browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }
            InitBrowser(browserName);
            driver.Url = "https://www.demoblaze.com/";
            //driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }
        public IWebDriver getDriver()
        {
            return driver;
        }
        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;
            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            if (status == TestStatus.Failed)
            {
                test.Fail("Test Failed", captureScreenshot(driver, fileName));
                test.Log(Status.Fail, "test failed with logTrace" + stackTrace);
            }
            else if (status == TestStatus.Passed)
            {

            }
            extent.Flush();
            driver.Quit();
        }
        public MediaEntityModelProvider captureScreenshot(IWebDriver driver, String screenShotName)
        {
            //here casting the driver to screenshot mode-so driver switch to screenshot mode
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
            //Convert AsBase64EncodedString format to media entity
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }

    }
}
