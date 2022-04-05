namespace WeTile
{
    partial class settingsBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.opacityBox = new System.Windows.Forms.TextBox();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitBox
            // 
            this.unitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unitBox.ForeColor = System.Drawing.SystemColors.Window;
            this.unitBox.Items.AddRange(new object[] {
            "C",
            "F"});
            this.unitBox.Location = new System.Drawing.Point(97, 60);
            this.unitBox.Margin = new System.Windows.Forms.Padding(5);
            this.unitBox.MaxDropDownItems = 2;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(157, 31);
            this.unitBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(18, 259);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(236, 35);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(34, 63);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(53, 23);
            this.unitLabel.TabIndex = 21;
            this.unitLabel.Text = "Units:";
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cityBox.Location = new System.Drawing.Point(97, 19);
            this.cityBox.Margin = new System.Windows.Forms.Padding(5);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(157, 29);
            this.cityBox.TabIndex = 1;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            this.cityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityBox_KeyDown);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(44, 22);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 23);
            this.cityLabel.TabIndex = 20;
            this.cityLabel.Text = "City:";
            // 
            // colorButton
            // 
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.ForeColor = System.Drawing.SystemColors.Window;
            this.colorButton.Location = new System.Drawing.Point(18, 215);
            this.colorButton.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(236, 35);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "Select Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.colorDialog.FullOpen = true;
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(49, 140);
            this.startupCheck.Margin = new System.Windows.Forms.Padding(5);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(176, 27);
            this.startupCheck.TabIndex = 4;
            this.startupCheck.Text = "Launch on Startup";
            this.startupCheck.UseVisualStyleBackColor = true;
            this.startupCheck.CheckedChanged += new System.EventHandler(this.startupCheck_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resetButton.Location = new System.Drawing.Point(18, 171);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(236, 35);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // opacityBox
            // 
            this.opacityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.opacityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.opacityBox.Location = new System.Drawing.Point(97, 103);
            this.opacityBox.Name = "opacityBox";
            this.opacityBox.Size = new System.Drawing.Size(157, 29);
            this.opacityBox.TabIndex = 3;
            this.opacityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.opacityBox_KeyDown);
            this.opacityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opacityBox_KeyPress);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(19, 106);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(72, 23);
            this.opacityLabel.TabIndex = 22;
            this.opacityLabel.Text = "Opacity:";
            // 
            // settingsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(260, 305);
            this.ControlBox = false;
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.opacityBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startupCheck);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.unitBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsBox";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox opacityBox;
        private System.Windows.Forms.Label opacityLabel;
    }
}
