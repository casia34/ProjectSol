using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectSol.Utils.Drow
{
    class AnimationDrowing
    {
        //public class Grid
        //{
        //    static readonly Random rng = new Random();
        //    readonly Color[,] data;

        //    public Grid(int rows, int columns)
        //    {
        //        Rows = rows;
        //        Columns = columns;

        //        data = new Color[rows, columns];

        //        for (int i = 0; i < rows; i++)
        //        {
        //            for (int j = 0; j < columns; j++)
        //            {
        //                SetRandomColor(i, j);
        //            }
        //        }
        //    }

        //    public void SetRandomColor(int row, int column)
        //    {
        //        data[row, column] = Color.FromArgb(
        //            rng.Next(256),
        //            rng.Next(256),
        //            rng.Next(256),
        //            rng.Next(256));
        //    }

        //    public int Rows { get; }
        //    public int Columns { get; }

        //    public (int row, int column) GetCoordinates(Control target, Point point)
        //    {
        //        float wt = target.ClientSize.Width, ht = target.ClientSize.Height;
        //        float dx = wt / Columns, dy = ht / Rows;

        //        return ((int)(point.X / dx), (int)(point.Y / dy));
        //    }

        //    public Color this[int row, int column]
        //    {
        //        get => data[row, column];
        //        set => data[row, column] = value;
        //    }

        //    public void Render(Graphics g, Control target)
        //    {
        //        float wt = target.ClientSize.Width, ht = target.ClientSize.Height;
        //        float dx = wt / Columns, dy = ht / Rows;
        //        using (var fill = new SolidBrush(Color.Black))
        //        {
        //            for (int i = 0; i < Rows; i++)
        //            {
        //                for (int j = 0; j < Columns; j++)
        //                {
        //                    float x = i * dx, y = j * dy;

        //                    fill.Color = data[i, j];

        //                    g.FillRectangle(fill, x, y, dx, dy);
        //                }
        //            }
        //        }
        //    }

        //    public Bitmap GenerateBitmap(PictureBox target)
        //    {
        //        int wt = target.ClientSize.Width, ht = target.ClientSize.Height;
        //        Bitmap bmp = new Bitmap(wt, ht, PixelFormat.Format32bppArgb);
        //        Graphics g = Graphics.FromImage(bmp);
        //        Render(g, target);
        //        return bmp;
        //    }
        //}
    }
}
