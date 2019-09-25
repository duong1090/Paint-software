namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTool = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnForeFill = new System.Windows.Forms.Button();
            this.btnBackFill = new System.Windows.Forms.Button();
            this.ptbFill = new System.Windows.Forms.PictureBox();
            this.menuFill = new System.Windows.Forms.MenuStrip();
            this.fillStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardDiagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardDiagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalCrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percent05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percent10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percent20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percent25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.cbbStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.pnlShape = new System.Windows.Forms.Panel();
            this.btnFillPolygon = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnFillRec = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            this.RefreshPtb = new System.Windows.Forms.Timer(this.components);
            this.ptbMain = new System.Windows.Forms.PictureBox();
            this.RefreshFillAndPen = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTool.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFill)).BeginInit();
            this.menuFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            this.pnlShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlTool.Controls.Add(this.panel4);
            this.pnlTool.Controls.Add(this.label6);
            this.pnlTool.Controls.Add(this.panel3);
            this.pnlTool.Controls.Add(this.panel2);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.panel1);
            this.pnlTool.Controls.Add(this.pnlShape);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Location = new System.Drawing.Point(7, 63);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(160, 704);
            this.pnlTool.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnUnGroup);
            this.panel4.Controls.Add(this.btnGroup);
            this.panel4.Location = new System.Drawing.Point(19, 555);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 71);
            this.panel4.TabIndex = 19;
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnGroup.Location = new System.Drawing.Point(9, 33);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(105, 31);
            this.btnUnGroup.TabIndex = 16;
            this.btnUnGroup.Text = "UnGroup";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(9, 3);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(105, 31);
            this.btnGroup.TabIndex = 15;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Brush";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnForeFill);
            this.panel3.Controls.Add(this.btnBackFill);
            this.panel3.Controls.Add(this.ptbFill);
            this.panel3.Controls.Add(this.menuFill);
            this.panel3.Location = new System.Drawing.Point(9, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 156);
            this.panel3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ForeColor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BackColor";
            // 
            // btnForeFill
            // 
            this.btnForeFill.BackColor = System.Drawing.Color.White;
            this.btnForeFill.Location = new System.Drawing.Point(92, 51);
            this.btnForeFill.Name = "btnForeFill";
            this.btnForeFill.Size = new System.Drawing.Size(32, 32);
            this.btnForeFill.TabIndex = 5;
            this.btnForeFill.UseVisualStyleBackColor = false;
            this.btnForeFill.Click += new System.EventHandler(this.btnForeFill_Click);
            // 
            // btnBackFill
            // 
            this.btnBackFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBackFill.Location = new System.Drawing.Point(19, 51);
            this.btnBackFill.Name = "btnBackFill";
            this.btnBackFill.Size = new System.Drawing.Size(32, 32);
            this.btnBackFill.TabIndex = 4;
            this.btnBackFill.UseVisualStyleBackColor = false;
            this.btnBackFill.Click += new System.EventHandler(this.btnBackFill_Click);
            // 
            // ptbFill
            // 
            this.ptbFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFill.Location = new System.Drawing.Point(8, 89);
            this.ptbFill.Name = "ptbFill";
            this.ptbFill.Size = new System.Drawing.Size(125, 50);
            this.ptbFill.TabIndex = 2;
            this.ptbFill.TabStop = false;
            // 
            // menuFill
            // 
            this.menuFill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillStyleToolStripMenuItem});
            this.menuFill.Location = new System.Drawing.Point(0, 0);
            this.menuFill.Name = "menuFill";
            this.menuFill.Size = new System.Drawing.Size(138, 24);
            this.menuFill.TabIndex = 3;
            this.menuFill.Text = "menuStrip1";
            // 
            // fillStyleToolStripMenuItem
            // 
            this.fillStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushToolStripMenuItem,
            this.hatchBrushToolStripMenuItem});
            this.fillStyleToolStripMenuItem.Name = "fillStyleToolStripMenuItem";
            this.fillStyleToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fillStyleToolStripMenuItem.Text = "Fill Style";
            // 
            // solidBrushToolStripMenuItem
            // 
            this.solidBrushToolStripMenuItem.Name = "solidBrushToolStripMenuItem";
            this.solidBrushToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.solidBrushToolStripMenuItem.Text = "SolidBrush";
            this.solidBrushToolStripMenuItem.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchBrushToolStripMenuItem
            // 
            this.hatchBrushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.forwardDiagonalToolStripMenuItem,
            this.backwardDiagonalToolStripMenuItem,
            this.crossToolStripMenuItem,
            this.diagonalCrossToolStripMenuItem,
            this.percent05ToolStripMenuItem,
            this.percent10ToolStripMenuItem,
            this.percent20ToolStripMenuItem,
            this.percent25ToolStripMenuItem});
            this.hatchBrushToolStripMenuItem.Name = "hatchBrushToolStripMenuItem";
            this.hatchBrushToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hatchBrushToolStripMenuItem.Text = "HatchBrush";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // forwardDiagonalToolStripMenuItem
            // 
            this.forwardDiagonalToolStripMenuItem.Name = "forwardDiagonalToolStripMenuItem";
            this.forwardDiagonalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.forwardDiagonalToolStripMenuItem.Text = "ForwardDiagonal";
            this.forwardDiagonalToolStripMenuItem.Click += new System.EventHandler(this.forwardDiagonalToolStripMenuItem_Click);
            // 
            // backwardDiagonalToolStripMenuItem
            // 
            this.backwardDiagonalToolStripMenuItem.Name = "backwardDiagonalToolStripMenuItem";
            this.backwardDiagonalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.backwardDiagonalToolStripMenuItem.Text = "BackwardDiagonal";
            this.backwardDiagonalToolStripMenuItem.Click += new System.EventHandler(this.backwardDiagonalToolStripMenuItem_Click);
            // 
            // crossToolStripMenuItem
            // 
            this.crossToolStripMenuItem.Name = "crossToolStripMenuItem";
            this.crossToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.crossToolStripMenuItem.Text = "Cross";
            this.crossToolStripMenuItem.Click += new System.EventHandler(this.crossToolStripMenuItem_Click);
            // 
            // diagonalCrossToolStripMenuItem
            // 
            this.diagonalCrossToolStripMenuItem.Name = "diagonalCrossToolStripMenuItem";
            this.diagonalCrossToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.diagonalCrossToolStripMenuItem.Text = "DiagonalCross";
            this.diagonalCrossToolStripMenuItem.Click += new System.EventHandler(this.diagonalCrossToolStripMenuItem_Click);
            // 
            // percent05ToolStripMenuItem
            // 
            this.percent05ToolStripMenuItem.Name = "percent05ToolStripMenuItem";
            this.percent05ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.percent05ToolStripMenuItem.Text = "Percent05";
            this.percent05ToolStripMenuItem.Click += new System.EventHandler(this.percent05ToolStripMenuItem_Click);
            // 
            // percent10ToolStripMenuItem
            // 
            this.percent10ToolStripMenuItem.Name = "percent10ToolStripMenuItem";
            this.percent10ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.percent10ToolStripMenuItem.Text = "Percent10";
            this.percent10ToolStripMenuItem.Click += new System.EventHandler(this.percent10ToolStripMenuItem_Click);
            // 
            // percent20ToolStripMenuItem
            // 
            this.percent20ToolStripMenuItem.Name = "percent20ToolStripMenuItem";
            this.percent20ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.percent20ToolStripMenuItem.Text = "Percent20";
            this.percent20ToolStripMenuItem.Click += new System.EventHandler(this.percent20ToolStripMenuItem_Click);
            // 
            // percent25ToolStripMenuItem
            // 
            this.percent25ToolStripMenuItem.Name = "percent25ToolStripMenuItem";
            this.percent25ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.percent25ToolStripMenuItem.Text = "Percent25";
            this.percent25ToolStripMenuItem.Click += new System.EventHandler(this.percent25ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(19, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 61);
            this.panel2.TabIndex = 16;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(9, 28);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 26);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 26);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.cbbStyle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numThickness);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Location = new System.Drawing.Point(9, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 202);
            this.panel1.TabIndex = 12;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(8, 41);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(87, 32);
            this.btnSet.TabIndex = 18;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // cbbStyle
            // 
            this.cbbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStyle.FormattingEnabled = true;
            this.cbbStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbbStyle.Location = new System.Drawing.Point(8, 105);
            this.cbbStyle.Name = "cbbStyle";
            this.cbbStyle.Size = new System.Drawing.Size(127, 28);
            this.cbbStyle.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thickness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Color";
            // 
            // numThickness
            // 
            this.numThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThickness.Location = new System.Drawing.Point(8, 165);
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(127, 26);
            this.numThickness.TabIndex = 13;
            this.numThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(101, 41);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 32);
            this.btnColor.TabIndex = 10;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // pnlShape
            // 
            this.pnlShape.BackColor = System.Drawing.Color.Lime;
            this.pnlShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShape.Controls.Add(this.btnFillPolygon);
            this.pnlShape.Controls.Add(this.btnPolygon);
            this.pnlShape.Controls.Add(this.btnCurve);
            this.pnlShape.Controls.Add(this.btnFillEllipse);
            this.pnlShape.Controls.Add(this.btnEllipse);
            this.pnlShape.Controls.Add(this.btnFillRec);
            this.pnlShape.Controls.Add(this.btnRectangle);
            this.pnlShape.Controls.Add(this.btnLine);
            this.pnlShape.Location = new System.Drawing.Point(4, 44);
            this.pnlShape.Name = "pnlShape";
            this.pnlShape.Size = new System.Drawing.Size(147, 82);
            this.pnlShape.TabIndex = 11;
            // 
            // btnFillPolygon
            // 
            this.btnFillPolygon.BackgroundImage = global::Paint.Properties.Resources.FillPolygon;
            this.btnFillPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFillPolygon.FlatAppearance.BorderSize = 2;
            this.btnFillPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillPolygon.Location = new System.Drawing.Point(106, 39);
            this.btnFillPolygon.Name = "btnFillPolygon";
            this.btnFillPolygon.Size = new System.Drawing.Size(35, 35);
            this.btnFillPolygon.TabIndex = 32;
            this.btnFillPolygon.UseVisualStyleBackColor = true;
            this.btnFillPolygon.Click += new System.EventHandler(this.btnFillPolygon_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = global::Paint.Properties.Resources.Polygon1;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.FlatAppearance.BorderSize = 2;
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPolygon.Location = new System.Drawing.Point(106, 3);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(35, 35);
            this.btnPolygon.TabIndex = 31;
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::Paint.Properties.Resources.Curve1;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurve.FlatAppearance.BorderSize = 2;
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCurve.Location = new System.Drawing.Point(4, 39);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(35, 35);
            this.btnCurve.TabIndex = 30;
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.BackgroundImage = global::Paint.Properties.Resources.FillEllipse;
            this.btnFillEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFillEllipse.FlatAppearance.BorderSize = 2;
            this.btnFillEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillEllipse.Location = new System.Drawing.Point(72, 39);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(35, 35);
            this.btnFillEllipse.TabIndex = 29;
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            this.btnFillEllipse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyDown);
            this.btnFillEllipse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyUp);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.FlatAppearance.BorderSize = 2;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEllipse.Location = new System.Drawing.Point(72, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(35, 35);
            this.btnEllipse.TabIndex = 28;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            this.btnEllipse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyDown);
            this.btnEllipse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyUp);
            // 
            // btnFillRec
            // 
            this.btnFillRec.BackgroundImage = global::Paint.Properties.Resources.FillRectangle;
            this.btnFillRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFillRec.FlatAppearance.BorderSize = 2;
            this.btnFillRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFillRec.Location = new System.Drawing.Point(38, 39);
            this.btnFillRec.Name = "btnFillRec";
            this.btnFillRec.Size = new System.Drawing.Size(35, 35);
            this.btnFillRec.TabIndex = 27;
            this.btnFillRec.UseVisualStyleBackColor = true;
            this.btnFillRec.Click += new System.EventHandler(this.btnFillRec_Click);
            this.btnFillRec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyDown);
            this.btnFillRec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyUp);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.FlatAppearance.BorderSize = 2;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangle.Location = new System.Drawing.Point(38, 3);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(35, 35);
            this.btnRectangle.TabIndex = 26;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            this.btnRectangle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyDown);
            this.btnRectangle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRectangle_KeyUp);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::Paint.Properties.Resources.line1;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.FlatAppearance.BorderSize = 2;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLine.Location = new System.Drawing.Point(4, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(35, 35);
            this.btnLine.TabIndex = 25;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shape";
            // 
            // tbrZoom
            // 
            this.tbrZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbrZoom.Location = new System.Drawing.Point(172, 13);
            this.tbrZoom.Maximum = 50;
            this.tbrZoom.Minimum = -50;
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Size = new System.Drawing.Size(1202, 45);
            this.tbrZoom.TabIndex = 18;
            this.tbrZoom.Value = 1;
            this.tbrZoom.Scroll += new System.EventHandler(this.tbrZoom_Scroll);
            // 
            // RefreshPtb
            // 
            this.RefreshPtb.Enabled = true;
            this.RefreshPtb.Interval = 1;
            this.RefreshPtb.Tick += new System.EventHandler(this.RefreshPtb_Tick);
            // 
            // ptbMain
            // 
            this.ptbMain.BackColor = System.Drawing.Color.White;
            this.ptbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbMain.Location = new System.Drawing.Point(172, 63);
            this.ptbMain.Margin = new System.Windows.Forms.Padding(2);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(1203, 705);
            this.ptbMain.TabIndex = 6;
            this.ptbMain.TabStop = false;
            this.ptbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseClick);
            this.ptbMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseDoubleClick);
            this.ptbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseDown);
            this.ptbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseMove);
            this.ptbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbMain_MouseUp);
            // 
            // RefreshFillAndPen
            // 
            this.RefreshFillAndPen.Enabled = true;
            this.RefreshFillAndPen.Interval = 1;
            this.RefreshFillAndPen.Tick += new System.EventHandler(this.RefreshFillAndPen_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Olive;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(7, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 44);
            this.panel5.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(12, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phạm Thái Dương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(33, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "17110273";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1386, 779);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbrZoom);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.ptbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuFill;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint";
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFill)).EndInit();
            this.menuFill.ResumeLayout(false);
            this.menuFill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            this.pnlShape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Timer RefreshPtb;
        private System.Windows.Forms.PictureBox ptbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel pnlShape;
        private System.Windows.Forms.Button btnFillPolygon;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnFillRec;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ComboBox cbbStyle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbrZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptbFill;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.MenuStrip menuFill;
        private System.Windows.Forms.ToolStripMenuItem fillStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardDiagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backwardDiagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalCrossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percent05ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percent10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percent20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percent25ToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnForeFill;
        private System.Windows.Forms.Button btnBackFill;
        private System.Windows.Forms.Timer RefreshFillAndPen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

