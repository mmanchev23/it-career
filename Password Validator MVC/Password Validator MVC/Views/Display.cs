using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Validator_MVC.Views
{
    public class Display
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public Display()
        {
            Input = "";
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter your password: ");
            this.Input = Console.ReadLine();
        }

        public void CheckAndOutputPassword()
        {
            Console.WriteLine(Output);
        }
    }
}
