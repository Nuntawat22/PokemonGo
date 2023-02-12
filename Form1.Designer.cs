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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHp2 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.At1 = new System.Windows.Forms.Button();
            this.Df1 = new System.Windows.Forms.Button();
            this.Hp1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
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
            this.add1.Text = "Charmander";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(38, 59);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(109, 23);
            this.add2.TabIndex = 5;
            this.add2.Text = "Charmelon";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(38, 88);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(109, 23);
            this.add3.TabIndex = 6;
            this.add3.Text = "Pichu";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add1);
            this.groupBox1.Controls.Add(this.add3);
            this.groupBox1.Controls.Add(this.add2);
            this.groupBox1.Location = new System.Drawing.Point(77, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My pokemon";
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
            this.groupBox2.Controls.Add(this.At1);
            this.groupBox2.Controls.Add(this.Df1);
            this.groupBox2.Controls.Add(this.Hp1);
            this.groupBox2.Location = new System.Drawing.Point(487, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "command";
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
            // Df1
            // 
            this.Df1.Location = new System.Drawing.Point(38, 88);
            this.Df1.Name = "Df1";
            this.Df1.Size = new System.Drawing.Size(109, 23);
            this.Df1.TabIndex = 6;
            this.Df1.Text = "Defense + 50";
            this.Df1.UseVisualStyleBackColor = true;
            this.Df1.Click += new System.EventHandler(this.Df1_Click);
            // 
            // Hp1
            // 
            this.Hp1.Location = new System.Drawing.Point(38, 59);
            this.Hp1.Name = "Hp1";
            this.Hp1.Size = new System.Drawing.Size(109, 23);
            this.Hp1.TabIndex = 5;
            this.Hp1.Text = "HP + 50";
            this.Hp1.UseVisualStyleBackColor = true;
            this.Hp1.Click += new System.EventHandler(this.Hp1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 461);
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
    }
}