using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Systems
{
    public class MenuModel
    {
        public MenuModel()
        {
            MainItems = new List<MenuItemModel>();
            ShotCutItems = new List<MenuShotCutItemModel>();
        }
        public MenuDisplayMode DisplayMode { get; set; }
        public IList<MenuItemModel> MainItems { get; set; }
        public IList<MenuShotCutItemModel> ShotCutItems { get; set; }
        public bool ShowShotCuts { get; set; }

    }
}