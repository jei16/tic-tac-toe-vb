namespace tic_tac_toe_vb
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PlayerOScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PlayerXScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextRoundButton = new System.Windows.Forms.Button();
            this.TicButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TicButton9 = new System.Windows.Forms.Button();
            this.TicButton8 = new System.Windows.Forms.Button();
            this.TicButton7 = new System.Windows.Forms.Button();
            this.TicButton6 = new System.Windows.Forms.Button();
            this.TicButton5 = new System.Windows.Forms.Button();
            this.TicButton4 = new System.Windows.Forms.Button();
            this.TicButton3 = new System.Windows.Forms.Button();
            this.TicButton2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 360);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 194);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.PlayerOScore);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(149, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 194);
            this.panel6.TabIndex = 4;
            // 
            // PlayerOScore
            // 
            this.PlayerOScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerOScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 82F, System.Drawing.FontStyle.Bold);
            this.PlayerOScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerOScore.Location = new System.Drawing.Point(6, 37);
            this.PlayerOScore.Name = "PlayerOScore";
            this.PlayerOScore.Size = new System.Drawing.Size(140, 153);
            this.PlayerOScore.TabIndex = 2;
            this.PlayerOScore.Text = "0";
            this.PlayerOScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player O";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.PlayerXScore);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(-2, -7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 199);
            this.panel5.TabIndex = 3;
            // 
            // PlayerXScore
            // 
            this.PlayerXScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerXScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 82F, System.Drawing.FontStyle.Bold);
            this.PlayerXScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerXScore.Location = new System.Drawing.Point(3, 42);
            this.PlayerXScore.Name = "PlayerXScore";
            this.PlayerXScore.Size = new System.Drawing.Size(140, 153);
            this.PlayerXScore.TabIndex = 1;
            this.PlayerXScore.Text = "0";
            this.PlayerXScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerXScore.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.NewGameButton);
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.NextRoundButton);
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 153);
            this.panel3.TabIndex = 1;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.NewGameButton.Location = new System.Drawing.Point(38, 57);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(224, 35);
            this.NewGameButton.TabIndex = 12;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(114, 102);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(74, 26);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NextRoundButton
            // 
            this.NextRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.NextRoundButton.Location = new System.Drawing.Point(40, 12);
            this.NextRoundButton.Name = "NextRoundButton";
            this.NextRoundButton.Size = new System.Drawing.Size(224, 35);
            this.NextRoundButton.TabIndex = 9;
            this.NextRoundButton.Text = "Next Round";
            this.NextRoundButton.UseVisualStyleBackColor = true;
            this.NextRoundButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // TicButton1
            // 
            this.TicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton1.Location = new System.Drawing.Point(36, 12);
            this.TicButton1.Name = "TicButton1";
            this.TicButton1.Size = new System.Drawing.Size(130, 130);
            this.TicButton1.TabIndex = 0;
            this.TicButton1.UseVisualStyleBackColor = true;
            this.TicButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TicButton9);
            this.panel2.Controls.Add(this.TicButton8);
            this.panel2.Controls.Add(this.TicButton7);
            this.panel2.Controls.Add(this.TicButton6);
            this.panel2.Controls.Add(this.TicButton5);
            this.panel2.Controls.Add(this.TicButton4);
            this.panel2.Controls.Add(this.TicButton3);
            this.panel2.Controls.Add(this.TicButton2);
            this.panel2.Controls.Add(this.TicButton1);
            this.panel2.Location = new System.Drawing.Point(334, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 413);
            this.panel2.TabIndex = 1;
            // 
            // TicButton9
            // 
            this.TicButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton9.Location = new System.Drawing.Point(287, 265);
            this.TicButton9.Name = "TicButton9";
            this.TicButton9.Size = new System.Drawing.Size(130, 130);
            this.TicButton9.TabIndex = 8;
            this.TicButton9.UseVisualStyleBackColor = true;
            this.TicButton9.Click += new System.EventHandler(this.TicButton9_Click);
            // 
            // TicButton8
            // 
            this.TicButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton8.Location = new System.Drawing.Point(161, 265);
            this.TicButton8.Name = "TicButton8";
            this.TicButton8.Size = new System.Drawing.Size(130, 130);
            this.TicButton8.TabIndex = 7;
            this.TicButton8.UseVisualStyleBackColor = true;
            this.TicButton8.Click += new System.EventHandler(this.TicButton8_Click);
            // 
            // TicButton7
            // 
            this.TicButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton7.Location = new System.Drawing.Point(36, 265);
            this.TicButton7.Name = "TicButton7";
            this.TicButton7.Size = new System.Drawing.Size(130, 130);
            this.TicButton7.TabIndex = 6;
            this.TicButton7.UseVisualStyleBackColor = true;
            this.TicButton7.Click += new System.EventHandler(this.TicButton7_Click);
            // 
            // TicButton6
            // 
            this.TicButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton6.Location = new System.Drawing.Point(287, 139);
            this.TicButton6.Name = "TicButton6";
            this.TicButton6.Size = new System.Drawing.Size(130, 130);
            this.TicButton6.TabIndex = 5;
            this.TicButton6.UseVisualStyleBackColor = true;
            this.TicButton6.Click += new System.EventHandler(this.TicButton6_Click);
            // 
            // TicButton5
            // 
            this.TicButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton5.Location = new System.Drawing.Point(161, 139);
            this.TicButton5.Name = "TicButton5";
            this.TicButton5.Size = new System.Drawing.Size(130, 130);
            this.TicButton5.TabIndex = 4;
            this.TicButton5.UseVisualStyleBackColor = true;
            this.TicButton5.Click += new System.EventHandler(this.TicButton5_Click);
            // 
            // TicButton4
            // 
            this.TicButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton4.Location = new System.Drawing.Point(36, 139);
            this.TicButton4.Name = "TicButton4";
            this.TicButton4.Size = new System.Drawing.Size(130, 130);
            this.TicButton4.TabIndex = 3;
            this.TicButton4.UseVisualStyleBackColor = true;
            this.TicButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TicButton3
            // 
            this.TicButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton3.Location = new System.Drawing.Point(287, 12);
            this.TicButton3.Name = "TicButton3";
            this.TicButton3.Size = new System.Drawing.Size(130, 130);
            this.TicButton3.TabIndex = 2;
            this.TicButton3.UseVisualStyleBackColor = true;
            this.TicButton3.Click += new System.EventHandler(this.TicButton3_Click);
            // 
            // TicButton2
            // 
            this.TicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TicButton2.Location = new System.Drawing.Point(161, 12);
            this.TicButton2.Name = "TicButton2";
            this.TicButton2.Size = new System.Drawing.Size(130, 130);
            this.TicButton2.TabIndex = 1;
            this.TicButton2.UseVisualStyleBackColor = true;
            this.TicButton2.Click += new System.EventHandler(this.TicButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TicButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TicButton4;
        private System.Windows.Forms.Button TicButton3;
        private System.Windows.Forms.Button TicButton2;
        private System.Windows.Forms.Button TicButton7;
        private System.Windows.Forms.Button TicButton6;
        private System.Windows.Forms.Button TicButton5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NextRoundButton;
        private System.Windows.Forms.Button TicButton9;
        private System.Windows.Forms.Button TicButton8;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label PlayerOScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label PlayerXScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewGameButton;
    }
}

