using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib;
using System.Windows.Forms;
using CmlLib.Core.Auth.Microsoft.UI.WinForm;

namespace MGLauncher
{
    internal class LaunchMinecraft
    {
        microsoftLoginGUI ml = new microsoftLoginGUI();
        mainGUI mgui = new mainGUI();

        public async void launchMinecraftMicrosoft(int mb)
        {
            MicrosoftLoginForm loginForm = new MicrosoftLoginForm();
            MSession session = loginForm.ShowLoginDialog();
            if (session != null)

                ml.Hide();
            // increase connection limit to fast download
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;

            //var path = new MinecraftPath("game_directory_path");
            var path = new MinecraftPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.MGPack\");  // use default directory

            var launcher = new CMLauncher(path);

            // show launch progress to console
            launcher.FileChanged += (e) =>
            {
                string filekind = e.FileKind.ToString();
                string filename = e.FileName;
                var progress = e.ProgressedFileCount;
                var naile = e.TotalFileCount;

               
            };
            launcher.ProgressChanged += (s, e) =>
            {
                

            };

            var versions = await launcher.GetAllVersionsAsync();
            foreach (var item in versions)
            {
                // show all version names
                // use this version name in CreateProcessAsync method.
                Console.WriteLine(item.Name);
            }

            var launchOption = new MLaunchOption
            {
                MaximumRamMb = mb,
                Session = session

            };

            
            var process = await launcher.CreateProcessAsync("1.12.2-forge-14.23.5.2860", launchOption); // forge
                                                                                                        // var process = await launcher.CreateProcessAsync("1.12.2-LiteLoader1.12.2"); // liteloader
                                                                                                        // var process = await launcher.CreateProcessAsync("fabric-loader-0.11.3-1.16.5") // fabric-loader
            mgui.notifyIcon1.Visible = true;
            process.Start();
        }



        public async void launchMinecraftOffline(string username, int mb)
        {
            offlineLoginGUI ml = new offlineLoginGUI();


            var session = MSession.GetOfflineSession(username);


            System.Net.ServicePointManager.DefaultConnectionLimit = 256;


            var path = new MinecraftPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.MGPack\");


            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                string filekind = e.FileKind.ToString();
                string filename = e.FileName;
                var progress = e.ProgressedFileCount;
                var naile = e.TotalFileCount;

               
            };
            launcher.ProgressChanged += (s, e) =>
            {
              

            };

            var versions = await launcher.GetAllVersionsAsync();
            foreach (var item in versions)
            {

                Console.WriteLine(item.Name);
            }

            var launchOption = new MLaunchOption
            {
                MaximumRamMb = mb,
                Session = session

            };
            var process = await launcher.CreateProcessAsync("1.12.2-forge-14.23.5.2860", launchOption); // forge
                                                                                                        // var process = await launcher.CreateProcessAsync("1.12.2-LiteLoader1.12.2"); // liteloader
            ml.Hide();
            mgui.notifyIcon1.Visible = true;
            process.Start();
        }


    }
}




