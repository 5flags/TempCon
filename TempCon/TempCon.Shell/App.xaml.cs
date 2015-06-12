using System.Reflection;
using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using GalaSoft.MvvmLight.Threading;
using log4net;
using Microsoft.Practices.ServiceLocation;
using TempCon.Shell.ViewModel;

namespace TempCon.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static App()
        {
            DispatcherHelper.Initialize();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _log.Info("Application started.");

            AppearanceManager.Current.ThemeSource = AppearanceManager.DarkThemeSource;
            AppearanceManager.Current.AccentColor = Color.FromRgb(0x50, 0x2D, 0x7F);
        }
    }
}
