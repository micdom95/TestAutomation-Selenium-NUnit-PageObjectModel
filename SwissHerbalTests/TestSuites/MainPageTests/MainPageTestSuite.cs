﻿using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects;
using SwissHerbalTests.PageObjects.MainPage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SwissHerbalTests.TestSuites.MainPageTests
{
    public class MainPageTestSuite
    {
        [Test]
        [Category("Smoke test")]
        public void OpenMainPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
            }
        }

        [Test]
        [Category("Smoke test")]
        public void OpenMyAccountPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMyAccountPage();
            }
        }

        [Test]
        [Category("Smoke test")]
        public void OpenBasketPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenBasketPage();
            }
        }

        [TestCase("https://pl.swissherbal.eu/sklep/noopeptil-max/")]
        [TestCase("https://pl.swissherbal.eu/sklep/noopept/")]
        [TestCase("https://pl.swissherbal.eu/sklep/immuno-box-mushroom-synergy/")]
        public void OpenGivenPage_PageOpenedProperly_CorrectUrlAddress(string url)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenGivenPage(url);
            }
        }

        [Test]
        public void SearchItem_OpenSearchEngine_SearchEngineOpened()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.SearchIconButtonClick();
            }
        }

        [Test]
        public void SearchItem_SearchItemByText_SearchProcessWorkProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.SearchIconButtonClick();
                mainPageActions.SearchTextboxInput("ABC");
                Thread.Sleep(5000);
            }
        }

        [Test]
        public void SuplementsTab_ClickEnergyTab_TabOpenedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.SuplementsTabHover();
            }
        }

        [Test]
        public void DisplayedProductCounter_ProductsCountedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.FindtAllProductsOnPage();
            }
        }

        [Test]
        public void DisplayedInStockProductCounter_ProductsCountedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.FindInStockProductsOnPage();
            }
        }

        [Test]
        public void SelectProductFromPage_SelectFirstOrDefaultInStockProduct_ProductSelectedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                Thread.Sleep(5000);
            }
        }

        [Test]
        public void SelectProductFromPage_SelectFirstOrDefaultOutOfStockProduct_ProductSelectedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectOutOfStockProduct();
                mainPageActions.AddProductButtonClick();
                Thread.Sleep(5000);
            }
        }

    }
}