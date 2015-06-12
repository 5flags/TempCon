using System.Windows.Controls;
using System.Windows.Input;

namespace TempCon.Shell.Pages
{
    /// <summary>
    /// Interaction logic for Debug.xaml
    /// </summary>
    public partial class Debug : UserControl
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
