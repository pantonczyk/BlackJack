namespace BlackJack
{
    partial class Form_Single_Player
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
            this.btn_single_player_reuslt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_List_Random_Cards = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_single_player_random = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_single_player_reuslt
            // 
            this.btn_single_player_reuslt.FlatAppearance.BorderSize = 0;
            this.btn_single_player_reuslt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_player_reuslt.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_single_player_reuslt.Location = new System.Drawing.Point(352, 290);
            this.btn_single_player_reuslt.Name = "btn_single_player_reuslt";
            this.btn_single_player_reuslt.Size = new System.Drawing.Size(169, 41);
            this.btn_single_player_reuslt.TabIndex = 15;
            this.btn_single_player_reuslt.Text = "RESULT";
            this.btn_single_player_reuslt.UseVisualStyleBackColor = true;
            this.btn_single_player_reuslt.Click += new System.EventHandler(this.btn_single_player_reuslt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label2.Location = new System.Drawing.Point(331, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Score:";
            // 
            // Tb_List_Random_Cards
            // 
            this.Tb_List_Random_Cards.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Random_Cards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Random_Cards.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Random_Cards.Location = new System.Drawing.Point(5, 94);
            this.Tb_List_Random_Cards.Multiline = true;
            this.Tb_List_Random_Cards.Name = "Tb_List_Random_Cards";
            this.Tb_List_Random_Cards.ReadOnly = true;
            this.Tb_List_Random_Cards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Random_Cards.Size = new System.Drawing.Size(308, 353);
            this.Tb_List_Random_Cards.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wylosowane karty:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label3.Location = new System.Drawing.Point(412, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 11;
            // 
            // btn_single_player_random
            // 
            this.btn_single_player_random.FlatAppearance.BorderSize = 0;
            this.btn_single_player_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_player_random.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_single_player_random.Location = new System.Drawing.Point(352, 243);
            this.btn_single_player_random.Name = "btn_single_player_random";
            this.btn_single_player_random.Size = new System.Drawing.Size(169, 41);
            this.btn_single_player_random.TabIndex = 10;
            this.btn_single_player_random.Text = "RANDOM";
            this.btn_single_player_random.UseVisualStyleBackColor = true;
            this.btn_single_player_random.Click += new System.EventHandler(this.btn_single_player_random_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "PLAYER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Single_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btn_single_player_reuslt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_List_Random_Cards);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_single_player_random);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form_Single_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLACK JACK -SINGLE GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Single_Player_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_single_player_reuslt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_List_Random_Cards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_single_player_random;
        private System.Windows.Forms.Label label1;
    }
}