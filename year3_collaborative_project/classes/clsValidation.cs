using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("unit_tests_ws304502")]
[assembly: InternalsVisibleTo("CollaborativeProjectUnitTesting")]
namespace year3_collaborative_project.classes
{
    class clsValidation
    {


        static bool bIsValid = false;
        public bool ValidateName(string sName)
        {

            if (Regex.Match(sName, "[A-Z][a-zA-Z]*$").Success)
            {

                bIsValid = true;

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public bool ValidateDate_Over18(string sDay, string sMonth, string sYear)
        {

            int iDay = int.Parse(sDay);
            int iMonth = int.Parse(sMonth);
            int iYear = int.Parse(sYear);

            if (iYear > (DateTime.Now.Year - 18))
            {

                bIsValid = false;

            }
            else
            {

                if (iMonth == 2 && iDay > 28)
                {

                    bIsValid = false;

                }
                else if ((iMonth == 4 || iMonth == 6 || iMonth == 9 || iMonth == 11) && iDay > 30)
                {

                    bIsValid = false;

                }
                else
                {

                    bIsValid = true;

                }

            }

            return bIsValid;

        }

        public bool ValidateIsNumber(string sNumber)
        {

            return sNumber.All(char.IsDigit);

        }

        public bool ValidateIsDecimal(string sNumber)
        {

            decimal dHolder;

            return Decimal.TryParse(sNumber, out dHolder);

        }

        public bool ValidatePhone(string sPhone)
        {

            if (Regex.Match(sPhone, @"^\d{11}$").Success)
            {

                bIsValid = true;

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public bool ValidateEmail(string sEmail)
        {

            if (Regex.Match(sEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {

                bIsValid = true;

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public bool ValidateUsername(string sUsername)
        {

            if (Regex.Match(sUsername, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$").Success)
            {

                string sNameExists;
                clsDatabase_Users clsDatabase = new clsDatabase_Users();

                sNameExists = clsDatabase.GetUsername(sUsername);

                if (sNameExists == "")
                {

                    bIsValid = true;

                }
                else
                {

                    bIsValid = false;

                }

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public bool ValidatePassword(string sPassword)
        {

            if (Regex.Match(sPassword, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$").Success)
            {

                bIsValid = true;

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public bool ValidatePostCode(string sPostCode)
        {

            if (Regex.Match(sPostCode, @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$").Success)
            {

                bIsValid = true;

            }
            else
            {

                bIsValid = false;

            }

            return bIsValid;

        }

        public string FormatCurrencyForDisplay(string sValue)
        {

            string sFormatted;

            decimal dTemp = decimal.Parse(sValue);
            sFormatted = dTemp.ToString("C");

            return sFormatted;

        }

        public decimal FormatCurrencyForCalculation(string sValue)
        {

            decimal dFormatted;

            dFormatted = decimal.Parse(sValue, System.Globalization.NumberStyles.Currency);

            return dFormatted;

        }

    }
}
