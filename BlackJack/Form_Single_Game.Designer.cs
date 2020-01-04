namespace BlackJack
{
    partial class Form_Single_Game
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
            this.Tb_List_Computer = new System.Windows.Forms.TextBox();
            this.Tb_List_Player = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.btn_single_player_back = new System.Windows.Forms.Button();
            this.btn_single_player_start_game = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_List_Computer
            // 
            this.Tb_List_Computer.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Computer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Computer.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Computer.Location = new System.Drawing.Point(672, 113);
            this.Tb_List_Computer.Multiline = true;
            this.Tb_List_Computer.Name = "Tb_List_Computer";
            this.Tb_List_Computer.ReadOnly = true;
            this.Tb_List_Computer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Computer.Size = new System.Drawing.Size(300, 380);
            this.Tb_List_Computer.TabIndex = 17;
            // 
            // Tb_List_Player
            // 
            this.Tb_List_Player.BackColor = System.Drawing.SystemColors.Control;
            this.Tb_List_Player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_List_Player.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_List_Player.Location = new System.Drawing.Point(12, 113);
            this.Tb_List_Player.Multiline = true;
            this.Tb_List_Player.Name = "Tb_List_Player";
            this.Tb_List_Player.ReadOnly = true;
            this.Tb_List_Player.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_List_Player.Size = new System.Drawing.Size(300, 380);
            this.Tb_List_Player.TabIndex = 16;
            // 
            // label_Result
            // 
            this.label_Result.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Result.ForeColor = System.Drawing.Color.Red;
            this.label_Result.Location = new System.Drawing.Point(318, 339);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(323, 131);
            this.label_Result.TabIndex = 15;
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_single_player_back
            // 
            this.btn_single_player_back.FlatAppearance.BorderSize = 0;
            this.btn_single_player_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_player_back.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_single_player_back.Location = new System.Drawing.Point(397, 146);
            this.btn_single_player_back.Name = "btn_single_player_back";
            this.btn_single_player_back.Size = new System.Drawing.Size(169, 41);
            this.btn_single_player_back.TabIndex = 13;
            this.btn_single_player_back.Text = "BACK";
            this.btn_single_player_back.UseVisualStyleBackColor = true;
            this.btn_single_player_back.Click += new System.EventHandler(this.btn_single_player_back_Click);
            // 
            // btn_single_player_start_game
            // 
            this.btn_single_player_start_game.FlatAppearance.BorderSize = 0;
            this.btn_single_player_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_player_start_game.Font = new System.Drawing.Font("Impact", 13.8F);
            this.btn_single_player_start_game.Location = new System.Drawing.Point(397, 99);
            this.btn_single_player_start_game.Name = "btn_single_player_start_game";
            this.btn_single_player_start_game.Size = new System.Drawing.Size(169, 41);
            this.btn_single_player_start_game.TabIndex = 12;
            this.btn_single_player_start_game.Text = "START GAME";
            this.btn_single_player_start_game.UseVisualStyleBackColor = true;
            this.btn_single_player_start_game.Click += new System.EventHandler(this.btn_single_player_start_game_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(667, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "COMPUTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "PLAYER ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "BLACK JACK - SINGLE PLAYER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Single_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.Tb_List_Computer);
            this.Controls.Add(this.Tb_List_Player);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.btn_single_player_back);
            this.Controls.Add(this.btn_single_player_start_game);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Single_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLACK JACK - SINGLE GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Single_Player_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_List_Computer;
        private System.Windows.Forms.TextBox Tb_List_Player;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button btn_single_player_back;
        private System.Windows.Forms.Button btn_single_player_start_game;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}