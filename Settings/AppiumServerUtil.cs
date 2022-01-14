using System;
using System.Diagnostics;

namespace MerakiApiAutomation.Settings
{
    public class AppiumServerUtil
    {
        public bool IsAppiumRunning { get; private set; }

        public void StartAppium()
        {
            // Check whether the environment variable exists.
            var value = Environment.GetEnvironmentVariable("ANDROID_HOME");

            // If necessary, create it.
            // This could also be set through setting, for the purpose of demo hard coding it.
            if (value == null) Environment.SetEnvironmentVariable("ANDROID_HOME", @"C:\Users\alir2t2\AppData\Local\Android\Sdk");

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C Appium -a {AppSettings.IPAddress} -p {AppSettings.Port} --allow-cors --base-path=/";
            process.Start();
        }
    }
}
