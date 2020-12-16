using System.IO;
using System.Windows;
using QuickLook.Common.Plugin;

namespace QuickLook.Plugin.HelloWorld
{
    public class Plugin : IViewer
    {
        public int Priority => 0;

        public void Init()
        {
        }

        public bool CanHandle(string path)
        {
            return !Directory.Exists(path) && (path.ToLower().EndsWith(".gltf") || path.ToLower().EndsWith(".glb"));
        }

        public void Prepare(string path, ContextObject context)
        {
            context.PreferredSize = new Size {Width = 800, Height = 800};
        }

        public void View(string path, ContextObject context)
        {
            context.ViewerContent = new WebFrame(path);
            context.Title = $"{Path.GetFileName(path)}";

            context.IsBusy = false;
        }

        public void Cleanup()
        {
        }
    }
}