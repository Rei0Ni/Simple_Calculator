using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Media;
using Clilp;

namespace Calculator
{
    
    public partial class Calculator : Form
    {
        private bool mousedown;
        private Point mouseLocation;
        private decimal Result = 0.0m;
        private char Operator = '^';
        int num = 0;

        public Calculator()
        {
            InitializeComponent();
           
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                Zero.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                One.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                Two.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Three.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Four.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Five.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Six.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Seven.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Eight.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Nine.PerformClick();
            }
            else if(e.KeyCode == Keys.OemPeriod)
            {
                Point.PerformClick();
            }
            else if(e.KeyCode == Keys.Divide)
            {
                Divide.PerformClick();
            }
            else if(e.KeyCode == Keys.Add)
            {
                plus.PerformClick();
            }
            else if(e.KeyCode == Keys.Delete)
            {
                Clear.PerformClick();
            }
            else if(e.KeyCode == Keys.Multiply)
            {
                Multiblication.PerformClick();
            }
            else if(e.KeyCode == Keys.Subtract)
            {
                Minus.PerformClick();
            }
            else if(e.KeyValue == 192)
            {
                PlusMinus.PerformClick();
            }
            
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                Equal.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                Delete.PerformClick();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            btn_click.Delete(Input);
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            txt_Change.Input_Text_Changed(Input);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            btn_click.Clear(TMP_Carry, Input);
        }
        
        private void Zero_Click(object sender, EventArgs e)
        {
            num = 0;
            btn_click.Num(Input, num);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            btn_click.Point(Input, Result);
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            btn_click.PlusMinus(Input);
        }

        private void One_Click(object sender, EventArgs e)
        {
            num = 1;
            btn_click.Num(Input, num);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            num = 2;
            btn_click.Num(Input, num);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            num = 3;
            btn_click.Num(Input, num);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            num = 4;
            btn_click.Num(Input, num);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            num = 5;
            btn_click.Num(Input, num);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            num = 6;
            btn_click.Num(Input, num);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            num = 7;
            btn_click.Num(Input, num);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            num = 8;
            btn_click.Num(Input, num);
        }
        
        private void Nine_Click(object sender, EventArgs e)
        {
            num = 9;
            btn_click.Num(Input, num);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Operator = '+';
            btn_click.operation_Click(TMP_Carry, Input, ref Operator, ref Result, HistoryList);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Operator = '-';
            btn_click.operation_Click(TMP_Carry, Input, ref Operator, ref Result, HistoryList);
        }
        
        private void Divide_Click(object sender, EventArgs e)
        {
            Operator = '/';
            btn_click.operation_Click(TMP_Carry, Input, ref Operator, ref Result, HistoryList);
        }

        private void Multiblication_Click(object sender, EventArgs e)
        {
            Operator = '*';
            btn_click.operation_Click(TMP_Carry, Input, ref Operator, ref Result, HistoryList);
        }
        
        private void Percent_Click(object sender, EventArgs e)
        {
            btn_click.Percent(TMP_Carry, Input, ref Operator, ref Result);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            btn_click.Equal(TMP_Carry, Input, ref Operator, ref Result, HistoryList);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (800); // 500 ms
            
            MyTimer.Tick += new EventHandler(History_check);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Equal.Focus();
        }

        private void History_check(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.HistoryList.Items)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                }
                if (item.Text == "No History Here." && base.Width == 575)
                {
                    Clear_H.Visible = false;
                }
                else 
                {
                    Clear_H.Visible = true;
                }
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            if( base.Width == 332)
            {
                for (base.Width = 332; base.Width < 575; base.Width += 1) ;

                foreach (ListViewItem item in this.HistoryList.Items)
                {
                    if(item.Text == "No History Here." && base.Width == 575)
                    {
                        Clear_H.Visible = false;
                    }
                    else if (base.Width == 575)
                    {
                        Clear_H.Visible = true;
                    }
                }
            }
            else if( base.Width == 575)
            {
                for (base.Width = 575; base.Width > 332; base.Width -= 1) ;
            }
            else
            {
                base.Width = 575;
            }


        }

        private void Clear_H_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item1 in HistoryList.Items)
            {
                item1.Remove();
            }
                
            
            ListViewItem item = new ListViewItem(new[] { "No History Here." });
            HistoryList.Items.Add(item);
            Clear_H.Visible=false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            mouseLocation = e.Location;
        }

        private void Calculator_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - mouseLocation.X) + e.X, (this.Location.Y - mouseLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Calculator_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Calc_Name_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            mouseLocation = e.Location;
        }

        private void Calc_Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - mouseLocation.X) + e.X, (this.Location.Y - mouseLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Calc_Name_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
