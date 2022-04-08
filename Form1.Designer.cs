namespace WeTile
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.checkMouse = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.refreshButtonStill = new System.Windows.Forms.PictureBox();
            this.WeatherPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 186);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(0, 50);
            this.TemperatureLabel.TabIndex = 2;
            this.TemperatureLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.TemperatureLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // weatherTimer
            // 
            this.weatherTimer.Enabled = true;
            this.weatherTimer.Interval = 1800000;
            this.weatherTimer.Tick += new System.EventHandler(this.getData);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(16, 15);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 28);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            this.dateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.dateLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.Location = new System.Drawing.Point(18, 241);
            this.weatherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(0, 23);
            this.weatherLabel.TabIndex = 7;
            this.weatherLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.weatherLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionLabel.Location = new System.Drawing.Point(8, 301);
            this.exceptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(64, 15);
            this.exceptionLabel.TabIndex = 8;
            this.exceptionLabel.Text = "Exceptions";
            this.exceptionLabel.Visible = false;
            this.exceptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.exceptionLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(18, 268);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 23);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.cityLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // checkMouse
            // 
            this.checkMouse.Tick += new System.EventHandler(this.checkMouse_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(176, 52);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(22, 22);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsButton.TabIndex = 28;
            this.settingsButton.TabStop = false;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(176, 19);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 22);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(176, 289);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(22, 22);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshButton.TabIndex = 6;
            this.refreshButton.TabStop = false;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.getData);
            this.refreshButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // refreshButtonStill
            // 
            this.refreshButtonStill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButtonStill.Image = ((System.Drawing.Image)(resources.GetObject("refreshButtonStill.Image")));
            this.refreshButtonStill.Location = new System.Drawing.Point(176, 289);
            this.refreshButtonStill.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButtonStill.Name = "refreshButtonStill";
            this.refreshButtonStill.Size = new System.Drawing.Size(22, 22);
            this.refreshButtonStill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshButtonStill.TabIndex = 5;
            this.refreshButtonStill.TabStop = false;
            this.refreshButtonStill.Visible = false;
            this.refreshButtonStill.Click += new System.EventHandler(this.getData);
            this.refreshButtonStill.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // WeatherPictureBox
            // 
            this.WeatherPictureBox.Image = global::WeTile.Properties.Resources.sunny;
            this.WeatherPictureBox.Location = new System.Drawing.Point(36, 51);
            this.WeatherPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeatherPictureBox.Name = "WeatherPictureBox";
            this.WeatherPictureBox.Size = new System.Drawing.Size(138, 138);
            this.WeatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WeatherPictureBox.TabIndex = 9;
            this.WeatherPictureBox.TabStop = false;
            this.WeatherPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.WeatherPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(210, 322);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.WeatherPictureBox);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.refreshButtonStill);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.getData);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.mainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Timer weatherTimer;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox refreshButtonStill;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Timer checkMouse;
        private System.Windows.Forms.PictureBox settingsButton;
        public System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox WeatherPictureBox;
    }
}

