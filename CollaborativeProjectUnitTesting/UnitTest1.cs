using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using MySql.Data;
using year3_collaborative_project.classes;


namespace CollaborativeProjectUnitTesting
{
    using BCrypt = BCrypt.Net.BCrypt;

    [TestClass]

    public class EncryptionTest
    {

        [TestMethod]

        public void TestEncryption()
        {

            clsEncryption objEncryption = new clsEncryption();

            string sPassword = "Password123!";
            string sEncrypted = objEncryption.EncryptPassword(sPassword);

            Assert.IsTrue(BCrypt.Verify(sPassword, sEncrypted));
        }
    
    }

    [TestClass]
    public class Decimaltests
    {
        clsValidation clsValidate = new clsValidation();

        // Accepts numbers only, no letters, special characters or spaces

        [TestMethod]
        public void TestNotADecimal()
        {
            string notADecmial = "something";
            bool isADecimal = clsValidate.ValidateIsDecimal(notADecmial);

            Assert.IsFalse(isADecimal);
        }

        [TestMethod]
        public void TestADecimal()
        {
            string aDecimal = "56.00";
            bool isADecimal = clsValidate.ValidateIsDecimal(aDecimal);

            Assert.IsTrue(isADecimal);
        }

        [TestMethod]
        public void TestHalfDecimal()
        {
            string aDecimal = "56.ab";
            bool isADecimal = clsValidate.ValidateIsDecimal(aDecimal);

            Assert.IsFalse(isADecimal);
        }
        [TestMethod]
        public void TestHalfDecimal1()
        {
            string aDecimal = "ab.00";
            bool isADecimal = clsValidate.ValidateIsDecimal(aDecimal);

            Assert.IsFalse(isADecimal);
        }

        [TestClass]
        public class PhoneNoTests
        {
            clsValidation clsValidate = new clsValidation();

            // Must be 11 digits long, no spaces, no letters, no special characters

            [TestMethod]
            public void testPhoneAgainstDecimal()
            {
                string aDecimal = "00.33";
                bool isADecimal = clsValidate.ValidatePhone(aDecimal);

                Assert.IsFalse(isADecimal);
            }

            [TestMethod]
            public void testPhoneAgainstString()
            {
                string sAString = "alan";
                bool bIsAString = clsValidate.ValidatePhone(sAString);

                Assert.IsFalse(bIsAString);
            }

            [TestMethod]
            public void testPhoneLength()
            {
                string sIsTenLong = "0193465858";
                bool bTenLong = clsValidate.ValidatePhone(sIsTenLong);

                Assert.IsFalse(bTenLong);
            }

            //Length tests not currently working - need to change validation code for phone numbers
            [TestMethod]
            public void testPhoneLength1()
            {
                string sIsTwelveLong = "019346585834";
                bool bIsTwelveLong = clsValidate.ValidatePhone(sIsTwelveLong);

                Assert.IsFalse(bIsTwelveLong);
            }

            [TestMethod]
            public void testPhoneLength2()
            {
                string sIsThirteenLong = "0193465858342";
                bool bIsThirteenLong = clsValidate.ValidatePhone(sIsThirteenLong);

                Assert.IsFalse(bIsThirteenLong);
            }

            [TestMethod]
            public void testCorrectPhoneLength()
            {
                string sIsElevenLong = "01934658583";
                bool bIsElevenLong = clsValidate.ValidatePhone(sIsElevenLong);

                Assert.IsTrue(bIsElevenLong);
            }

            [TestMethod]
            public void testMixedInput()
            {
                string sIsMixedInput = "a19b4658c83";
                bool bIsMixedInput = clsValidate.ValidatePhone(sIsMixedInput);

                Assert.IsFalse(bIsMixedInput);
            }

            [TestMethod]
            public void testSpaceInMiddle()
            {
                string sSpaceInMiddle = "01934 456456";
                bool bSpaceInMiddle = clsValidate.ValidatePhone(sSpaceInMiddle);

                Assert.IsFalse(bSpaceInMiddle);
            }

            [TestMethod]
            public void testSpaceAtEnd()
            {
                string sSpaceAtEnd = "01934456456 ";
                bool bSpaceAtEnd = clsValidate.ValidatePhone(sSpaceAtEnd);

                Assert.IsFalse(bSpaceAtEnd);
            }

        }

        [TestClass]
        public class EmailTests
        {
            clsValidation clsValidate = new clsValidation();

            // Cannot have spaces and must have a correct suffix, can contain letters, numbers and special characters

            [TestMethod]
            public void testMixedInput()
            {
                string sMixedInput = "aburnell78@alan.com";
                bool bMixedInput = clsValidate.ValidateEmail(sMixedInput);

                Assert.IsTrue(bMixedInput);
            }

            [TestMethod]
            public void testSpaceInMiddle()
            {
                string sSpaceInMiddle = "aburnell78 @alan.com";
                bool bSpaceInMiddle = clsValidate.ValidateEmail(sSpaceInMiddle);

                Assert.IsFalse(bSpaceInMiddle);
            }

