using NewType.Seeker.Interface;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NewType.Seeker
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!MyProcess.ShowPrevProcess()) Application.Run(new MainForm());
        }
    }

    /* 同名のプロセスが起動中の場合、メイン ウィンドウをアクティブにします  */
    /* http://jeanne.wankuma.com/tips/csharp/process/activewindow.html */
    public class MyProcess
    {
        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        private static extern int ShowWindow(
            System.IntPtr hWnd,
            int nCmdShow
        );

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        private static extern bool SetForegroundWindow(
            System.IntPtr hWnd
        );

        private const int SW_NORMAL = 1;

        /// ------------------------------------------------------------------------------------
        /// <summary>
        ///     同名のプロセスが起動中の場合、メイン ウィンドウをアクティブにします。</summary>
        /// <returns>
        ///     既に起動中であれば true。それ以外は false。</returns>
        /// ------------------------------------------------------------------------------------
        public static bool ShowPrevProcess()
        {
            Process hThisProcess = Process.GetCurrentProcess();
            Process[] hProcesses = Process.GetProcessesByName(hThisProcess.ProcessName);
            int iThisProcessId = hThisProcess.Id;

            foreach (Process hProcess in hProcesses)
            {
                if (hProcess.Id != iThisProcessId)
                {
                    ShowWindow(hProcess.MainWindowHandle, SW_NORMAL);
                    SetForegroundWindow(hProcess.MainWindowHandle);
                    return true;
                }
            }

            return false;
        }
    }

}
