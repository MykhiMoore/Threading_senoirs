using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace Threading_senoirs
{ 
    
    internal class ThreadingSamples
    {
        public static Random _random = new Random();
        public static void CrazyMouseThread()
        {
            Trace.WriteLine("Thread Started");

            int moveX = 0;
            int moveY = 0;

            while (true) 
            {
                moveX = _random.Next(20);
                moveY = _random.Next(20);

                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Postion.X + moveX, System.Windows.Forms Cursor.Position.Y + moveY);
                Thread.Sleep(100);

            }

        }
    }

    
}
