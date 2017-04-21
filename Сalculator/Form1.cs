using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Сalculator
{
    
    public partial class Form1 : Form
    {
        private static string Input = "";
        private static string Larg = "";
        private static string Rarg = "";
        private static string command = "";
        public Form1()
        {
            InitializeComponent();
            
        }



        private void one_Click(object sender, EventArgs e)
        {
            Input += "1";
            BoxText.Text = Input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Input += "2";
            BoxText.Text = Input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Input += "3";
            BoxText.Text = Input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Input += "4";
            BoxText.Text = Input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Input += "5";
            BoxText.Text = Input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Input += "6";
            BoxText.Text = Input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Input += "7";
            BoxText.Text = Input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Input += "8";
            BoxText.Text = Input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Input += "9";
            BoxText.Text = Input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Input += "0";
            BoxText.Text = Input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Input, @"[,]") == false) // protection from double point
            {
                if (Input == "") { Input = "0,"; BoxText.Text = Input; }
                else Input += ",";
                BoxText.Text = Input;
            }
        }

        private void enter_Click(object sender, EventArgs e)//ENTER
        {
            
            bool error=false;//div on zero
            double equally = 0;
            Rarg = Input;
            /// protection{
            if (Larg == ""|| Larg == ",") Larg = "0";
            if (Rarg == ""|| Rarg == ",") Rarg = "0";
            /// protection}

            double double_Larg = Convert.ToDouble(Larg);
            double double_Rarg = Convert.ToDouble(Rarg);
            switch (command)
            {
                case "add": { equally = double_Larg + double_Rarg; break; }
                case "sub": { equally = double_Larg - double_Rarg; break; }
                case "mul": { equally = double_Larg * double_Rarg; break; }
                case "div": { if (double_Rarg != 0) { equally = double_Larg / double_Rarg; } else { error = true; } break; }
                default: equally = double_Rarg; break;
            }

            //Larg = Convert.ToString(equally);
            Larg = Convert.ToString(equally);

            if (error) BoxText.Text = "error!";
            else BoxText.Text = Convert.ToString(equally);
            
            Input = "";

        }

        private void clean_Click(object sender, EventArgs e)
        {
            Larg = "";
            Rarg = "";
            Input = "";
            BoxText.Text = "0";
        }

        private void add_Click(object sender, EventArgs e)//ADD
        {
            if(Input !="") Larg = Input;
            Input = "";
            command = "add";
            BoxText.Text = Larg;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "sub";
            BoxText.Text = Larg;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "mul";
            BoxText.Text = Larg;
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "div";
            BoxText.Text = Larg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            L_arg.Text = Larg;
            R_arg.Text = Rarg;
            _Input.Text = Input;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (Input != "")
            {
                Input = Input.Substring(0, Input.Length - 1);
                BoxText.Text = Input;
            }
        }

        private void sin_Click(object sender, EventArgs e)// in radians!!!
        {
            if (Input != "")
            {
                Larg = Input;
                Rarg = "";
                Input = "";
                command = "sin";
                Larg = Convert.ToString(Math.Sin(Convert.ToDouble(Larg)));
                BoxText.Text = Larg;
            }
        }

        private void cos_Click(object sender, EventArgs e)// in radians!!!
        {
            Larg = Input;
            Rarg = "";
            Input = "";
            command = "sin";
            Larg = Convert.ToString(Math.Cos(Convert.ToDouble(Larg)));
            BoxText.Text = Larg;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)// keyboar reader
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                this.zero_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D1|| e.KeyCode ==Keys.NumPad1)
                this.one_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                this.two_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                this.three_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                this.four_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                this.five_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                this.six_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                this.seven_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                this.eight_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                this.nine_Click(new object(), new EventArgs());

            if (e.KeyCode == Keys.Enter)
                this.nine_Click(new object(), new EventArgs());
        }








    }
}
