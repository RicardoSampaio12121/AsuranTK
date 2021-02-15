using System;
using BusinessObjects.User;
using GW2Wrapper.Models.Account;

namespace Logic.Application
{
    public static class TestController
    {
        public static void Test(string user)
        {
            var mapper = GW2Wrapper.Factory.InitializeMapper();
            var connector = GW2Wrapper.Factory.InitializeConnector(user);
            var account = GW2Wrapper.Factory.InitializeAccount(connector ,mapper);

            var data = account.GetData();

            Console.WriteLine(data.Name);
            foreach (var c in data.Access)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(data.Age);
            Console.WriteLine(data.Commander);
            Console.WriteLine(data.Created);

        }
    }
}