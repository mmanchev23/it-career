using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Validator_MVC.Models;

namespace Password_Validator_MVC_Tests
{
    [TestFixture]
    public class PasswordsTests
    {
        [Test]
        public void TestIfPasswordContainsAtleast8Characters()
        {
            Password password = new Password("AbCdEf1");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password should contain atleast 8 characters!");
        }

        [Test]
        public void TestIfPasswordContainsAtleastOneDigit()
        {
            Password password = new Password("aBcDeFgH");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password should contain atleast one digit!");
        }

        [Test]
        public void TestIfPasswordContainsAtleastOneUpperCharacter()
        {
            Password password = new Password("abcdefg1");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password should contain atleast one upper character!");
        }

        [Test]
        public void TestIfPasswordContainsAtleastOneLowerCharacter()
        {
            Password password = new Password("ABCDEFG1");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password should contain atleast one lower character!");
        }

        [Test]
        public void TestIfPasswordContainsNonAlphanumericCharacters()
        {
            Password password = new Password("aBc1!$#%");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password should not contain characters such as '!', '$', '#', '%'!");
        }

        [Test]
        public void TestIfPasswordIsInvalid()
        {
            Password password = new Password("abcdefg");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password is invalid!\n" +
                    "It either contains:\n" +
                    "- Less than 8 characters.\n" +
                    "- No digits.\n" +
                    "- No upper Case letters.\n" +
                    "- No lower case letters.\n" +
                    "- Characters such as '!', '$', '#', '%'!");
        }

        [Test]
        public void TestIfPasswordIsValid()
        {
            Password password = new Password("Ab1Cd2Ef3");

            string output = password.CheckPassword();

            Assert.AreEqual(output, "The password is valid.");
        }
    }
}
