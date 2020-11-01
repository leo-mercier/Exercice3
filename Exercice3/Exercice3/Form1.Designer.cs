namespace Exercice3
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
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoustraire = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnDiviser = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(156, 77);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 20);
            this.txtVal1.TabIndex = 0;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(156, 129);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 20);
            this.txtVal2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre2:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSoustraire
            // 
            this.btnSoustraire.Location = new System.Drawing.Point(165, 191);
            this.btnSoustraire.Name = "btnSoustraire";
            this.btnSoustraire.Size = new System.Drawing.Size(75, 23);
            this.btnSoustraire.TabIndex = 4;
            this.btnSoustraire.Text = "Soustraire";
            this.btnSoustraire.UseVisualStyleBackColor = true;
            this.btnSoustraire.Click += new System.EventHandler(this.btnSoustraire_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(165, 314);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "Additionner";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnDiviser
            // 
            this.btnDiviser.Location = new System.Drawing.Point(165, 275);
            this.btnDiviser.Name = "btnDiviser";
            this.btnDiviser.Size = new System.Drawing.Size(75, 23);
            this.btnDiviser.TabIndex = 6;
            this.btnDiviser.Text = "Diviser";
            this.btnDiviser.UseVisualStyleBackColor = true;
            this.btnDiviser.Click += new System.EventHandler(this.btnDiviser_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Location = new System.Drawing.Point(165, 234);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplier.TabIndex = 7;
            this.btnMultiplier.Text = "Multiplier";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(407, 77);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultat :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.btnDiviser);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSoustraire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoustraire;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnDiviser;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

