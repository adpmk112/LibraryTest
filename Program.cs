using System;

namespace Readymade_utils_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing PhoneValidation");

            PhoneValidation phoneValidation = new PhoneValidation();

            string phone = "09262634123";
            string countryCode = "MM"; 

            phoneValidation.validate(phone, countryCode);

            Console.WriteLine("-----------------------------");

            string photoName = "animePhoto.png";

            DateTimeFormat dateTimeFormat = new DateTimeFormat();
            Console.WriteLine("Added DateTime In Photo");
            Console.WriteLine(dateTimeFormat.addTimeInPhoto(photoName));

        }
    }
}
