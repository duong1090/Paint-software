using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    public abstract class Shape
    {
        private List<Point> listDxDy = new List<Point>(); 
        private List<Point> listPoints = new List<Point>();
        private Pen itsPen;
        private bool isSelected;
        private bool isCircleOrSquare;
        private float sizeZoom;
        private SolidBrush solidBrush;
        private HatchBrush hatchBrush;
        private int group;
        public int sizeZoomPen;
        public FillStyle fillStyle;
        
        public List<Point> ListPoints { get => listPoints; set => listPoints = value; }
        public Pen ItsPen { get => itsPen; set => itsPen = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public bool IsCircleOrSquare { get => isCircleOrSquare; set => isCircleOrSquare = value; }
        public float SizeZoom { get => sizeZoom; set => sizeZoom = value; }
        public SolidBrush SolidBrush { get => solidBrush; set => solidBrush = value; }
        public HatchBrush HatchBrush { get => hatchBrush; set => hatchBrush = value; }
        public List<Point> ListDxDy { get => listDxDy; set => listDxDy = value; }
        public int Group { get => group; set => group = value; }

        public bool isBeside(MouseEventArgs e)
        {
            if ((e.Location.X >= PMin().X && e.Location.Y >= PMin().Y)
                && (e.Location.X <= PMax().X && e.Location.Y <= PMax().Y))
                return true;
            return false;
        }

        public Point PMax()
        {
            int maxX = listPoints[0].X + (int)(ListDxDy[0].X * SizeZoom);
            int maxY = listPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom);
            for (int i = 0; i < listPoints.Count; i++)
            {
                if ((listPoints[i].X + (int)(ListDxDy[i].X * SizeZoom)) >= maxX)
                    maxX = listPoints[i].X + (int)(ListDxDy[i].X * SizeZoom);
                if ((listPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom)) >= maxY)
                    maxY = listPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom);
            }
            return new Point(maxX, maxY);
        }

        public Point PMin()
        {
            int minX = listPoints[0].X + (int)(ListDxDy[0].X * SizeZoom);
            int minY = listPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom);
            for (int i = 0; i < listPoints.Count; i++)
            {
                if ((listPoints[i].X + (int)(ListDxDy[i].X * SizeZoom)) <= minX)
                    minX = listPoints[i].X + (int)(ListDxDy[i].X * SizeZoom);
                if ((listPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom)) <= minY)
                    minY = listPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom);
            }
            return new Point(minX, minY);
        }

        public Point Center()
        {
            return new Point((PMax().X + PMin().X)/2, (PMax().Y + PMin().Y) / 2);
        }

        public void DistaceWithCenter()
        {
            for (int i = 0; i< listPoints.Count; i++)
            {
                listDxDy[i] = new Point(listPoints[i].X - Center().X, listPoints[i].Y - Center().Y);
            }
        }

        public abstract void Draw(Graphics g);

        public void DrawRegion(Graphics g, Pen pen, Point PMin, Point PMax)
        {
            g.DrawRectangle(pen, PMin.X, PMin.Y, PMax.X - PMin.X, PMax.Y - PMin.Y);
        }
    }



    public class Line : Shape
    {
        public Line()
        {
            Point point = new Point();
            ListPoints.Add(point);
            ListPoints.Add(point);
            ListDxDy.Add(point);
            ListDxDy.Add(point);
            ItsPen = new Pen(Color.Blue);
            SizeZoom = 0;
        }
        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom*10 + 1);
            Point p1 = new Point(ListPoints[0].X + (int)(ListDxDy[0].X * SizeZoom), ListPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom));
            Point p2 = new Point(ListPoints[1].X + (int)(ListDxDy[1].X * SizeZoom), ListPoints[1].Y + (int)(ListDxDy[1].Y * SizeZoom));
            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width + 1 * sizeZoomPen) { DashStyle = ItsPen.DashStyle }; 
            g.DrawLine(penDraw, p1, p2);
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Point point = new Point();
            ListPoints.Add(point);
            ListPoints.Add(point);
            ListDxDy.Add(point);
            ListDxDy.Add(point);
            SizeZoom = 0;
        }

        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom*10 + 1);
            Point p1 = new Point(ListPoints[0].X + (int)(ListDxDy[0].X * SizeZoom), ListPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom));
            Point p2 = new Point(ListPoints[ListPoints.Count - 1].X + (int)(ListDxDy[ListPoints.Count - 1].X * SizeZoom),
                ListPoints[ListPoints.Count - 1].Y + (int)(ListDxDy[ListPoints.Count - 1].Y * SizeZoom));

            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width * sizeZoomPen) { DashStyle = ItsPen.DashStyle };
            int a = 0, b = 0, c = 0, d = 0;
            if (IsCircleOrSquare)
                Define.DefineSquareOrCircle(p1, p2, ref a, ref b, ref c, ref d);
            else
                Define.DefineDirection(p1, p2, ref a, ref b, ref c, ref d);
            g.DrawRectangle(penDraw, a, b, c, d);
        }
    }
    public class FillRectangle : Shape
    {
        public FillRectangle()
        {
            Point point = new Point();
            ListPoints.Add(point);
            ListPoints.Add(point);
            ListDxDy.Add(point);
            ListDxDy.Add(point);
            SizeZoom = 0;
            fillStyle = FillStyle.SolidBrush;
        }

        public override void Draw(Graphics g)
        {
            Point p1 = new Point(ListPoints[0].X + (int)(ListDxDy[0].X * SizeZoom), ListPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom));
            Point p2 = new Point(ListPoints[ListPoints.Count - 1].X + (int)(ListDxDy[ListPoints.Count - 1].X * SizeZoom),
                ListPoints[ListPoints.Count - 1].Y + (int)(ListDxDy[ListPoints.Count - 1].Y * SizeZoom));


            int a = 0, b = 0, c = 0, d = 0;
            if (IsCircleOrSquare)
                Define.DefineSquareOrCircle(p1, p2, ref a, ref b, ref c, ref d);
            else
                Define.DefineDirection(p1, p2, ref a, ref b, ref c, ref d);

            if (fillStyle == FillStyle.SolidBrush)
                g.FillRectangle(SolidBrush, a, b, c, d);
            else
                g.FillRectangle(HatchBrush, a, b, c, d);

        }
    }
    public class Ellipse : Shape
    {
        public Ellipse()
        {
            Point point = new Point();
            ListPoints.Add(point);
            ListPoints.Add(point);
            ListDxDy.Add(point);
            ListDxDy.Add(point);
            SizeZoom = 0;
        }

        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom*10 + 1);
            Point p1 = new Point(ListPoints[0].X + (int)(ListDxDy[0].X * SizeZoom), ListPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom));
            Point p2 = new Point(ListPoints[ListPoints.Count - 1].X + (int)(ListDxDy[ListPoints.Count - 1].X * SizeZoom),
                ListPoints[ListPoints.Count - 1].Y + (int)(ListDxDy[ListPoints.Count - 1].Y * SizeZoom));

            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width * sizeZoomPen) { DashStyle = ItsPen.DashStyle };
            int a = 0, b = 0, c = 0, d = 0;
            if (IsCircleOrSquare)
                Define.DefineSquareOrCircle(p1, p2, ref a, ref b, ref c, ref d);
            else
                Define.DefineDirection(p1, p2, ref a, ref b, ref c, ref d);
            g.DrawEllipse(penDraw, a, b, c, d);
        }
    }
    public class FillEllipse : Shape
    {
        public FillEllipse()
        {
            Point point = new Point();
            ListPoints.Add(point);
            ListPoints.Add(point);
            ListDxDy.Add(point);
            ListDxDy.Add(point);
            SizeZoom = 0;
            fillStyle = FillStyle.SolidBrush;
        }
        public override void Draw(Graphics g)
        {
            Point p1 = new Point(ListPoints[0].X + (int)(ListDxDy[0].X * SizeZoom), ListPoints[0].Y + (int)(ListDxDy[0].Y * SizeZoom));
            Point p2 = new Point(ListPoints[ListPoints.Count - 1].X + (int)(ListDxDy[ListPoints.Count - 1].X * SizeZoom),
                ListPoints[ListPoints.Count - 1].Y + (int)(ListDxDy[ListPoints.Count - 1].Y * SizeZoom));

            int a = 0, b = 0, c = 0, d = 0;
            if (IsCircleOrSquare)
                Define.DefineSquareOrCircle(p1, p2, ref a, ref b, ref c, ref d);
            else
                Define.DefineDirection(p1, p2, ref a, ref b, ref c, ref d);


            if (fillStyle == FillStyle.SolidBrush)
                g.FillEllipse(SolidBrush, a, b, c, d);
            else
                g.FillEllipse(HatchBrush, a, b, c, d);
        }
    }
    public class Curve : Shape
    {
        private const int NUMBER_OF_POINTS = 4;
        public Curve()
        {
            Point point = new Point();
            for (int i = 0; i < NUMBER_OF_POINTS; i++)
            {
                ListPoints.Add(point);
                ListDxDy.Add(point);
            }
            SizeZoom = 0;
        }
        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom*10 + 1);
            List<Point> list = new List<Point>();
            for(int i = 0; i < ListPoints.Count; i++)
                list.Add(new Point(ListPoints[i].X + (int)(ListDxDy[i].X * SizeZoom), ListPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom)));

            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width * sizeZoomPen) { DashStyle = ItsPen.DashStyle };
            g.DrawCurve(penDraw, list.ToArray());
        }
    }
    public class Polygon : Shape
    {
        public Polygon()
        {
            ListPoints.Add(new Point());
            ListDxDy.Add(new Point());
            SizeZoom = 0;
        }
        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom * 10 + 1);
            List<Point> list = new List<Point>();
            for (int i = 0; i < ListPoints.Count; i++)
                list.Add(new Point(ListPoints[i].X + (int)(ListDxDy[i].X * SizeZoom), ListPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom)));

            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width * sizeZoomPen) { DashStyle = ItsPen.DashStyle };
            if (ListPoints.Count >= 3)
                g.DrawPolygon(penDraw, list.ToArray());
            else
                g.DrawLine(penDraw, list[0], list[1]);
        }
    }
    public class FillPolygon : Shape
    {
        public FillPolygon()
        {
            ListPoints.Add(new Point());
            ListDxDy.Add(new Point());
            SizeZoom = 0;
            fillStyle = FillStyle.SolidBrush;
        }
        public override void Draw(Graphics g)
        {
            sizeZoomPen = (int)(SizeZoom * 10 + 1);
            List<Point> list = new List<Point>();
            for (int i = 0; i < ListPoints.Count; i++)
                list.Add(new Point(ListPoints[i].X + (int)(ListDxDy[i].X * SizeZoom), ListPoints[i].Y + (int)(ListDxDy[i].Y * SizeZoom)));

            Pen penDraw = new Pen(ItsPen.Color, ItsPen.Width * sizeZoomPen) { DashStyle = ItsPen.DashStyle };
            if (ListPoints.Count >= 3)
            {
                if (fillStyle == FillStyle.SolidBrush)
                    g.FillPolygon(SolidBrush, list.ToArray());
                else
                    g.FillPolygon(HatchBrush, list.ToArray());
            }
            else
                g.DrawLine(penDraw, list[0], list[1]);
        }
    }


    public static class Define
    {
        public static void DefineDirection(Point pStart, Point pEnd, ref int a, ref int b, ref int c, ref int d)
        {
            if (pStart.X <= pEnd.X)
                a = pStart.X;
            else
                a = pEnd.X;


            if (pStart.Y <= pEnd.Y)
                b = pStart.Y;
            else
                b = pEnd.Y;


            if (pStart.X <= pEnd.X)
                c = pEnd.X - pStart.X;
            else
                c = pStart.X - pEnd.X;


            if (pStart.Y <= pEnd.Y)
                d = pEnd.Y - pStart.Y;
            else
                d = pStart.Y - pEnd.Y;
        }

        public static void DefineSquareOrCircle(Point pStart, Point pEnd, ref int a, ref int b, ref int c, ref int d)
        {
            if (pStart.X <= pEnd.X)
                c = pEnd.X - pStart.X;
            else
                c = pStart.X - pEnd.X;


            if (pStart.Y <= pEnd.Y)
                d = pEnd.Y - pStart.Y;
            else
                d = pStart.Y - pEnd.Y;

            if (c <= d)
                d = c;
            else
                c = d;

            if (pStart.X <= pEnd.X)
                a = pStart.X;
            else
                a = pStart.X - c;

            if (pStart.Y <= pEnd.Y)
                b = pStart.Y;
            else
                b = pStart.Y - c;
        }
    }
}
