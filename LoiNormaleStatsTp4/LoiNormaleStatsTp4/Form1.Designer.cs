namespace LoiNormaleStatsTp4
{
   partial class Menu
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
         this.helpProvider1 = new System.Windows.Forms.HelpProvider();
         this.Btn_R_Cote = new System.Windows.Forms.Button();
         this.Btn_Prob = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Btn_R_Cote
         // 
         this.Btn_R_Cote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_R_Cote.Location = new System.Drawing.Point(40, 66);
         this.Btn_R_Cote.Name = "Btn_R_Cote";
         this.Btn_R_Cote.Size = new System.Drawing.Size(182, 52);
         this.Btn_R_Cote.TabIndex = 0;
         this.Btn_R_Cote.Text = "Recherche de Cote Z";
         this.Btn_R_Cote.UseVisualStyleBackColor = true;
         // 
         // Btn_Prob
         // 
         this.Btn_Prob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Prob.Location = new System.Drawing.Point(40, 166);
         this.Btn_Prob.Name = "Btn_Prob";
         this.Btn_Prob.Size = new System.Drawing.Size(182, 51);
         this.Btn_Prob.TabIndex = 1;
         this.Btn_Prob.Text = "Calcul De Proportion";
         this.Btn_Prob.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(80, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(107, 16);
         this.label1.TabIndex = 2;
         this.label1.Text = "le Super Menu";
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(276, 271);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Btn_Prob);
         this.Controls.Add(this.Btn_R_Cote);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "Menu";
         this.Text = "That Menu";
         this.Load += new System.EventHandler(this.Menu_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.HelpProvider helpProvider1;
      private System.Windows.Forms.Button Btn_R_Cote;
      private System.Windows.Forms.Button Btn_Prob;
      private System.Windows.Forms.Label label1;
   }
}

