using System;
using System.Collections.Generic;
using System.Text;
using Password_Validator_MVC.Models;
using Password_Validator_MVC.Views;

namespace Password_Validator_MVC.Controllers
{
    public class PasswordController
    {
        private Password password;
        private Display display;

        public PasswordController()
        {
            display = new Display();
            password = new Password(display.Input);

            display.Input = password.CheckPassword();
            display.Output = password.CheckPassword();

            display.CheckAndOutputPassword();
        }
    }
}
