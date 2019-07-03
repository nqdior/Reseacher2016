using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewType.Seeker.Common
{
    public static class TimeCounter
    {
        private static DateTime startDt;

        private static DateTime endDt;

        public static void Start()
        {
            Console.WriteLine("処理開始");
            startDt = DateTime.Now;

            System.Threading.Thread.Sleep(1000);
        }

        public static void End()
        {
            endDt = DateTime.Now;

            TimeSpan ts = endDt - startDt; // 時間の差分を取得

            Console.WriteLine("経過時間（分）: " + ts.TotalMinutes); // 経過時間（分）
            Console.WriteLine("経過時間（秒）: " + ts.TotalSeconds); // 経過時間（秒）
            Console.WriteLine("経過時間（ミリ秒）: " + ts.TotalMilliseconds); // 経過時間（ミリ秒）

            Console.ReadKey();
        }
    }
}
