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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnl4x4 = new System.Windows.Forms.Panel();
            this.lbl4x4 = new System.Windows.Forms.Label();
            this.pnl4x3 = new System.Windows.Forms.Panel();
            this.lbl4x3 = new System.Windows.Forms.Label();
            this.pnl4x2 = new System.Windows.Forms.Panel();
            this.lbl4x2 = new System.Windows.Forms.Label();
            this.pnl4x1 = new System.Windows.Forms.Panel();
            this.lbl4x1 = new System.Windows.Forms.Label();
            this.pnl3x4 = new System.Windows.Forms.Panel();
            this.lbl3x4 = new System.Windows.Forms.Label();
            this.pnl3x3 = new System.Windows.Forms.Panel();
            this.lbl3x3 = new System.Windows.Forms.Label();
            this.pnl3x2 = new System.Windows.Forms.Panel();
            this.lbl3x2 = new System.Windows.Forms.Label();
            this.pnl3x1 = new System.Windows.Forms.Panel();
            this.lbl3x1 = new System.Windows.Forms.Label();
            this.pnl2x4 = new System.Windows.Forms.Panel();
            this.lbl2x4 = new System.Windows.Forms.Label();
            this.pnl2x3 = new System.Windows.Forms.Panel();
            this.lbl2x3 = new System.Windows.Forms.Label();
            this.pnl2x2 = new System.Windows.Forms.Panel();
            this.lbl2x2 = new System.Windows.Forms.Label();
            this.pnl2x1 = new System.Windows.Forms.Panel();
            this.lbl2x1 = new System.Windows.Forms.Label();
            this.pnl1x4 = new System.Windows.Forms.Panel();
            this.lbl1x4 = new System.Windows.Forms.Label();
            this.pnl1x3 = new System.Windows.Forms.Panel();
            this.lbl1x3 = new System.Windows.Forms.Label();
            this.pnl1x2 = new System.Windows.Forms.Panel();
            this.lbl1x2 = new System.Windows.Forms.Label();
            this.pnl1x1 = new System.Windows.Forms.Panel();
            this.lbl1x1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlGrid.SuspendLayout();
            this.pnl4x4.SuspendLayout();
            this.pnl4x3.SuspendLayout();
            this.pnl4x2.SuspendLayout();
            this.pnl4x1.SuspendLayout();
            this.pnl3x4.SuspendLayout();
            this.pnl3x3.SuspendLayout();
            this.pnl3x2.SuspendLayout();
            this.pnl3x1.SuspendLayout();
            this.pnl2x4.SuspendLayout();
            this.pnl2x3.SuspendLayout();
            this.pnl2x2.SuspendLayout();
            this.pnl2x1.SuspendLayout();
            this.pnl1x4.SuspendLayout();
            this.pnl1x3.SuspendLayout();
            this.pnl1x2.SuspendLayout();
            this.pnl1x1.SuspendLayout();
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
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlGrid.Controls.Add(this.pnl4x4);
            this.pnlGrid.Controls.Add(this.pnl4x3);
            this.pnlGrid.Controls.Add(this.pnl4x2);
            this.pnlGrid.Controls.Add(this.pnl4x1);
            this.pnlGrid.Controls.Add(this.pnl3x4);
            this.pnlGrid.Controls.Add(this.pnl3x3);
            this.pnlGrid.Controls.Add(this.pnl3x2);
            this.pnlGrid.Controls.Add(this.pnl3x1);
            this.pnlGrid.Controls.Add(this.pnl2x4);
            this.pnlGrid.Controls.Add(this.pnl2x3);
            this.pnlGrid.Controls.Add(this.pnl2x2);
            this.pnlGrid.Controls.Add(this.pnl2x1);
            this.pnlGrid.Controls.Add(this.pnl1x4);
            this.pnlGrid.Controls.Add(this.pnl1x3);
            this.pnlGrid.Controls.Add(this.pnl1x2);
            this.pnlGrid.Controls.Add(this.pnl1x1);
            this.pnlGrid.Location = new System.Drawing.Point(50, 92);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(425, 425);
            this.pnlGrid.TabIndex = 2;
            // 
            // pnl4x4
            // 
            this.pnl4x4.Controls.Add(this.lbl4x4);
            this.pnl4x4.Location = new System.Drawing.Point(320, 320);
            this.pnl4x4.Name = "pnl4x4";
            this.pnl4x4.Size = new System.Drawing.Size(100, 100);
            this.pnl4x4.TabIndex = 15;
            // 
            // lbl4x4
            // 
            this.lbl4x4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl4x4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4x4.Location = new System.Drawing.Point(0, 0);
            this.lbl4x4.Name = "lbl4x4";
            this.lbl4x4.Size = new System.Drawing.Size(100, 100);
            this.lbl4x4.TabIndex = 0;
            this.lbl4x4.Text = "0";
            this.lbl4x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl4x3
            // 
            this.pnl4x3.Controls.Add(this.lbl4x3);
            this.pnl4x3.Location = new System.Drawing.Point(215, 320);
            this.pnl4x3.Name = "pnl4x3";
            this.pnl4x3.Size = new System.Drawing.Size(100, 100);
            this.pnl4x3.TabIndex = 14;
            // 
            // lbl4x3
            // 
            this.lbl4x3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl4x3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4x3.Location = new System.Drawing.Point(0, 0);
            this.lbl4x3.Name = "lbl4x3";
            this.lbl4x3.Size = new System.Drawing.Size(100, 100);
            this.lbl4x3.TabIndex = 0;
            this.lbl4x3.Text = "0";
            this.lbl4x3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl4x2
            // 
            this.pnl4x2.Controls.Add(this.lbl4x2);
            this.pnl4x2.Location = new System.Drawing.Point(110, 320);
            this.pnl4x2.Name = "pnl4x2";
            this.pnl4x2.Size = new System.Drawing.Size(100, 100);
            this.pnl4x2.TabIndex = 13;
            // 
            // lbl4x2
            // 
            this.lbl4x2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl4x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4x2.Location = new System.Drawing.Point(0, 0);
            this.lbl4x2.Name = "lbl4x2";
            this.lbl4x2.Size = new System.Drawing.Size(100, 100);
            this.lbl4x2.TabIndex = 0;
            this.lbl4x2.Text = "0";
            this.lbl4x2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl4x1
            // 
            this.pnl4x1.Controls.Add(this.lbl4x1);
            this.pnl4x1.Location = new System.Drawing.Point(5, 320);
            this.pnl4x1.Name = "pnl4x1";
            this.pnl4x1.Size = new System.Drawing.Size(100, 100);
            this.pnl4x1.TabIndex = 12;
            // 
            // lbl4x1
            // 
            this.lbl4x1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl4x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4x1.Location = new System.Drawing.Point(0, 0);
            this.lbl4x1.Name = "lbl4x1";
            this.lbl4x1.Size = new System.Drawing.Size(100, 100);
            this.lbl4x1.TabIndex = 0;
            this.lbl4x1.Text = "0";
            this.lbl4x1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl3x4
            // 
            this.pnl3x4.Controls.Add(this.lbl3x4);
            this.pnl3x4.Location = new System.Drawing.Point(320, 215);
            this.pnl3x4.Name = "pnl3x4";
            this.pnl3x4.Size = new System.Drawing.Size(100, 100);
            this.pnl3x4.TabIndex = 11;
            // 
            // lbl3x4
            // 
            this.lbl3x4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl3x4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3x4.Location = new System.Drawing.Point(0, 0);
            this.lbl3x4.Name = "lbl3x4";
            this.lbl3x4.Size = new System.Drawing.Size(100, 100);
            this.lbl3x4.TabIndex = 0;
            this.lbl3x4.Text = "0";
            this.lbl3x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl3x3
            // 
            this.pnl3x3.Controls.Add(this.lbl3x3);
            this.pnl3x3.Location = new System.Drawing.Point(215, 215);
            this.pnl3x3.Name = "pnl3x3";
            this.pnl3x3.Size = new System.Drawing.Size(100, 100);
            this.pnl3x3.TabIndex = 10;
            // 
            // lbl3x3
            // 
            this.lbl3x3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl3x3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3x3.Location = new System.Drawing.Point(0, 0);
            this.lbl3x3.Name = "lbl3x3";
            this.lbl3x3.Size = new System.Drawing.Size(100, 100);
            this.lbl3x3.TabIndex = 0;
            this.lbl3x3.Text = "0";
            this.lbl3x3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl3x2
            // 
            this.pnl3x2.Controls.Add(this.lbl3x2);
            this.pnl3x2.Location = new System.Drawing.Point(110, 215);
            this.pnl3x2.Name = "pnl3x2";
            this.pnl3x2.Size = new System.Drawing.Size(100, 100);
            this.pnl3x2.TabIndex = 9;
            // 
            // lbl3x2
            // 
            this.lbl3x2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl3x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3x2.Location = new System.Drawing.Point(0, 0);
            this.lbl3x2.Name = "lbl3x2";
            this.lbl3x2.Size = new System.Drawing.Size(100, 100);
            this.lbl3x2.TabIndex = 0;
            this.lbl3x2.Text = "0";
            this.lbl3x2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl3x1
            // 
            this.pnl3x1.Controls.Add(this.lbl3x1);
            this.pnl3x1.Location = new System.Drawing.Point(5, 215);
            this.pnl3x1.Name = "pnl3x1";
            this.pnl3x1.Size = new System.Drawing.Size(100, 100);
            this.pnl3x1.TabIndex = 8;
            // 
            // lbl3x1
            // 
            this.lbl3x1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl3x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3x1.Location = new System.Drawing.Point(0, 0);
            this.lbl3x1.Name = "lbl3x1";
            this.lbl3x1.Size = new System.Drawing.Size(100, 100);
            this.lbl3x1.TabIndex = 0;
            this.lbl3x1.Text = "0";
            this.lbl3x1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl2x4
            // 
            this.pnl2x4.Controls.Add(this.lbl2x4);
            this.pnl2x4.Location = new System.Drawing.Point(320, 110);
            this.pnl2x4.Name = "pnl2x4";
            this.pnl2x4.Size = new System.Drawing.Size(100, 100);
            this.pnl2x4.TabIndex = 7;
            // 
            // lbl2x4
            // 
            this.lbl2x4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2x4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2x4.Location = new System.Drawing.Point(0, 0);
            this.lbl2x4.Name = "lbl2x4";
            this.lbl2x4.Size = new System.Drawing.Size(100, 100);
            this.lbl2x4.TabIndex = 0;
            this.lbl2x4.Text = "0";
            this.lbl2x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl2x3
            // 
            this.pnl2x3.Controls.Add(this.lbl2x3);
            this.pnl2x3.Location = new System.Drawing.Point(215, 110);
            this.pnl2x3.Name = "pnl2x3";
            this.pnl2x3.Size = new System.Drawing.Size(100, 100);
            this.pnl2x3.TabIndex = 6;
            // 
            // lbl2x3
            // 
            this.lbl2x3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2x3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2x3.Location = new System.Drawing.Point(0, 0);
            this.lbl2x3.Name = "lbl2x3";
            this.lbl2x3.Size = new System.Drawing.Size(100, 100);
            this.lbl2x3.TabIndex = 0;
            this.lbl2x3.Text = "0";
            this.lbl2x3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl2x2
            // 
            this.pnl2x2.Controls.Add(this.lbl2x2);
            this.pnl2x2.Location = new System.Drawing.Point(110, 110);
            this.pnl2x2.Name = "pnl2x2";
            this.pnl2x2.Size = new System.Drawing.Size(100, 100);
            this.pnl2x2.TabIndex = 5;
            // 
            // lbl2x2
            // 
            this.lbl2x2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2x2.Location = new System.Drawing.Point(0, 0);
            this.lbl2x2.Name = "lbl2x2";
            this.lbl2x2.Size = new System.Drawing.Size(100, 100);
            this.lbl2x2.TabIndex = 0;
            this.lbl2x2.Text = "0";
            this.lbl2x2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl2x1
            // 
            this.pnl2x1.Controls.Add(this.lbl2x1);
            this.pnl2x1.Location = new System.Drawing.Point(5, 110);
            this.pnl2x1.Name = "pnl2x1";
            this.pnl2x1.Size = new System.Drawing.Size(100, 100);
            this.pnl2x1.TabIndex = 4;
            // 
            // lbl2x1
            // 
            this.lbl2x1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2x1.Location = new System.Drawing.Point(0, 0);
            this.lbl2x1.Name = "lbl2x1";
            this.lbl2x1.Size = new System.Drawing.Size(100, 100);
            this.lbl2x1.TabIndex = 0;
            this.lbl2x1.Text = "0";
            this.lbl2x1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1x4
            // 
            this.pnl1x4.Controls.Add(this.lbl1x4);
            this.pnl1x4.Location = new System.Drawing.Point(320, 5);
            this.pnl1x4.Name = "pnl1x4";
            this.pnl1x4.Size = new System.Drawing.Size(100, 100);
            this.pnl1x4.TabIndex = 3;
            // 
            // lbl1x4
            // 
            this.lbl1x4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1x4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1x4.Location = new System.Drawing.Point(0, 0);
            this.lbl1x4.Name = "lbl1x4";
            this.lbl1x4.Size = new System.Drawing.Size(100, 100);
            this.lbl1x4.TabIndex = 0;
            this.lbl1x4.Text = "0";
            this.lbl1x4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1x3
            // 
            this.pnl1x3.Controls.Add(this.lbl1x3);
            this.pnl1x3.Location = new System.Drawing.Point(215, 5);
            this.pnl1x3.Name = "pnl1x3";
            this.pnl1x3.Size = new System.Drawing.Size(100, 100);
            this.pnl1x3.TabIndex = 2;
            // 
            // lbl1x3
            // 
            this.lbl1x3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1x3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1x3.Location = new System.Drawing.Point(0, 0);
            this.lbl1x3.Name = "lbl1x3";
            this.lbl1x3.Size = new System.Drawing.Size(100, 100);
            this.lbl1x3.TabIndex = 0;
            this.lbl1x3.Text = "0";
            this.lbl1x3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1x2
            // 
            this.pnl1x2.Controls.Add(this.lbl1x2);
            this.pnl1x2.Location = new System.Drawing.Point(110, 5);
            this.pnl1x2.Name = "pnl1x2";
            this.pnl1x2.Size = new System.Drawing.Size(100, 100);
            this.pnl1x2.TabIndex = 1;
            // 
            // lbl1x2
            // 
            this.lbl1x2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1x2.Location = new System.Drawing.Point(0, 0);
            this.lbl1x2.Name = "lbl1x2";
            this.lbl1x2.Size = new System.Drawing.Size(100, 100);
            this.lbl1x2.TabIndex = 0;
            this.lbl1x2.Text = "0";
            this.lbl1x2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1x1
            // 
            this.pnl1x1.Controls.Add(this.lbl1x1);
            this.pnl1x1.Location = new System.Drawing.Point(5, 5);
            this.pnl1x1.Name = "pnl1x1";
            this.pnl1x1.Size = new System.Drawing.Size(100, 100);
            this.pnl1x1.TabIndex = 0;
            // 
            // lbl1x1
            // 
            this.lbl1x1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1x1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1x1.Location = new System.Drawing.Point(0, 0);
            this.lbl1x1.Name = "lbl1x1";
            this.lbl1x1.Size = new System.Drawing.Size(100, 100);
            this.lbl1x1.TabIndex = 0;
            this.lbl1x1.Text = "0";
            this.lbl1x1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(381, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 18);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Votre score:";
            // 
            // lblNumScore
            // 
            this.lblNumScore.AutoSize = true;
            this.lblNumScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumScore.Location = new System.Drawing.Point(413, 67);
            this.lblNumScore.Name = "lblNumScore";
            this.lblNumScore.Size = new System.Drawing.Size(14, 16);
            this.lblNumScore.TabIndex = 4;
            this.lblNumScore.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Snow;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(230, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 595);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNumScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.lbl2048);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(217, 208, 199);
            this.Name = "Form1";
            this.Text = "2048";
            this.pnlGrid.ResumeLayout(false);
            this.pnl4x4.ResumeLayout(false);
            this.pnl4x3.ResumeLayout(false);
            this.pnl4x2.ResumeLayout(false);
            this.pnl4x1.ResumeLayout(false);
            this.pnl3x4.ResumeLayout(false);
            this.pnl3x3.ResumeLayout(false);
            this.pnl3x2.ResumeLayout(false);
            this.pnl3x1.ResumeLayout(false);
            this.pnl2x4.ResumeLayout(false);
            this.pnl2x3.ResumeLayout(false);
            this.pnl2x2.ResumeLayout(false);
            this.pnl2x1.ResumeLayout(false);
            this.pnl1x4.ResumeLayout(false);
            this.pnl1x3.ResumeLayout(false);
            this.pnl1x2.ResumeLayout(false);
            this.pnl1x1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2048;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnl4x4;
        private System.Windows.Forms.Panel pnl4x3;
        private System.Windows.Forms.Panel pnl4x2;
        private System.Windows.Forms.Panel pnl4x1;
        private System.Windows.Forms.Panel pnl3x4;
        private System.Windows.Forms.Panel pnl3x3;
        private System.Windows.Forms.Panel pnl3x2;
        private System.Windows.Forms.Panel pnl3x1;
        private System.Windows.Forms.Panel pnl2x4;
        private System.Windows.Forms.Panel pnl2x3;
        private System.Windows.Forms.Panel pnl2x2;
        private System.Windows.Forms.Panel pnl2x1;
        private System.Windows.Forms.Panel pnl1x4;
        private System.Windows.Forms.Panel pnl1x3;
        private System.Windows.Forms.Panel pnl1x2;
        private System.Windows.Forms.Panel pnl1x1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumScore;
        private System.Windows.Forms.Label lbl1x1;
        private System.Windows.Forms.Label lbl1x2;
        private System.Windows.Forms.Label lbl4x4;
        private System.Windows.Forms.Label lbl4x3;
        private System.Windows.Forms.Label lbl4x2;
        private System.Windows.Forms.Label lbl4x1;
        private System.Windows.Forms.Label lbl3x4;
        private System.Windows.Forms.Label lbl3x3;
        private System.Windows.Forms.Label lbl3x2;
        private System.Windows.Forms.Label lbl3x1;
        private System.Windows.Forms.Label lbl2x4;
        private System.Windows.Forms.Label lbl2x3;
        private System.Windows.Forms.Label lbl2x2;
        private System.Windows.Forms.Label lbl2x1;
        private System.Windows.Forms.Label lbl1x4;
        private System.Windows.Forms.Label lbl1x3;
        private System.Windows.Forms.Button btnExit;
    }
}

