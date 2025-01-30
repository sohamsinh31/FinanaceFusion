using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceFusion.Resources.Themes
{
    public class Theme
    {
        public static class Colors
        {
            public static Color BtnColorLight = Color.FromArgb(20, 53, 197); // Light Mode Button Color
            public static Color BtnTxtColorLight = Color.FromArgb(255, 255, 255); // Light Mode Text Color

            public static Color BtnColorDark = Color.FromArgb(40, 53, 197); // Dark Mode Button Color
            public static Color BtnTxtColorDark = Color.FromArgb(255, 255, 255); // Dark Mode Text Color
        }

        public static class Fonts
        {
            public static Font HeadingFont = new Font("Segoe UI", 14F);
            public static Font InputFont = new Font("Segoe UI", 11F);
        }

        public static class Sizes
        {
            public static Size LeftPanelSize = new Size(250, 588);
            public static Size WindowSize = new Size(1360, 722);
        }
    }
}