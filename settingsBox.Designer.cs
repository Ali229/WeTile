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
            this.accentCheck = new System.Windows.Forms.CheckBox();
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
            this.unitBox.Location = new System.Drawing.Point(81, 50);
            this.unitBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitBox.MaxDropDownItems = 2;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(153, 27);
            this.unitBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(15, 246);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(218, 29);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(28, 52);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(44, 19);
            this.unitLabel.TabIndex = 21;
            this.unitLabel.Text = "Units:";
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cityBox.Location = new System.Drawing.Point(81, 16);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(153, 26);
            this.cityBox.TabIndex = 1;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            this.cityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityBox_KeyDown);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(37, 18);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(36, 19);
            this.cityLabel.TabIndex = 20;
            this.cityLabel.Text = "City:";
            // 
            // colorButton
            // 
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.ForeColor = System.Drawing.SystemColors.Window;
            this.colorButton.Location = new System.Drawing.Point(15, 209);
            this.colorButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(218, 29);
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
            this.startupCheck.Location = new System.Drawing.Point(30, 117);
            this.startupCheck.Margin = new System.Windows.Forms.Padding(4);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(144, 23);
            this.startupCheck.TabIndex = 4;
            this.startupCheck.Text = "Launch on Startup";
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resetButton.Location = new System.Drawing.Point(15, 172);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(218, 29);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // opacityBox
            // 
            this.opacityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.opacityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.opacityBox.Location = new System.Drawing.Point(81, 86);
            this.opacityBox.Margin = new System.Windows.Forms.Padding(2);
            this.opacityBox.Name = "opacityBox";
            this.opacityBox.Size = new System.Drawing.Size(153, 26);
            this.opacityBox.TabIndex = 3;
            this.opacityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.opacityBox_KeyDown);
            this.opacityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opacityBox_KeyPress);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(16, 88);
            this.opacityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(59, 19);
            this.opacityLabel.TabIndex = 22;
            this.opacityLabel.Text = "Opacity:";
            // 
            // accentCheck
            // 
            this.accentCheck.AutoSize = true;
            this.accentCheck.Location = new System.Drawing.Point(30, 141);
            this.accentCheck.Margin = new System.Windows.Forms.Padding(4);
            this.accentCheck.Name = "accentCheck";
            this.accentCheck.Size = new System.Drawing.Size(196, 23);
            this.accentCheck.TabIndex = 23;
            this.accentCheck.Text = "Use Windows Accent Color";
            this.accentCheck.UseVisualStyleBackColor = true;
            // 
            // settingsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(240, 280);
            this.ControlBox = false;
            this.Controls.Add(this.accentCheck);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsBox";
            this.Padding = new System.Windows.Forms.Padding(11);
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
        private System.Windows.Forms.CheckBox accentCheck;
    }
}
