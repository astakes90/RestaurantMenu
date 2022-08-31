using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }

}