            [TestMethod]
            public void testNoSuffix()
            {
                string sNoSuffix = "aburnell78@alan";
                bool bNoSuffix = clsValidate.ValidateEmail(sNoSuffix);

                Assert.IsFalse(bNoSuffix);
            }
        }

        [TestClass]
        public class NameTests

        // Must start with a capital but rest can all be capital or mixture of capital and lowercase, cannot contain any numbere or special characters or spaces
        {
            clsValidation clsValidate = new clsValidation();

            [TestMethod]
            public void testAllCapital()
            {
                string sAllCapital = "ALAN";
                bool bAllCapital = clsValidate.ValidateName(sAllCapital);

                Assert.IsTrue(bAllCapital);
            }

            [TestMethod]
            public void testSomeCapital()
            {
                string sSomeCapital = "ALan";
                bool bSomeCapital = clsValidate.ValidateName(sSomeCapital);

                Assert.IsTrue(bSomeCapital);
            }

            [TestMethod]
            public void testSomeCapital1()
            {
                string sSomeCapital = "AlAn";
                bool bSomeCapital = clsValidate.ValidateName(sSomeCapital);

                Assert.IsTrue(bSomeCapital);
            }

            [TestMethod]
            public void testMixedInput()
            {
                string sMixedInput = "al3n";
                bool bMixedInput = clsValidate.ValidateName(sMixedInput);

                Assert.IsFalse(bMixedInput);
            }

            [TestMethod]
            public void testSpaceAtEnd()
            {
                string sSpaceAtEnd = "alan ";
                bool bSpaceAtEnd = clsValidate.ValidateName(sSpaceAtEnd);

                Assert.IsFalse(bSpaceAtEnd);
            }

            [TestMethod]
            public void testSpaceInMiddle()
            {
                string sSpaceInMiddle = "al an";
                bool bSpaceInMiddle = clsValidate.ValidateName(sSpaceInMiddle);

                Assert.IsFalse(bSpaceInMiddle);
            }


            [TestMethod]
            public void testCorrectInput()
            {
                string sCorrectInput = "Alan";
                bool bCorrectInput = clsValidate.ValidateName(sCorrectInput);

                Assert.IsTrue(bCorrectInput);
            }

            [TestMethod]
            public void testWithoutCapital()
            {
                string sWithoutCapital = "alan";
                bool bWithoutCapital = clsValidate.ValidateName(sWithoutCapital);

                Assert.IsFalse(bWithoutCapital);
            }
        }
        [TestClass]
        public class Over18Tests
        {
            clsValidation clsValidate = new clsValidation();

            // User entry can only be numerical so only need to test against age

            [TestMethod]
            public void testUnder18()
            {
                string sDay = "02";
                string sMonth = "07";
                string sYear = "2010";
                bool bUnder18 = clsValidate.ValidateDate_Over18(sDay, sMonth, sYear);

                Assert.IsFalse(bUnder18);
            }

            [TestMethod]
            public void testOver18()
            {
                string sDay = "02";
                string sMonth = "07";
                string sYear = "1990";
                bool bOver18 = clsValidate.ValidateDate_Over18(sDay, sMonth, sYear);

                Assert.IsTrue(bOver18);
            }

        }

        [TestClass]
        public class NumberTests
        {
            clsValidation clsValidate = new clsValidation();

            // Must be a number with no spaces, no letters, no characters

            [TestMethod]
            public void testWithLetters()
            {
                string sNumber = "alan";
                bool bWithLetters = clsValidate.ValidateIsNumber(sNumber);

                Assert.IsFalse(bWithLetters);
            }

            [TestMethod]
            public void testMixedInput()
            {
                string sNumber = "al45";
                bool bMixedInput = clsValidate.ValidateIsNumber(sNumber);

                Assert.IsFalse(bMixedInput);
            }

            [TestMethod]
            public void testWithSpace()
            {
                string sNumber = "4 5";
                bool bWithSpace = clsValidate.ValidateIsNumber(sNumber);

                Assert.IsFalse(bWithSpace);
            }
        }

        [TestClass]
        public class UserNameTests

        // Username can contain - or _ but no other special characters, must be less than 24 character and cannot end with - or _
        {
            clsValidation clsValidate = new clsValidation();


            [TestMethod]
            public void testEndsWithSpecial()
            {
                string sEndsInSpecial = "alan-";
                bool bEndsInSpecial = clsValidate.ValidateUsername(sEndsInSpecial);

                Assert.IsFalse(bEndsInSpecial);
            }

            [TestMethod]
            public void testLongerThan24Characters()
            {
                string sLongerThan24 = "alansdssaddalanalanalanalanb";
                bool bLongerThan24 = clsValidate.ValidateUsername(sLongerThan24);

                Assert.IsFalse(bLongerThan24);
            }

            [TestMethod]
            public void testUnacceptableCharacters()
            {
                string sIncorrectEntry = "alanala@nalanalanal";
                bool bIncorrectEntry = clsValidate.ValidateUsername(sIncorrectEntry);

                Assert.IsFalse(bIncorrectEntry);
            }

            [TestMethod]
            public void testCorrectEntry()
            {
                string sCorrectEntry = "alanala-na_lanalanal";
                bool bCorrectEntry = clsValidate.ValidateUsername(sCorrectEntry);

                Assert.IsTrue(bCorrectEntry);
            }

        }

