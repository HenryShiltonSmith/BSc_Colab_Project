using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using year3_collaborative_project.classes;

namespace UnitTestProject1
{
    [TestClass]
    public class UserAccountTests
    {
        
        [TestMethod]
        public void Username_ID()
        {

            //Username ID returns correctly

            string sInput = "User1";
            string sExpected = "1";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            Assert.AreEqual(sExpected, clsUsers.GetUserID_String(sInput));

        }

        [TestMethod]
        public void Customer_ID_From_ID()
        {

            //Customer ID returns correctly

            string sInput = "1";
            string sExpected = "5";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            Assert.AreEqual(sExpected, clsUsers.GetCutomerID(sInput));

        }

        [TestMethod]
        public void Customer_All()
        {

            //Returns all customers correctly

            int iInput = 0;
            string[,] sExpected = new string[1,6];

            sExpected[0, 0] = "Alan";
            sExpected[0, 1] = "Burnell";
            sExpected[0, 2] = "User1";
            sExpected[0, 3] = "1";
            sExpected[0, 4] = "5";
            sExpected[0, 5] = "1";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[,] sTestArray = clsUsers.GetUsers(iInput);

            Assert.AreEqual(sExpected[0,0], sTestArray[0,0]);
            Assert.AreEqual(sExpected[0, 1], sTestArray[0, 1]);
            Assert.AreEqual(sExpected[0, 2], sTestArray[0, 2]);
            Assert.AreEqual(sExpected[0, 3], sTestArray[0, 3]);
            Assert.AreEqual(sExpected[0, 4], sTestArray[0, 4]);
            Assert.AreEqual(sExpected[0, 5], sTestArray[0, 5]);
        }

        [TestMethod]
        public void Admin_All()
        {

            //Returns all admins correctly

            int iInput = 1;
            string[,] sExpected = new string[1, 6];

            sExpected[0, 0] = "Rep";
            sExpected[0, 1] = "One";
            sExpected[0, 2] = "Rep1";
            sExpected[0, 3] = "4";
            sExpected[0, 4] = "1";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[,] sTestArray = clsUsers.GetUsers(iInput);

            Assert.AreEqual(sExpected[0, 0], sTestArray[0, 0]);
            Assert.AreEqual(sExpected[0, 1], sTestArray[0, 1]);
            Assert.AreEqual(sExpected[0, 2], sTestArray[0, 2]);
            Assert.AreEqual(sExpected[0, 3], sTestArray[0, 3]);
            Assert.AreEqual(sExpected[0, 4], sTestArray[0, 4]);
        }

        [TestMethod]
        public void Login_Check()
        {

            //Returns login details correctly

            int iInput = 7;
            string[] sExpected = new string[2];

            sExpected[0] = "Admin1";
            sExpected[1] = "$2a$10$xeVH0zAKLrYnSFiLPTleDeQESQffQcd/uxm5mFGo/3Fmhszj9zpqG";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[] sTestArray = clsUsers.GetLoginDetails(iInput);

            Assert.AreEqual(sExpected[0], sTestArray[0]);
            Assert.AreEqual(sExpected[1], sTestArray[1]);
        }

        [TestMethod]
        public void User_Details_Customer()
        {

            //Returns customer details correctly

            int iInput = 5;
            int iType = 0;
            string[] sExpected = new string[4];

            sExpected[0] = "Alan";
            sExpected[1] = "Burnell";
            sExpected[2] = "ws1318@weston.ac.uk";
            sExpected[3] = "08587565478";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[] sTestArray = clsUsers.GetUserDetails(iInput, iType);

            Assert.AreEqual(sExpected[0], sTestArray[0]);
            Assert.AreEqual(sExpected[1], sTestArray[1]);
            Assert.AreEqual(sExpected[2], sTestArray[2]);
            Assert.AreEqual(sExpected[3], sTestArray[3]);
        }

