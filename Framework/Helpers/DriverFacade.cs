﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Unity;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Helpers
{
    public class DriverFacade : IDisposable
    {

        private IWebDriver _driver;
        private readonly ConfigHelper _configHelper;
        ConfigSetting _setting;
        private readonly int _timeout;

        public DriverFacade(DisposableContainer disposableContainer)
        {
            _configHelper = UnityContainerFactory.GetContainer().Resolve<ConfigHelper>();
            _setting = _configHelper._setting;
            LoadDriver();
            _timeout = _setting.Timeout;
            disposableContainer.AddDisposableObject(this);
        }

        private void LoadDriver()
        {
            var browser = _setting.Browser;

            switch (browser)
            {
                case "firefox":
                    _driver = GetFirefoxDriver();
                    break;
                case "chrome":
                    _driver = GetChromeDriver();
                    break;
            }

            GoToUrl(_setting.AppUrl);

        }

        private IWebDriver GetChromeDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }

        private IWebDriver GetFirefoxDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }


        public IWebDriver GetDriver() => _driver;
        public void CloseDriver() => _driver.Close();

        public IWebElement WaitUntilElementVisible(By by)
        {
            return this.WaitUntilElementVisible(by, _timeout);
        }

        public IWebElement WaitUntilElementVisible(By by, int timeout)
        {
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            webDriverWait.IgnoreExceptionTypes(new Type[2]
            {
                typeof(NoSuchElementException),
                typeof(StaleElementReferenceException)
            });
            return webDriverWait.Until(_driver => !_driver.FindElement(by).Displayed ? null : _driver?.FindElement(by));
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            _driver.Dispose();
        }
    }
}