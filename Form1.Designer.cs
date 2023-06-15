namespace Calculadora
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
            lblTitle = new Label();
            tbx_screen = new TextBox();
            btn_plus = new Button();
            btn_sub = new Button();
            btn_multip = new Button();
            btn_div = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_5 = new Button();
            btn_clear = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_dot = new Button();
            btn_res = new Button();
            btn_0 = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(54, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Calculator";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbx_screen
            // 
            tbx_screen.BorderStyle = BorderStyle.FixedSingle;
            tbx_screen.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_screen.Location = new Point(12, 68);
            tbx_screen.Name = "tbx_screen";
            tbx_screen.Size = new Size(262, 43);
            tbx_screen.TabIndex = 1;
            tbx_screen.Text = "0";
            tbx_screen.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.FromArgb(128, 128, 255);
            btn_plus.FlatAppearance.BorderColor = Color.Fuchsia;
            btn_plus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_plus.ForeColor = Color.White;
            btn_plus.Location = new Point(12, 117);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(61, 57);
            btn_plus.TabIndex = 2;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += construction_operation;
            // 
            // btn_sub
            // 
            btn_sub.BackColor = Color.FromArgb(128, 128, 255);
            btn_sub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sub.ForeColor = Color.White;
            btn_sub.Location = new Point(79, 117);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(61, 57);
            btn_sub.TabIndex = 3;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = false;
            btn_sub.Click += construction_operation;
            // 
            // btn_multip
            // 
            btn_multip.BackColor = Color.FromArgb(128, 128, 255);
            btn_multip.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multip.ForeColor = Color.White;
            btn_multip.Location = new Point(146, 117);
            btn_multip.Name = "btn_multip";
            btn_multip.Size = new Size(61, 57);
            btn_multip.TabIndex = 4;
            btn_multip.Text = "*";
            btn_multip.UseVisualStyleBackColor = false;
            btn_multip.Click += construction_operation;
            // 
            // btn_div
            // 
            btn_div.BackColor = Color.FromArgb(128, 128, 255);
            btn_div.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_div.ForeColor = Color.White;
            btn_div.Location = new Point(213, 117);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(61, 57);
            btn_div.TabIndex = 5;
            btn_div.Text = "÷";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += construction_operation;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Silver;
            btn_1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1.ForeColor = Color.White;
            btn_1.Location = new Point(12, 180);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(61, 57);
            btn_1.TabIndex = 6;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += construction_operation;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Silver;
            btn_2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_2.ForeColor = Color.White;
            btn_2.Location = new Point(79, 180);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(61, 57);
            btn_2.TabIndex = 7;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += construction_operation;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Silver;
            btn_4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_4.ForeColor = Color.White;
            btn_4.Location = new Point(12, 243);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(61, 57);
            btn_4.TabIndex = 8;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += construction_operation;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Silver;
            btn_3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_3.ForeColor = Color.White;
            btn_3.Location = new Point(146, 180);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(61, 57);
            btn_3.TabIndex = 9;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += construction_operation;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Silver;
            btn_5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_5.ForeColor = Color.White;
            btn_5.Location = new Point(79, 243);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(61, 57);
            btn_5.TabIndex = 10;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += construction_operation;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(128, 128, 255);
            btn_clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(213, 180);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(61, 57);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "AC";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.Silver;
            btn_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_6.ForeColor = Color.White;
            btn_6.Location = new Point(146, 241);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(61, 57);
            btn_6.TabIndex = 12;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += construction_operation;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Silver;
            btn_7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_7.ForeColor = Color.White;
            btn_7.Location = new Point(12, 306);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(61, 57);
            btn_7.TabIndex = 13;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += construction_operation;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.Silver;
            btn_8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_8.ForeColor = Color.White;
            btn_8.Location = new Point(79, 304);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(61, 57);
            btn_8.TabIndex = 14;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += construction_operation;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.Silver;
            btn_9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_9.ForeColor = Color.White;
            btn_9.Location = new Point(146, 304);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(61, 57);
            btn_9.TabIndex = 15;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += construction_operation;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.Silver;
            btn_dot.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dot.ForeColor = Color.White;
            btn_dot.Location = new Point(146, 367);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(61, 57);
            btn_dot.TabIndex = 16;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += construction_operation;
            // 
            // btn_res
            // 
            btn_res.BackColor = Color.FromArgb(128, 128, 255);
            btn_res.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_res.ForeColor = Color.White;
            btn_res.Location = new Point(213, 306);
            btn_res.Name = "btn_res";
            btn_res.Size = new Size(61, 118);
            btn_res.TabIndex = 17;
            btn_res.Text = "=";
            btn_res.UseVisualStyleBackColor = false;
            btn_res.Click += operation;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.Silver;
            btn_0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_0.ForeColor = Color.White;
            btn_0.Location = new Point(12, 367);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(128, 57);
            btn_0.TabIndex = 18;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += construction_operation;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(128, 128, 255);
            btn_back.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(213, 243);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(61, 57);
            btn_back.TabIndex = 19;
            btn_back.Text = "←";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 437);
            Controls.Add(btn_back);
            Controls.Add(btn_0);
            Controls.Add(btn_res);
            Controls.Add(btn_dot);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_clear);
            Controls.Add(btn_5);
            Controls.Add(btn_3);
            Controls.Add(btn_4);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_div);
            Controls.Add(btn_multip);
            Controls.Add(btn_sub);
            Controls.Add(btn_plus);
            Controls.Add(tbx_screen);
            Controls.Add(lblTitle);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox tbx_screen;
        private Button btn_plus;
        private Button btn_sub;
        private Button btn_multip;
        private Button btn_div;
        private Button btn_1;
        private Button btn_2;
        private Button btn_4;
        private Button btn_3;
        private Button btn_5;
        private Button btn_clear;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_dot;
        private Button btn_res;
        private Button btn_0;
        private Button btn_back;
    }
}