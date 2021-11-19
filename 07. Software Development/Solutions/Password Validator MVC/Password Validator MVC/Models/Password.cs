using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Validator_MVC.Models
{
    public class Password
    {
        //Fields
        private string input;

        //Properties
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        //Constructor
        public Password(string input)
        {
            this.Input = input;
        }

        /// <summary>
        /// A method that checks whether a password is valid or not.
        /// </summary>
        /// 
        /// <returns>
        /// If valid:
        ///     -> returns a string "The password is valid."
        ///     
        /// If not valid:
        ///     -> returns a string:
        ///         1) "The password should contain atleast 8 characters!"
        ///         2) "The password should contain atleast one digit!"
        ///         3) "The password should contain atleast one upper character!"
        ///         4) "The password should contain atleast one lower character!"
        ///         5) "The password should not contain characters such as '!', '$', '#', '%'!"
        ///         6) "The password is invalid."
        /// </returns>
        public string CheckPassword()
        {
            //Variables
            bool hasAtleast8Characters = false;
            bool hasAtleastOneDigit = false;
            bool hasAtleastOneUpperCharacter = false;
            bool hasAtleastOneLowerCharacter = false;
            bool hasNoNonAlphanumericCharacters = false;

            char currentCharacter;


            //Logic that checks for the length and the non-alphanumeric characters
            if (this.Input.Length >= 8)
                hasAtleast8Characters = true;

            //Logic that checks for the non-alphanumeric characters
            if (!(Input.Contains('!') || Input.Contains('$') || Input.Contains('#') || Input.Contains('%')))
                hasNoNonAlphanumericCharacters = true;

            //Looping through the given password
            for (int i = 0; i < Input.Length; i++)
            {
                currentCharacter = Input[i];

                //Some more logic
                if (char.IsDigit(currentCharacter))
                    hasAtleastOneDigit = true;
                else if (char.IsUpper(currentCharacter))
                    hasAtleastOneUpperCharacter = true;
                else if (char.IsLower(currentCharacter))
                    hasAtleastOneLowerCharacter = true;
            }


            //Return statements
            if (!hasAtleast8Characters && hasAtleastOneDigit && hasAtleastOneUpperCharacter && hasAtleastOneLowerCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "The password should contain atleast 8 characters!";
            }
            
            if (hasAtleast8Characters && !hasAtleastOneDigit && hasAtleastOneUpperCharacter && hasAtleastOneLowerCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "The password should contain atleast one digit!";
            }
            
            if (hasAtleast8Characters && hasAtleastOneDigit && !hasAtleastOneUpperCharacter && hasAtleastOneLowerCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "The password should contain atleast one upper character!";
            }
            
            if (hasAtleast8Characters && hasAtleastOneDigit && hasAtleastOneUpperCharacter && !hasAtleastOneLowerCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "The password should contain atleast one lower character!";
            }
            
            if (hasAtleast8Characters && hasAtleastOneDigit && hasAtleastOneUpperCharacter && hasAtleastOneLowerCharacter && !hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "The password should not contain characters such as '!', '$', '#', '%'!";
            }

            if (!hasAtleast8Characters && !hasAtleastOneDigit && !hasAtleastOneUpperCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "The password is invalid!\n" +
                    "It either contains:\n" +
                    "- Less than 8 characters.\n" +
                    "- No digits.\n" +
                    "- No upper Case letters.\n" +
                    "- No lower case letters.\n" +
                    "- Characters such as '!', '$', '#', '%'!";
            }

            if (hasAtleast8Characters && hasAtleastOneDigit && hasAtleastOneUpperCharacter && hasAtleastOneLowerCharacter && hasNoNonAlphanumericCharacters)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "The password is valid.";
            }

            //Default return statement
            return "The password is invalid!";
        }
    }
}
