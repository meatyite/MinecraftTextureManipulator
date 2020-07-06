namespace MinecraftTextureManipulator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.num_saturation = new System.Windows.Forms.NumericUpDown();
            this.num_contrast = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check_bw = new System.Windows.Forms.CheckBox();
            this.check_comic = new System.Windows.Forms.CheckBox();
            this.check_gotham = new System.Windows.Forms.CheckBox();
            this.check_greyscale = new System.Windows.Forms.CheckBox();
            this.check_invert = new System.Windows.Forms.CheckBox();
            this.check_lomograph = new System.Windows.Forms.CheckBox();
            this.check_polaroid = new System.Windows.Forms.CheckBox();
            this.check_sepia = new System.Windows.Forms.CheckBox();
            this.num_seed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_random = new System.Windows.Forms.Button();
            this.num_brightness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_onlyflower = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_seed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Resource Pack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Choose Source Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Choose Save Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // num_saturation
            // 
            this.num_saturation.Location = new System.Drawing.Point(185, 125);
            this.num_saturation.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_saturation.Name = "num_saturation";
            this.num_saturation.Size = new System.Drawing.Size(86, 20);
            this.num_saturation.TabIndex = 4;
            // 
            // num_contrast
            // 
            this.num_contrast.Location = new System.Drawing.Point(185, 151);
            this.num_contrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_contrast.Name = "num_contrast";
            this.num_contrast.Size = new System.Drawing.Size(86, 20);
            this.num_contrast.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saturation (Percentage, -100 to 100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contrast (Percentage, -100 to 100)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filters:";
            // 
            // check_bw
            // 
            this.check_bw.AutoSize = true;
            this.check_bw.Location = new System.Drawing.Point(3, 188);
            this.check_bw.Name = "check_bw";
            this.check_bw.Size = new System.Drawing.Size(105, 17);
            this.check_bw.TabIndex = 9;
            this.check_bw.Text = "Black and White";
            this.check_bw.UseVisualStyleBackColor = true;
            // 
            // check_comic
            // 
            this.check_comic.AutoSize = true;
            this.check_comic.Location = new System.Drawing.Point(3, 211);
            this.check_comic.Name = "check_comic";
            this.check_comic.Size = new System.Drawing.Size(83, 17);
            this.check_comic.TabIndex = 10;
            this.check_comic.Text = "Comic Book";
            this.check_comic.UseVisualStyleBackColor = true;
            // 
            // check_gotham
            // 
            this.check_gotham.AutoSize = true;
            this.check_gotham.Location = new System.Drawing.Point(3, 234);
            this.check_gotham.Name = "check_gotham";
            this.check_gotham.Size = new System.Drawing.Size(63, 17);
            this.check_gotham.TabIndex = 11;
            this.check_gotham.Text = "Gotham";
            this.check_gotham.UseVisualStyleBackColor = true;
            // 
            // check_greyscale
            // 
            this.check_greyscale.AutoSize = true;
            this.check_greyscale.Location = new System.Drawing.Point(3, 257);
            this.check_greyscale.Name = "check_greyscale";
            this.check_greyscale.Size = new System.Drawing.Size(73, 17);
            this.check_greyscale.TabIndex = 12;
            this.check_greyscale.Text = "Greyscale";
            this.check_greyscale.UseVisualStyleBackColor = true;
            // 
            // check_invert
            // 
            this.check_invert.AutoSize = true;
            this.check_invert.Location = new System.Drawing.Point(3, 280);
            this.check_invert.Name = "check_invert";
            this.check_invert.Size = new System.Drawing.Size(53, 17);
            this.check_invert.TabIndex = 13;
            this.check_invert.Text = "Invert";
            this.check_invert.UseVisualStyleBackColor = true;
            // 
            // check_lomograph
            // 
            this.check_lomograph.AutoSize = true;
            this.check_lomograph.Location = new System.Drawing.Point(3, 303);
            this.check_lomograph.Name = "check_lomograph";
            this.check_lomograph.Size = new System.Drawing.Size(79, 17);
            this.check_lomograph.TabIndex = 14;
            this.check_lomograph.Text = "Lomograph";
            this.check_lomograph.UseVisualStyleBackColor = true;
            // 
            // check_polaroid
            // 
            this.check_polaroid.AutoSize = true;
            this.check_polaroid.Location = new System.Drawing.Point(3, 326);
            this.check_polaroid.Name = "check_polaroid";
            this.check_polaroid.Size = new System.Drawing.Size(64, 17);
            this.check_polaroid.TabIndex = 15;
            this.check_polaroid.Text = "Polaroid";
            this.check_polaroid.UseVisualStyleBackColor = true;
            // 
            // check_sepia
            // 
            this.check_sepia.AutoSize = true;
            this.check_sepia.Location = new System.Drawing.Point(3, 349);
            this.check_sepia.Name = "check_sepia";
            this.check_sepia.Size = new System.Drawing.Size(53, 17);
            this.check_sepia.TabIndex = 16;
            this.check_sepia.Text = "Sepia";
            this.check_sepia.UseVisualStyleBackColor = true;
            // 
            // num_seed
            // 
            this.num_seed.Location = new System.Drawing.Point(668, 171);
            this.num_seed.Name = "num_seed";
            this.num_seed.Size = new System.Drawing.Size(120, 20);
            this.num_seed.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Random Seed (0 for none):";
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(542, 141);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(120, 25);
            this.btn_random.TabIndex = 19;
            this.btn_random.Text = "Random Settings";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // num_brightness
            // 
            this.num_brightness.Location = new System.Drawing.Point(185, 99);
            this.num_brightness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_brightness.Name = "num_brightness";
            this.num_brightness.Size = new System.Drawing.Size(86, 20);
            this.num_brightness.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Brightness (Percentage, -100 to 100)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 25);
            this.button4.TabIndex = 22;
            this.button4.Text = "Reset Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pack Description:";
            // 
            // check_onlyflower
            // 
            this.check_onlyflower.AutoSize = true;
            this.check_onlyflower.Location = new System.Drawing.Point(277, 126);
            this.check_onlyflower.Name = "check_onlyflower";
            this.check_onlyflower.Size = new System.Drawing.Size(98, 17);
            this.check_onlyflower.TabIndex = 25;
            this.check_onlyflower.Text = "Only for flowers";
            this.check_onlyflower.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.check_onlyflower);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_brightness);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_seed);
            this.Controls.Add(this.check_sepia);
            this.Controls.Add(this.check_polaroid);
            this.Controls.Add(this.check_lomograph);
            this.Controls.Add(this.check_invert);
            this.Controls.Add(this.check_greyscale);
            this.Controls.Add(this.check_gotham);
            this.Controls.Add(this.check_comic);
            this.Controls.Add(this.check_bw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_contrast);
            this.Controls.Add(this.num_saturation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Texture Manipulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_seed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_brightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown num_saturation;
        private System.Windows.Forms.NumericUpDown num_contrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_bw;
        private System.Windows.Forms.CheckBox check_comic;
        private System.Windows.Forms.CheckBox check_gotham;
        private System.Windows.Forms.CheckBox check_greyscale;
        private System.Windows.Forms.CheckBox check_invert;
        private System.Windows.Forms.CheckBox check_lomograph;
        private System.Windows.Forms.CheckBox check_polaroid;
        private System.Windows.Forms.CheckBox check_sepia;
        private System.Windows.Forms.NumericUpDown num_seed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.NumericUpDown num_brightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_onlyflower;
    }
}

