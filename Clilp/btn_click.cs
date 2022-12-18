using System;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Clilp;


namespace Clilp
{
    public class Var
    {
        protected static decimal TMP = 0.0m;
    }
    
    public class btn_click:txt_Change
    {
        public static void Point(TextBox Input, decimal Result)
        {
            if (decimal.Parse(Input.Text) == Result || decimal.Parse(Input.Text) - Result == Result)
            {
                Input.Text = "0.";
            }
            else if (!Input.Text.Contains("."))
            {
                Input.Text += ".";
            }
        }

        public static void PlusMinus(TextBox Input)
        {
            if (Input.Text != "0")
            {
                if (Input.Text.Contains('-'))
                {
                    Input.Text = Input.Text.Trim('-');
                }
                else
                {
                    Input.Text = "-" + Input.Text;
                }
            }
        }

        public static void Delete(TextBox Input)
        {
            if (Input.TextLength > 1)
            {
                Input.Text = Input.Text.Substring(0, Input.TextLength - 1);
            }
            else
            {
                Input.Text = "0";
            }
        }

        public static void Clear(TextBox Carry, TextBox Input)
        {
            if (Input.Text != "0" && !Carry.Text.Contains("+") && !Carry.Text.Contains("-") && !Carry.Text.Contains("x") && !Carry.Text.Contains("/") && !Carry.Text.Contains("%"))
            {
                Input.Text = "0";
            }
            else if (Input.Text != "0" && Carry.Text != "0")
            {
                Input.Text = "0";
            }
            else if (Input.Text == "0")
            {
                TMP = 0;
                Carry.Text = "0";
            }
        }

        public static void Num(TextBox Input, int num)
        {
            if (Input.TextLength > Input.MaxLength - 1)
            {
                SystemSounds.Exclamation.Play();
            }
            else
            {
                if (Input.Text == "0")
                {
                    Input.Text = num.ToString();
                }
                else
                {
                    Input.Text += num.ToString();
                }
            }
        }

        public static void operation_Click(TextBox Carry, TextBox Input, ref char Operator, ref decimal Result, ListView History)
        {
            if (TMP == 0 && !Carry.Text.Contains("="))
            {
                if (Carry.Text.Contains("="))
                {
                    TMP = decimal.Parse(Input.Text);
                    Carry_Text_Changed(Carry, Input, Operator, ref Result);

                }
                else
                {
                    TMP = decimal.Parse(Input.Text);
                    Input.Text = "0";
                    Carry_Text_Changed(Carry, Input, Operator, ref Result);
                }


            }
            else
            {
                Carry_Text_Changed(Carry, Input, Operator, ref Result);
                List_Check(History, Carry);

            }
        }

        public static void Percent(TextBox Carry, TextBox Input, ref char Operator, ref decimal Result)
        {
            if (TMP == 0)
            {
                TMP = decimal.Parse(Input.Text);
                Operator = '%';
                Input.Text = "0";
                Carry_Text_Changed(Carry, Input, Operator, ref Result);

            }
            else
            {

                Operator = '%';
                Carry_Text_Changed(Carry, Input, Operator, ref Result);
                Input.Text = "0";
            }
        }

        public static void Equal(TextBox Carry, TextBox Input, ref char Operator, ref decimal Result, ListView History)
        {
            if (Operator == '*')
            {
                Result = decimal.Parse(Input.Text) * TMP;
                Carry_Text_Changed(Carry, Input, Operator, ref Result);
                List_Check(History, Carry);
                Operator = '^';
            }
            else if (Operator == '+')
            {

                Carry_Text_Changed(Carry, Input, Operator, ref Result);
                Input.Text = "0";
                List_Check(History, Carry);
                Operator = '^';
            }
            else if (Operator == '-')
            {
                Carry_Text_Changed(Carry, Input, Operator, ref Result);
                Input.Text = "0";
                List_Check(History, Carry);
                Operator = '^';
            }
            else if (Operator == '/')
            {
                if (decimal.Parse(Input.Text) == 0)
                {
                    Input.Text = "Syntax Error.";
                    TMP = 0;
                    Carry.Text = "0";
                    List_Check(History, Carry);
                    Operator = '^';
                }
                else
                {
                    Carry_Text_Changed(Carry, Input, Operator, ref Result);
                    Input.Text = "0";
                    List_Check(History, Carry);
                    Operator = '^';
                }
            }
            else if (Operator == '%')
            {
                if (Input.Text == "0" || Input.Text == "0" && Carry.Text != "0")
                {
                    Input.Text = "Syntax Error";
                }
                else
                {
                    Carry_Text_Changed(Carry, Input, Operator, ref Result);
                    Input.Text = "%" + Result.ToString();
                    List_Check(History, Carry);
                    Operator = '^';
                }

            }
        }
    }   
}