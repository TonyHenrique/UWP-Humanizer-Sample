﻿using Mvvm.Services;
using XamlBrewer.Uwp.HumanizerSample;

namespace Mvvm
{
    internal class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menus
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("HomeIcon"), Text = "Home", NavigationDestination = typeof(HomePage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("MainPageIcon"), Text = "Main", NavigationDestination = typeof(MainPage) });

            SecondMenu.Add(new MenuItem() { Glyph = Icon.GetIcon("InfoIcon"), Text = "About", NavigationDestination = typeof(AboutPage) });
        }
    }
}
