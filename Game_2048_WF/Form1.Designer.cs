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
            this.PnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2048.Location = new System.Drawing.Point(48, 41);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(102, 42);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(526, 611);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lbl2048;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Panel PnlScore;
    }
}

