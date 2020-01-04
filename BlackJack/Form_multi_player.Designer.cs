namespace BlackJack
{
    partial class Form_multi_player
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.btn_multi_player_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_List_Player_One = new System.Windows.Forms.TextBox();
            this.Tb_List_Player_Two = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLACK JACK - MULTI PLAYER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER ONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(667, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLAYER TWO";
            // 
            // btn_start_game
            // 
            this.btn_start_game.FlatAppearance.BorderSize = 0;
            this.btn_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_game.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_start_game.Location = new System.Drawing.Point(397, 93);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(169, 41);
            this.btn_start_game.TabIndex = 3;
            this.btn_start_game.Text = "START GAME";
            this.btn_start_game.UseVisualStyleBackColor = true;
            this.btn_start_game.Click += new System.EventHandler(this.btn_start_game_Click);
            // 
            // btn_multi_player_back
            // 
            this.btn_multi_player_back.FlatAppearance.BorderSize = 0;
            this.btn_multi_player_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi_player_back.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_multi_player_back.Location = new System.Drawing.Point(397, 140);
            this.btn_multi_player_back.Name = "btn_multi_player_back";
            this.btn_multi_player_back.Size = new System.Drawing.Size(169, 41);
            this.btn_multi_player_back.TabIndex = 4;
            this.btn_multi_player_back.Text = "BACK";
            this.btn_multi_player_back.UseVisualStyleBackColor = true;
            this.btn_multi_player_back.Click += new System.EventHandler(this.btn_multi_player_back_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(318, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 131);
            this.label5.TabIndex = 6;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_List_Player_One
            // 
            this.Tb_List_Player_One.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Player_One.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Player_One.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Player_One.Location = new System.Drawing.Point(12, 107);
            this.Tb_List_Player_One.Multiline = true;
            this.Tb_List_Player_One.Name = "Tb_List_Player_One";
            this.Tb_List_Player_One.ReadOnly = true;
            this.Tb_List_Player_One.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Player_One.Size = new System.Drawing.Size(300, 380);
            this.Tb_List_Player_One.TabIndex = 7;
            // 
            // Tb_List_Player_Two
            // 
            this.Tb_List_Player_Two.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Player_Two.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Player_Two.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Player_Two.Location = new System.Drawing.Point(672, 107);
            this.Tb_List_Player_Two.Multiline = true;
            this.Tb_List_Player_Two.Name = "Tb_List_Player_Two";
            this.Tb_List_Player_Two.ReadOnly = true;
            this.Tb_List_Player_Two.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Player_Two.Size = new System.Drawing.Size(300, 380);
            this.Tb_List_Player_Two.TabIndex = 8;
            // 
            // Form_multi_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.Tb_List_Player_Two);
            this.Controls.Add(this.Tb_List_Player_One);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_multi_player_back);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 545);
            this.MinimumSize = new System.Drawing.Size(1000, 545);
            this.Name = "Form_multi_player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLAC JACK - MULTI PLAYER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_multi_player_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Button btn_multi_player_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_List_Player_One;
        private System.Windows.Forms.TextBox Tb_List_Player_Two;
    }
}