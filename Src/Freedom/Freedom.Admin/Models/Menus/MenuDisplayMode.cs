using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freedom.Admin.Models.Menus
{
    public enum MenuDisplayMode : int
    {
        /// <summary>
        /// 默认的显示
        /// </summary>
        Default = 0,
        /// <summary>
        /// 菜单最小话，只有一个图标
        /// </summary>
        MiniMenu = 1,
        /// <summary>
        /// 菜单在顶部
        /// </summary>
        Top = 2,

    }
}