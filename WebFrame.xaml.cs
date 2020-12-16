using System.IO;
using System.Windows;
using System.Windows.Controls;
using static System.IO.Directory;

namespace QuickLook.Plugin.HelloWorld
{
    public partial class WebFrame : UserControl
    {
        const string pluginPath = "UserData/QuickLook.Plugin/QuickLook.Plugin.HelloWorld";

        public WebFrame(string path)
        {
            InitializeComponent();


            var mainModuleFileName = System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName;
            var directoryName = Path.GetDirectoryName(mainModuleFileName);

            if (directoryName == null) return;

            var htmlPath = Path.Combine(directoryName, pluginPath, "three-gltf-viewer/index.html");
            Browser.Address = htmlPath
                              + "#model=" + path
                              + "&kiosk=1";
        }
    }
}