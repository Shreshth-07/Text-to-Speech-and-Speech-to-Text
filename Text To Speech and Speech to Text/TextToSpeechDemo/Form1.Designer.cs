
namespace TextToSpeechDemo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpeechButton = new System.Windows.Forms.Button();
            this.SoundTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.VoiceComboBox = new System.Windows.Forms.ComboBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Listen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StopListen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 296);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SpeechButton
            // 
            this.SpeechButton.BackColor = System.Drawing.Color.White;
            this.SpeechButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeechButton.Image = ((System.Drawing.Image)(resources.GetObject("SpeechButton.Image")));
            this.SpeechButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SpeechButton.Location = new System.Drawing.Point(20, 579);
            this.SpeechButton.Margin = new System.Windows.Forms.Padding(4);
            this.SpeechButton.Name = "SpeechButton";
            this.SpeechButton.Size = new System.Drawing.Size(147, 55);
            this.SpeechButton.TabIndex = 1;
            this.SpeechButton.Text = "Speech ";
            this.SpeechButton.UseVisualStyleBackColor = false;
            this.SpeechButton.Click += new System.EventHandler(this.SpeechButton_Click);
            // 
            // SoundTrackBar
            // 
            this.SoundTrackBar.BackColor = System.Drawing.Color.White;
            this.SoundTrackBar.Location = new System.Drawing.Point(522, 513);
            this.SoundTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.SoundTrackBar.Maximum = 100;
            this.SoundTrackBar.Name = "SoundTrackBar";
            this.SoundTrackBar.Size = new System.Drawing.Size(139, 56);
            this.SoundTrackBar.TabIndex = 2;
            this.SoundTrackBar.Value = 50;
            this.SoundTrackBar.Scroll += new System.EventHandler(this.SoundTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume:";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.BackColor = System.Drawing.Color.White;
            this.SpeedTrackBar.Location = new System.Drawing.Point(294, 513);
            this.SpeedTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedTrackBar.Minimum = -10;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(139, 56);
            this.SpeedTrackBar.TabIndex = 4;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 520);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // VoiceComboBox
            // 
            this.VoiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoiceComboBox.FormattingEnabled = true;
            this.VoiceComboBox.Location = new System.Drawing.Point(20, 517);
            this.VoiceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.VoiceComboBox.Name = "VoiceComboBox";
            this.VoiceComboBox.Size = new System.Drawing.Size(197, 28);
            this.VoiceComboBox.TabIndex = 10;
            this.VoiceComboBox.Text = "SELECT VOICE";
            this.VoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.VoiceComboBox_SelectedIndexChanged);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.White;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PauseButton.Location = new System.Drawing.Point(186, 579);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(149, 55);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton1);
            // 
            // ResumeButton
            // 
            this.ResumeButton.BackColor = System.Drawing.Color.White;
            this.ResumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeButton.Image = ((System.Drawing.Image)(resources.GetObject("ResumeButton.Image")));
            this.ResumeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResumeButton.Location = new System.Drawing.Point(354, 579);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(149, 55);
            this.ResumeButton.TabIndex = 1;
            this.ResumeButton.Text = "Resume   ";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton1);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.White;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopButton.Location = new System.Drawing.Point(522, 579);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(141, 55);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEXT-TO-SPEECH";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(716, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(643, 296);
            this.textBox2.TabIndex = 0;
            // 
            // Listen
            // 
            this.Listen.BackColor = System.Drawing.Color.White;
            this.Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen.Image = ((System.Drawing.Image)(resources.GetObject("Listen.Image")));
            this.Listen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Listen.Location = new System.Drawing.Point(898, 567);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(215, 67);
            this.Listen.TabIndex = 0;
            this.Listen.Text = "Listen";
            this.Listen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Listen.UseVisualStyleBackColor = false;
            this.Listen.Click += new System.EventHandler(this.ListenButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(113, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "TEXT-TO-SPEECH     ";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(814, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "SPEECH-TO-TEXT      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(378, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "TEXT-SPEECH CONVERTER";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearButton.Location = new System.Drawing.Point(716, 567);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(149, 67);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton1);
            // 
            // StopListen
            // 
            this.StopListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopListen.Image = ((System.Drawing.Image)(resources.GetObject("StopListen.Image")));
            this.StopListen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StopListen.Location = new System.Drawing.Point(1144, 567);
            this.StopListen.Name = "StopListen";
            this.StopListen.Size = new System.Drawing.Size(215, 67);
            this.StopListen.TabIndex = 11;
            this.StopListen.Text = "Stop";
            this.StopListen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StopListen.UseVisualStyleBackColor = true;
            this.StopListen.Click += new System.EventHandler(this.Stop_listen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1379, 667);
            this.Controls.Add(this.StopListen);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Listen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VoiceComboBox);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoundTrackBar);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.SpeechButton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text-Speech Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SpeechButton;
        private System.Windows.Forms.TrackBar SoundTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VoiceComboBox;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button StopListen;
    }
}