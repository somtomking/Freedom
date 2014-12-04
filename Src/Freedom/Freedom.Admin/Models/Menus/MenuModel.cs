using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Menus
{
    public class MenuModel
    {
        public MenuModel()
        {
            MainItems = new List<MenuItemModel>();
        }
        public MenuDisplayMode DisplayMode { get; set; }
        public IList<MenuItemModel> MainItems { get; set; }
        public bool ShowShotCuts { get; set; }
        
    }
}