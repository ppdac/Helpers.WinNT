using System;

namespace Helpers.WinNT
{
    public class KernelNames
    {
        public enum KernelName { Vista, Windows7, Windows8, Windows, WinUnkown, WinOutdated };
        public static KernelName GetWindowsNTVersion()
        {
            string NTx = Environment.OSVersion.ToString();

            if (NTx.Contains("10.0"))
                return KernelName.Windows;
            if (NTx.Contains("6.3.") || NTx.Contains("6.2."))
                return KernelName.Windows8;
            else if (NTx.Contains("6.1."))
                return KernelName.Windows7;
            else if (NTx.Contains("6.0."))
                return KernelName.Vista;
            else if (NTx.Contains("5.2.") || NTx.Contains("5.1.") || NTx.Contains("5.1."))
                return KernelName.WinOutdated;

            return KernelName.WinUnkown;
        }
    }
}
