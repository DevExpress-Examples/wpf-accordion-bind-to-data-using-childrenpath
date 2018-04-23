using System.Collections.Generic;

namespace ChildrenPath {

    class ViewModel {
        public Menu AppMenu { get; set; }
        public MenuItem SelectedItem { get; set; }
        public ViewModel() {
            AppMenu = new Menu();
            SelectedItem = AppMenu.MenuItems[0];
        }
    }

    public class Menu {
        public List<MenuItem> MenuItems { get; set; }
        public Menu() {
            MenuItems = GetMenuItems();
        }
        private static List<MenuItem> GetMenuItems() {
            List<MenuItem> items = new List<MenuItem>();
            List<MenuItem> subitems = new List<MenuItem>();
            subitems.Add(new MenuItem() { Caption = "SubItem3" });
            items.Add(new MenuItem() {
                Caption = "Item1",
                SubItems = new List<MenuItem>() { new MenuItem() { Caption = "SubItem1" },
                    new MenuItem() { Caption = "SubItem2", SubItems=subitems }
                }
            });
            items.Add(new MenuItem() {
                Caption = "Item2",
                SubItems = new List<MenuItem>() { new MenuItem() { Caption = "SubItem1" },
                    new MenuItem() { Caption = "SubItem2" }
                }
            });
            return items;
        }
    }

    public class MenuItem {
        public string Caption { get; set; }
        public List<MenuItem> SubItems { get; set; }
    }
}
