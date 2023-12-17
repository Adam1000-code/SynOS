using System;
using Cosmos.System.Graphics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Sys = Cosmos.System;
using IL2CPU.API.Attribs;
using Cosmos.System;

namespace SynOS.Graphics
{
    public class NewDisplay
    {
        // new display system. old was was too fucking hard to get working.

        public Canvas canvas = FullScreenCanvas.GetFullScreenCanvas();

        [ManifestResourceStream(ResourceName = "SynOS.Resources.kodi-cursor.bmp")] public static byte[] cursor;
        public Bitmap curs = new Bitmap(cursor);

        public void Initialize()
        {
            MouseManager.ScreenWidth = (UInt32)this.canvas.Mode.Columns;
            MouseManager.ScreenHeight = (UInt32)this.canvas.Mode.Rows;
        }

        public void Display()
        {
            canvas.DrawFilledRectangle(new Pen(Color.Blue), 0, 0, canvas.Mode.Columns, canvas.Mode.Rows);
            canvas.DrawImageAlpha(curs, (int)MouseManager.X, (int)MouseManager.Y);
            canvas.Display();
        }
    }
}
