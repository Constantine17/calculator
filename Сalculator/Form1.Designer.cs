namespace Сalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button nine;
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.L_arg = new System.Windows.Forms.TextBox();
            this.R_arg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxText = new System.Windows.Forms.TextBox();
            this._Input = new System.Windows.Forms.TextBox();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            nine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(147, 38);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(52, 43);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(205, 38);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(52, 43);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            nine.CausesValidation = false;
            nine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nine.Location = new System.Drawing.Point(263, 38);
            nine.Name = "nine";
            nine.Size = new System.Drawing.Size(52, 43);
            nine.TabIndex = 3;
            nine.TabStop = false;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(147, 87);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(52, 43);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(205, 87);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(52, 43);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(263, 87);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(52, 43);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(147, 136);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(52, 43);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(205, 136);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(52, 43);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(263, 136);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(52, 43);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(263, 185);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(52, 43);
            this.point.TabIndex = 10;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(147, 185);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(110, 43);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(89, 136);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(52, 43);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(89, 87);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(52, 43);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(89, 38);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(52, 43);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(89, 185);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(52, 43);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(321, 136);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(52, 92);
            this.enter.TabIndex = 16;
            this.enter.Text = "=";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean.Location = new System.Drawing.Point(321, 38);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(52, 92);
            this.clean.TabIndex = 17;
            this.clean.Text = "C";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // L_arg
            // 
            this.L_arg.Location = new System.Drawing.Point(89, 288);
            this.L_arg.Name = "L_arg";
            this.L_arg.Size = new System.Drawing.Size(100, 20);
            this.L_arg.TabIndex = 18;
            // 
            // R_arg
            // 
            this.R_arg.Location = new System.Drawing.Point(89, 314);
            this.R_arg.Name = "R_arg";
            this.R_arg.Size = new System.Drawing.Size(100, 20);
            this.R_arg.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxText
            // 
            this.BoxText.HideSelection = false;
            this.BoxText.Location = new System.Drawing.Point(13, 8);
            this.BoxText.Name = "BoxText";
            this.BoxText.Size = new System.Drawing.Size(359, 20);
            this.BoxText.TabIndex = 21;
            this.BoxText.Text = "0";
            this.BoxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BoxText.WordWrap = false;
            // 
            // _Input
            // 
            this._Input.Location = new System.Drawing.Point(286, 300);
            this._Input.Name = "_Input";
            this._Input.Size = new System.Drawing.Size(100, 20);
            this._Input.TabIndex = 22;
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(31, 185);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(52, 43);
            this.cos.TabIndex = 26;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.Location = new System.Drawing.Point(31, 136);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(52, 43);
            this.sin.TabIndex = 25;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(31, 87);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(52, 43);
            this.sqrt.TabIndex = 24;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(31, 38);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(52, 43);
            this.backspace.TabIndex = 23;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.clean;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(390, 352);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this._Input);
            this.Controls.Add(this.BoxText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.R_arg);
            this.Controls.Add(this.L_arg);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.point);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.TextBox L_arg;
        private System.Windows.Forms.TextBox R_arg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxText;
        private System.Windows.Forms.TextBox _Input;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button backspace;
    }
}

