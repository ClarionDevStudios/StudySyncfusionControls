using StudySyncfusion;
using System.Configuration;
using System.Data;
using System.Windows;

namespace StudySyncfusionControls
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AssemblyResolver.LicenseKeyLocator.FindandRegisterLicenseKey();
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JAaF1cX2hAYVF2WmFZfVhgdl9CZlZUR2YuP1ZhSXxVdk1hWH9dcndVRmRfUEV9XEY=");
        }
    }

}
