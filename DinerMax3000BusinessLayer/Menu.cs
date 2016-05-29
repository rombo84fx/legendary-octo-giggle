using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        private int _databaseId;
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }

        public int DatabaseId
        {
            get
            {
                return _databaseId;
            }

            set
            {
                _databaseId = value;
            }
        }

        public Menu()
        {
            Items = new List<MenuItem>();   
        }

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu.DatabaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItem = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach (dsDinerMax3000.MenuItemRow menuItemRow in dtMenuItem.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }
            return allMenus;
        }

        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
        }

        public void SaveNewMenuItem(string Name, string Description, double price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Name, Description, price, DatabaseId);
        }
    }
}
