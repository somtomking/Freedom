using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Menus
{
    public class MenuItemBaseModel
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public bool NewWindowOpen { get; set; }

        public int Order { get; set; }

        public string IconCss { get; set; }

        public bool HasUrl()
        {
            return !string.IsNullOrWhiteSpace(Url);
        }
    }
}