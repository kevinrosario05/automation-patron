using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserDriver
{
    public class DriverHelper
    {
        public static WebDriver driver;
        public static void Iniciar(string Driver)
        {
            driver = DriversDirectory.GetDriver(Driver);
            driver.Manage().Window.Maximize();
        }
        public static void Cierre()
        {
            driver.Quit();
        }
    }
}
