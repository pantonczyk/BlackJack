namespace BlackJack
{
    partial class Form_black_jack
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Single_Player = new System.Windows.Forms.Button();
            this.btn_Multi_Player = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLACK JACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Single_Player
            // 
            this.btn_Single_Player.FlatAppearance.BorderSize = 0;
            this.btn_Single_Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Single_Player.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Single_Player.Location = new System.Drawing.Point(40, 77);
            this.btn_Single_Player.Name = "btn_Single_Player";
            this.btn_Single_Player.Size = new System.Drawing.Size(300, 40);
            this.btn_Single_Player.TabIndex = 2;
            this.btn_Single_Player.Text = "SINGLE PLAYER";
            this.btn_Single_Player.UseVisualStyleBackColor = true;
            this.btn_Single_Player.Click += new System.EventHandler(this.btn_Single_Player_Click);
            // 
            // btn_Multi_Player
            // 
            this.btn_Multi_Player.FlatAppearance.BorderSize = 0;
            this.btn_Multi_Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Multi_Player.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multi_Player.Location = new System.Drawing.Point(40, 123);
            this.btn_Multi_Player.Name = "btn_Multi_Player";
            this.btn_Multi_Player.Size = new System.Drawing.Size(300, 40);
            this.btn_Multi_Player.TabIndex = 3;
            this.btn_Multi_Player.Text = "PLAYER VS PLAYER";
            this.btn_Multi_Player.UseVisualStyleBackColor = true;
            this.btn_Multi_Player.Click += new System.EventHandler(this.btn_Multi_Player_Click);
            // 
            // btn_About
            // 
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_About.Location = new System.Drawing.Point(40, 169);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(300, 40);
            this.btn_About.TabIndex = 4;
            this.btn_About.Text = "ABOUT US";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit.Location = new System.Drawing.Point(40, 215);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(300, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form_black_jack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Multi_Player);
            this.Controls.Add(this.btn_Single_Player);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "Form_black_jack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLACK JACK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_black_jack_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Single_Player;
        private System.Windows.Forms.Button btn_Multi_Player;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Exit;
    }
}

