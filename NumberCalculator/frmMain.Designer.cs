namespace NumberCalculator
{
    partial class frmMain
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblNum14 = new System.Windows.Forms.Label();
            this.lblOp13 = new System.Windows.Forms.Label();
            this.lblNum13 = new System.Windows.Forms.Label();
            this.lblOp12 = new System.Windows.Forms.Label();
            this.lblNum12 = new System.Windows.Forms.Label();
            this.lblOp11 = new System.Windows.Forms.Label();
            this.lblNum11 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delayTime = new System.Windows.Forms.NumericUpDown();
            this.rdoPlusNum2 = new System.Windows.Forms.RadioButton();
            this.rdoPlusNum3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.numTimeStartNewOps = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.maxNum1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.minNum1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPlusMinusNum3 = new System.Windows.Forms.RadioButton();
            this.rdoPlusMinusNum2 = new System.Windows.Forms.RadioButton();
            this.rdoDivideNum2 = new System.Windows.Forms.RadioButton();
            this.rdoMultipleNum2 = new System.Windows.Forms.RadioButton();
            this.minNum2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxNum2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minNum3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.maxNum3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.chkPlayBackground = new System.Windows.Forms.CheckBox();
            this.rdoBangCuuChuong = new System.Windows.Forms.RadioButton();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartNewOps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.Controls.Add(this.lblNum14);
            this.pnl1.Controls.Add(this.lblOp13);
            this.pnl1.Controls.Add(this.lblNum13);
            this.pnl1.Controls.Add(this.lblOp12);
            this.pnl1.Controls.Add(this.lblNum12);
            this.pnl1.Controls.Add(this.lblOp11);
            this.pnl1.Controls.Add(this.lblNum11);
            this.pnl1.Location = new System.Drawing.Point(12, 9);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1112, 301);
            this.pnl1.TabIndex = 0;
            this.pnl1.Visible = false;
            this.pnl1.Resize += new System.EventHandler(this.pnl1_Resize);
            // 
            // lblNum14
            // 
            this.lblNum14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum14.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum14.ForeColor = System.Drawing.Color.White;
            this.lblNum14.Location = new System.Drawing.Point(778, 11);
            this.lblNum14.Name = "lblNum14";
            this.lblNum14.Size = new System.Drawing.Size(225, 274);
            this.lblNum14.TabIndex = 6;
            this.lblNum14.Text = "9999";
            this.lblNum14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOp13
            // 
            this.lblOp13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOp13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp13.ForeColor = System.Drawing.Color.White;
            this.lblOp13.Location = new System.Drawing.Point(724, 27);
            this.lblOp13.Name = "lblOp13";
            this.lblOp13.Size = new System.Drawing.Size(48, 259);
            this.lblOp13.TabIndex = 5;
            this.lblOp13.Text = "=";
            this.lblOp13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum13
            // 
            this.lblNum13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum13.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum13.ForeColor = System.Drawing.Color.White;
            this.lblNum13.Location = new System.Drawing.Point(493, 11);
            this.lblNum13.Name = "lblNum13";
            this.lblNum13.Size = new System.Drawing.Size(225, 274);
            this.lblNum13.TabIndex = 4;
            this.lblNum13.Text = "9999";
            this.lblNum13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOp12
            // 
            this.lblOp12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOp12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp12.ForeColor = System.Drawing.Color.White;
            this.lblOp12.Location = new System.Drawing.Point(439, 27);
            this.lblOp12.Name = "lblOp12";
            this.lblOp12.Size = new System.Drawing.Size(48, 259);
            this.lblOp12.TabIndex = 3;
            this.lblOp12.Text = "+";
            this.lblOp12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum12
            // 
            this.lblNum12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum12.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum12.ForeColor = System.Drawing.Color.White;
            this.lblNum12.Location = new System.Drawing.Point(248, 11);
            this.lblNum12.Name = "lblNum12";
            this.lblNum12.Size = new System.Drawing.Size(185, 274);
            this.lblNum12.TabIndex = 2;
            this.lblNum12.Text = "999";
            this.lblNum12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOp11
            // 
            this.lblOp11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOp11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp11.ForeColor = System.Drawing.Color.White;
            this.lblOp11.Location = new System.Drawing.Point(194, 27);
            this.lblOp11.Name = "lblOp11";
            this.lblOp11.Size = new System.Drawing.Size(48, 259);
            this.lblOp11.TabIndex = 1;
            this.lblOp11.Text = "+";
            this.lblOp11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum11
            // 
            this.lblNum11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum11.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum11.ForeColor = System.Drawing.Color.White;
            this.lblNum11.Location = new System.Drawing.Point(3, 11);
            this.lblNum11.Name = "lblNum11";
            this.lblNum11.Size = new System.Drawing.Size(185, 274);
            this.lblNum11.TabIndex = 0;
            this.lblNum11.Text = "999";
            this.lblNum11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1013, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 40);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thời gian trả lời (giây):";
            // 
            // delayTime
            // 
            this.delayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayTime.Location = new System.Drawing.Point(16, 365);
            this.delayTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayTime.Name = "delayTime";
            this.delayTime.Size = new System.Drawing.Size(120, 22);
            this.delayTime.TabIndex = 11;
            this.delayTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rdoPlusNum2
            // 
            this.rdoPlusNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoPlusNum2.AutoSize = true;
            this.rdoPlusNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPlusNum2.ForeColor = System.Drawing.Color.White;
            this.rdoPlusNum2.Location = new System.Drawing.Point(260, 342);
            this.rdoPlusNum2.Name = "rdoPlusNum2";
            this.rdoPlusNum2.Size = new System.Drawing.Size(99, 24);
            this.rdoPlusNum2.TabIndex = 12;
            this.rdoPlusNum2.Text = "Cộng 2 số";
            this.rdoPlusNum2.UseVisualStyleBackColor = true;
            this.rdoPlusNum2.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // rdoPlusNum3
            // 
            this.rdoPlusNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoPlusNum3.AutoSize = true;
            this.rdoPlusNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPlusNum3.ForeColor = System.Drawing.Color.White;
            this.rdoPlusNum3.Location = new System.Drawing.Point(260, 373);
            this.rdoPlusNum3.Name = "rdoPlusNum3";
            this.rdoPlusNum3.Size = new System.Drawing.Size(99, 24);
            this.rdoPlusNum3.TabIndex = 13;
            this.rdoPlusNum3.Text = "Cộng 3 số";
            this.rdoPlusNum3.UseVisualStyleBackColor = true;
            this.rdoPlusNum3.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(12, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 10);
            this.panel1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.AutoSize = true;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(1013, 341);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 40);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Dừng lại";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // numTimeStartNewOps
            // 
            this.numTimeStartNewOps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numTimeStartNewOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeStartNewOps.Location = new System.Drawing.Point(16, 421);
            this.numTimeStartNewOps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeStartNewOps.Name = "numTimeStartNewOps";
            this.numTimeStartNewOps.Size = new System.Drawing.Size(120, 22);
            this.numTimeStartNewOps.TabIndex = 17;
            this.numTimeStartNewOps.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thời gian bắt đầu bài mới (giây):";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // maxNum1
            // 
            this.maxNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNum1.Location = new System.Drawing.Point(595, 421);
            this.maxNum1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxNum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxNum1.Name = "maxNum1";
            this.maxNum1.Size = new System.Drawing.Size(57, 22);
            this.maxNum1.TabIndex = 19;
            this.maxNum1.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(592, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lớn nhất 2";
            // 
            // minNum1
            // 
            this.minNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNum1.Location = new System.Drawing.Point(595, 365);
            this.minNum1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minNum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNum1.Name = "minNum1";
            this.minNum1.Size = new System.Drawing.Size(57, 22);
            this.minNum1.TabIndex = 21;
            this.minNum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(591, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số nhỏ nhất 1";
            // 
            // rdoPlusMinusNum3
            // 
            this.rdoPlusMinusNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoPlusMinusNum3.AutoSize = true;
            this.rdoPlusMinusNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPlusMinusNum3.ForeColor = System.Drawing.Color.White;
            this.rdoPlusMinusNum3.Location = new System.Drawing.Point(260, 435);
            this.rdoPlusMinusNum3.Name = "rdoPlusMinusNum3";
            this.rdoPlusMinusNum3.Size = new System.Drawing.Size(122, 24);
            this.rdoPlusMinusNum3.TabIndex = 23;
            this.rdoPlusMinusNum3.Text = "Cộng trừ 3 số";
            this.rdoPlusMinusNum3.UseVisualStyleBackColor = true;
            this.rdoPlusMinusNum3.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // rdoPlusMinusNum2
            // 
            this.rdoPlusMinusNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoPlusMinusNum2.AutoSize = true;
            this.rdoPlusMinusNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPlusMinusNum2.ForeColor = System.Drawing.Color.White;
            this.rdoPlusMinusNum2.Location = new System.Drawing.Point(260, 405);
            this.rdoPlusMinusNum2.Name = "rdoPlusMinusNum2";
            this.rdoPlusMinusNum2.Size = new System.Drawing.Size(122, 24);
            this.rdoPlusMinusNum2.TabIndex = 22;
            this.rdoPlusMinusNum2.Text = "Cộng trừ 2 số";
            this.rdoPlusMinusNum2.UseVisualStyleBackColor = true;
            this.rdoPlusMinusNum2.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // rdoDivideNum2
            // 
            this.rdoDivideNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDivideNum2.AutoSize = true;
            this.rdoDivideNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDivideNum2.ForeColor = System.Drawing.Color.White;
            this.rdoDivideNum2.Location = new System.Drawing.Point(412, 405);
            this.rdoDivideNum2.Name = "rdoDivideNum2";
            this.rdoDivideNum2.Size = new System.Drawing.Size(93, 24);
            this.rdoDivideNum2.TabIndex = 25;
            this.rdoDivideNum2.Text = "Chia 2 số";
            this.rdoDivideNum2.UseVisualStyleBackColor = true;
            this.rdoDivideNum2.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // rdoMultipleNum2
            // 
            this.rdoMultipleNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoMultipleNum2.AutoSize = true;
            this.rdoMultipleNum2.Checked = true;
            this.rdoMultipleNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMultipleNum2.ForeColor = System.Drawing.Color.White;
            this.rdoMultipleNum2.Location = new System.Drawing.Point(410, 342);
            this.rdoMultipleNum2.Name = "rdoMultipleNum2";
            this.rdoMultipleNum2.Size = new System.Drawing.Size(99, 24);
            this.rdoMultipleNum2.TabIndex = 24;
            this.rdoMultipleNum2.TabStop = true;
            this.rdoMultipleNum2.Text = "Nhân 2 số";
            this.rdoMultipleNum2.UseVisualStyleBackColor = true;
            this.rdoMultipleNum2.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // minNum2
            // 
            this.minNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNum2.Location = new System.Drawing.Point(728, 365);
            this.minNum2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minNum2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNum2.Name = "minNum2";
            this.minNum2.Size = new System.Drawing.Size(57, 22);
            this.minNum2.TabIndex = 29;
            this.minNum2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(724, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số nhỏ nhất 2";
            // 
            // maxNum2
            // 
            this.maxNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNum2.Location = new System.Drawing.Point(728, 421);
            this.maxNum2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxNum2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxNum2.Name = "maxNum2";
            this.maxNum2.Size = new System.Drawing.Size(57, 22);
            this.maxNum2.TabIndex = 27;
            this.maxNum2.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(725, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số lớn nhất 2";
            // 
            // minNum3
            // 
            this.minNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNum3.Location = new System.Drawing.Point(854, 365);
            this.minNum3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minNum3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNum3.Name = "minNum3";
            this.minNum3.Size = new System.Drawing.Size(57, 22);
            this.minNum3.TabIndex = 33;
            this.minNum3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(849, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số nhỏ nhất 3";
            // 
            // maxNum3
            // 
            this.maxNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNum3.Location = new System.Drawing.Point(854, 421);
            this.maxNum3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxNum3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxNum3.Name = "maxNum3";
            this.maxNum3.Size = new System.Drawing.Size(57, 22);
            this.maxNum3.TabIndex = 31;
            this.maxNum3.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(851, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số lớn nhất 3";
            // 
            // chkPlayBackground
            // 
            this.chkPlayBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPlayBackground.AutoSize = true;
            this.chkPlayBackground.Checked = true;
            this.chkPlayBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlayBackground.ForeColor = System.Drawing.Color.White;
            this.chkPlayBackground.Location = new System.Drawing.Point(1026, 431);
            this.chkPlayBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPlayBackground.Name = "chkPlayBackground";
            this.chkPlayBackground.Size = new System.Drawing.Size(65, 24);
            this.chkPlayBackground.TabIndex = 34;
            this.chkPlayBackground.Text = "Nhạc";
            this.chkPlayBackground.UseVisualStyleBackColor = true;
            // 
            // rdoBangCuuChuong
            // 
            this.rdoBangCuuChuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoBangCuuChuong.AutoSize = true;
            this.rdoBangCuuChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBangCuuChuong.ForeColor = System.Drawing.Color.White;
            this.rdoBangCuuChuong.Location = new System.Drawing.Point(412, 373);
            this.rdoBangCuuChuong.Name = "rdoBangCuuChuong";
            this.rdoBangCuuChuong.Size = new System.Drawing.Size(152, 24);
            this.rdoBangCuuChuong.TabIndex = 35;
            this.rdoBangCuuChuong.Text = "Bảng cửu chương";
            this.rdoBangCuuChuong.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1138, 466);
            this.Controls.Add(this.rdoBangCuuChuong);
            this.Controls.Add(this.chkPlayBackground);
            this.Controls.Add(this.minNum3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxNum3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minNum2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxNum2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdoDivideNum2);
            this.Controls.Add(this.rdoMultipleNum2);
            this.Controls.Add(this.rdoPlusMinusNum3);
            this.Controls.Add(this.rdoPlusMinusNum2);
            this.Controls.Add(this.minNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTimeStartNewOps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoPlusNum3);
            this.Controls.Add(this.rdoPlusNum2);
            this.Controls.Add(this.delayTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnl1);
            this.MinimumSize = new System.Drawing.Size(1028, 505);
            this.Name = "frmMain";
            this.Text = "Làm toán vui - Phép cộng trừ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartNewOps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblOp12;
        private System.Windows.Forms.Label lblNum12;
        private System.Windows.Forms.Label lblOp11;
        private System.Windows.Forms.Label lblNum11;
        private System.Windows.Forms.Label lblNum13;
        private System.Windows.Forms.Label lblNum14;
        private System.Windows.Forms.Label lblOp13;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown delayTime;
        private System.Windows.Forms.RadioButton rdoPlusNum2;
        private System.Windows.Forms.RadioButton rdoPlusNum3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numTimeStartNewOps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown maxNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoPlusMinusNum3;
        private System.Windows.Forms.RadioButton rdoPlusMinusNum2;
        private System.Windows.Forms.RadioButton rdoDivideNum2;
        private System.Windows.Forms.RadioButton rdoMultipleNum2;
        private System.Windows.Forms.NumericUpDown minNum2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxNum2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minNum3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxNum3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkPlayBackground;
        private System.Windows.Forms.RadioButton rdoBangCuuChuong;
    }
}

