using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Menus
{
    public class MenuItemModel : MenuItemBaseModel
    {
      
        public ICollection<MenuItemModel> Children { get; set; }
        public MenuItemLevel Level { get; set; }
        public bool Active { get; set; }
      

        public bool HasChildren()
        {
            return Children != null && Children.Count > 0;
        }

    }
}