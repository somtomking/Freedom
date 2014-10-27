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
        private string _theThemeName = string.Empty;


        public ThemeContext(
            IThemeProvider themeProvider)
        {

            this._themeProvider = themeProvider;
        }

        /// <summary>
        /// Get or  current theme system name
        /// </summary>
        public string WorkingThemeName
        {
            get
            {
                if (string.IsNullOrEmpty(_theThemeName))
                {
                    _theThemeName = System.Configuration.ConfigurationManager.AppSettings["CurrentThemeName"];
                }
                return _theThemeName;

            }
            set { }


        }
    }
}
