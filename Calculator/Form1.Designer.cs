namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("No History Here.");
            this.Input = new System.Windows.Forms.TextBox();
            this.Seven = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiblication = new System.Windows.Forms.Button();
            this.TMP_Carry = new System.Windows.Forms.TextBox();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.HistoryList = new System.Windows.Forms.ListView();
            this.Header = new System.Windows.Forms.ColumnHeader();
            this.Clear_H = new System.Windows.Forms.Button();
            this.seperator = new System.Windows.Forms.Label();
            this.Calc_Name = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Black;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(6, 86);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Input.MaxLength = 10;
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Input.Size = new System.Drawing.Size(319, 55);
            this.Input.TabIndex = 25;
            this.Input.Text = "0";
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Seven
            // 
            this.Seven.AutoSize = true;
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seven.FlatAppearance.BorderSize = 0;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Seven.Location = new System.Drawing.Point(7, 210);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(75, 55);
            this.Seven.TabIndex = 12;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Four
            // 
            this.Four.AutoSize = true;
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Four.FlatAppearance.BorderSize = 0;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Four.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Four.Location = new System.Drawing.Point(7, 271);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 55);
            this.Four.TabIndex = 2;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // One
            // 
            this.One.AutoSize = true;
            this.One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.One.Cursor = System.Windows.Forms.Cursors.Hand;
            this.One.FlatAppearance.BorderSize = 0;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.One.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.One.Location = new System.Drawing.Point(7, 332);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 55);
            this.One.TabIndex = 3;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.AutoSize = true;
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Zero.Location = new System.Drawing.Point(7, 393);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 55);
            this.Zero.TabIndex = 4;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Point.FlatAppearance.BorderSize = 0;
            this.Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Point.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Point.Location = new System.Drawing.Point(88, 393);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(75, 55);
            this.Point.TabIndex = 8;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Two
            // 
            this.Two.AutoSize = true;
            this.Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Two.FlatAppearance.BorderSize = 0;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Two.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Two.Location = new System.Drawing.Point(88, 332);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 55);
            this.Two.TabIndex = 7;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Five
            // 
            this.Five.AutoSize = true;
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Five.FlatAppearance.BorderSize = 0;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Five.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Five.Location = new System.Drawing.Point(88, 271);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 55);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Eight
            // 
            this.Eight.AutoSize = true;
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eight.FlatAppearance.BorderSize = 0;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eight.Location = new System.Drawing.Point(88, 210);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 55);
            this.Eight.TabIndex = 5;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Three
            // 
            this.Three.AutoSize = true;
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Three.FlatAppearance.BorderSize = 0;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Three.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Three.Location = new System.Drawing.Point(169, 332);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 55);
            this.Three.TabIndex = 11;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Six
            // 
            this.Six.AutoSize = true;
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Six.FlatAppearance.BorderSize = 0;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Six.Location = new System.Drawing.Point(169, 271);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 55);
            this.Six.TabIndex = 10;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Nine
            // 
            this.Nine.AutoSize = true;
            this.Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nine.FlatAppearance.BorderSize = 0;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nine.Location = new System.Drawing.Point(169, 210);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 55);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Divide
            // 
            this.Divide.AutoSize = true;
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(5)))));
            this.Divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(250, 149);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 55);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(5)))));
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(250, 332);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 55);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(7, 149);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 55);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(5)))));
            this.Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Percent.FlatAppearance.BorderSize = 0;
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percent.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Percent.Location = new System.Drawing.Point(169, 149);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(75, 55);
            this.Percent.TabIndex = 22;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Equal
            // 
            this.Equal.AutoSize = true;
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Equal.FlatAppearance.BorderSize = 0;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Equal.Location = new System.Drawing.Point(250, 393);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(75, 55);
            this.Equal.TabIndex = 1;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(5)))));
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(250, 271);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 55);
            this.Minus.TabIndex = 23;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiblication
            // 
            this.Multiblication.AutoSize = true;
            this.Multiblication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(5)))));
            this.Multiblication.FlatAppearance.BorderSize = 0;
            this.Multiblication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiblication.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiblication.Location = new System.Drawing.Point(250, 210);
            this.Multiblication.Name = "Multiblication";
            this.Multiblication.Size = new System.Drawing.Size(75, 55);
            this.Multiblication.TabIndex = 24;
            this.Multiblication.Text = "x";
            this.Multiblication.UseVisualStyleBackColor = false;
            this.Multiblication.Click += new System.EventHandler(this.Multiblication_Click);
            // 
            // TMP_Carry
            // 
            this.TMP_Carry.BackColor = System.Drawing.Color.Black;
            this.TMP_Carry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TMP_Carry.Enabled = false;
            this.TMP_Carry.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TMP_Carry.ForeColor = System.Drawing.Color.White;
            this.TMP_Carry.Location = new System.Drawing.Point(47, 54);
            this.TMP_Carry.MaxLength = 10;
            this.TMP_Carry.Name = "TMP_Carry";
            this.TMP_Carry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TMP_Carry.Size = new System.Drawing.Size(278, 24);
            this.TMP_Carry.TabIndex = 0;
            this.TMP_Carry.TabStop = false;
            this.TMP_Carry.Text = "0";
            this.TMP_Carry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlusMinus
            // 
            this.PlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PlusMinus.FlatAppearance.BorderSize = 0;
            this.PlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusMinus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PlusMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlusMinus.Location = new System.Drawing.Point(169, 393);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(75, 55);
            this.PlusMinus.TabIndex = 26;
            this.PlusMinus.Text = "-/+";
            this.PlusMinus.UseVisualStyleBackColor = false;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(88, 149);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 55);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "⌫";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Verdana", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.History.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.History.Image = ((System.Drawing.Image)(resources.GetObject("History.Image")));
            this.History.Location = new System.Drawing.Point(7, 49);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.History.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.History.Size = new System.Drawing.Size(33, 33);
            this.History.TabIndex = 28;
            this.History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // HistoryList
            // 
            this.HistoryList.BackColor = System.Drawing.Color.Black;
            this.HistoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header});
            this.HistoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryList.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryList.ForeColor = System.Drawing.SystemColors.Window;
            this.HistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.HistoryList.HideSelection = false;
            listViewItem2.StateImageIndex = 0;
            this.HistoryList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.HistoryList.Location = new System.Drawing.Point(345, 49);
            this.HistoryList.MultiSelect = false;
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(225, 350);
            this.HistoryList.TabIndex = 29;
            this.HistoryList.UseCompatibleStateImageBehavior = false;
            this.HistoryList.View = System.Windows.Forms.View.Details;
            // 
            // Header
            // 
            this.Header.Text = "";
            this.Header.Width = 190;
            // 
            // Clear_H
            // 
            this.Clear_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Clear_H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_H.FlatAppearance.BorderSize = 0;
            this.Clear_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_H.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear_H.Location = new System.Drawing.Point(345, 405);
            this.Clear_H.Name = "Clear_H";
            this.Clear_H.Size = new System.Drawing.Size(225, 38);
            this.Clear_H.TabIndex = 30;
            this.Clear_H.Text = "Clear History";
            this.Clear_H.UseVisualStyleBackColor = false;
            this.Clear_H.Visible = false;
            this.Clear_H.Click += new System.EventHandler(this.Clear_H_Click);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Silver;
            this.seperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seperator.Location = new System.Drawing.Point(338, 48);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(1, 399);
            this.seperator.TabIndex = 31;
            // 
            // Calc_Name
            // 
            this.Calc_Name.AutoSize = true;
            this.Calc_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_Name.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calc_Name.ForeColor = System.Drawing.Color.Green;
            this.Calc_Name.Location = new System.Drawing.Point(-3, 8);
            this.Calc_Name.Name = "Calc_Name";
            this.Calc_Name.Size = new System.Drawing.Size(149, 32);
            this.Calc_Name.TabIndex = 32;
            this.Calc_Name.Text = "Calculator";
            this.Calc_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calc_Name_MouseDown);
            this.Calc_Name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calc_Name_MouseMove);
            this.Calc_Name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Calc_Name_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = global::Calculator.Properties.Resources._removal_ai__tmp_637820c6e736b_HL6S0G;
            this.Exit.Location = new System.Drawing.Point(285, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 40);
            this.Exit.TabIndex = 33;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(239, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 40);
            this.Minimize.TabIndex = 34;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 454);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calc_Name);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.Clear_H);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.TMP_Carry);
            this.Controls.Add(this.Multiblication);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.Opacity = 0.99900000000000011D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiblication;
        private System.Windows.Forms.TextBox TMP_Carry;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.ListView HistoryList;
        private System.Windows.Forms.Button Clear_H;
        private System.Windows.Forms.ColumnHeader Header;
        private System.Windows.Forms.Label seperator;
        private System.Windows.Forms.Label Calc_Name;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
    }
}
