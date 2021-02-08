using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace FacebookPoster
{
    class Poster
    {
        private List<string> grupy;
        private string email;
        private string haslo;
        private string zdjecie;
        private string post;

        public void loguj()
        {
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")));
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(1000);
        }

        public Poster(List<string> grupy, string email, string haslo, string post, string zdjecie = null)
        {
            this.grupy = grupy;
            this.email = email;
            this.haslo = haslo;
            this.zdjecie = zdjecie;
        }

    }
}
