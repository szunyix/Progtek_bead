using System;
using Vatera.Interface;
using Vatera.Class;
using Vatera.Decorator;
using Vatera.Storage;


namespace Vatera
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser exampleUser = new User();
            exampleUser.CreateUser();

            MemberUserDecorator member = new MemberUserDecorator(exampleUser);
            member.CreateUser(); //Seres P

            //string a = member.fullName;
            //string b = exampleUser.fu

            
            TheStorage asd = TheStorage.GetInstance();
            TheStorage asd2 = TheStorage.GetInstance();
            if (asd == asd2)
            {
                Console.WriteLine("A kettő ugyan az");
            }


        }
    }
}
