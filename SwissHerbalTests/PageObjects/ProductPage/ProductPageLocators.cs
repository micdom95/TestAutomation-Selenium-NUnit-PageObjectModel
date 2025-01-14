﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ItemPage
{
    public class ProductPageLocators
    {
        private IWebDriver _driver;

        public ProductPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }
 
        public IWebElement ItemCounterField => _driver.FindElement(By.Name("quantity"));
        public IWebElement SelectPackageField => _driver.FindElement(By.Id("pa_opakowanie"));
        public IWebElement SelectPackageOption => _driver.FindElement(By.Id("pa_opakowanie"));
        public IWebElement ClearPackageOptionButton => _driver.FindElement(By.ClassName("reset_variations"));
        public IWebElement AddItemButton => _driver.FindElement(By.CssSelector("button[class='single_add_to_cart_button button alt']"));
        public IWebElement AddItemWithoutSelectedOptionButton => _driver.FindElement(By.CssSelector("button[class='single_add_to_cart_button button alt disabled wc-variation-selection-needed']"));
        public IWebElement AddUnavailableItemButton => _driver.FindElement(By.CssSelector("button[class='single_add_to_cart_button button alt disabled wc-variation-is-unavailable']"));
        public IWebElement GoToBasketPageButton => _driver.FindElement(By.XPath("//a[@class='button wc-forward']"));
        public IWebElement AddToWaitingListButton => _driver.FindElement(By.XPath("//a[@class='xoo-wl-btn button btn']"));
        public IWebElement TemporaryMissingLaber => _driver.FindElement(By.CssSelector("span[class='stock-danger']"));
        public IWebElement OutOfStockLabel => _driver.FindElement(By.CssSelector("[class='stock out-of-stock']"));
        public IWebElement AddedItemLabel => _driver.FindElement(By.ClassName("woocommerce-notices-wrapper"));
        public IWebElement AddToWaitingListModal => _driver.FindElement(By.XPath("//div[@class='xoo-wl-container xoo-wl-active']"));
        public IWebElement AddToWaitingListModalEmailTextbox => _driver.FindElement(By.XPath("//input[@class='xoo-wl-email']"));
        public IWebElement AddToWaitingListModalNotificationButton => _driver.FindElement(By.Name("xoo-wl-submit"));
        public IWebElement WaitingListModal => _driver.FindElement(By.XPath("//div[@class='xoo-wl-inmodal']"));
        public IWebElement ModalEmptyEmailErrorLabel => _driver.FindElement(By.CssSelector("span[class='xoo-wl-error']"));
        public IWebElement ModalIncorrectEmailErrorLabel => _driver.FindElement(By.CssSelector("span[class='xoo-wl-error']"));
        public IWebElement AcceptCookieButton => _driver.FindElement(By.CssSelector("a[id='cookie_action_close_header']"));
        public IAlert OptionAlert => _driver.SwitchTo().Alert();
        public IAlert OutOfStockAlert => _driver.SwitchTo().Alert();
    }
}
