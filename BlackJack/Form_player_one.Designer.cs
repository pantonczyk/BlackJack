namespace BlackJack
{
    partial class Form_player_one
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_player_one_random = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_List_Random_Cards = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_player_one_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYER ONE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_player_one_random
            // 
            this.btn_player_one_random.FlatAppearance.BorderSize = 0;
            this.btn_player_one_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_player_one_random.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_player_one_random.Location = new System.Drawing.Point(352, 237);
            this.btn_player_one_random.Name = "btn_player_one_random";
            this.btn_player_one_random.Size = new System.Drawing.Size(169, 41);
            this.btn_player_one_random.TabIndex = 2;
            this.btn_player_one_random.Text = "RANDOM";
            this.btn_player_one_random.UseVisualStyleBackColor = true;
            this.btn_player_one_random.Click += new System.EventHandler(this.btn_player_one_random_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label3.Location = new System.Drawing.Point(412, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wylosowane karty:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_List_Random_Cards
            // 
            this.Tb_List_Random_Cards.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Random_Cards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Random_Cards.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Random_Cards.Location = new System.Drawing.Point(5, 88);
            this.Tb_List_Random_Cards.Multiline = true;
            this.Tb_List_Random_Cards.Name = "Tb_List_Random_Cards";
            this.Tb_List_Random_Cards.ReadOnly = true;
            this.Tb_List_Random_Cards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Random_Cards.Size = new System.Drawing.Size(308, 353);
            this.Tb_List_Random_Cards.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label2.Location = new System.Drawing.Point(331, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score:";
            // 
            // btn_player_one_next
            // 
            this.btn_player_one_next.FlatAppearance.BorderSize = 0;
            this.btn_player_one_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_player_one_next.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_player_one_next.Location = new System.Drawing.Point(352, 284);
            this.btn_player_one_next.Name = "btn_player_one_next";
            this.btn_player_one_next.Size = new System.Drawing.Size(169, 41);
            this.btn_player_one_next.TabIndex = 8;
            this.btn_player_one_next.Text = "NEXT PLAYER";
            this.btn_player_one_next.UseVisualStyleBackColor = true;
            this.btn_player_one_next.Click += new System.EventHandler(this.btn_player_one_next_Click);
            // 
            // Form_player_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btn_player_one_next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_List_Random_Cards);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_player_one_random);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form_player_one";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLACK JACK - PLAYER ONE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_player_one_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_player_one_random;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_List_Random_Cards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_player_one_next;
    }
}