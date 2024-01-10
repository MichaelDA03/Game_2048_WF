using System.Drawing;

namespace Game_2048_WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2048 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.PnlScore = new System.Windows.Forms.Panel();
            this.PnlDefaite = new System.Windows.Forms.Panel();
            this.lblDefaite = new System.Windows.Forms.Label();
            this.lblDefaiteTexte = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PnlScore.SuspendLayout();
            this.PnlDefaite.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2048.Location = new System.Drawing.Point(48, 41);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(95, 43);
            this.lbl2048.TabIndex = 1;
            this.lbl2048.Text = "2048";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(30, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Votre score:";
            // 
            // lblScoreVal
            // 
            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.Location = new System.Drawing.Point(54, 32);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.Size = new System.Drawing.Size(13, 13);
            this.lblScoreVal.TabIndex = 1;
            this.lblScoreVal.Text = "0";
            // 
            // PnlScore
            // 
            this.PnlScore.Controls.Add(this.lblScoreVal);
            this.PnlScore.Controls.Add(this.lblScore);
            this.PnlScore.Location = new System.Drawing.Point(331, 31);
            this.PnlScore.Name = "PnlScore";
            this.PnlScore.Size = new System.Drawing.Size(119, 52);
            this.PnlScore.TabIndex = 2;
            this.PnlScore.Visible = false;
            // 
            // PnlDefaite
            // 
            this.PnlDefaite.Controls.Add(this.btnExit);
            this.PnlDefaite.Controls.Add(this.btnRestart);
            this.PnlDefaite.Controls.Add(this.lblDefaiteTexte);
            this.PnlDefaite.Controls.Add(this.lblDefaite);
            this.PnlDefaite.Location = new System.Drawing.Point(123, 183);
            this.PnlDefaite.Name = "PnlDefaite";
            this.PnlDefaite.Size = new System.Drawing.Size(263, 154);
            this.PnlDefaite.TabIndex = 3;
            this.PnlDefaite.Visible = false;
            // 
            // lblDefaite
            // 
            this.lblDefaite.AutoSize = true;
            this.lblDefaite.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaite.Location = new System.Drawing.Point(86, 21);
            this.lblDefaite.Name = "lblDefaite";
            this.lblDefaite.Size = new System.Drawing.Size(85, 30);
            this.lblDefaite.TabIndex = 0;
            this.lblDefaite.Text = "Défaite!";
            // 
            // lblDefaiteTexte
            // 
            this.lblDefaiteTexte.AutoSize = true;
            this.lblDefaiteTexte.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaiteTexte.Location = new System.Drawing.Point(10, 63);
            this.lblDefaiteTexte.Name = "lblDefaiteTexte";
            this.lblDefaiteTexte.Size = new System.Drawing.Size(243, 21);
            this.lblDefaiteTexte.TabIndex = 1;
            this.lblDefaiteTexte.Text = "Souhaitez vous recommencer ou quitter?";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(29, 109);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(86, 24);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Recommencer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(146, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(526, 611);
            this.Controls.Add(this.PnlDefaite);
            this.Controls.Add(this.PnlScore);
            this.Controls.Add(this.lbl2048);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PnlScore.ResumeLayout(false);
            this.PnlScore.PerformLayout();
            this.PnlDefaite.ResumeLayout(false);
            this.PnlDefaite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lbl2048;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Panel PnlScore;
        private System.Windows.Forms.Panel PnlDefaite;
        private System.Windows.Forms.Label lblDefaite;
        private System.Windows.Forms.Label lblDefaiteTexte;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
    }
}

