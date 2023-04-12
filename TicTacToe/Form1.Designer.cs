using System.Windows.Forms;

namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";

            const int buttonX = 200;
            const int buttonY = 200;
            int counter = 0;
            int lessCode = 0;

            btn1 = new Button();
            btn1.Font = new System.Drawing.Font("", 40);
            btn1.Size = new System.Drawing.Size(buttonX, buttonY);
            btn1.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn1.BackColor = System.Drawing.Color.Azure;
                    btn1.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn1.BackColor = System.Drawing.Color.Bisque;
                    btn1.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn1.Enabled = false;

            };

            btn2 = new Button();
            btn2.Font = new System.Drawing.Font("", 40);
            btn2.Location = new System.Drawing.Point(200, 0);
            btn2.Size = new System.Drawing.Size(buttonX, buttonY);
            btn2.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn2.BackColor = System.Drawing.Color.Azure;
                    btn2.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn2.BackColor = System.Drawing.Color.Bisque;
                    btn2.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn2.Enabled = false;
            };

            btn3 = new Button();
            btn3.Font = new System.Drawing.Font("", 40);
            btn3.Location = new System.Drawing.Point(400, 0);
            btn3.Size = new System.Drawing.Size(buttonX, buttonY);
            btn3.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn3.BackColor = System.Drawing.Color.Azure;
                    btn3.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn3.BackColor = System.Drawing.Color.Bisque;
                    btn3.Text = "X";

                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn3.Enabled = false;
            };

            btn4 = new Button();
            btn4.Font = new System.Drawing.Font("", 40);
            btn4.Location = new System.Drawing.Point(0, 200);
            btn4.Size = new System.Drawing.Size(buttonX, buttonY);
            btn4.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn4.BackColor = System.Drawing.Color.Azure;
                    btn4.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn4.BackColor = System.Drawing.Color.Bisque;
                    btn4.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn4.Enabled = false;
            };

            btn5 = new Button();
            btn5.Font = new System.Drawing.Font("", 40);
            btn5.Location = new System.Drawing.Point(200, 200);
            btn5.Size = new System.Drawing.Size(buttonX, buttonY);
            btn5.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn5.BackColor = System.Drawing.Color.Azure;
                    btn5.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn5.BackColor = System.Drawing.Color.Bisque;
                    btn5.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn5.Enabled = false;
            };

            btn6 = new Button();
            btn6.Font = new System.Drawing.Font("", 40);
            btn6.Location = new System.Drawing.Point(400, 200);
            btn6.Size = new System.Drawing.Size(buttonX, buttonY);
            btn6.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn6.BackColor = System.Drawing.Color.Azure;
                    btn6.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn6.BackColor = System.Drawing.Color.Bisque;
                    btn6.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn6.Enabled = false;
            };

            btn7 = new Button();
            btn7.Font = new System.Drawing.Font("", 40);
            btn7.Location = new System.Drawing.Point(0, 400);
            btn7.Size = new System.Drawing.Size(buttonX, buttonY);
            btn7.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn7.BackColor = System.Drawing.Color.Azure;
                    btn7.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn7.BackColor = System.Drawing.Color.Bisque;
                    btn7.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn7.Enabled = false;
            };

            btn8 = new Button();
            btn8.Font = new System.Drawing.Font("", 40);
            btn8.Location = new System.Drawing.Point(200, 400);
            btn8.Size = new System.Drawing.Size(buttonX, buttonY);
            btn8.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn8.BackColor = System.Drawing.Color.Azure;
                    btn8.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn8.BackColor = System.Drawing.Color.Bisque;
                    btn8.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn8.Enabled = false;
            };

            btn9 = new Button();
            btn9.Font = new System.Drawing.Font("", 40);
            btn9.Location = new System.Drawing.Point(400, 400);
            btn9.Size = new System.Drawing.Size(buttonX, buttonY);
            btn9.Click += (e, sender) =>
            {
                counter++;
                if (counter % 2 == 0)
                {
                    btn9.BackColor = System.Drawing.Color.Azure;
                    btn9.Text = "O";
                    if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                    {
                        this.Text = "O wins!";
                        lessCode++;
                    }
                }
                else
                {
                    btn9.BackColor = System.Drawing.Color.Bisque;
                    btn9.Text = "X";
                    if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
                    {
                        this.Text = "X wins!";
                        lessCode++;
                    }
                }
                if (lessCode == 1)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                    return;
                }
                btn9.Enabled = false;
            };



            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
            this.Controls.Add(btn9);
        }

        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        #endregion
    }
}

