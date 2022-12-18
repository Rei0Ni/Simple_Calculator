using System.Windows.Forms;


namespace Clilp
{
    public class txt_Change:Var
    {
        public static void Input_Text_Changed(TextBox Input)
        {
            if (Input.Text == "-")
            {
                Input.Text = "0";
            }
        }

        protected static void Carry_Text_Changed(TextBox Carry, TextBox Input, char Operator, ref decimal Result)
        {
            if (TMP != 0 || TMP == 0 && Carry.Text.Contains("=") || Carry.Text == "0 -")
            {
                switch (Operator)
                {
                    case '*':
                        {
                            if (Input.Text != "0")
                            {
                                Result = TMP * decimal.Parse(Input.Text);
                                Carry.Text = TMP.ToString() + " x " + Input.Text + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else
                            {
                                Carry.Text = TMP.ToString() + " x";
                            }
                            break;
                        }
                    case '/':
                        {
                            if (Input.Text != "0")
                            {
                                Result = TMP / decimal.Parse(Input.Text);
                                Carry.Text = TMP.ToString() + " / " + Input.Text + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else
                            {
                                Carry.Text = TMP.ToString() + " /";
                            }
                            break;
                        }
                    case '+':
                        {
                            if (Input.Text != "0")
                            {
                                Result = TMP + decimal.Parse(Input.Text);
                                Carry.Text = TMP.ToString() + " + " + Input.Text + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else
                            {
                                Carry.Text = TMP.ToString() + " +";
                            }
                            break;
                        }
                    case '-':
                        {
                            if(Carry.Text == "0 -")
                            {
                                Result = decimal.Parse(Input.Text) - TMP;
                                Carry.Text = Input.Text + " - " + TMP.ToString() + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else if (Input.Text != "0")
                            {
                                Result = TMP - decimal.Parse(Input.Text);
                                Carry.Text = TMP.ToString() + " - " + Input.Text + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else
                            {
                                Carry.Text = TMP.ToString() + " -";
                            }
                            break;
                        }
                    case '%':
                        {
                            if (Input.Text != "0")
                            {
                                Result = (TMP / decimal.Parse(Input.Text)) * 100;
                                Carry.Text = TMP.ToString() + " % " + Input.Text + " = " + Result;
                                TMP = Result;
                                Input.Text = "0";
                            }
                            else
                            {
                                Carry.Text = TMP.ToString() + " %";
                            }

                            break;
                        }
                }
            }
        }

        protected static void List_Check(ListView History, TextBox Carry)
        {
            if (History.Items[0].Text == "No History Here.")
            {
                History.Items[0].Remove();
                History.Items.Add(Carry.Text);
            }
            else if (Carry.Text.Substring(Carry.TextLength - 1) != "+" && Carry.Text.Substring(Carry.TextLength - 1) != "-" && Carry.Text.Substring(Carry.TextLength - 1) != "x" && Carry.Text.Substring(Carry.TextLength - 1) != "/")
            {
                History.Items.Add(Carry.Text);
            }
        }
    }
}
