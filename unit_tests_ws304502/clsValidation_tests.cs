using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using year3_collaborative_project.classes;

//The only other tests are simple gets/sets or interact with the database.

namespace unit_tests_ws304502
{
    [TestClass]
    public class clsValidateName
    {
        clsValidation objValidation = new clsValidation();
        [TestMethod]
        public void NameValidationCorrectNormal()
        {
            clsValidation objValidation = new clsValidation();

            string _sName = "Jimmy";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void NameValidationCorrectSplit()
        {
            clsValidation objValidation = new clsValidation();

            string _sName = "Jimmy Ymmij";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void NameValidationCorrectAllUpper()
        {
            clsValidation objValidation = new clsValidation();

            string _sName = "JIMMY";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void NameValidationIncorrectAllLower()
        {
            clsValidation objValidation = new clsValidation();

            string _sName = "jimmy";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void NameValidationIncorrectCaseMix()
        {
            clsValidation objValidation = new clsValidation();

            string _sName = "JiMmY";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void NameValidationIncorrectNumbers()
        {
            string _sName = "Jimmy 12";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void NameValidationIncorrectSpecial()
        {
            string _sName = "Jimmy!";
            bool _bValid;

            _bValid = objValidation.ValidateName(_sName);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsOver18Validate
    {
        clsValidation objValidation = new clsValidation();
        [TestMethod]
        public void Over18ValidateCorrectNormal()
        {
            string _sDay = "2";
            string _sMonth = "5";
            string _sYear = "1976";
            bool _bValid;

            _bValid = objValidation.ValidateDate_Over18(_sDay, _sMonth, _sYear);

            Assert.IsTrue(_bValid);
        }
        
        [TestMethod]
        public void Over18ValidateCorrectLongForm()
        {
            string _sDay = "02";
            string _sMonth = "05";
            string _sYear = "1976";
            bool _bValid;

            _bValid = objValidation.ValidateDate_Over18(_sDay, _sMonth, _sYear);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void Over18ValidateIncorrectNormal()
        {
            string _sDay = "2";
            string _sMonth = "5";
            string _sYear = DateTime.Now.Year.ToString();
            bool _bValid;

            _bValid = objValidation.ValidateDate_Over18(_sDay, _sMonth, _sYear);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Over18ValidateIncorrectLongForm()
        {
            string _sDay = "02";
            string _sMonth = "05";
            string _sYear = DateTime.Now.Year.ToString();
            bool _bValid;

            _bValid = objValidation.ValidateDate_Over18(_sDay, _sMonth, _sYear);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsValidateNumber
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidateNumberCorrectShort()
        {
            string _sNumber = "8";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateNumberCorrectThreeDigit()
        {
            string _sNumber = "149";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateNumberCorrectLong()
        {
            string _sNumber = "463845652846";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateNumberIncorrectWords()
        {
            string _sNumber = "Three";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateNumberIncorrectSpace()
        {
            string _sNumber = "123 4";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateNumberIncorrectDecimal()
        {
            string _sNumber = "123.14";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateNumberIncorrectNegative()
        {
            string _sNumber = "-123";
            bool _bValid;

            _bValid = objValidation.ValidateIsNumber(_sNumber);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsValidatePostCode
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidateCorrect33PostCodeUpperSpace()
        {
            string _sPostcode = "SE1 7TP";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect33PostCodeLowerSpace()
        {
            string _sPostcode = "se1 7tp";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect33PostCodeUpperSpaceless()
        {
            string _sPostcode = "SE17TP";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect33PostCodeLowerSpaceless()
        {
            string _sPostcode = "se17tp";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect43PostCodeUpperSpace()
        {
            string _sPostcode = "EH52 5JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect43PostCodeLowerSpace()
        {
            string _sPostcode = "eh52 5je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect43PostCodeUpperSpaceless()
        {
            string _sPostcode = "EH525JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateCorrect43PostCodeLowerSpaceless()
        {
            string _sPostcode = "eh525je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeLetterUpperSpace()
        {
            string _sPostcode = "EHY52 5JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeLetterLowerSpace()
        {
            string _sPostcode = "ehy52 5je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeLetterUpperSpaceless()
        {
            string _sPostcode = "EHY525JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeLetterLowerSpaceless()
        {
            string _sPostcode = "ehy525je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeNumberUpperSpace()
        {
            string _sPostcode = "EH652 5JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeNumberLowerSpace()
        {
            string _sPostcode = "eh652 5je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeNumberUpperSpaceless()
        {
            string _sPostcode = "EH6525JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect53PostCodeNumberLowerSpaceless()
        {
            string _sPostcode = "eh6525je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeLetterUpperSpace()
        {
            string _sPostcode = "EH52 5YJE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeLetterLowerSpace()
        {
            string _sPostcode = "eh52 5yje";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeLetterUpperSpaceless()
        {
            string _sPostcode = "EH525YJE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeLetterLowerSpaceless()
        {
            string _sPostcode = "eh525yje";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeNumberUpperSpace()
        {
            string _sPostcode = "EH52 54JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeNumberLowerSpace()
        {
            string _sPostcode = "eh52 57je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeNumberUpperSpaceless()
        {
            string _sPostcode = "EH5257JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect44PostCodeNumberLowerSpaceless()
        {
            string _sPostcode = "eh5257je";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect23PostCode()
        {
            string _sPostcode = "EH 5JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void Validateincorrect32PostCode()
        {
            string _sPostcode = "EH5 JE";
            bool _bValid;

            _bValid = objValidation.ValidatePostCode(_sPostcode);

            Assert.IsFalse(_bValid);
        }

    }

    [TestClass]
    public class clsValidateDecimal
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidateDecimalCorrectOnePoint()
        {
            string _sNumber = "12.2";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateDecimalCorrectTwoPoint()
        {
            string _sNumber = "14.78";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateDecimalCorrectThreePoint()
        {
            string _sNumber = "14.738";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateDecimalIncorrectWordsSpaceless()
        {
            string _sNumber = "One";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateDecimalIncorrectWordsSpace()
        {
            string _sNumber = "One point seven";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateDecimalIncorrectNumberSpace()
        {
            string _sNumber = "12 .3";
            bool _bValid;

            _bValid = objValidation.ValidateIsDecimal(_sNumber);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsValidatePhonenumber
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidatePhoneNumberCorrect11()
        {
            string _sNumber = "18263546275";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectShort10()
        {
            string _sNumber = "1826354627";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectLong12()
        {
            string _sNumber = "758589348574238942333";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectLetter()
        {
            string _sNumber = "18263546275f";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectSpace()
        {
            string _sNumber = "18263 546275";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectSymbolMid()
        {
            string _sNumber = "1826+3546275";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidatePhoneNumberIncorrectSymbolStart()
        {
            string _sNumber = "+18263546275";
            bool _bValid;

            _bValid = objValidation.ValidatePhone(_sNumber);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsValidateEmail
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidateEmailCorrectStandard()
        {
            string _sEmail = "test@gmail.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectCapitalStandard()
        {
            string _sEmail = "Test@gmail.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectCustomServerLower()
        {
            string _sEmail = "Test@email.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectCustomServerUpper()
        {
            string _sEmail = "Test@Email.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectCustomDomainExtensionLower()
        {
            string _sEmail = "Test@email.gov";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectCustomDomainExtensionUper()
        {
            string _sEmail = "Test@email.Gov";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateEmailCorrectSpecial()
        {
            string _sEmail = "Te_st@gmail.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsTrue(_bValid);
        }

        [TestMethod] 
        public void ValidateEmailIncorrectCustomDomainExtensionLower()
        {
            string _sEmail = "Test@email.email";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateEmailIncorrectCustomDomainExtensionUpper()
        {
            string _sEmail = "Test@email.email";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateEmailIncorrectSpace()
        {
            string _sEmail = "Te st@gmail.com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateEmailIncorrectTwoDots()
        {
            string _sEmail = "Test@gmail..com";
            bool _bValid;

            _bValid = objValidation.ValidateEmail(_sEmail);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsValidationPassword
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void ValidateValidPasswordCorrectStandard()
        {
            string _sPassword = "6ThickThistleSticks!";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsTrue(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordCorrectSpace()
        {
            string _sPassword = "6ThickThist leSticks!";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsTrue(_bValid);
        }
     
        [TestMethod]
        public void ValidateValidPasswordIncorrectAllWrong()
        {
            string _sPassword = "sixthickthistlesticks";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordIncorrectMissingCap()
        {
            string _sPassword = "6thickthistlesticks!";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordIncorrectMissingNumber()
        {
            string _sPassword = "SixThickThistleSticks!";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordIncorrectMissingSymbol()
        {
            string _sPassword = "7ThickThistleSticks";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordIncorrectShort()
        {
            string _sPassword = "6Tt!";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }

        [TestMethod]
        public void ValidateValidPasswordIncorrectShort7()
        {
            string _sPassword = "6iu!daw";
            bool _bValid;

            _bValid = objValidation.ValidatePassword(_sPassword);

            Assert.IsFalse(_bValid);
        }
    }

    [TestClass]
    public class clsCurencyDisplay
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void FormatCurrencyDisplayCorrectStandard()
        {
            string _sExpected = "£400.00";
            string _sPrice = "400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayCorrectComma()
        {
            string _sExpected = "£23,400.00";
            string _sPrice = "23400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayCorrectMultiComma()
        {
            string _sExpected = "£192,727,123,400.00";
            string _sPrice = "192727123400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayCorrectNegativeBeforePound()
        {
            string _sExpected = "-£400.00";
            string _sPrice = "-400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayIncorrectMissingComma()
        {
            string _sExpected = "£23400.00";
            string _sPrice = "23400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreNotEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayIncorrectNegativeAfterPound()
        {
            string _sExpected = "£-400.00";
            string _sPrice = "-400.00";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreNotEqual(_sExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyDisplayIncorrectNoDecimal()
        {
            string _sExpected = "£400";
            string _sPrice = "400";
            string _sReturn;

            _sReturn = objValidation.FormatCurrencyForDisplay(_sPrice);

            Assert.AreNotEqual(_sExpected, _sReturn);
        }
    }

    [TestClass]
    public class clsCurrencyCalculate
    {
        clsValidation objValidation = new clsValidation();

        [TestMethod]
        public void FormatCurrencyCalculateCorrectStandard()
        {
            decimal _dExpected = 400.23m;
            string _sPrice = "£400.23";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreEqual(_dExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyCalculateCorrectComma()
        {
            decimal _dExpected = 23400.23m;
            string _sPrice = "£23,400.23";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreEqual(_dExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyCalculateCorrectMultiComma()
        {
            decimal _dExpected = 234125614.23m;
            string _sPrice = "£234,125,614.23";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreEqual(_dExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyCalculateCorrectNegativeBefore()
        {
            decimal _dExpected = -400.10m;
            string _sPrice = "-£400.10";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreEqual(_dExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyCalculateCorrectNegativeAfter()
        {
            decimal _dExpected = -400.10m;
            string _sPrice = "£-400.10";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreEqual(_dExpected, _sReturn);
        }

        [TestMethod]
        public void FormatCurrencyCalculateIncorrectMissingDecimal()
        {
            decimal _dExpected = 23400m;
            string _sPrice = "£23,400.10";
            decimal _sReturn;

            _sReturn = objValidation.FormatCurrencyForCalculation(_sPrice);

            Assert.AreNotEqual(_dExpected, _sReturn);
        }
    }

    [TestClass]
    public class clsValidation_tests
    {
        //Base class no tests
    }
}
