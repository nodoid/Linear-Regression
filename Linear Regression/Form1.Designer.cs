namespace Linear_Regression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.datain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.analysis = new System.Windows.Forms.TabPage();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.r2 = new System.Windows.Forms.Label();
            this.stddev = new System.Windows.Forms.Label();
            this.Eyybar2 = new System.Windows.Forms.Label();
            this.exxbar2 = new System.Windows.Forms.Label();
            this.Exxbaryybar = new System.Windows.Forms.Label();
            this.eyybar = new System.Windows.Forms.Label();
            this.exxbar = new System.Windows.Forms.Label();
            this.ybar = new System.Windows.Forms.Label();
            this.xbar = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.mgrad = new System.Windows.Forms.Label();
            this.ex2 = new System.Windows.Forms.Label();
            this.ex2brace = new System.Windows.Forms.Label();
            this.exy = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.ey = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ex = new System.Windows.Forms.Label();
            this.regress = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.datain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.datain);
            this.tabControl1.Controls.Add(this.analysis);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // datain
            // 
            this.datain.AutoScroll = true;
            this.datain.Controls.Add(this.tableLayoutPanel3);
            this.datain.Controls.Add(this.tableLayoutPanel2);
            this.datain.Controls.Add(this.tableLayoutPanel1);
            this.datain.Location = new System.Drawing.Point(4, 22);
            this.datain.Name = "datain";
            this.datain.Padding = new System.Windows.Forms.Padding(3);
            this.datain.Size = new System.Drawing.Size(660, 489);
            this.datain.TabIndex = 0;
            this.datain.Text = "Initial Data";
            this.datain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(448, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 23;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 464);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "\"y\" Data";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "\"x\" Data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(227, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 23;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 464);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"y\" Data";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"x\" Data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 23;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"y\" Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"x\" Data";
            // 
            // analysis
            // 
            this.analysis.AutoScroll = true;
            this.analysis.Controls.Add(this.label42);
            this.analysis.Controls.Add(this.label41);
            this.analysis.Controls.Add(this.pictureBox2);
            this.analysis.Controls.Add(this.tableLayoutPanel4);
            this.analysis.Location = new System.Drawing.Point(4, 22);
            this.analysis.Name = "analysis";
            this.analysis.Padding = new System.Windows.Forms.Padding(3);
            this.analysis.Size = new System.Drawing.Size(660, 489);
            this.analysis.TabIndex = 1;
            this.analysis.Text = "Analysis";
            this.analysis.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(379, 450);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(237, 13);
            this.label42.TabIndex = 4;
            this.label42.Text = "(c) 2011 Paul F. Johnson";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(139, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Results table";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Linear_Regression.Properties.Resources.forensicscience;
            this.pictureBox2.Location = new System.Drawing.Point(365, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.r2, 1, 16);
            this.tableLayoutPanel4.Controls.Add(this.stddev, 1, 15);
            this.tableLayoutPanel4.Controls.Add(this.Eyybar2, 1, 14);
            this.tableLayoutPanel4.Controls.Add(this.exxbar2, 1, 13);
            this.tableLayoutPanel4.Controls.Add(this.Exxbaryybar, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.eyybar, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.exxbar, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.ybar, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.xbar, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.c, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.mgrad, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.ex2, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.ex2brace, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.exy, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.n, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.ey, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 12);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 13);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 14);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 15);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 16);
            this.tableLayoutPanel4.Controls.Add(this.ex, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(51, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 17;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(245, 342);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // r2
            // 
            this.r2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(177, 324);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(13, 13);
            this.r2.TabIndex = 33;
            this.r2.Text = "0";
            // 
            // stddev
            // 
            this.stddev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stddev.AutoSize = true;
            this.stddev.Location = new System.Drawing.Point(177, 303);
            this.stddev.Name = "stddev";
            this.stddev.Size = new System.Drawing.Size(13, 13);
            this.stddev.TabIndex = 32;
            this.stddev.Text = "0";
            // 
            // Eyybar2
            // 
            this.Eyybar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eyybar2.AutoSize = true;
            this.Eyybar2.Location = new System.Drawing.Point(177, 283);
            this.Eyybar2.Name = "Eyybar2";
            this.Eyybar2.Size = new System.Drawing.Size(13, 13);
            this.Eyybar2.TabIndex = 31;
            this.Eyybar2.Text = "0";
            // 
            // exxbar2
            // 
            this.exxbar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exxbar2.AutoSize = true;
            this.exxbar2.Location = new System.Drawing.Point(177, 263);
            this.exxbar2.Name = "exxbar2";
            this.exxbar2.Size = new System.Drawing.Size(13, 13);
            this.exxbar2.TabIndex = 30;
            this.exxbar2.Text = "0";
            // 
            // Exxbaryybar
            // 
            this.Exxbaryybar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exxbaryybar.AutoSize = true;
            this.Exxbaryybar.Location = new System.Drawing.Point(177, 243);
            this.Exxbaryybar.Name = "Exxbaryybar";
            this.Exxbaryybar.Size = new System.Drawing.Size(13, 13);
            this.Exxbaryybar.TabIndex = 29;
            this.Exxbaryybar.Text = "0";
            // 
            // eyybar
            // 
            this.eyybar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eyybar.AutoSize = true;
            this.eyybar.Location = new System.Drawing.Point(177, 223);
            this.eyybar.Name = "eyybar";
            this.eyybar.Size = new System.Drawing.Size(13, 13);
            this.eyybar.TabIndex = 28;
            this.eyybar.Text = "0";
            // 
            // exxbar
            // 
            this.exxbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exxbar.AutoSize = true;
            this.exxbar.Location = new System.Drawing.Point(177, 203);
            this.exxbar.Name = "exxbar";
            this.exxbar.Size = new System.Drawing.Size(13, 13);
            this.exxbar.TabIndex = 27;
            this.exxbar.Text = "0";
            // 
            // ybar
            // 
            this.ybar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ybar.AutoSize = true;
            this.ybar.Location = new System.Drawing.Point(177, 183);
            this.ybar.Name = "ybar";
            this.ybar.Size = new System.Drawing.Size(13, 13);
            this.ybar.TabIndex = 26;
            this.ybar.Text = "0";
            // 
            // xbar
            // 
            this.xbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xbar.AutoSize = true;
            this.xbar.Location = new System.Drawing.Point(177, 163);
            this.xbar.Name = "xbar";
            this.xbar.Size = new System.Drawing.Size(13, 13);
            this.xbar.TabIndex = 25;
            this.xbar.Text = "0";
            // 
            // c
            // 
            this.c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(177, 143);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(13, 13);
            this.c.TabIndex = 24;
            this.c.Text = "0";
            // 
            // mgrad
            // 
            this.mgrad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mgrad.AutoSize = true;
            this.mgrad.Location = new System.Drawing.Point(177, 123);
            this.mgrad.Name = "mgrad";
            this.mgrad.Size = new System.Drawing.Size(13, 13);
            this.mgrad.TabIndex = 23;
            this.mgrad.Text = "0";
            // 
            // ex2
            // 
            this.ex2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ex2.AutoSize = true;
            this.ex2.Location = new System.Drawing.Point(177, 103);
            this.ex2.Name = "ex2";
            this.ex2.Size = new System.Drawing.Size(13, 13);
            this.ex2.TabIndex = 22;
            this.ex2.Text = "0";
            // 
            // ex2brace
            // 
            this.ex2brace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ex2brace.AutoSize = true;
            this.ex2brace.Location = new System.Drawing.Point(177, 83);
            this.ex2brace.Name = "ex2brace";
            this.ex2brace.Size = new System.Drawing.Size(13, 13);
            this.ex2brace.TabIndex = 21;
            this.ex2brace.Text = "0";
            // 
            // exy
            // 
            this.exy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exy.AutoSize = true;
            this.exy.Location = new System.Drawing.Point(177, 63);
            this.exy.Name = "exy";
            this.exy.Size = new System.Drawing.Size(13, 13);
            this.exy.TabIndex = 20;
            this.exy.Text = "0";
            // 
            // n
            // 
            this.n.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(177, 43);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(13, 13);
            this.n.TabIndex = 19;
            this.n.Text = "0";
            // 
            // ey
            // 
            this.ey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ey.AutoSize = true;
            this.ey.Location = new System.Drawing.Point(177, 23);
            this.ey.Name = "ey";
            this.ey.Size = new System.Drawing.Size(13, 13);
            this.ey.TabIndex = 18;
            this.ey.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ex";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ey";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "n";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Exy";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "(Ex)^2";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ex^2";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "m (gradient)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "c (intercept on y)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Average x";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Average y";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "E(x - ave x)";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "E(y - ave y)";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "E(x - ave x)(y - ave y)";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 263);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "E(x - ave x)^2";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 283);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "E(y - ave y)^2";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 303);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Standard deviation";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(50, 324);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "r^2";
            // 
            // ex
            // 
            this.ex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(177, 3);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(13, 13);
            this.ex.TabIndex = 17;
            this.ex.Text = "0";
            // 
            // regress
            // 
            this.regress.Enabled = false;
            this.regress.Location = new System.Drawing.Point(567, 534);
            this.regress.Name = "regress";
            this.regress.Size = new System.Drawing.Size(114, 23);
            this.regress.TabIndex = 1;
            this.regress.Text = "Perform regression";
            this.regress.UseVisualStyleBackColor = true;
            this.regress.Click += new System.EventHandler(this.regress_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(486, 534);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Clear data";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 565);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.regress);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Linear Regression";
            this.tabControl1.ResumeLayout(false);
            this.datain.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.analysis.ResumeLayout(false);
            this.analysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage datain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage analysis;
        private System.Windows.Forms.Button regress;
        private System.Windows.Forms.Button cancel;
        private NumberBox[] data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label r2;
        private System.Windows.Forms.Label stddev;
        private System.Windows.Forms.Label Eyybar2;
        private System.Windows.Forms.Label exxbar2;
        private System.Windows.Forms.Label Exxbaryybar;
        private System.Windows.Forms.Label eyybar;
        private System.Windows.Forms.Label exxbar;
        private System.Windows.Forms.Label ybar;
        private System.Windows.Forms.Label xbar;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label mgrad;
        private System.Windows.Forms.Label ex2;
        private System.Windows.Forms.Label ex2brace;
        private System.Windows.Forms.Label exy;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label ey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label ex;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

