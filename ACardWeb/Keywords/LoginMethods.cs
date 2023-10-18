using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserDriver;
using ACardWeb.ObjectRepository;

namespace ACardWeb.Keywords
{
    public class LoginMethods
    {
        public static void IngresarUsuario(WebDriver driver, string value)
        {
            if (CommonMethods.ValidateValue(value))
            {
                driver.FindElement(LoginObjects.input_Usuario).SendKeys(value);
            }
        }
        public static void IngresarClave(WebDriver driver, string value)
        {
            if (CommonMethods.ValidateValue(value))
            {
                driver.FindElement(LoginObjects.input_Clave).SendKeys(value);
            }
        }
        public static void PresionarEntrar(WebDriver driver)
        {
            driver.FindElement(LoginObjects.button_Entrar).Click();
        }
    }
}
