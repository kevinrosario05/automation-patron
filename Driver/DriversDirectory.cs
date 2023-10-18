using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace BrowserDriver
{
    public class DriversDirectory
    {
        public static WebDriver GetDriver(string Driver) 
        {
            switch (Driver)
            {
                case "CHROME":
                    return new ChromeDriver();

                case "EDGE":
                    return new EdgeDriver();

                case "FIREFOX":
                    return new FirefoxDriver();

                default:
                    return new ChromeDriver();
            }
        }
    }
}
