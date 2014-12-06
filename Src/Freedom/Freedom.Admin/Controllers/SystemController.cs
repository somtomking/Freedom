using Freedom.Admin.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freedom.Admin.Controllers
{
    public class SystemController : Controller
    {
        #region Menus
        /// <summary>
        /// 1级菜单建议不超过15个
        /// 2级菜单建议不超过10个
        /// 3级菜单建议不超过7个
        /// 4级菜单建议最好不要有，会影响客户端性能
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            MenuModel model = new MenuModel();
            PrepareMenuModelTest(model);
            return PartialView(model);
        }

        #region Test
        private void PrepareMenuModelTest(MenuModel model)
        {
            for (int loop = 0; loop < 15; loop++)
            {
                var item = new MenuItemModel();
                item.Text = "test";
                item.Url = Url.Action();
                item.IconCss = "fa-desktop";
                for (int loop2 = 0; loop2 < 20; loop2++)
                {
                    var item2 = new MenuItemModel();
                    item2.Text = "test";
                    item2.Url = Url.Action();
                    item2.IconCss = "fa-desktop";
                    item.Children.Add(item2);

                    for (int loop3 = 0; loop3 < 15; loop3++)
                    {
                        var item3 = new MenuItemModel();
                        item3.Text = "test";
                        item3.Url = Url.Action();
                        item3.IconCss = "fa-desktop";
                        item2.Children.Add(item3);

                    }


                }
                model.MainItems.Add(item);
            }
        }
        #endregion
        #endregion



    }
}