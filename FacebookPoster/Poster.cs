﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FacebookPoster
{
    class Poster
    {
        public void start()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.demoqa.com";
        }

    }
}