        [TestMethod]
        public void User_Details_Admin()
        {

            //Returns admin details correctly

            int iInput = 4;
            int iType = 2;
            string[] sExpected = new string[4];

            sExpected[0] = "Admin";
            sExpected[1] = "One";
            sExpected[2] = "a1@admin.co.uk";
            sExpected[3] = "03215479657";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[] sTestArray = clsUsers.GetUserDetails(iInput, iType);

            Assert.AreEqual(sExpected[0], sTestArray[0]);
            Assert.AreEqual(sExpected[1], sTestArray[1]);
            Assert.AreEqual(sExpected[2], sTestArray[2]);
            Assert.AreEqual(sExpected[3], sTestArray[3]);
        }

        [TestMethod]
        public void Address_Details()
        {

            //Returns address details correctly

            int iInput = 1;
            string[] sExpected = new string[4];

            sExpected[0] = "31";
            sExpected[1] = "Arundell Road";
            sExpected[2] = "Weston super Mare";
            sExpected[3] = "BS232QG";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            string[] sTestArray = clsUsers.GetAddress(iInput);

            Assert.AreEqual(sExpected[0], sTestArray[0]);
            Assert.AreEqual(sExpected[1], sTestArray[1]);
            Assert.AreEqual(sExpected[2], sTestArray[2]);
            Assert.AreEqual(sExpected[3], sTestArray[3]);
        }

        [TestMethod]
        public void DateOfBirth()
        {

            //Returns date of birth correctly

            int iInput = 5;
            string sExpected = "02/07/1978 00:00:00";

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            Assert.AreEqual(sExpected, clsUsers.GetDoB(iInput));
        }

    }

    [TestClass]

    public class ValidationNameTests
    {

