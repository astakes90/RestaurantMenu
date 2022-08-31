using System;
using System.Xml.Linq;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public DateTime Updated { get; set; }

        public Menu(List<MenuItem> menuItems, DateTime updated)
        {
            MenuItems = menuItems;
            Updated = updated;
        }

        public void AddToMenu (MenuItem itemFromMenu)
        {
            Updated = DateTime.Now;
            MenuItems.Add(itemFromMenu);   
        }

        public void RemoveFromMenu(MenuItem itemFromMenu)
        {
            int index = MenuItems.IndexOf(itemFromMenu);

            MenuItems.RemoveAt(index);



        }

        public bool IsMenuItemNew (MenuItem itemFromMenu)
        {
            if (itemFromMenu.IsNew == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //public string LastUpdated (MenuItem itemFromMenu)
        //{
        //    if (itemFromMenu.)
        //}

        public void PrintMenu()
        {
            Console.WriteLine($"Menu: {MenuItems.Name} (updated: {MenuItems.UpdatedOn})");
        }
    }
}

