using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KingKeeper
{
    static class Program
    {
        static readonly Guid LocalAppDataLowId = new Guid("A520A1A4-1780-4FF6-BD18-167343C5AF16");
        static readonly Guid ProgramFilesId = new Guid("905e63b6-c1bf-494e-b29c-65b732d3d21a");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static string GetKnownFolderPath(Guid knownFolderId)
        {
            var pszPath = IntPtr.Zero;
            try
            {
                var hr = SHGetKnownFolderPath(knownFolderId, 0, IntPtr.Zero, out pszPath);
                if (hr >= 0)
                    return Marshal.PtrToStringAuto(pszPath);

                throw Marshal.GetExceptionForHR(hr);
            }
            finally
            {
                if (pszPath != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(pszPath);
            }
        }

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        /// <summary>
        /// Returns the AppData directory for the game.
        /// </summary>
        public static string GetAppDataDirectory() => Path.Combine(
            GetKnownFolderPath(LocalAppDataLowId),
            "Owlcat Games",
            "Pathfinder Kingmaker"
        );

        /// <summary>
        /// Returns the Saved Games directory.
        /// </summary>
        public static string GetSavedGamesDirectory() => Path.Combine(GetAppDataDirectory(), "Saved Games");

        /// <summary>
        /// Returns the installation directory for the game.
        /// </summary>
        /// <returns></returns>
        public static string GetInstallationDirectory() => Path.Combine(
            GetKnownFolderPath(ProgramFilesId),
            "Steam",
            "steamapps",
            "common",
            "Pathfinder Kingmaker"
        );
    }
}
