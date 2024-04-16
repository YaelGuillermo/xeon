using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using FontAwesome.Sharp;
using System.ComponentModel;
using CustomControls.RJControls;

namespace Xeon.Design
{
    class AppearanceManager
    {
        //Fields
        private static Font centhury14 = new Font("Centhury Gothic", 14);
        private static Font centhury12 = new Font("Centhury Gothic", 12);
        private static Font centhury11 = new Font("Centhury Gothic", 11);
        private static Font centhury9 = new Font("Centhury Gothic", 9);
        private static Font centhurySchool12 = new Font("Century Schoolbook", 12);
        private static Color rojoFuerte = Color.FromArgb(166, 36, 47);
        private static Color rojoMediano = Color.FromArgb(242, 56, 71);
        private static Color rojoDebil = Color.FromArgb(237, 128, 137);
        private static Color rosaMediano = Color.FromArgb(242, 174, 187);
        private static Color rosaFuerte = Color.FromArgb(166, 101, 101);
        private static Color rosaDebil = Color.FromArgb(217, 150, 162);
        private static Color vino = Color.FromArgb(115, 47, 53);
        private static Color marron = Color.FromArgb(64, 1, 6);
        private static Color rojoMuyFuerte = Color.FromArgb(140, 11, 22);
        private static Color rosaMuyFuerte = Color.FromArgb(217,48,79);
        private static Color gris = Color.FromArgb(242, 242, 242);
        private static Color blanco = Color.White;
        private static Color negro = Color.Black;

        //Constructor
        public AppearanceManager(Font a, Font b, Font c, Color d, Color e, 
            Color f, Color g, Color h, Color i, Color j, Color k)
        {
            centhury14 = a;
            centhury12 = b;
            centhury9 = c;
            rojoFuerte = d;
            rojoMediano = e;
            rojoDebil = f;
            rosaMediano = g;
            rosaFuerte = h;
            rosaDebil = i;
            vino = j;
            gris = k;
        }

        public static void principalClaro(Form form)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control control in form.Controls)
                controlList.Add(control);

            if (form.IsMdiContainer)
            {
                foreach (Control ctl in form.Controls)
                    ctl.BackColor = rosaMediano;
            }

