using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public bool DisBool = false;
        public bool SpeedBool = false;
        public bool TimeBool = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Distans";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            label2.Text = "Din hastighet";
            label3.Text = "Tid till destination";

            button5.Text = "Tillbaks";

            DisBool = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hastighet";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            label2.Text = "Distans kvar";
            label3.Text = "Tid till destination";

            button5.Text = "Tillbaks";

            SpeedBool = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Tid";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            label2.Text = "Din hastighet";
            label3.Text = "Distans kvar";

            button5.Text = "Tillbaks";

            TimeBool = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DisBool == true)
            {
                float DisFloat;
                string Dis;

                string Speed;
                Speed = textBox1.Text;

                float SpeedFloat = Convert.ToSingle(Speed);

                string Time;
                Time = textBox2.Text;

                float TimeFloat = Convert.ToSingle(Time);

                TimeFloat = TimeFloat * 60f;
                SpeedFloat = SpeedFloat / 3.6f;

                DisFloat = SpeedFloat * TimeFloat;
                DisFloat = DisFloat / 1000f;

                Dis = Convert.ToString(DisFloat);

                label4.Text = Dis + "km till Destination";

            }

            if(SpeedBool == true)
            {
                float SpeedFloat;
                string Speed;

                string Dis;
                Dis = textBox1.Text;

                float DisFloat = Convert.ToSingle(Dis);

                string Time;
                Time = textBox2.Text;

                float TimeFloat = Convert.ToSingle(Time);

                DisFloat = DisFloat * 1000f;
                TimeFloat = TimeFloat * 60;

                SpeedFloat = DisFloat / TimeFloat;
                SpeedFloat = SpeedFloat * 3.6f;

                Speed = Convert.ToString(SpeedFloat);
                label4.Text = Speed + " Km/h";
            }

            if(TimeBool == true)
            {
                float TimeFloat;
                string Time;

                string Dis;
                Dis = textBox2.Text;

                float DisFloat = Convert.ToSingle(Dis);

                string Speed;
                Speed = textBox1.Text;

                float SpeedFloat = Convert.ToSingle(Speed);

                DisFloat = DisFloat * 1000f;
                SpeedFloat = SpeedFloat / 3.6f;

                TimeFloat = DisFloat / SpeedFloat;
                TimeFloat = TimeFloat / 60f;

                Time = Convert.ToString(TimeFloat);

                label4.Text = Time + " minuter till destination";

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if(DisBool || SpeedBool || TimeBool == true)
            {
                label1.Text = "Vad vill du beräkna?";

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;

                button5.Text = "Avsluta";

                DisBool = false;
                SpeedBool = false;
                TimeBool = false;
            }
            else
            {
                this.Close();
            }

        }
    }
}
