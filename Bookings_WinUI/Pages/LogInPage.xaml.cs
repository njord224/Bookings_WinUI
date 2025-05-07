using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ABI.Windows.UI;
using Microsoft.UI.System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Bookings_WinUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogInPage : Page
    {
        public LogInPage()
        {
            this.InitializeComponent();
        }

        public void ShowErrors_BtnClick(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin();
            //Show errors
            UsernameInput.BorderBrush = Application.Current.Resources["SystemFillColorAttentionBrush"] as SolidColorBrush;
            usernameError.Visibility = Visibility.Visible;
            PasswordInput.BorderBrush = Application.Current.Resources["SystemFillColorAttentionBrush"] as SolidColorBrush;
            passwordError.Visibility = Visibility.Visible;
        }
    }
}
