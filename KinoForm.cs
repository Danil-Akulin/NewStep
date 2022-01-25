using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MinuVorm
{

    public partial class KinoForm : Form
    {

        public PictureBox img = new PictureBox();
        private Control image;

        public Button but;
        private Control button;

        public Button butt;

        public KinoForm()
        {           

            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Meil on hea meel teid näha!";


            TextBox box = new TextBox();
            box.Location = new Point(260, 100);

            box.Text = "Tere, Tere tulemast kinno \"Lootus\"";
            Font myfont = new Font("Times New Roman", 25.0f);        //изменения размера шрифта
            box.Font = myfont;                                    // хз
            box.ReadOnly = true;                                //только для чтения
            box.Height = 150;
            box.Width = 460;
            box.BackColor = Color.FromArgb(255, 23, 14, 43);
            box.ForeColor = Color.AliceBlue;
            box.BorderStyle = 0;


            this.Controls.Add(box);
            but = new Button();
            but.Text = "Pileti ostmiseks";
            but.Size = new Size(120, 70);
            but.Location = new Point(400, 375);
            but.Font = new Font("Times New Roman", 18);
            but.Click += new EventHandler(but_Click);
            but.BackColor = Color.FromArgb(23, 14, 43);

            this.Controls.Add(box);
            butt = new Button();
            butt.Text = "Admin";
            butt.Size = new Size(80, 40);
            butt.Location = new Point(20, 25);
            butt.Font = new Font("Times New Roman", 14);
            butt.Click += new EventHandler(butt_Click);
            butt.BackColor = Color.AliceBlue;


            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            but.BackColor = Color.Transparent;
            this.Controls.Add(but);
            this.Controls.Add(butt);
            //////////////////////////////////////////////////////////////////////////// 
            img.Size = new Size(1000, 600);
            img.Image = Image.FromFile(@"..\..\img\kinoshka2.jpg");
            this.Controls.Add(img);
            /////////////////////////////////////////////////////////////////////////////////////

        }


        private void but_Click(object sender, EventArgs e)
        {
            films uus_aken = new films();
            this.Hide();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void butt_Click(object sender, EventArgs e)
        {
            admin_panel uus_aken = new admin_panel();
            this.Hide();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}