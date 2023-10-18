using ACardWeb.Keywords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACardWeb.Tests
{
    [TestClass]
    public class Login : BrowserDriver.DriverHelper
    {
        [TestMethod ("Iniciar sesion con las credenciales correctas")]
        public void IniciarSesion_CredencialesCorrectas()
        {
            Iniciar("CHROME");
            LoginMethods.IngresarUsuario(driver, Profiles.QA.Usuario);
            LoginMethods.IngresarClave(driver, Profiles.QA.Clave);
            LoginMethods.PresionarEntrar(driver);
            //Validaciones
        }
        [TestMethod("Iniciar sesion con las credenciales incorrectas")]
        public void IniciarSesion_CredencialesInorrectas()
        {
            Iniciar("CHROME");
            LoginMethods.IngresarUsuario(driver, Profiles.QA.Usuario);
            LoginMethods.IngresarClave(driver, "asasas");
            LoginMethods.PresionarEntrar(driver);
            //Validaciones
        }
    }
}
