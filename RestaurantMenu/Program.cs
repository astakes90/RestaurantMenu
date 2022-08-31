using RestaurantMenu;

var menu = new Menu("Dinner Menu", DateTime.Now, new List<MenuItem>());

Console.WriteLine(menu.Name);

menu.PrintMenu();