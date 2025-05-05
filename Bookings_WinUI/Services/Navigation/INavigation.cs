using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;

namespace Bookings_WinUI.Services.Navigation
{
    public interface INavigation
    {
        NavigationViewItem GetCurrentNavigationViewItem();

        List<NavigationViewItem> GetNavigationViewItems();

        List<NavigationViewItem> GetNavigationViewItems(Type type);

        List<NavigationViewItem> GetNavigationViewItems(Type type, string title);

        void SetCurrentNavigationViewItem(NavigationViewItem item);
    }
}