        [TestMethod]
        public void NameTest_IsValid()
        {

            //Check the name entered is structured as a name, must have a Captial letter and lacks unwanted symbols or numerics

            string sInput = "Sam";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_IsValid_ValidSymbol()
        {

            //Check the name entered is structured as a name, must have a Captial letter and second name with dash

            string sInput = "Sam-Ted";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_IsValid_TwoPartName()
        {

            //Check the name entered is structured as a name, must have a Captial letter and also has second part

            string sInput = "Sam Ted";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_NoCap()
        {

            //Check the name entered is not correct, returns false with user enters name without capital

            string sInput = "sam";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_Number()
        {

            //Check the name entered is not correct, returns false with user enters name as a number

            string sInput = "12345";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_FalseSymbol1()
        {

            //Check the name entered is not correct, returns false with user enters name with unwanted symbol

            string sInput = "Sam%";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_FalseSymbol2()
        {

            //Check the name entered is not correct, returns false with user enters name with unwanted symbol

            string sInput = "Sam!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_FalseSymbol3()
        {

            //Check the name entered is not correct, returns false with user enters name with unwanted symbol

            string sInput = "Sam(";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_FalseSymbol4()
        {

            //Check the name entered is not correct, returns false with user enters name with unwanted symbol

            string sInput = "Sam*";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

        [TestMethod]
        public void NameTest_NotValid_FalseSymbol5()
        {

            //Check the name entered is not correct, returns false with user enters name with unwanted symbol

            string sInput = "Sam&";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateName(sInput));

        }

    }

    [TestClass]

    public class ValidationDoBTests
    {

        [TestMethod]
        public void DoBTest_IsValid()
        {

            //Check date of birth is valid, a real date and result will be a user 18 or older

            string sInputDay = "02";
            string sInputMonth = "02";
            string sInputYear = "1994";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_Not18_SameYear()
        {

            //Check date of birth is not valid, not 18 for couple months

            string sInputDay = "02";
            string sInputMonth = "10";
            string sInputYear = "2005";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_Not18_ThisYear()
        {

            //Check date of birth is not valid, enters current year

            string sInputDay = "01";
            string sInputMonth = "04";
            string sInputYear = "2021";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_Feb30()
        {

            //Check date of birth is not valid, enters wrong day for shorter month

            string sInputDay = "30";
            string sInputMonth = "02";
            string sInputYear = "2000";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_April31()
        {

            //Check date of birth is not valid, enters wrong day for shorter month

            string sInputDay = "31";
            string sInputMonth = "04";
            string sInputYear = "2000";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_June31()
        {

            //Check date of birth is not valid, enters wrong day for shorter month

            string sInputDay = "31";
            string sInputMonth = "06";
            string sInputYear = "2000";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_September31()
        {

            //Check date of birth is not valid, enters wrong day for shorter month

            string sInputDay = "31";
            string sInputMonth = "09";
            string sInputYear = "2000";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

        [TestMethod]
        public void DoBTest_NotValid_November31()
        {

            //Check date of birth is not valid, enters wrong day for shorter month

            string sInputDay = "31";
            string sInputMonth = "11";
            string sInputYear = "2000";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateDate_Over18(sInputDay, sInputMonth, sInputYear));

        }

    }

    [TestClass]

    public class ValidationNumbers
    {

        [TestMethod]
        public void Number_IsValid()
        {

            //Check number is valid, not a decimal, no characters, no spaces

            string sInput = "2";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsNumber(sInput));

        }

        [TestMethod]
        public void Number_NotValid_Decimal()
        {

            //Check number is not valid, contains decimal point

            string sInput = "2.2";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsNumber(sInput));

        }

        [TestMethod]
        public void Number_NotValid_Character()
        {

            //Check number not valid, contains character

            string sInput = "asd";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsNumber(sInput));

        }

        [TestMethod]
        public void Number_NotValid_Space()
        {

            //Check number not valid, contains space

            string sInput = "    2";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsNumber(sInput));

        }

        [TestMethod]
        public void Decimal_IsValid()
        {

            //Check decmila is valid, no characters, no spaces

            string sInput = "2.2";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsDecimal(sInput));

        }

        [TestMethod]
        public void Decimal_NotValid_Character()
        {

            //Check number not valid, contains character

            string sInput = "asd";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateIsDecimal(sInput));

        }

    }

    [TestClass]

    public class ValidationPhone
    {

        [TestMethod]
        public void Phone_IsValid()
        {

            //Check phone is valid, just contain 11 digits, no characters, no spaces

            string sInput = "08001234567";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_1LessDigit()
        {

            //Check phone is not valid, contains 10 digits

            string sInput = "0800123456";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_1Digit()
        {

            //Check phone is not valid, contains 1 digits

            string sInput = "7";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_1MoreDigit()
        {

            //Check phone is not valid, contains 12 digits

            string sInput = "080012345691";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_10MoreDigits()
        {

            //Check phone is not valid, contains 21 digits

            string sInput = "080012345601234567891231231312";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_Character()
        {

            //Check phone is not valid, contains "A"

            string sInput = "080012345A";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_Spaces()
        {

            //Check phone is not valid, contains spaces

            string sInput = "0800   123456";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePhone(sInput));

        }

    }

    [TestClass]

    public class ValidationEmail
    {

        [TestMethod]
        public void Email_IsValid()
        {

            //Check email is valid, contains characters followed by "@" symbol, followed by "." followed by acceptable extention

            string sInput = "ws0000@weston.ac.uk";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateEmail(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_Symbol()
        {

            //Check email not valid, lacking "@" symbol

            string sInput = "ws0000weston.ac.uk";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateEmail(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_Stop()
        {

            //Check email not valid, lacking "." symbol

            string sInput = "ws0000@westonacuk";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateEmail(sInput));

        }

        [TestMethod]
        public void Phone_NotValid_Extention()
        {

            //Check email not valid, lacking "@" symbol

            string sInput = "ws0000weston.yyy";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateEmail(sInput));

        }

    }

    [TestClass]

    public class ValidationUsername
    {

        [TestMethod]
        public void Username_IsValid()
        {

            //Check username is valid, contains characters or symbols but cannot end with a symbol or be greater than 24 characters. The Username cannot already exist in the database

            string sInput = "User-21";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_IsValid_Length23()
        {

            //Check username is valid, 23 characters

            string sInput = "User1234567891234567890";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_IsValid_Length24()
        {

            //Check username is valid, 24 characters

            string sInput = "User12345678912345678901";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_NotValid_Symbol()
        {

            //Check username not valid, symbol at the end

            string sInput = "User21-";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_NotValid_Length25()
        {

            //Check username is valid, 25 characters

            string sInput = "User123456789123456789012";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_NotValid_Length50()
        {

            //Check username is valid, 50 characters

            string sInput = "User123456789123456789012User123456789123456789012";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

        [TestMethod]
        public void Username_NotValid_Exists()
        {

            //Check username not valid, username already exisits

            string sInput = "User1";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidateUsername(sInput));

        }

    }

    [TestClass]

    public class ValidationPassword
    {

        [TestMethod]
        public void Password_IsValid()
        {

            //Check password is valid, contains characters or symbols. MUST contain 1 capital, 1 lowercase, 1 symbol, 1 number and no less than 8 characters

            string sInput = "Password1!";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_IsValid_Length8()
        {

            //Check password is valid, 8 characters

            string sInput = "Ab12345!";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Length7()
        {

            //Check password not valid, 7 characters

            string sInput = "Ab1345!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Length4()
        {

            //Check password not valid, 4 characters

            string sInput = "Ab1!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Lowercase()
        {

            //Check password not valid, missing lowercase

            string sInput = "PASSWORD1!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Capital()
        {

            //Check password not valid, missing capital

            string sInput = "password1!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Number()
        {

            //Check password not valid, missing number

            string sInput = "Passwords!";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

        [TestMethod]
        public void Password_NotValid_Symbol()
        {

            //Check password not valid, missing symbol

            string sInput = "Passwords1";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePassword(sInput));

        }

    }

    [TestClass]

    public class ValidationPostCode
    {

        [TestMethod]
        public void PostCode_IsValid()
        {

            //Check postcode is valid, contains characters and numbers in the following format: 2letters 2numbers 1number 2letters

            string sInput = "BS26 1EE";
            bool bExpected = true;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_1MissingLetter()
        {

            //Check postcode not valid, wrong format: 1letters 2numbers 1number 2letters

            string sInput = "B23 1EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_2MissingLetter()
        {

            //Check postcode not valid, wrong format: 0letters 2numbers 1number 2letters

            string sInput = "23 1EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_1MissingNumber()
        {

            //Check postcode not valid, wrong format: 2letters 1numbers 1number 2letters

            string sInput = "BS3 1EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_2MissingNumber()
        {

            //Check postcode not valid, wrong format: 2letters 0numbers 1number 2letters

            string sInput = "BS 1EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_LastMissingNumber()
        {

            //Check postcode not valid, wrong format: 0letters 2numbers 0number 2letters

            string sInput = "BS23 EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_LastMissingLetter1()
        {

            //Check postcode not valid, wrong format: 0letters 2numbers 1number 1letters

            string sInput = "BS23 1Q";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_LastMissingLetter2()
        {

            //Check postcode not valid, wrong format: 0letters 2numbers 1number 0letters

            string sInput = "BS23 1";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_Order1()
        {

            //Check postcode not valid, mixed first section

            string sInput = "B2S3 1EQ";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_Order2()
        {

            //Check postcode not valid, mixed first section

            string sInput = "BS23 E1Q";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

        [TestMethod]
        public void PostCode_NotValid_Order3()
        {

            //Check postcode not valid, mixed first section

            string sInput = "2BS3 EQ1";
            bool bExpected = false;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(bExpected, clsValidate.ValidatePostCode(sInput));

        }

    }

    [TestClass]

    public class ConvertCurrency
    {

        [TestMethod]
        public void CurrencyForDisplay_Test_WholeNumber()
        {

            //Check currency converts correctly

            string sInput = "1000";
            string sExpected = "£1,000.00";

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(sExpected, clsValidate.FormatCurrencyForDisplay(sInput));

        }

        [TestMethod]
        public void CurrencyForDisplay_Test_DecimalNumber()
        {

            //Check currency converts correctly

            string sInput = "1000.39";
            string sExpected = "£1,000.39";

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(sExpected, clsValidate.FormatCurrencyForDisplay(sInput));

        }

        [TestMethod]
        public void CurrencyForCalculation_Test_WholeNumber()
        {

            //Check currency converts correctly

            string sInput = "£1,000.00";
            decimal dExpected = 1000;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(dExpected, clsValidate.FormatCurrencyForCalculation(sInput));

        }

        [TestMethod]
        public void CurrencyForCalculation_Test_Decimal()
        {

            //Check currency converts correctly

            string sInput = "£1,000.39";
            decimal dExpected = 1000.39m;

            clsValidation clsValidate = new clsValidation();

            Assert.AreEqual(dExpected, clsValidate.FormatCurrencyForCalculation(sInput));

        }

    }

}
