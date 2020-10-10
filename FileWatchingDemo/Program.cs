using System;
using System.IO;

namespace FileWatchingDemo
{
    class Program
    {
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
        static void Main()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);
            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.EnableRaisingEvents = true;
            Console.WriteLine(watcher.Path);
            Console.ReadKey();  
        }
    }
}
