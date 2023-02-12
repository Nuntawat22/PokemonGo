namespace PokemonGo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHp2 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Hp2 = new System.Windows.Forms.Button();
            this.At1 = new System.Windows.Forms.Button();
            this.Df2 = new System.Windows.Forms.Button();
            this.Hp4 = new System.Windows.Forms.Button();
            this.At2 = new System.Windows.Forms.Button();
            this.Hp3 = new System.Windows.Forms.Button();
            this.Df1 = new System.Windows.Forms.Button();
            this.Hp1 = new System.Windows.Forms.Button();
            this.At3 = new System.Windows.Forms.Button();
            this.At4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokemonGo.Properties.Resources.Pokemon02;
            this.pictureBox2.Location = new System.Drawing.Point(487, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(133, 189);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 2;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(133, 218);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(100, 23);
            this.tbHp.TabIndex = 3;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(38, 30);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(109, 23);
            this.add1.TabIndex = 4;
            this.add1.Text = "Add Pokemon";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(38, 59);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(109, 23);
            this.add2.TabIndex = 5;
            this.add2.Text = "Add Pokemon";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(38, 88);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(109, 23);
            this.add3.TabIndex = 6;
            this.add3.Text = "Add Pokemon";
            this.add3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add4);
            this.groupBox1.Controls.Add(this.add1);
            this.groupBox1.Controls.Add(this.add3);
            this.groupBox1.Controls.Add(this.add2);
            this.groupBox1.Location = new System.Drawing.Point(77, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My pokemon";
            // 
            // add4
            // 
            this.add4.Location = new System.Drawing.Point(38, 117);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(109, 23);
            this.add4.TabIndex = 7;
            this.add4.Text = "Add Pokemon";
            this.add4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            // 
            // tbHp2
            // 
            this.tbHp2.Location = new System.Drawing.Point(554, 218);
            this.tbHp2.Name = "tbHp2";
            this.tbHp2.Size = new System.Drawing.Size(100, 23);
            this.tbHp2.TabIndex = 12;
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(554, 189);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(100, 23);
            this.tbName2.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Hp2);
            this.groupBox2.Controls.Add(this.At1);
            this.groupBox2.Controls.Add(this.Df2);
            this.groupBox2.Controls.Add(this.Hp4);
            this.groupBox2.Controls.Add(this.At2);
            this.groupBox2.Controls.Add(this.Hp3);
            this.groupBox2.Controls.Add(this.Df1);
            this.groupBox2.Controls.Add(this.Hp1);
            this.groupBox2.Controls.Add(this.At3);
            this.groupBox2.Controls.Add(this.At4);
            this.groupBox2.Location = new System.Drawing.Point(334, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 192);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "command";
            // 
            // Hp2
            // 
            this.Hp2.Location = new System.Drawing.Point(194, 98);
            this.Hp2.Name = "Hp2";
            this.Hp2.Size = new System.Drawing.Size(109, 23);
            this.Hp2.TabIndex = 15;
            this.Hp2.Text = "HP + 50";
            this.Hp2.UseVisualStyleBackColor = true;
            // 
            // At1
            // 
            this.At1.Location = new System.Drawing.Point(38, 30);
            this.At1.Name = "At1";
            this.At1.Size = new System.Drawing.Size(109, 23);
            this.At1.TabIndex = 4;
            this.At1.Text = "Attack";
            this.At1.UseVisualStyleBackColor = true;
            this.At1.Click += new System.EventHandler(this.button6_Click);
            // 
            // Df2
            // 
            this.Df2.Location = new System.Drawing.Point(194, 161);
            this.Df2.Name = "Df2";
            this.Df2.Size = new System.Drawing.Size(109, 23);
            this.Df2.TabIndex = 18;
            this.Df2.Text = "Defense +50";
            this.Df2.UseVisualStyleBackColor = true;
            // 
            // Hp4
            // 
            this.Hp4.Location = new System.Drawing.Point(194, 127);
            this.Hp4.Name = "Hp4";
            this.Hp4.Size = new System.Drawing.Size(109, 23);
            this.Hp4.TabIndex = 16;
            this.Hp4.Text = "HP + 50";
            this.Hp4.UseVisualStyleBackColor = true;
            // 
            // At2
            // 
            this.At2.Location = new System.Drawing.Point(194, 30);
            this.At2.Name = "At2";
            this.At2.Size = new System.Drawing.Size(109, 23);
            this.At2.TabIndex = 12;
            this.At2.Text = "Atack";
            this.At2.UseVisualStyleBackColor = true;
            // 
            // Hp3
            // 
            this.Hp3.Location = new System.Drawing.Point(38, 127);
            this.Hp3.Name = "Hp3";
            this.Hp3.Size = new System.Drawing.Size(109, 23);
            this.Hp3.TabIndex = 17;
            this.Hp3.Text = "HP + 50";
            this.Hp3.UseVisualStyleBackColor = true;
            // 
            // Df1
            // 
            this.Df1.Location = new System.Drawing.Point(38, 161);
            this.Df1.Name = "Df1";
            this.Df1.Size = new System.Drawing.Size(109, 23);
            this.Df1.TabIndex = 6;
            this.Df1.Text = "Defense + 50";
            this.Df1.UseVisualStyleBackColor = true;
            // 
            // Hp1
            // 
            this.Hp1.Location = new System.Drawing.Point(38, 98);
            this.Hp1.Name = "Hp1";
            this.Hp1.Size = new System.Drawing.Size(109, 23);
            this.Hp1.TabIndex = 5;
            this.Hp1.Text = "HP + 50";
            this.Hp1.UseVisualStyleBackColor = true;
            // 
            // At3
            // 
            this.At3.Location = new System.Drawing.Point(38, 59);
            this.At3.Name = "At3";
            this.At3.Size = new System.Drawing.Size(109, 23);
            this.At3.TabIndex = 14;
            this.At3.Text = "Atack";
            this.At3.UseVisualStyleBackColor = true;
            // 
            // At4
            // 
            this.At4.Location = new System.Drawing.Point(194, 59);
            this.At4.Name = "At4";
            this.At4.Size = new System.Drawing.Size(109, 23);
            this.At4.TabIndex = 13;
            this.At4.Text = "Atack";
            this.At4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHp2);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbName;
        private TextBox tbHp;
        private Button add1;
        private Button add2;
        private Button add3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbHp2;
        private TextBox tbName2;
        private GroupBox groupBox2;
        private Button At1;
        private Button Df1;
        private Button Hp1;
        private Button Hp2;
        private Button Df2;
        private Button Hp4;
        private Button At2;
        private Button Hp3;
        private Button At3;
        private Button At4;
        private Button add4;
    }
}