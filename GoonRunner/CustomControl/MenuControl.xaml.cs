using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using GoonRunner.MVVM.ViewModel;

namespace GoonRunner.CustomControl
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }
        private void CollapseSidebar(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this);
            if (mainWindow == null) return;

            var mainGrid = FindChild<Grid>(mainWindow, "MainGrid");
            var split2 = FindChild<GridSplitter>(mainWindow, "Split2");
            var sidebarButton = FindChild<ToggleButton>(mainWindow, "SidebarButton");

            if (split2 != null)
                split2.Visibility = Visibility.Collapsed;

            if (mainGrid != null && mainGrid.ColumnDefinitions.Count > 5)
            {
                mainGrid.ColumnDefinitions[4].Width = new GridLength(0);
                mainGrid.ColumnDefinitions[5].Width = new GridLength(0);
            }

            if (sidebarButton != null)
            {
                sidebarButton.IsChecked = false;
                sidebarButton.IsEnabled = false;
            }
        }

        private T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            if (parent == null) return null;

            T foundChild = null;
            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is T typedChild && (child as FrameworkElement)?.Name == childName)
                {
                    foundChild = typedChild;
                    break;
                }

                foundChild = FindChild<T>(child, childName);
                if (foundChild != null) break;
            }

            return foundChild;
        }
    }
}
