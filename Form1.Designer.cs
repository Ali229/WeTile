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
            this.timestampLabel = new System.Windows.Forms.Label();
            this.airQualityPictureBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.WeatherPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.refreshButtonStill = new System.Windows.Forms.PictureBox();
            this.AQITable = new System.Windows.Forms.TableLayoutPanel();
            this.qualityValueLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.pm25Label = new System.Windows.Forms.Label();
            this.pm10Label = new System.Windows.Forms.Label();
            this.pm25ValueLabel = new System.Windows.Forms.Label();
            this.pm10ValueLabel = new System.Windows.Forms.Label();
            this.O3ValueLabel = new System.Windows.Forms.Label();
            this.O3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airQualityPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).BeginInit();
            this.AQITable.SuspendLayout();
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
            this.weatherTimer.Tick += new System.EventHandler(this.weatherTimer_Tick);
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
            // timestampLabel
            // 
            this.timestampLabel.AutoSize = true;
            this.timestampLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestampLabel.Location = new System.Drawing.Point(14, 297);
            this.timestampLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timestampLabel.Name = "timestampLabel";
            this.timestampLabel.Size = new System.Drawing.Size(0, 17);
            this.timestampLabel.TabIndex = 29;
            this.timestampLabel.Visible = false;
            // 
            // airQualityPictureBox
            // 
            this.airQualityPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.airQualityPictureBox.Location = new System.Drawing.Point(158, 194);
            this.airQualityPictureBox.MaximumSize = new System.Drawing.Size(40, 40);
            this.airQualityPictureBox.Name = "airQualityPictureBox";
            this.airQualityPictureBox.Size = new System.Drawing.Size(40, 40);
            this.airQualityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airQualityPictureBox.TabIndex = 30;
            this.airQualityPictureBox.TabStop = false;
            this.airQualityPictureBox.Visible = false;
            this.airQualityPictureBox.MouseEnter += new System.EventHandler(this.airQualityPictureBox_MouseEnter);
            this.airQualityPictureBox.MouseLeave += new System.EventHandler(this.airQualityPictureBox_MouseLeave);
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
            this.refreshButton.Click += new System.EventHandler(this.weatherTimer_Tick);
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
            this.refreshButtonStill.Click += new System.EventHandler(this.weatherTimer_Tick);
            this.refreshButtonStill.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // AQITable
            // 
            this.AQITable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AQITable.ColumnCount = 2;
            this.AQITable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.AQITable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AQITable.Controls.Add(this.qualityValueLabel, 1, 0);
            this.AQITable.Controls.Add(this.qualityLabel, 0, 0);
            this.AQITable.Controls.Add(this.pm25Label, 0, 1);
            this.AQITable.Controls.Add(this.pm10Label, 0, 2);
            this.AQITable.Controls.Add(this.pm25ValueLabel, 1, 1);
            this.AQITable.Controls.Add(this.pm10ValueLabel, 1, 2);
            this.AQITable.Controls.Add(this.O3ValueLabel, 1, 3);
            this.AQITable.Controls.Add(this.O3Label, 0, 3);
            this.AQITable.Location = new System.Drawing.Point(0, 3);
            this.AQITable.Name = "AQITable";
            this.AQITable.RowCount = 4;
            this.AQITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AQITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AQITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AQITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AQITable.Size = new System.Drawing.Size(210, 185);
            this.AQITable.TabIndex = 31;
            this.AQITable.Visible = false;
            // 
            // qualityValueLabel
            // 
            this.qualityValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityValueLabel.AutoSize = true;
            this.qualityValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityValueLabel.Location = new System.Drawing.Point(129, 13);
            this.qualityValueLabel.Name = "qualityValueLabel";
            this.qualityValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.qualityValueLabel.Size = new System.Drawing.Size(77, 20);
            this.qualityValueLabel.TabIndex = 1;
            this.qualityValueLabel.Text = "0";
            this.qualityValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qualityLabel
            // 
            this.qualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLabel.Location = new System.Drawing.Point(4, 13);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.qualityLabel.Size = new System.Drawing.Size(118, 20);
            this.qualityLabel.TabIndex = 2;
            this.qualityLabel.Text = "Air Quality";
            this.qualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pm25Label
            // 
            this.pm25Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pm25Label.AutoSize = true;
            this.pm25Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm25Label.Location = new System.Drawing.Point(4, 59);
            this.pm25Label.Name = "pm25Label";
            this.pm25Label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pm25Label.Size = new System.Drawing.Size(118, 20);
            this.pm25Label.TabIndex = 3;
            this.pm25Label.Text = "PM ₂⋅₅";
            this.pm25Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pm10Label
            // 
            this.pm10Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pm10Label.AutoSize = true;
            this.pm10Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm10Label.Location = new System.Drawing.Point(4, 105);
            this.pm10Label.Name = "pm10Label";
            this.pm10Label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pm10Label.Size = new System.Drawing.Size(118, 20);
            this.pm10Label.TabIndex = 4;
            this.pm10Label.Text = "PM ₁₀";
            this.pm10Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pm25ValueLabel
            // 
            this.pm25ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pm25ValueLabel.AutoSize = true;
            this.pm25ValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm25ValueLabel.Location = new System.Drawing.Point(129, 59);
            this.pm25ValueLabel.Name = "pm25ValueLabel";
            this.pm25ValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pm25ValueLabel.Size = new System.Drawing.Size(77, 20);
            this.pm25ValueLabel.TabIndex = 6;
            this.pm25ValueLabel.Text = "0";
            this.pm25ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pm10ValueLabel
            // 
            this.pm10ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pm10ValueLabel.AutoSize = true;
            this.pm10ValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm10ValueLabel.Location = new System.Drawing.Point(129, 105);
            this.pm10ValueLabel.Name = "pm10ValueLabel";
            this.pm10ValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pm10ValueLabel.Size = new System.Drawing.Size(77, 20);
            this.pm10ValueLabel.TabIndex = 7;
            this.pm10ValueLabel.Text = "0";
            this.pm10ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // O3ValueLabel
            // 
            this.O3ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.O3ValueLabel.AutoSize = true;
            this.O3ValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O3ValueLabel.Location = new System.Drawing.Point(129, 151);
            this.O3ValueLabel.Name = "O3ValueLabel";
            this.O3ValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.O3ValueLabel.Size = new System.Drawing.Size(77, 20);
            this.O3ValueLabel.TabIndex = 8;
            this.O3ValueLabel.Text = "0";
            this.O3ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // O3Label
            // 
            this.O3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.O3Label.AutoSize = true;
            this.O3Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O3Label.Location = new System.Drawing.Point(4, 151);
            this.O3Label.Name = "O3Label";
            this.O3Label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.O3Label.Size = new System.Drawing.Size(118, 20);
            this.O3Label.TabIndex = 5;
            this.O3Label.Text = "O ₃";
            this.O3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(210, 322);
            this.Controls.Add(this.AQITable);
            this.Controls.Add(this.airQualityPictureBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.timestampLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.WeatherPictureBox);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dateLabel);
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
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.mainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.airQualityPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).EndInit();
            this.AQITable.ResumeLayout(false);
            this.AQITable.PerformLayout();
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
        private System.Windows.Forms.Label timestampLabel;
        private System.Windows.Forms.PictureBox airQualityPictureBox;
        private System.Windows.Forms.TableLayoutPanel AQITable;
        private System.Windows.Forms.Label qualityValueLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label pm25Label;
        private System.Windows.Forms.Label pm10Label;
        private System.Windows.Forms.Label pm25ValueLabel;
        private System.Windows.Forms.Label pm10ValueLabel;
        private System.Windows.Forms.Label O3ValueLabel;
        private System.Windows.Forms.Label O3Label;
    }
}