            while (controlList.Count > 0)
            {
                Control control = controlList[0];
                controlList.RemoveAt(0);
                foreach (Control childControl in control.Controls)
                    controlList.Add(childControl);

                if (control is Panel)
                {
                    foreach (IconPictureBox btn in control.Controls.OfType<IconPictureBox>())
                    {
                        btn.BackColor = rojoMediano;
                        btn.ForeColor = rojoDebil;
                    }
                    foreach (IconButton button in control.Controls.OfType<IconButton>())
                    {
                        if (control.Height <= 50)
                        {
                            foreach (IconButton btn in control.Controls.OfType<IconButton>())
                            {
                                if (control.Controls.IndexOf(btn) == 0)
                                {
                                    btn.BackColor = rojoMediano;
                                    btn.Font = centhury9;
                                    btn.IconColor = gris;
                                }
                                else if (control.Controls.IndexOf(btn) == 1)
                                {
                                    btn.BackColor = rojoDebil;
                                    btn.Font = centhury9;
                                    btn.IconColor = gris;
                                }
                            }
                            button.BackColor = rojoMediano;
                            button.ForeColor = vino;
                            button.IconColor = rojoDebil;
                            control.BackColor = rojoMediano;                          
                        }
                        else if (control.Height > 51 && control.Height <= 90)
                        {
                            foreach (IconButton btn in control.Controls.OfType<IconButton>())
                            {
                                btn.Font = centhury14;
                                btn.BackColor = rojoFuerte;
                                btn.IconColor = rojoDebil;
                            }
                        }
                        else
                        {
                            control.BackColor = rojoFuerte;
                            button.IconColor = rojoDebil;
                        }
                    }
                }
                if (control is Label)
                {
                    control.Font = centhury12;
                    control.ForeColor = rojoFuerte;
                    if (control.Name == "lblDateTime")
                    {
                        control.Font = new Font("Centhury Gotic", 50);
                    }
                }
            }
        }

        public static void RJtablaClaro(TabControl tabControl)
        {
            ToolBox TB = new ToolBox();
            tabControl.Font = centhurySchool12;
            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (TableLayoutPanel tlp in page.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (Control control in tlp.Controls)
                    {
                        if (control is RJButton btn)
                        {
                            btn.Font = centhurySchool12;
                            btn.BackColor = Color.MediumSlateBlue;
                            btn.BackgroundColor = Color.MediumSlateBlue;
                            btn.ForeColor = Color.White;
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.ImageAlign = ContentAlignment.BottomCenter;
                            btn.TextImageRelation = TextImageRelation.ImageAboveText;
                            if (control.Name == "btnSearch")
                            {
                                btn.Font = centhury9;
                                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                            }
                        }
                        else if (control is RJTextBox txt)
                        {
                            control.Enter += new EventHandler(TB.RJtextBox_Enter);
                            control.Leave += new EventHandler(TB.RJtextBox_Leave);
                            txt.Font = centhurySchool12;
                        }
                        else if (control is DateTimePicker dtp)
                        {
                            //dtp.Format = DateTimePickerFormat.Short;
                        }
                        else if (control is ComboBox cbo)
                        {
                            control.Enter += new EventHandler(TB.textBox_Enter);
                            control.Leave += new EventHandler(TB.textBox_Leave);
                            cbo.Font = centhury14;
                            cbo.ForeColor = vino;
                            cbo.BackColor = blanco;
                            cbo.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else if (control is DataGridView dgv)
                        {
                            dgv.BorderStyle = BorderStyle.None;
                            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            dgv.ColumnHeadersHeight = 54;
                            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dgv.BackgroundColor = vino;
                            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            dgv.DefaultCellStyle.BackColor = vino;
                            dgv.DefaultCellStyle.Font = centhury12;
                            dgv.DefaultCellStyle.ForeColor = blanco;
                            dgv.DefaultCellStyle.SelectionBackColor = rosaDebil;
                            dgv.DefaultCellStyle.SelectionForeColor = blanco;
                            dgv.EnableHeadersVisualStyles = false;
                            dgv.ColumnHeadersDefaultCellStyle.BackColor = rojoMuyFuerte;
                            dgv.ColumnHeadersDefaultCellStyle.Font = centhury12;
                            dgv.ColumnHeadersDefaultCellStyle.ForeColor = blanco;
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.RowHeadersVisible = false;
                            dgv.RowHeadersDefaultCellStyle.BackColor = vino;
                            dgv.RowHeadersDefaultCellStyle.Font = centhury9;
                            dgv.RowHeadersDefaultCellStyle.ForeColor = blanco;
                            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = rosaFuerte;
                            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = rojoDebil;
                            dgv.ReadOnly = true;
                        }
                        else if (control is PictureBox pic)
                        {
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                            pic.Anchor = AnchorStyles.None;
                        }
                        else if (control is Label lbl) 
                        {
                            lbl.ForeColor = Color.Black;
                        }
                    }
                    tlp.BackColor = Color.LightPink;
                }
            }
        }

        public static void tablaClaro(TabControl tabControl)
        {
            ToolBox TB = new ToolBox();
            tabControl.Font = centhurySchool12;
            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (TableLayoutPanel tlp in page.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (Control control in tlp.Controls)
                    {
                        if (control is IconButton btn)
                        {
                            btn.Font = centhury12;
                            btn.IconColor = vino;
                            btn.BackColor = rosaDebil;
                            btn.ForeColor = rojoFuerte;
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.ImageAlign = ContentAlignment.BottomCenter;
                            btn.TextImageRelation = TextImageRelation.ImageAboveText;
                            if (control.Name == "btnSearch")
                            {
                                btn.Font = centhury9;
                                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                            }
                        }
                        else if (control is TextBox txt)
                        {
                            control.Enter += new EventHandler(TB.textBox_Enter);
                            control.Leave += new EventHandler(TB.textBox_Leave);
                            txt.Font = centhury14;
                            txt.ForeColor = vino;
                            txt.BackColor = blanco;
                            if (tlp.GetControlFromPosition(0, 0).Name.StartsWith("txtID"))
                            {
                                tlp.GetControlFromPosition(0, 0).Text = "1";
                                tlp.GetControlFromPosition(0, 0).Enabled = false;
                            }
                        }
                        else if (control is DateTimePicker dtp)
                        {
                            //dtp.Format = DateTimePickerFormat.Short;
                        }
                        else if (control is ComboBox cbo)
                        {
                            control.Enter += new EventHandler(TB.textBox_Enter);
                            control.Leave += new EventHandler(TB.textBox_Leave);
                            cbo.Font = centhury14;
                            cbo.ForeColor = vino;
                            cbo.BackColor = blanco;
                            cbo.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else if (control is DataGridView dgv)
                        {
                            dgv.BorderStyle = BorderStyle.None;
                            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            dgv.ColumnHeadersHeight = 54;
                            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dgv.BackgroundColor = vino;
                            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            dgv.DefaultCellStyle.BackColor = vino;
                            dgv.DefaultCellStyle.Font = centhury12;
                            dgv.DefaultCellStyle.ForeColor = blanco;
                            dgv.DefaultCellStyle.SelectionBackColor = rosaDebil;
                            dgv.DefaultCellStyle.SelectionForeColor = blanco;
                            dgv.EnableHeadersVisualStyles = false;
                            dgv.ColumnHeadersDefaultCellStyle.BackColor = rojoMuyFuerte;
                            dgv.ColumnHeadersDefaultCellStyle.Font = centhury12;
                            dgv.ColumnHeadersDefaultCellStyle.ForeColor = blanco;
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.RowHeadersVisible = false;
                            dgv.RowHeadersDefaultCellStyle.BackColor = vino;
                            dgv.RowHeadersDefaultCellStyle.Font = centhury9;
                            dgv.RowHeadersDefaultCellStyle.ForeColor = blanco;
                            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = rosaFuerte;
                            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = rojoDebil;
                            dgv.ReadOnly = true;
                        }
                        else if (control is PictureBox pic)
                        {
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                            pic.Anchor = AnchorStyles.None;
                        }
                    }
                    tlp.BackColor = rosaMediano;
                }
            }
        }
    }
}
