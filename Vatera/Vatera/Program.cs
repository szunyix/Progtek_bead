using System;
using Vatera.Interface;
using Vatera.Class;
using Vatera.Decorator;

namespace Vatera
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser exampleUser = new User();
            exampleUser.CreateUser();

            MemberUserDecorator member = new MemberUserDecorator(exampleUser);
            member.CreateUser("Seres Péter");

            string a = member.fullName;
            string b = exampleUser.fu
        }
    }
}
