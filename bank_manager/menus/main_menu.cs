using bank_manager.items;
using System;
using System.Collections.Generic;
using System.Text;

namespace bank_manager.menus
{
    public class main_menu
    {

        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("Choose an Option");
            Console.WriteLine("1) Create New User");
            Console.WriteLine("2) Lookup User");

            Console.WriteLine("\r\nSelect an Option");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        User user = create_user.CreateUserMenu();

                        break;

                    }
            }
        }

    }
}
