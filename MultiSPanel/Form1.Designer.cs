namespace MultiSPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Hide = new System.Windows.Forms.Button();
            this.sliding1 = new System.Windows.Forms.Panel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hide2 = new System.Windows.Forms.Button();
            this.sliding2 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hide3 = new System.Windows.Forms.Button();
            this.sliding3 = new System.Windows.Forms.Panel();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hide4 = new System.Windows.Forms.Button();
            this.sliding4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.sliding1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sliding2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sliding3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.sliding4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Hide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 38);
            this.panel5.TabIndex = 2;
            // 
            // Hide
            // 
            this.Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide.BackgroundImage")));
            this.Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Hide.FlatAppearance.BorderSize = 0;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.ForeColor = System.Drawing.Color.White;
            this.Hide.Location = new System.Drawing.Point(0, 38);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(229, 29);
            this.Hide.TabIndex = 0;
            this.Hide.Text = "▲";
            this.Hide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.button1_Click);
            this.Hide.MouseLeave += new System.EventHandler(this.Hide_MouseLeave);
            this.Hide.MouseHover += new System.EventHandler(this.Hide_MouseHover);
            // 
            // sliding1
            // 
            this.sliding1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.sliding1.Controls.Add(this.domainUpDown1);
            this.sliding1.Controls.Add(this.checkBox4);
            this.sliding1.Controls.Add(this.checkBox1);
            this.sliding1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliding1.Location = new System.Drawing.Point(0, 67);
            this.sliding1.Name = "sliding1";
            this.sliding1.Size = new System.Drawing.Size(229, 86);
            this.sliding1.TabIndex = 1;
            this.sliding1.Paint += new System.Windows.Forms.PaintEventHandler(this.sliding1_Paint);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.domainUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.domainUpDown1.Location = new System.Drawing.Point(9, 6);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(65, 23);
            this.domainUpDown1.TabIndex = 5;
            this.domainUpDown1.Text = "domainUpDown1";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox4.Location = new System.Drawing.Point(9, 61);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 20);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(9, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox3.Location = new System.Drawing.Point(10, 136);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "ITEM ESP";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Lato Hairline", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox2.Location = new System.Drawing.Point(10, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "ESP";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.hide2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 27);
            this.panel2.TabIndex = 2;
            // 
            // hide2
            // 
            this.hide2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide2.BackgroundImage")));
            this.hide2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide2.FlatAppearance.BorderSize = 0;
            this.hide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide2.ForeColor = System.Drawing.Color.Snow;
            this.hide2.Location = new System.Drawing.Point(0, 0);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(229, 27);
            this.hide2.TabIndex = 0;
            this.hide2.Text = "▲";
            this.hide2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hide2.UseVisualStyleBackColor = true;
            this.hide2.MouseLeave += new System.EventHandler(this.hide2_MouseLeave);
            this.hide2.MouseHover += new System.EventHandler(this.hide2_MouseHover);
            // 
            // sliding2
            // 
            this.sliding2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.sliding2.Controls.Add(this.checkBox5);
            this.sliding2.Controls.Add(this.checkBox6);
            this.sliding2.Controls.Add(this.checkBox3);
            this.sliding2.Controls.Add(this.comboBox1);
            this.sliding2.Controls.Add(this.checkBox11);
            this.sliding2.Controls.Add(this.checkBox2);
            this.sliding2.Controls.Add(this.checkBox7);
            this.sliding2.Controls.Add(this.checkBox8);
            this.sliding2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliding2.Location = new System.Drawing.Point(0, 180);
            this.sliding2.Name = "sliding2";
            this.sliding2.Size = new System.Drawing.Size(229, 207);
            this.sliding2.TabIndex = 3;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox5.Location = new System.Drawing.Point(10, 89);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Health";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox6.Location = new System.Drawing.Point(121, 37);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 20);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Distance";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox11.Location = new System.Drawing.Point(121, 63);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(51, 20);
            this.checkBox11.TabIndex = 2;
            this.checkBox11.Text = "Line";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox7.Location = new System.Drawing.Point(10, 37);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(70, 20);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "2D Box";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox8.Location = new System.Drawing.Point(10, 63);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(60, 20);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Text = "Name";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.hide3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 27);
            this.panel3.TabIndex = 4;
            // 
            // hide3
            // 
            this.hide3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide3.BackgroundImage")));
            this.hide3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide3.FlatAppearance.BorderSize = 0;
            this.hide3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide3.ForeColor = System.Drawing.Color.Snow;
            this.hide3.Location = new System.Drawing.Point(0, 0);
            this.hide3.Name = "hide3";
            this.hide3.Size = new System.Drawing.Size(229, 27);
            this.hide3.TabIndex = 0;
            this.hide3.Text = "▲";
            this.hide3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hide3.UseVisualStyleBackColor = true;
            this.hide3.MouseLeave += new System.EventHandler(this.hide3_MouseLeave);
            this.hide3.MouseHover += new System.EventHandler(this.hide3_MouseHover);
            // 
            // sliding3
            // 
            this.sliding3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.sliding3.Controls.Add(this.checkBox9);
            this.sliding3.Controls.Add(this.checkBox10);
            this.sliding3.Controls.Add(this.checkBox12);
            this.sliding3.Controls.Add(this.checkBox15);
            this.sliding3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliding3.Location = new System.Drawing.Point(0, 414);
            this.sliding3.Name = "sliding3";
            this.sliding3.Size = new System.Drawing.Size(229, 82);
            this.sliding3.TabIndex = 5;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox9.Location = new System.Drawing.Point(10, 20);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(78, 20);
            this.checkBox9.TabIndex = 4;
            this.checkBox9.Text = "NoRecoil";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox10.Location = new System.Drawing.Point(126, 46);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(73, 20);
            this.checkBox10.TabIndex = 3;
            this.checkBox10.Text = "NoSway";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox12.Location = new System.Drawing.Point(10, 46);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(82, 20);
            this.checkBox12.TabIndex = 1;
            this.checkBox12.Text = "NoSpread";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.checkBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.checkBox15.Location = new System.Drawing.Point(126, 20);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(104, 20);
            this.checkBox15.TabIndex = 2;
            this.checkBox15.Text = "FastProjectiles";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.hide4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 27);
            this.panel4.TabIndex = 6;
            // 
            // hide4
            // 
            this.hide4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide4.BackgroundImage")));
            this.hide4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide4.FlatAppearance.BorderSize = 0;
            this.hide4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide4.ForeColor = System.Drawing.Color.Snow;
            this.hide4.Location = new System.Drawing.Point(0, 0);
            this.hide4.Name = "hide4";
            this.hide4.Size = new System.Drawing.Size(229, 27);
            this.hide4.TabIndex = 0;
            this.hide4.Text = "▲";
            this.hide4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hide4.UseVisualStyleBackColor = true;
            this.hide4.MouseLeave += new System.EventHandler(this.hide4_MouseLeave);
            this.hide4.MouseHover += new System.EventHandler(this.hide4_MouseHover);
            // 
            // sliding4
            // 
            this.sliding4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.sliding4.Controls.Add(this.button1);
            this.sliding4.Controls.Add(this.label2);
            this.sliding4.Controls.Add(this.label1);
            this.sliding4.Controls.Add(this.trackBar2);
            this.sliding4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliding4.Location = new System.Drawing.Point(0, 523);
            this.sliding4.Name = "sliding4";
            this.sliding4.Size = new System.Drawing.Size(229, 113);
            this.sliding4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::MultiSPanel.Properties.Resources.signin;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(51, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save config";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "FPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Hairline", 9.749999F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "← Performance        Quality →";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 38);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(205, 45);
            this.trackBar2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(229, 784);
            this.Controls.Add(this.sliding4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sliding3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sliding2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sliding1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.sliding1.ResumeLayout(false);
            this.sliding1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sliding2.ResumeLayout(false);
            this.sliding2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.sliding3.ResumeLayout(false);
            this.sliding3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.sliding4.ResumeLayout(false);
            this.sliding4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sliding1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hide2;
        private System.Windows.Forms.Panel sliding2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button hide3;
        private System.Windows.Forms.Panel sliding3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button hide4;
        private System.Windows.Forms.Panel sliding4;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

