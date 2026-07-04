namespace TicTacToe
{
    partial class Form1
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblStatus = new Label();
            BtnRestart = new Button();
            lblXScore = new Label();
            lblOScore = new Label();
            lblDraws = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(158, 80);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 82);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(280, 80);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 82);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(404, 80);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 82);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(158, 192);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 82);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(280, 192);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 82);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(404, 192);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 82);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(158, 302);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 82);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(280, 302);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 82);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(404, 302);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 82);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(206, 412);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(228, 35);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Player X turn";
            // 
            // BtnRestart
            // 
            BtnRestart.Location = new Point(577, 34);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new Size(94, 29);
            BtnRestart.TabIndex = 10;
            BtnRestart.Text = "Restart";
            BtnRestart.UseVisualStyleBackColor = true;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // lblXScore
            // 
            lblXScore.AutoSize = true;
            lblXScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXScore.Location = new Point(642, 110);
            lblXScore.Name = "lblXScore";
            lblXScore.Size = new Size(54, 28);
            lblXScore.TabIndex = 11;
            lblXScore.Text = "X : 0";
            // 
            // lblOScore
            // 
            lblOScore.AutoSize = true;
            lblOScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOScore.Location = new Point(642, 138);
            lblOScore.Name = "lblOScore";
            lblOScore.Size = new Size(56, 28);
            lblOScore.TabIndex = 12;
            lblOScore.Text = "O : 0";
            // 
            // lblDraws
            // 
            lblDraws.AutoSize = true;
            lblDraws.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDraws.Location = new Point(598, 166);
            lblDraws.Name = "lblDraws";
            lblDraws.Size = new Size(100, 28);
            lblDraws.TabIndex = 13;
            lblDraws.Text = "Draws : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 492);
            Controls.Add(lblDraws);
            Controls.Add(lblOScore);
            Controls.Add(lblXScore);
            Controls.Add(BtnRestart);
            Controls.Add(lblStatus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Lihle's Tic Tac Toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lblStatus;
        private Button BtnRestart;
        private Label lblXScore;
        private Label lblOScore;
        private Label lblDraws;
    }
}
