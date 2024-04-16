using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using FontAwesome.Sharp;
using CustomControls.RJControls;

namespace Xeon.Design
{
    public class ToolBox
    {
        public void textBox_Enter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)control;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.FromArgb(115, 47, 53);
                txt.ForeColor = Color.White;
                if (txt.Text == txt.Tag.ToString())
                    txt.Text = "";
            }
            else if (control.GetType() == typeof(ComboBox))
            {
                ComboBox cbo = (ComboBox)control;
                cbo.BackColor = Color.FromArgb(115, 47, 53);
                cbo.ForeColor = Color.White;
                if (cbo.Text == cbo.Tag.ToString())
                    cbo.Text = "";
            }
        }

        public void textBox_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is TextBox)
            {
                TextBox txt = (TextBox)control;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.White;
                txt.ForeColor = Color.FromArgb(115, 47, 53);
                if (txt.Name == "txtContraseña" && txt.Text == "Contraseña")
                    txt.PasswordChar = '\0';
                else if (txt.Name == "txtContraseña" && txt.Text != "Contraseña")
                    txt.PasswordChar = '*';
                if (txt.Text == "")
                    txt.Text = txt.Tag.ToString();
            }
            else if (control.GetType() == typeof(ComboBox))
            {
                ComboBox cbo = (ComboBox)control;
                cbo.BackColor = Color.White;
                cbo.ForeColor = Color.FromArgb(115, 47, 53);
                if (cbo.Text == "")
                    cbo.Text = cbo.Tag.ToString();
            }
        }

        public void RJtextBox_Enter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control.GetType() == typeof(RJTextBox))
            {
                RJTextBox txt = (RJTextBox)control;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BorderColor = Color.MediumSlateBlue;
                txt.BorderFocusColor = Color.HotPink;
                txt.BackColor = Color.White;
                txt.PlaceholderColor = Color.DarkGray;
                if (txt.Texts == txt.Tag.ToString())
                    txt.Texts = "";
            }
        }

        public void RJtextBox_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is RJTextBox)
            {
                RJTextBox txt = (RJTextBox)control;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.White;
                if (txt.Name == "txContraseña" && txt.Texts == "Contraseña")
                    txt.PasswordChar = false;
                else if (txt.Name == "txtContraseña" && txt.Texts != "Contraseña")
                    txt.PasswordChar = true;
                if (txt.Texts == "")
                    txt.Texts = txt.Tag.ToString();
            }
        }

    }
}