        [TestClass]
        public class PasswordTests

        // Password must contain a capital letter, a lowercase letter, a symbol, a number and be longer than 8 characters
        {
            clsValidation clsValidate = new clsValidation();

            [TestMethod]
            public void testCorrectEntry()
            {
                string sCorrectEntry = "Alanalana@lanalana1";
                bool bCorrectEntry = clsValidate.ValidatePassword(sCorrectEntry);

                Assert.IsTrue(bCorrectEntry);
            }

            [TestMethod]
            public void testLessThanEightCharacters()
            {
                string sLessThanEight = "A@la1";
                bool bLessThanEight = clsValidate.ValidatePassword(sLessThanEight);

                Assert.IsFalse(bLessThanEight);
            }

            [TestMethod]
            public void testNoNumber()
            {
                string sNoNumber = "A@lamanda";
                bool bNoNumber = clsValidate.ValidatePassword(sNoNumber);

                Assert.IsFalse(bNoNumber);
            }

            [TestMethod]
            public void testNoCapital()
            {
                string sNoCapital = "a@lamanda1";
                bool bNoCapital = clsValidate.ValidatePassword(sNoCapital);

                Assert.IsFalse(bNoCapital);
            }

            [TestMethod]
            public void testNoLowercase()
            {
                string sNoLowercase = "A@EIGHTYG1";
                bool bNoLowercase = clsValidate.ValidatePassword(sNoLowercase);

                Assert.IsFalse(bNoLowercase);
            }

            [TestMethod]
            public void testSpecial()
            {
                string sNoSpecial = "AEIGHTYGaer1";
                bool bNoSpecial = clsValidate.ValidatePassword(sNoSpecial);

                Assert.IsFalse(bNoSpecial);
            }
        }

        [TestClass]
        public class PostcodeTests

        // Postcode can be 4-3 or 3-3 format, start with at least 1 letter and end with 2 letters can have a space before the last 3 characters, no special characters accepted
        {
            clsValidation clsValidate = new clsValidation();

            [TestMethod]
            public void testNoLetterAtStart()
            {
                string sNoLetter = "123 4gy";
                bool bNoLetter = clsValidate.ValidatePostCode(sNoLetter);

                Assert.IsFalse(bNoLetter);
            }

            [TestMethod]
            public void testTooManySpaces()
            {
                string sTooManySpaces = "bs23   3xg";
                bool bTooManySpaces = clsValidate.ValidatePostCode(sTooManySpaces);

                Assert.IsFalse(bTooManySpaces);
            }

            [TestMethod]
            public void testSpecialCharacters()
            {
                string sSpecialCharacters = "bs23-3xg";
                bool bSpecialCharacters = clsValidate.ValidatePostCode(sSpecialCharacters);

                Assert.IsFalse(bSpecialCharacters);
            }

            [TestMethod]
            public void testNoLetterAtEnd()
            {
                string sNoLetterAtEnd = "bs23 434";
                bool bNoLetterAtEnd = clsValidate.ValidatePostCode(sNoLetterAtEnd);

                Assert.IsFalse(bNoLetterAtEnd);
            }

            [TestMethod]
            public void testCorrectFourThree()
            {
                string sCorrectFourThree = "bs23 4gh";
                bool bCorrectFourThree = clsValidate.ValidatePostCode(sCorrectFourThree);

                Assert.IsTrue(bCorrectFourThree);
            }

            [TestMethod]
            public void testCorrectThreeThree()
            {
                string sCorrectThreeThree = "b23 4gh";
                bool bCorrectThreeThree = clsValidate.ValidatePostCode(sCorrectThreeThree);

                Assert.IsTrue(bCorrectThreeThree);
            }

            [TestMethod]
            public void testCapitalAndLowercase()
            {
                string sCapitalAndLowercase = "B23 4gh";
                bool bCapitalAndLowercase = clsValidate.ValidatePostCode(sCapitalAndLowercase);

                Assert.IsTrue(bCapitalAndLowercase);
            }

            [TestMethod]
            public void testNoSpace()
            {
                string sNoSpace = "B234gh";
                bool bNoSpace = clsValidate.ValidatePostCode(sNoSpace);

                Assert.IsTrue(bNoSpace);
            }

            [TestMethod]
            public void testAllLower()
            {
                string sAllLower = "b234gh";
                bool bAllLower = clsValidate.ValidatePostCode(sAllLower);

                Assert.IsTrue(bAllLower);
            }

            [TestMethod]
            public void testAllCapital()
            {
                string sAllCapital = "B234gh";
                bool bAllCapital = clsValidate.ValidatePostCode(sAllCapital);

                Assert.IsTrue(bAllCapital);
            }
        }

        

             
        
    }
}
