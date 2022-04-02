﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeather
{

    partial class settingsBox : Form
    {
        //=================================== Global Declerations =========================================//
        public delegate void PassTextBoxValue(string tbValue);
        public PassTextBoxValue passTBValue;
        //=================================== Main SettingsBox ============================================//
        public settingsBox()
        {
            InitializeComponent();
            cityBox.Text = Properties.Settings.Default.citySetting;
            this.BackColor = Properties.Settings.Default.colorSetting;
            unitBox.BackColor = Properties.Settings.Default.colorSetting;
            cityBox.BackColor = Properties.Settings.Default.colorSetting;

            if (Properties.Settings.Default.unitSetting == "C")
            {
                unitBox.SelectedIndex = 0;
            }
            else 
            {
                unitBox.SelectedIndex = 1;
            }
            this.ActiveControl = cityLabel;
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
                if (passTBValue != null)
                {
                    passTBValue(this.cityBox.Text);
                    {
                        this.Hide();
                    }
                }
                Properties.Settings.Default.citySetting = cityBox.Text;
                if (unitBox.SelectedItem.Equals("C"))
                {
                    Properties.Settings.Default.unitSetting = "C";
                }
                if (unitBox.SelectedItem.Equals("F"))
                {
                    Properties.Settings.Default.unitSetting = "F";
                }
                Properties.Settings.Default.Save();
                mainForm form = (mainForm)Application.OpenForms[0];
                form.getData(sender, e);
                form.changeColor();
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
        //=================================== Changes City Name ===========================================//
        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.citySetting = cityBox.Text;
        }
        //=================================== Startup checkBox ============================================//
        private void startupCheck_CheckedChanged(object sender, EventArgs e)
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
    }
}
