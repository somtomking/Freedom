using System;
using System.Linq;


namespace Freedom.Web.Framework.Themes
{
    /// <summary>
    /// Theme context
    /// </summary>
    public partial class ThemeContext : IThemeContext
    {

        private readonly IThemeProvider _themeProvider;



        public ThemeContext(
            IThemeProvider themeProvider)
        {

            this._themeProvider = themeProvider;
        }

        /// <summary>
        /// Get or set current theme system name
        /// </summary>
        public string WorkingThemeName
        {
            get;
            set;
        }
    }
}
