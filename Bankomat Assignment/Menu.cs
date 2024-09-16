namespace Bankomat_Assignment
{
    public class Menu
    {
        public static int MenuMakerActions()
        {
            string[] actionOptions =
            {
                "Display all", "View account", "Add to account", "Withdraw from account", "Quit"
            };
            return MenuSelection(actionOptions);
        }
        public static string[] AllAccountNames()
        {
            //create the bank account names
            string[] accountNames =
            {
                "100010", "100011", "100012", "100013", "100014", "100015", "100016", "100017", "100018", "100019"
            };
            return accountNames;
        }
        public static int MenuSelection(string[] menuOptions)
        {
            int menuSelect = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                //printing out the full menu
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    //printing out the selected menu
                    if (i == menuSelect)
                    {
                        Console.WriteLine(menuOptions[menuSelect] + " <---");
                    }
                    //printing out all other options
                    else
                    {
                        Console.WriteLine(menuOptions[i]);
                    }
                }
                var keyPressed = Console.ReadKey();

                //going down, one smaller than the full menu
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                //going up, no going higher than the starting-option
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }

                //press ENTER to send back info about which menu-option was selected
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    return menuSelect;
                }
            }
        }
    }
}