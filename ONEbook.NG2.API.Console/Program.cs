using System;
using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new Services();
            proxy.ChangeUsersGroup(new Request());
            proxy.CheckIsSyncCustomers(new Request());
            proxy.KickoutMembers(new Request());
                        
            Console.ReadLine();
        }        
    }
}
