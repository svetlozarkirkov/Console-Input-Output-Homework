using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhoneNum = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFaxNum = Console.ReadLine();
            Console.Write("Website: ");
            string companyWebsite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhoneNum = Console.ReadLine();

            Console.WriteLine(new string('=',30));
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWebsite: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
                companyName,companyAddress,companyPhoneNum,companyFaxNum,companyWebsite,managerFirstName,
                managerLastName,managerAge,managerPhoneNum);
            Console.WriteLine(new string('=', 30));
        }
    }
}
