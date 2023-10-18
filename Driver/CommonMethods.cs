using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;


namespace BrowserDriver
{
    public class CommonMethods
    {
        public static bool ValidateValue(string value)
        {
            bool validated = false;
            if (value != null && value.Trim() != string.Empty)
            {
                validated = true;
            }
            return validated;
        }
        public static void WaitObject(WebDriver driver, By locator, int seconds = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementExists(locator));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
