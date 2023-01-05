using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Readymade_utils_test
{
    public class PhoneValidation // testing libphonenumber-csharp library
    {
        public void validate(string phone, string countryCode)
        {
            if (phone == null)
            {
                phone = "";
                goto skip;
            }

            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            PhoneNumbers.PhoneNumber phoneNumber = phoneUtil.Parse(phone, countryCode);
            bool isValidPhone = phoneUtil.IsValidNumber(phoneNumber);

            if (!isValidPhone)
            {
                Console.WriteLine("Fail Validation");
                return;
            }
            else
            {
                Console.WriteLine("Pass Validation");
                return;
            }

        skip:
            Console.WriteLine("Phone number is null");
        }
    }
}
