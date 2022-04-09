using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WeTile
{
    internal partial class settingsBox : Form
    {
        //=================================== Global Declerations =========================================//
        public delegate void PassTextBoxValue(string tbValue);
        public PassTextBoxValue passTBValue;
        //=================================== Main SettingsBox ============================================//
        public settingsBox()
        {
            InitializeComponent();
            cityBox.Text = Properties.Settings.Default.citySetting;
            BackColor = Properties.Settings.Default.colorSetting;
            opacityBox.Text = Properties.Settings.Default.opacitySetting.ToString();
            unitBox.BackColor = Properties.Settings.Default.colorSetting;
            cityBox.BackColor = Properties.Settings.Default.colorSetting;
            opacityBox.BackColor = Properties.Settings.Default.colorSetting;
            accentCheck.Checked = Properties.Settings.Default.useAccentSetting;

            if (Properties.Settings.Default.unitSetting == "C")
            {
                unitBox.SelectedIndex = 0;
            }
            else
            {
                unitBox.SelectedIndex = 1;
            }
            ActiveControl = cityLabel;
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (rk.GetValue("WeTile") == null)
                {
                    startupCheck.Checked = false;
                }
                else
                {
                    startupCheck.Checked = true;
                }
            }
            catch (Exception)
            { }
        }
        //=================================== Save Button Click ===========================================//
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                int opacityVal = Convert.ToInt32(opacityBox.Text);
                if (opacityVal >= 10 && opacityVal <= 100)
                    Properties.Settings.Default.opacitySetting = opacityVal;
                else
                {
                    MessageBox.Show("Please enter a value between 10 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opacityBox.Text = "";
                    return;
                }
                if (passTBValue != null)
                {
                    passTBValue(cityBox.Text);
                    {
                        Hide();
                    }
                }

                if (unitBox.SelectedItem.Equals("C"))
                {
                    Properties.Settings.Default.unitSetting = "C";
                }
                if (unitBox.SelectedItem.Equals("F"))
                {
                    Properties.Settings.Default.unitSetting = "F";
                }
                Properties.Settings.Default.useAccentSetting = accentCheck.Checked;
                Properties.Settings.Default.citySetting = cityBox.Text;
                startupCheckOnSave();
                Properties.Settings.Default.Save();
                mainForm form = (mainForm)Application.OpenForms[0];
                form.GetData();
                form.ChangeColor();
            }
            catch (Exception)
            { }
        }
        private void cityBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.PerformClick();
            }
        }
        //=================================== Open And Select Color =======================================//
        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Properties.Settings.Default.colorSetting;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorSetting = colorDialog.Color;
            }
        }
        //=================================== Startup checkBox ============================================//
        private void startupCheckOnSave()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (startupCheck.Checked)
                {
                    rk.SetValue("WeTile", "\"" + Application.ExecutablePath.ToString() + "\"");
                }
                else
                {
                    rk.DeleteValue("WeTile", false);
                }
            }
            catch (Exception)
            { }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset the settings?", "Reset Settings", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                cityBox.Text = Properties.Settings.Default.citySetting;
                unitBox.SelectedIndex = 0;
                opacityBox.Text = Properties.Settings.Default.opacitySetting.ToString();
                startupCheck.Checked = false;
                accentCheck.Checked = false;
                Properties.Settings.Default.Save();
            }
        }

        private void opacityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (opacityBox.Text.Length > 3)
            {
                e.Handled = true;
                return;
            }

        }

        private void opacityBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.PerformClick();
            }
        }
    }
}
