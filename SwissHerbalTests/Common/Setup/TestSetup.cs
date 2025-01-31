﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SwissHerbalTests.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.Common.Setup
{
    public static class TestSetup
    {
        public static IWebDriver ReturnDriver(DriverType driverType)
        {
            IWebDriver _driver;
            switch(driverType)
            {
                case DriverType.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions
                    {
                        AcceptInsecureCertificates = true,
                        PageLoadStrategy = PageLoadStrategy.Normal
                    };
                    chromeOptions.AddArgument("--start-maximized");
                    
                    _driver = new ChromeDriver(chromeOptions);
                    break;
                
                case DriverType.FireFox:
                    _driver = new FirefoxDriver();
                    break;
               
                case DriverType.Edge:
                    EdgeOptions edgeOptions = new EdgeOptions()
                    {
                        AcceptInsecureCertificates = true,
                        PageLoadStrategy = PageLoadStrategy.Normal,
                    };

                    _driver = new EdgeDriver(edgeOptions);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(driverType), driverType, null);
            }
            return _driver;
        }
    }
}
