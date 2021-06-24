using System;
using Vatera.Interface;
using Vatera.Class;
using Vatera.Decorator.UserDecorator;
using Vatera.Storage;


namespace Vatera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IUser exampleUser = new User();
            exampleUser.CreateUser();

            MemberUserDecorator member = new MemberUserDecorator(exampleUser);
            member.CreateUser();*/ //Seres P

            //string a = member.fullName;
            //string b = exampleUser.fu
            User testUser = new User();

            testUser.CreateUser("name", "pw", "email@gmail.com");
            MemberUserDecorator testMember = new MemberUserDecorator(testUser);
            //VerifiedMemberUserDecorator testVerified = new VerifiedMemberUserDecorator(testMember);
            TheStorage asd = TheStorage.GetInstance();
            TheStorage asd3 = TheStorage.GetInstance();

            asd.productadd(new Item(1,"asd", 1.5, 3));

            if (asd == asd3)
            {
                Console.WriteLine("még mindig jó");
            }

        }
    }
}
