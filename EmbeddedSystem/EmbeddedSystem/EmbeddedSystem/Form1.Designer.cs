
namespace EmbeddedSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLightOn = new System.Windows.Forms.Button();
            this.btnLightOff = new System.Windows.Forms.Button();
            this.btnFanOff = new System.Windows.Forms.Button();
            this.btnFanOn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(84, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atmosphere Quality";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnLightOn
            // 
            this.btnLightOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLightOn.BackgroundImage")));
            this.btnLightOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLightOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightOn.Location = new System.Drawing.Point(72, 381);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(38, 47);
            this.btnLightOn.TabIndex = 3;
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnLightOff
            // 
            this.btnLightOff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLightOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLightOff.BackgroundImage")));
            this.btnLightOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLightOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightOff.Location = new System.Drawing.Point(114, 381);
            this.btnLightOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(38, 47);
            this.btnLightOff.TabIndex = 4;
            this.btnLightOff.UseVisualStyleBackColor = false;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // btnFanOff
            // 
            this.btnFanOff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFanOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFanOff.BackgroundImage")));
            this.btnFanOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFanOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFanOff.Location = new System.Drawing.Point(261, 381);
            this.btnFanOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFanOff.Name = "btnFanOff";
            this.btnFanOff.Size = new System.Drawing.Size(38, 47);
            this.btnFanOff.TabIndex = 6;
            this.btnFanOff.UseVisualStyleBackColor = false;
            this.btnFanOff.Click += new System.EventHandler(this.btnFanOff_Click);
            // 
            // btnFanOn
            // 
            this.btnFanOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFanOn.BackgroundImage")));
            this.btnFanOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFanOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFanOn.Location = new System.Drawing.Point(219, 381);
            this.btnFanOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFanOn.Name = "btnFanOn";
            this.btnFanOn.Size = new System.Drawing.Size(38, 47);
            this.btnFanOn.TabIndex = 5;
            this.btnFanOn.UseVisualStyleBackColor = true;
            this.btnFanOn.Click += new System.EventHandler(this.btnFanOn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Poplar Std", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Poplar Std", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(237, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fan";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Baud Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Com port";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 268);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 21);
            this.comboBox3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(139, 243);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(92, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFanOff);
            this.Controls.Add(this.btnFanOn);
            this.Controls.Add(this.btnLightOff);
            this.Controls.Add(this.btnLightOn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Button btnLightOff;
        private System.Windows.Forms.Button btnFanOff;
        private System.Windows.Forms.Button btnFanOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

