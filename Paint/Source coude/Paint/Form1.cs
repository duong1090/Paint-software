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
    enum Status { Line, Rectangle, FillRectangle, Ellipse, FillEllipse, Curve, Polygon, FillPolygon, Select }

    public enum FillStyle { Horizontal , Vertical, ForwardDiagonal, BackwardDiagonal, Cross , DiagonalCross , Percent05 , Percent10 , Percent20 , Percent25 , SolidBrush}
    public partial class Form1 : Form
    {
        List<Shape> listShapes;
        List<int> listGroup;
        Status status;
        FillStyle fillStyle;
        Bitmap bmp;
        Graphics graphic;
        Pen penRegion;
        Pen penMain;
        HatchBrush hatchBrush;
        SolidBrush solidBrush;
        Point posMouse;
        int groupNumber;
        bool isStart;
        bool isDelete;
        bool isRefreshPen;
        bool isZoom;
        bool isCurve;
        bool isSecondClickCurve;
        bool stopDrawPolygon;
        bool stopFillPolygon;
        bool holdShift;

        public Form1()
        {
            InitializeComponent();
            listShapes = new List<Shape>();
            listGroup = new List<int>();
            status = Status.Line;
            fillStyle = FillStyle.SolidBrush;
            bmp = new Bitmap(ptbMain.Size.Width, ptbMain.Size.Height);
            graphic = Graphics.FromImage(bmp);
            cbbStyle.SelectedIndex = 0;
            penRegion = new Pen(Color.Gray, 2F);
            penRegion.DashStyle = DashStyle.Dash;
            penMain = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
            solidBrush = new SolidBrush(btnBackFill.BackColor);
            hatchBrush = new HatchBrush(HatchStyle.Horizontal, btnForeFill.BackColor, btnBackFill.BackColor);
            isStart = false;
            isDelete = false;
            isRefreshPen = false;
            isZoom = false;
            isCurve = false;
            isSecondClickCurve = false;
            stopDrawPolygon = true;
            stopFillPolygon = true;
            holdShift = true;
            groupNumber = 1;
        }


        #region Click button

        public void SetBool()
        {
            stopDrawPolygon = true;
            stopFillPolygon = true;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            status = Status.Line;
            SetBool();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            status = Status.Rectangle;
            SetBool();
        }

        private void btnFillRec_Click(object sender, EventArgs e)
        {
            status = Status.FillRectangle;
            SetBool();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            status = Status.Ellipse;
            SetBool();
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            status = Status.Curve;
            SetBool();
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            status = Status.FillEllipse;
            SetBool();
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            status = Status.Polygon;
            SetBool();
        }

        private void btnFillPolygon_Click(object sender, EventArgs e)
        {
            status = Status.FillPolygon;
            SetBool();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            status = Status.Select;
            SetBool();
        }
        private void btnGroup_Click(object sender, EventArgs e)
        {
            foreach (Shape a in listShapes)
            {
                if (a.IsSelected)
                {
                    a.Group = groupNumber;
                }
            }
            groupNumber++;
        }

        private void btnUnGroup_Click(object sender, EventArgs e)
        {
            groupNumber--;
            foreach (Shape a in listShapes)
            {
                if (a.IsSelected)
                {
                    a.Group = groupNumber;
                }
            }
        }

        #endregion


        #region Draw Shape
        private void ptbMain_MouseDown(object sender, MouseEventArgs e)
        {
            isStart = true;
            if (status == Status.Select)
                posMouse = e.Location;
            else
                CreateAShape(e);
        }


        public void CreateAShape(MouseEventArgs e)
        {
            switch (status)
            {

                case Status.Line:
                    {
                        Shape shape = new Line();
                        shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                        shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                        shape.ListPoints[0] = shape.ListPoints[1] = e.Location;
                        listShapes.Add(shape);
                        break;
                    }
                case Status.Rectangle:
                    {
                        Shape shape = new Rectangle();

                        shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                        shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                        shape.ListPoints[0] = shape.ListPoints[1] = e.Location;
                        listShapes.Add(shape);
                        break;
                    }
                case Status.FillRectangle:
                    {
                        Shape shape = new FillRectangle();
                        shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                        shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                        shape.SolidBrush = solidBrush;
                        shape.HatchBrush = hatchBrush;
                        shape.ListPoints[0] = shape.ListPoints[1] = e.Location;
                        listShapes.Add(shape);
                        break;
                    }
                case Status.Ellipse:
                    {
                        Shape shape = new Ellipse();
                        shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                        shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                        shape.ListPoints[0] = shape.ListPoints[1] = e.Location;
                        listShapes.Add(shape);
                        break;
                    }
                case Status.FillEllipse:
                    {
                        Shape shape = new FillEllipse();
                        shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                        shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                        shape.SolidBrush = solidBrush;
                        shape.HatchBrush = hatchBrush;
                        shape.ListPoints[0] = shape.ListPoints[1] = e.Location;
                        listShapes.Add(shape);
                        break;
                    }
                case Status.Curve:
                    {
                        if (isCurve)
                        {
                            if (isSecondClickCurve)
                                listShapes[listShapes.Count - 1].ListPoints[2] = e.Location;
                            else
                                listShapes[listShapes.Count - 1].ListPoints[1] = e.Location;
                        }
                        else
                        {
                            Shape shape = new Curve();
                            shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                            shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                            shape.ListPoints[0] = shape.ListPoints[1] = shape.ListPoints[2] = shape.ListPoints[3] = e.Location;
                            listShapes.Add(shape);
                        }
                        break;
                    }
                case Status.Polygon:
                    {
                        if (stopDrawPolygon)
                        {
                            Shape shape = new Polygon();
                            shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                            shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                            listShapes.Add(shape);
                            listShapes[listShapes.Count - 1].ListPoints[0] = e.Location;
                            stopDrawPolygon = false;
                        }
                        Point point = e.Location;

                        listShapes[listShapes.Count - 1].ListPoints.Add(point);
                        listShapes[listShapes.Count - 1].ListDxDy.Add(point);
                        break;
                    }
                case Status.FillPolygon:
                    {
                        if (stopFillPolygon)
                        {
                            Shape shape = new FillPolygon();
                            shape.ItsPen = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
                            shape.ItsPen.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
                            shape.SolidBrush = solidBrush;
                            shape.HatchBrush = hatchBrush;
                            listShapes.Add(shape);
                            listShapes[listShapes.Count - 1].ListPoints[0] = e.Location;
                            stopFillPolygon = false;
                        }
                        Point point = e.Location;

                        listShapes[listShapes.Count - 1].ListPoints.Add(point);
                        listShapes[listShapes.Count - 1].ListDxDy.Add(point);
                        break;
                    }
            }
        }




        private void ptbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isStart)
            {
                if (status == Status.Select)
                {
                    MoveShape(e);
                }
                else
                    ChooseTheWayToDraw(e);
            }

        }

        public void MoveShape(MouseEventArgs e)
        {
            for (int i = listShapes.Count - 1; i >= 0; i--)
            {
                if (listShapes[i].IsSelected)
                {
                    ChangePoints(e, listShapes[i].ListPoints);
                    for (int j = listShapes.Count - 1; j >= 0; j--)
                        if (sameGroup(i, j))
                            ChangePoints(e, listShapes[j].ListPoints);
                }
            }
            posMouse = e.Location;
        }

        public void ChangePoints(MouseEventArgs e, List<Point> listPoints)
        {
            int distanceX, distanceY;
            distanceX = e.X - posMouse.X;
            distanceY = e.Y - posMouse.Y;



            for (int i = 0; i < listPoints.Count; i++)
            {
                Point temp = listPoints[i];
                listPoints[i] = new Point(temp.X + distanceX, temp.Y + distanceY);
            }

        }

        public void ChooseTheWayToDraw(MouseEventArgs e)
        {
            Shape theLastShape = listShapes[listShapes.Count - 1];
            if (status == Status.Curve)
            {
                if (isCurve)
                {
                    if (isSecondClickCurve)
                    {
                        theLastShape.ListPoints[2] = e.Location;
                    }
                    else
                    {
                        theLastShape.ListPoints[1] = e.Location;
                        theLastShape.ListPoints[2] = theLastShape.ListPoints[3];
                    }
                }
                else
                {
                    theLastShape.ListPoints[3] = e.Location;
                }
            }

            else
            {
                theLastShape.ListPoints[theLastShape.ListPoints.Count - 1] = e.Location;
            }

        }

        
        private void ptbMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (isStart)
            {
                if (status != Status.Select)
                {
                    ChooseTheWayToEnd(e);
                }
            }
            isStart = false;
        }

        public void ChooseTheWayToEnd(MouseEventArgs e)
        {
            Shape theLastShape = listShapes[listShapes.Count - 1];

            if (status == Status.Curve)
            {
                if (isCurve)
                {
                    if (isSecondClickCurve)
                    {
                        theLastShape.ListPoints[2] = e.Location;
                        isSecondClickCurve = false;
                        isCurve = false;
                    }
                    else
                    {
                        theLastShape.ListPoints[1] = e.Location;
                        theLastShape.ListPoints[2] = theLastShape.ListPoints[3];
                        isSecondClickCurve = true;
                    }
                }
                else
                {
                    theLastShape.ListPoints[3] = e.Location;
                    isCurve = true;
                }
            }


            else
            {
                theLastShape.ListPoints[theLastShape.ListPoints.Count - 1] = e.Location;
            }

            theLastShape.DistaceWithCenter();
        }

        private void RefreshPtb_Tick(object sender, EventArgs e)
        {
            if (isStart || isDelete || isZoom || isRefreshPen)
            {
                graphic.Clear(Color.White);
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                Draw(); 
                DrawRegion();
                ptbMain.Image = bmp;
            }
        }
        
        public void Draw()
        {
            for (int i = 0; i < listShapes.Count; i++)
            {
                listShapes[i].Draw(graphic);
            }
        }
        public void DrawRegion()
        {
            for (int i = listShapes.Count - 1; i >= 0; i--)
            {
                if (status == Status.Select)
                {
                    if (listShapes[i].IsSelected)
                    {
                        int count = 0;
                        int[] A = new int[100];
                        A[count++] = i;
                        for (int j = 0; j < listShapes.Count; j++)
                            if (sameGroup(i, j))
                            {
                                A[count++] = j;
                            }

                        if (count == 1)
                            listShapes[i].DrawRegion(graphic, penRegion, listShapes[i].PMin(), listShapes[i].PMax());
                        else
                            DrawRegionGroup(A, count);

                    }
                }
                else
                    listShapes[i].IsSelected = false;
            }
        }

        public void DrawRegionGroup(int[] A, int count)
        {
            graphic.DrawRectangle(penRegion, PMinGroup(A, count).X, PMinGroup(A, count).Y, PMaxGroup(A, count).X - PMinGroup(A, count).X, PMaxGroup(A, count).Y - PMinGroup(A, count).Y);
        }

        public Point PMaxGroup(int []A, int count)
        {
            int maxX = listShapes[A[0]].PMax().X;
            int maxY = listShapes[A[0]].PMax().Y;
            for (int i = 0; i < count; i++)
            {
                if (maxX < listShapes[A[i]].PMax().X)
                    maxX = listShapes[A[i]].PMax().X;
                if (maxY < listShapes[A[i]].PMax().Y)
                    maxY = listShapes[A[i]].PMax().Y;
            }
            return new Point(maxX, maxY);
        }

        public Point PMinGroup(int[] A, int count)
        {
            int minX = listShapes[A[0]].PMin().X;
            int minY = listShapes[A[0]].PMin().Y;
            for (int i = 0; i < count; i++)
            {
                if (minX > listShapes[A[i]].PMin().X)
                    minX = listShapes[A[i]].PMin().X;
                if (minY > listShapes[A[i]].PMin().Y)
                    minY = listShapes[A[i]].PMin().Y;
            }
            return new Point(minX, minY);
        }

        public bool sameGroup(int indexI, int indexJ)
        {
            if (listShapes[indexJ].Group == listShapes[indexI].Group && listShapes[indexJ].Group > 0 && indexJ != indexI)
                return true;
            return false;
        }

        
        #endregion


        #region Tool
        private void ptbMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stopDrawPolygon = true;
            stopFillPolygon = true;
            
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            ColorDialog cdg = new ColorDialog();
            if (cdg.ShowDialog() == DialogResult.OK)
                btnColor.BackColor = cdg.Color;
        }

        private void ptbMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (status == Status.Select)
            {
                for (int i = 0; i < listShapes.Count; i++)
                {
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (listShapes[i].isBeside(e))
                        {
                            listShapes[i].IsSelected = true;
                            listShapes[i].DrawRegion(graphic, penRegion, listShapes[i].PMin(), listShapes[i].PMax());
                        }
                    }

                    else
                    {
                        if (listShapes[i].isBeside(e))
                        {
                            listShapes[i].IsSelected = true;
                            listShapes[i].DrawRegion(graphic, penRegion, listShapes[i].PMin(), listShapes[i].PMax());
                            
                        }
                        else
                        {
                            listShapes[i].IsSelected = false;
                            RefreshPtb_Tick(null, null);
                        }
                    }

                    for (int j = 0; j < listShapes.Count; j++)
                        if (sameGroup(i, j))
                            listShapes[i].IsSelected = true;
                }
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            for (int i = 0; i < listShapes.Count; i++)
            {
                if (listShapes[i].IsSelected)
                {
                    listShapes.Remove(listShapes[i]);
                    i--;
                }
            }
        }

        private void btnRectangle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey && holdShift)
            {
                listShapes[listShapes.Count - 1].IsCircleOrSquare = !listShapes[listShapes.Count - 1].IsCircleOrSquare;
                holdShift = false;
            }
        }
        private void btnRectangle_KeyUp(object sender, KeyEventArgs e)
        {
            holdShift = true;
            listShapes[listShapes.Count - 1].IsCircleOrSquare = !listShapes[listShapes.Count - 1].IsCircleOrSquare;
        }

        private void btnSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnDelete_Click(null, null);
        }
        private void tbrZoom_Scroll(object sender, EventArgs e)
        {
            isZoom = true;
            foreach (Shape a in listShapes)
                if (a.IsSelected)
                    a.SizeZoom = (float)tbrZoom.Value/50;
        }
        private void btnBackFill_Click(object sender, EventArgs e)
        {
            ColorDialog cdg = new ColorDialog();
            if (cdg.ShowDialog() == DialogResult.OK)
                btnBackFill.BackColor = cdg.Color;
        }

        private void btnForeFill_Click(object sender, EventArgs e)
        {
            ColorDialog cdg = new ColorDialog();
            if (cdg.ShowDialog() == DialogResult.OK)
                btnForeFill.BackColor = cdg.Color;
        }

        
        #endregion


        #region Fill Style
        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.SolidBrush;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Horizontal;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Vertical;
        }

        private void forwardDiagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.ForwardDiagonal;
        }

        private void backwardDiagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.BackwardDiagonal;
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Cross;
        }

        private void diagonalCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.DiagonalCross;
        }

        private void percent05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Percent05;
        }

        private void percent10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Percent10;
        }

        private void percent20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Percent20;

        }

        private void percent25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillStyle = FillStyle.Percent25;
        }
        #endregion


        #region Refresh Pen And Brush
        private void RefreshFillAndPen_Tick(object sender, EventArgs e)
        {
            isRefreshPen = true;
            ShowFill();
            RefreshPen();
            RefreshBrush();
            foreach (Shape a in listShapes)
            {
                if (a.IsSelected)
                {
                    a.ItsPen = penMain;
                    a.SolidBrush = solidBrush;
                    a.HatchBrush = hatchBrush;
                    a.fillStyle = fillStyle;
                }
            }
        }

        public void RefreshPen()
        {
            penMain = new Pen(btnColor.BackColor, Convert.ToInt16(numThickness.Value));
            penMain.DashStyle = (DashStyle)cbbStyle.SelectedIndex;
        }

        public void RefreshBrush()
        {
            solidBrush = new SolidBrush(btnBackFill.BackColor);
            hatchBrush = new HatchBrush((HatchStyle) fillStyle, btnForeFill.BackColor, btnBackFill.BackColor);
            
        }

        public void ShowFill()
        {
            Bitmap bm = new Bitmap(ptbFill.Size.Width, ptbFill.Size.Height);
            Graphics g = Graphics.FromImage(bm);
           
            switch (fillStyle)
            {
                case FillStyle.SolidBrush:
                    {
                        solidBrush = new SolidBrush(btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Horizontal:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Horizontal, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.BackwardDiagonal:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Cross:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Cross, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.DiagonalCross:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.ForwardDiagonal:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.ForwardDiagonal, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Percent05:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Percent05, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Percent10:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Percent10, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Percent20:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Percent20, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Percent25:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Percent25, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
                case FillStyle.Vertical:
                    {
                        hatchBrush = new HatchBrush(HatchStyle.Vertical, btnForeFill.BackColor, btnBackFill.BackColor);
                        break;
                    }
            }

            if (fillStyle == FillStyle.SolidBrush)
                g.FillRectangle(solidBrush, 0, 0, ptbFill.Size.Width, ptbFill.Size.Height);
            else
                g.FillRectangle(hatchBrush, 0, 0, ptbFill.Size.Width, ptbFill.Size.Height);
            ptbFill.BackgroundImage = bm;
        }
        #endregion


    }
}



        