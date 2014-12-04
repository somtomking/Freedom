using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Menus
{
    public class MenuItemModel
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public bool NewWindowOpen { get; set; }
        public ICollection<MenuItemModel> Children { get; set; }
        public MenuItemLevel Level { get; set; }
        public int Order { get; set; }

        public string Css { get; set; }
        public bool HasUrl()
        {
            return !string.IsNullOrWhiteSpace(Url);
        }

        public bool HasChildren()
        {
            return Children != null && Children.Count > 0;
        }

    }
}