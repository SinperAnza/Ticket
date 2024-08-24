using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class Form2 : Form
    {
        public static double due = 0, change;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Mango_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nMango\t \tR1199.99";
            due = due + 1199.99;
            DueLbl.Text = "R" + due.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FlyEmirtaes_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nFly Emirates \tR15000,99";
            due = due + 15000.99;
            DueLbl.Text = "R" + due.ToString();
        }

        private void Britishair_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nBritish Airways \tR3000,99";
            due = due + 3000.99;
            DueLbl.Text = "R" + due.ToString();
        }

        private void Kulula_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nKulula\t \tR2000,99";
            due = due + 2000.99;
            DueLbl.Text = "R" + due.ToString();

        }

        private void Qatarbx_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nQatar Airways \tR25000,99";
            due = due + 25000.99;
            DueLbl.Text = "R" + due.ToString();

        }

        private void FlySafair_Click(object sender, EventArgs e)
        {
            SlipRtbx.Text = SlipRtbx.Text + "\nFlySafair\t \tR1600,99";
            due = due + 1600.99;
            DueLbl.Text = "R" + due.ToString();
        }

        private void changeL_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            change = 0;
            due = 0;
            SlipRtbx.Text = "";
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(cashTbx.Text);
            change = cash - due;
            if (change < 0)
                MessageBox.Show("Not enough cash");

            changeL.Text = "R" + change.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sliprich.Text = Sliprich.Text + "\nCity to City \t R700.99";

            due = due + 700.99;
            dueb.Text = "R" + due.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            slo.Text = slo.Text + "\n Man utd  vs Man city \t R1200";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change = 0;
            due = 0;
            slick.Text = "";
        }

        private void ReyaPbx_Click(object sender, EventArgs e)
        {
            Sliprich.Text = Sliprich.Text + "\n Reya Vaya \t R300.99";

            due = due + 300.99;
            dueb.Text = "R" + due.ToString();

        }

        private void interPbx_Click(object sender, EventArgs e)
        {
            Sliprich.Text = Sliprich.Text + "\nInter Cape  \t R500.99";

            due = due + 500.99;
            dueb.Text = "R" + due.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void travisScot_Click(object sender, EventArgs e)
        {
            slick.Text = slick.Text + "\n Travis Scott \t R1500";
        }

        private void Drake2_Click(object sender, EventArgs e)
        {
            slick.Text = slick.Text + "\n Drake  \t R2500";
        }

        private void kendrick_Click(object sender, EventArgs e)
        {
            slick.Text = slick.Text + "\n Kendrick Lamar \t R3000";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void orlandoKaizer_Click(object sender, EventArgs e)
        {
            slo.Text = slo.Text + "\n Orlando pirates vs Kazier chiefs \t R450";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            slo.Text = slo.Text + "\n Real Madrid  vs Fc Barcelona  \t R1500";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(busT.Text);
            change = cash - due;
            if (change < 0)
                MessageBox.Show("Not enough cash");

            changeb.Text = "R" + change.ToString();
        }

        private void changeb_Click(object sender, EventArgs e)
        {

        }

        private void cashTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double cash = Convert.ToDouble(textBox2.Text);
            change = cash - due;
            if (change < 0)
                MessageBox.Show("Not enough cash");

            changed.Text = "R" + change.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(textBox3.Text);
            change = cash - due;
            if (change < 0)
                MessageBox.Show("Not enough cash");

            label2.Text = "R" + change.ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
