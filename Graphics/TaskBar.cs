using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cosmos.System.Graphics;
using System.IO;
using Sys = Cosmos.System;
using Cosmos.System;
using Cosmos.System.Graphics.Fonts;
using Point = Cosmos.System.Graphics.Point;
using System.Runtime.CompilerServices;

namespace SynOS.Graphics
{
    public class TaskBar
    {
        private Pen pen;
        private Pen pen2;
        private Int32 rows, columns;

        public TaskBar(Canvas canvas)
        {
            this.pen = new Pen(Color.White);
            this.pen2 = new Pen(Color.Gray);
            this.rows = canvas.Mode.Rows;
            this.columns = canvas.Mode.Columns;

            canvas.DrawFilledRectangle(this.pen2, 0, this.rows - 60, this.columns, 99);
            canvas.DrawRectangle(this.pen, 0, this.rows - 60, 75, 99);
            canvas.DrawLine(this.pen, 25, this.rows - 50, 50, this.rows - 10);
        }

        public void tryProcessTabBarClick(Int32 mouseX, Int32 mouseY)
        {
            if(new Rectangle(mouseX, mouseY, 1, 1).IntersectsWith(new Rectangle(0, this.rows + 100, 100, 99)))
            {
                System.Console.Beep();
                new Tab(100, 100);
            }
        }
    }
}
