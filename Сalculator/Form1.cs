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
        private static string culc_str = "";
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

            bool error = false;//div on zero
            bool singl = false;
            string fun = "";
            Rarg = Input;

            /// protection{
            
            if (Rarg == ""|| Rarg == ",") Rarg = "0";
            if (Larg == ""|| Larg == ",") Larg = "0";
            /// protection}
            /// 
            double equally = Convert.ToDouble(Rarg);
            double double_Larg = Convert.ToDouble(Larg);
            double double_Rarg = Convert.ToDouble(Rarg);
            switch (command)
            {
                //Arithmetic operations {
                case "add": { equally = double_Larg + double_Rarg; break; }
                case "sub": { equally = double_Larg - double_Rarg; break; }
                case "mul": { equally = double_Larg * double_Rarg; break; }
                case "div": { if (double_Rarg != 0) { equally = double_Larg / double_Rarg; } else { error = true; } break; }
                //Arithmetic operations }

                // Functions {
                case "sqrt": { equally = Math.Sqrt(double_Rarg); fun = "sqrt( "; singl = true; break; }
                case "sin": { equally = Math.Sin(double_Rarg); fun = "sin( "; singl = true; break; }
                case "cos": { equally = Math.Cos(double_Rarg); fun = "cos( "; singl = true; break; }
                //case "sqrt": {; break; }
                //case "sqrt": {; break; }
                //case "sqrt": {; break; }
                // Functions }

                default: equally = Convert.ToDouble(BoxText.Text); break;// no command
            }
            command = "";
            //Larg = Convert.ToString(equally);
            Larg = Convert.ToString(equally);

            if (error) BoxText.Text = "error!";
            else { if (Larg != "") BoxText.Text = Convert.ToString(equally); else BoxText.Text = BoxText.Text; }
            
            Input = "";

            if (singl) culc_str = fun + Rarg +" )=";
            else culc_str +=" "+ Rarg + " =";
            
            culc.Text = culc_str;
            culc_str = "";
            if (culc.Text == " 0 =") { BoxText.Text = "0"; }
        }
        
        private void clean_Click(object sender, EventArgs e)
        {
            Larg = "";
            Rarg = "";
            Input = "";
            BoxText.Text = "0";

            culc_str = "";
            culc.Text = culc_str;
           
        }

        private void add_Click(object sender, EventArgs e)//ADD
        {
            if(Input !="") Larg = Input;
            Input = "";
            command = "add";

            BoxText.Text = Larg;
            culc_str += Larg + " +";
            culc.Text = culc_str;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "sub";
            BoxText.Text = Larg;

            BoxText.Text = Larg;
            culc_str += Larg + " -";
            culc.Text = culc_str;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "mul";
            BoxText.Text = Larg;

            BoxText.Text = Larg;
            culc_str += Larg + " *";
            culc.Text = culc_str;
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (Input != "") Larg = Input;
            Input = "";
            command = "div";
            BoxText.Text = Larg;

            BoxText.Text = Larg;
            culc_str += Larg + " /";
            culc.Text = culc_str;
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
                if (Input == "") Input = "0";
                BoxText.Text = Input;
            }
        }

        private void sin_Click(object sender, EventArgs e)// in radians!!!
        {
                Rarg = Input;

                command = "sin";

                culc.Text = "sin( " + Rarg + " )";
        }

        private void cos_Click(object sender, EventArgs e)// in radians!!!
        {
            Rarg = Input;

            command = "cos";

            culc.Text = "cos( " + Rarg + " )";
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            Rarg = Input;
            
            command = "sqrt";

            culc.Text = "sqrt( " + Rarg + " )";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// keyboar reader
        {

            /// Enter(equaly)
            if (e.KeyCode == Keys.Enter)
                this.enter_Click(new object(), new EventArgs());

            if(e.KeyCode == Keys.Back)
                this.backspace_Click(new object(), new EventArgs());


            // num lock {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                this.zero_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
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
            //num lock }

            //Arithmetic operations{
            if (e.KeyCode == Keys.Add)
                this.add_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.Subtract)
                this.sub_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.Multiply)
                this.mul_Click(new object(), new EventArgs());
            if (e.KeyCode == Keys.Divide)
                this.div_Click(new object(), new EventArgs());
           // Arithmetic operations}

            //  e.SuppressKeyPress = true;
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
               // this.enter_Click(new object(), new EventArgs());

        }


        /// Function

    }
}
 