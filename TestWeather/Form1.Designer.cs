namespace TestWeather
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
            this.breezePictureBox = new System.Windows.Forms.PictureBox();
            this.tornadoPictureBox = new System.Windows.Forms.PictureBox();
            this.fogPictureBox = new System.Windows.Forms.PictureBox();
            this.moonThunderPictureBox = new System.Windows.Forms.PictureBox();
            this.sunThunderPictureBox = new System.Windows.Forms.PictureBox();
            this.thunderPictureBox = new System.Windows.Forms.PictureBox();
            this.brokenPictureBox = new System.Windows.Forms.PictureBox();
            this.scatteredPictureBox = new System.Windows.Forms.PictureBox();
            this.moonOvercastPictureBox = new System.Windows.Forms.PictureBox();
            this.sunOvercastPictureBox = new System.Windows.Forms.PictureBox();
            this.moonLightCloudsPictureBox = new System.Windows.Forms.PictureBox();
            this.sunLightCloudsPictureBox = new System.Windows.Forms.PictureBox();
            this.icyRainPictureBox = new System.Windows.Forms.PictureBox();
            this.heavyRainPictureBox = new System.Windows.Forms.PictureBox();
            this.lightRainPictureBox = new System.Windows.Forms.PictureBox();
            this.cloudyPictureBox = new System.Windows.Forms.PictureBox();
            this.moonPictureBox = new System.Windows.Forms.PictureBox();
            this.sunPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.refreshButtonStill = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breezePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornadoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonThunderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunThunderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonOvercastPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunOvercastPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonLightCloudsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunLightCloudsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icyRainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavyRainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightRainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(10, 149);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(0, 40);
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
            this.dateLabel.Location = new System.Drawing.Point(13, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 21);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            this.dateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.dateLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.Location = new System.Drawing.Point(14, 193);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(0, 17);
            this.weatherLabel.TabIndex = 7;
            this.weatherLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.weatherLabel.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionLabel.Location = new System.Drawing.Point(6, 241);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(47, 12);
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
            this.cityLabel.Location = new System.Drawing.Point(14, 214);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 17);
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
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(141, 42);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(18, 18);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsButton.TabIndex = 28;
            this.settingsButton.TabStop = false;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // breezePictureBox
            // 
            this.breezePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("breezePictureBox.Image")));
            this.breezePictureBox.Location = new System.Drawing.Point(29, 41);
            this.breezePictureBox.Name = "breezePictureBox";
            this.breezePictureBox.Size = new System.Drawing.Size(110, 110);
            this.breezePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.breezePictureBox.TabIndex = 27;
            this.breezePictureBox.TabStop = false;
            this.breezePictureBox.Visible = false;
            this.breezePictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // tornadoPictureBox
            // 
            this.tornadoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tornadoPictureBox.Image")));
            this.tornadoPictureBox.Location = new System.Drawing.Point(29, 41);
            this.tornadoPictureBox.Name = "tornadoPictureBox";
            this.tornadoPictureBox.Size = new System.Drawing.Size(110, 110);
            this.tornadoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tornadoPictureBox.TabIndex = 26;
            this.tornadoPictureBox.TabStop = false;
            this.tornadoPictureBox.Visible = false;
            this.tornadoPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // fogPictureBox
            // 
            this.fogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fogPictureBox.Image")));
            this.fogPictureBox.Location = new System.Drawing.Point(29, 41);
            this.fogPictureBox.Name = "fogPictureBox";
            this.fogPictureBox.Size = new System.Drawing.Size(110, 110);
            this.fogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fogPictureBox.TabIndex = 25;
            this.fogPictureBox.TabStop = false;
            this.fogPictureBox.Visible = false;
            this.fogPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // moonThunderPictureBox
            // 
            this.moonThunderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("moonThunderPictureBox.Image")));
            this.moonThunderPictureBox.Location = new System.Drawing.Point(29, 41);
            this.moonThunderPictureBox.Name = "moonThunderPictureBox";
            this.moonThunderPictureBox.Size = new System.Drawing.Size(110, 110);
            this.moonThunderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moonThunderPictureBox.TabIndex = 24;
            this.moonThunderPictureBox.TabStop = false;
            this.moonThunderPictureBox.Visible = false;
            this.moonThunderPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.moonThunderPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // sunThunderPictureBox
            // 
            this.sunThunderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sunThunderPictureBox.Image")));
            this.sunThunderPictureBox.Location = new System.Drawing.Point(29, 41);
            this.sunThunderPictureBox.Name = "sunThunderPictureBox";
            this.sunThunderPictureBox.Size = new System.Drawing.Size(110, 110);
            this.sunThunderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunThunderPictureBox.TabIndex = 23;
            this.sunThunderPictureBox.TabStop = false;
            this.sunThunderPictureBox.Visible = false;
            this.sunThunderPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.sunThunderPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // thunderPictureBox
            // 
            this.thunderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("thunderPictureBox.Image")));
            this.thunderPictureBox.Location = new System.Drawing.Point(29, 41);
            this.thunderPictureBox.Name = "thunderPictureBox";
            this.thunderPictureBox.Size = new System.Drawing.Size(110, 110);
            this.thunderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thunderPictureBox.TabIndex = 22;
            this.thunderPictureBox.TabStop = false;
            this.thunderPictureBox.Visible = false;
            this.thunderPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.thunderPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // brokenPictureBox
            // 
            this.brokenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("brokenPictureBox.Image")));
            this.brokenPictureBox.Location = new System.Drawing.Point(29, 41);
            this.brokenPictureBox.Name = "brokenPictureBox";
            this.brokenPictureBox.Size = new System.Drawing.Size(110, 110);
            this.brokenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brokenPictureBox.TabIndex = 21;
            this.brokenPictureBox.TabStop = false;
            this.brokenPictureBox.Visible = false;
            this.brokenPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.brokenPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // scatteredPictureBox
            // 
            this.scatteredPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scatteredPictureBox.Image")));
            this.scatteredPictureBox.Location = new System.Drawing.Point(29, 41);
            this.scatteredPictureBox.Name = "scatteredPictureBox";
            this.scatteredPictureBox.Size = new System.Drawing.Size(110, 110);
            this.scatteredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scatteredPictureBox.TabIndex = 20;
            this.scatteredPictureBox.TabStop = false;
            this.scatteredPictureBox.Visible = false;
            this.scatteredPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.scatteredPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // moonOvercastPictureBox
            // 
            this.moonOvercastPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("moonOvercastPictureBox.Image")));
            this.moonOvercastPictureBox.Location = new System.Drawing.Point(29, 41);
            this.moonOvercastPictureBox.Name = "moonOvercastPictureBox";
            this.moonOvercastPictureBox.Size = new System.Drawing.Size(110, 110);
            this.moonOvercastPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moonOvercastPictureBox.TabIndex = 19;
            this.moonOvercastPictureBox.TabStop = false;
            this.moonOvercastPictureBox.Visible = false;
            this.moonOvercastPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.moonOvercastPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // sunOvercastPictureBox
            // 
            this.sunOvercastPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sunOvercastPictureBox.Image")));
            this.sunOvercastPictureBox.Location = new System.Drawing.Point(29, 41);
            this.sunOvercastPictureBox.Name = "sunOvercastPictureBox";
            this.sunOvercastPictureBox.Size = new System.Drawing.Size(110, 110);
            this.sunOvercastPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunOvercastPictureBox.TabIndex = 18;
            this.sunOvercastPictureBox.TabStop = false;
            this.sunOvercastPictureBox.Visible = false;
            this.sunOvercastPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.sunOvercastPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // moonLightCloudsPictureBox
            // 
            this.moonLightCloudsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("moonLightCloudsPictureBox.Image")));
            this.moonLightCloudsPictureBox.Location = new System.Drawing.Point(29, 41);
            this.moonLightCloudsPictureBox.Name = "moonLightCloudsPictureBox";
            this.moonLightCloudsPictureBox.Size = new System.Drawing.Size(110, 110);
            this.moonLightCloudsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moonLightCloudsPictureBox.TabIndex = 17;
            this.moonLightCloudsPictureBox.TabStop = false;
            this.moonLightCloudsPictureBox.Visible = false;
            this.moonLightCloudsPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.moonLightCloudsPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // sunLightCloudsPictureBox
            // 
            this.sunLightCloudsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sunLightCloudsPictureBox.Image")));
            this.sunLightCloudsPictureBox.Location = new System.Drawing.Point(29, 41);
            this.sunLightCloudsPictureBox.Name = "sunLightCloudsPictureBox";
            this.sunLightCloudsPictureBox.Size = new System.Drawing.Size(110, 110);
            this.sunLightCloudsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunLightCloudsPictureBox.TabIndex = 16;
            this.sunLightCloudsPictureBox.TabStop = false;
            this.sunLightCloudsPictureBox.Visible = false;
            this.sunLightCloudsPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.sunLightCloudsPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // icyRainPictureBox
            // 
            this.icyRainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("icyRainPictureBox.Image")));
            this.icyRainPictureBox.Location = new System.Drawing.Point(29, 41);
            this.icyRainPictureBox.Name = "icyRainPictureBox";
            this.icyRainPictureBox.Size = new System.Drawing.Size(110, 110);
            this.icyRainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icyRainPictureBox.TabIndex = 15;
            this.icyRainPictureBox.TabStop = false;
            this.icyRainPictureBox.Visible = false;
            this.icyRainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.icyRainPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // heavyRainPictureBox
            // 
            this.heavyRainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("heavyRainPictureBox.Image")));
            this.heavyRainPictureBox.Location = new System.Drawing.Point(29, 41);
            this.heavyRainPictureBox.Name = "heavyRainPictureBox";
            this.heavyRainPictureBox.Size = new System.Drawing.Size(110, 110);
            this.heavyRainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heavyRainPictureBox.TabIndex = 14;
            this.heavyRainPictureBox.TabStop = false;
            this.heavyRainPictureBox.Visible = false;
            this.heavyRainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.heavyRainPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // lightRainPictureBox
            // 
            this.lightRainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightRainPictureBox.Image")));
            this.lightRainPictureBox.Location = new System.Drawing.Point(29, 41);
            this.lightRainPictureBox.Name = "lightRainPictureBox";
            this.lightRainPictureBox.Size = new System.Drawing.Size(110, 110);
            this.lightRainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightRainPictureBox.TabIndex = 13;
            this.lightRainPictureBox.TabStop = false;
            this.lightRainPictureBox.Visible = false;
            this.lightRainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.lightRainPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // cloudyPictureBox
            // 
            this.cloudyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cloudyPictureBox.Image")));
            this.cloudyPictureBox.Location = new System.Drawing.Point(29, 41);
            this.cloudyPictureBox.Name = "cloudyPictureBox";
            this.cloudyPictureBox.Size = new System.Drawing.Size(110, 110);
            this.cloudyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudyPictureBox.TabIndex = 12;
            this.cloudyPictureBox.TabStop = false;
            this.cloudyPictureBox.Visible = false;
            this.cloudyPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.cloudyPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // moonPictureBox
            // 
            this.moonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("moonPictureBox.Image")));
            this.moonPictureBox.Location = new System.Drawing.Point(29, 41);
            this.moonPictureBox.Name = "moonPictureBox";
            this.moonPictureBox.Size = new System.Drawing.Size(110, 110);
            this.moonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moonPictureBox.TabIndex = 11;
            this.moonPictureBox.TabStop = false;
            this.moonPictureBox.Visible = false;
            this.moonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.moonPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // sunPictureBox
            // 
            this.sunPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sunPictureBox.Image")));
            this.sunPictureBox.Location = new System.Drawing.Point(29, 41);
            this.sunPictureBox.Name = "sunPictureBox";
            this.sunPictureBox.Size = new System.Drawing.Size(110, 110);
            this.sunPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunPictureBox.TabIndex = 9;
            this.sunPictureBox.TabStop = false;
            this.sunPictureBox.Visible = false;
            this.sunPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.sunPictureBox.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(141, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(141, 231);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(18, 18);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshButton.TabIndex = 6;
            this.refreshButton.TabStop = false;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.getData);
            this.refreshButton.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // refreshButtonStill
            // 
            this.refreshButtonStill.Image = ((System.Drawing.Image)(resources.GetObject("refreshButtonStill.Image")));
            this.refreshButtonStill.Location = new System.Drawing.Point(141, 231);
            this.refreshButtonStill.Name = "refreshButtonStill";
            this.refreshButtonStill.Size = new System.Drawing.Size(18, 18);
            this.refreshButtonStill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshButtonStill.TabIndex = 5;
            this.refreshButtonStill.TabStop = false;
            this.refreshButtonStill.Visible = false;
            this.refreshButtonStill.Click += new System.EventHandler(this.getData);
            this.refreshButtonStill.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(168, 258);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.breezePictureBox);
            this.Controls.Add(this.tornadoPictureBox);
            this.Controls.Add(this.fogPictureBox);
            this.Controls.Add(this.moonThunderPictureBox);
            this.Controls.Add(this.sunThunderPictureBox);
            this.Controls.Add(this.thunderPictureBox);
            this.Controls.Add(this.brokenPictureBox);
            this.Controls.Add(this.scatteredPictureBox);
            this.Controls.Add(this.moonOvercastPictureBox);
            this.Controls.Add(this.sunOvercastPictureBox);
            this.Controls.Add(this.moonLightCloudsPictureBox);
            this.Controls.Add(this.sunLightCloudsPictureBox);
            this.Controls.Add(this.icyRainPictureBox);
            this.Controls.Add(this.heavyRainPictureBox);
            this.Controls.Add(this.lightRainPictureBox);
            this.Controls.Add(this.cloudyPictureBox);
            this.Controls.Add(this.moonPictureBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.sunPictureBox);
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
            this.Name = "mainForm";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.getData);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.MouseEnter += new System.EventHandler(this.mainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.mainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breezePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornadoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonThunderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunThunderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonOvercastPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunOvercastPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonLightCloudsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunLightCloudsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icyRainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavyRainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightRainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButtonStill)).EndInit();
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
        private System.Windows.Forms.PictureBox sunPictureBox;
        private System.Windows.Forms.PictureBox moonPictureBox;
        private System.Windows.Forms.PictureBox cloudyPictureBox;
        private System.Windows.Forms.PictureBox lightRainPictureBox;
        private System.Windows.Forms.PictureBox heavyRainPictureBox;
        private System.Windows.Forms.PictureBox icyRainPictureBox;
        private System.Windows.Forms.PictureBox sunLightCloudsPictureBox;
        private System.Windows.Forms.PictureBox moonLightCloudsPictureBox;
        private System.Windows.Forms.PictureBox sunOvercastPictureBox;
        private System.Windows.Forms.PictureBox moonOvercastPictureBox;
        private System.Windows.Forms.PictureBox scatteredPictureBox;
        private System.Windows.Forms.PictureBox brokenPictureBox;
        private System.Windows.Forms.PictureBox thunderPictureBox;
        private System.Windows.Forms.PictureBox sunThunderPictureBox;
        private System.Windows.Forms.PictureBox moonThunderPictureBox;
        private System.Windows.Forms.Timer checkMouse;
        private System.Windows.Forms.PictureBox fogPictureBox;
        private System.Windows.Forms.PictureBox tornadoPictureBox;
        private System.Windows.Forms.PictureBox breezePictureBox;
        private System.Windows.Forms.PictureBox settingsButton;
        public System.Windows.Forms.Label cityLabel;
    }
}

