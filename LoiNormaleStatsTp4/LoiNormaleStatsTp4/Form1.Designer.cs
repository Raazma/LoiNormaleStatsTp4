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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Cb_Cas = new System.Windows.Forms.ComboBox();
            this.Btn_Calcul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "le Super Menu Des Choix";
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Quitter.Location = new System.Drawing.Point(62, 369);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(150, 34);
            this.Btn_Quitter.TabIndex = 3;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Cb_Cas
            // 
            this.Cb_Cas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Cas.FormattingEnabled = true;
            this.Cb_Cas.Items.AddRange(new object[] {
            "Interieur d\'une intervale",
            "Inferieur a une valeur",
            "Superieur a une valeur"});
            this.Cb_Cas.Location = new System.Drawing.Point(12, 53);
            this.Cb_Cas.Name = "Cb_Cas";
            this.Cb_Cas.Size = new System.Drawing.Size(159, 21);
            this.Cb_Cas.TabIndex = 5;
            this.Cb_Cas.SelectedIndexChanged += new System.EventHandler(this.Cb_Cas_SelectedIndexChanged);
            // 
            // Btn_Calcul
            // 
            this.Btn_Calcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calcul.Location = new System.Drawing.Point(269, 369);
            this.Btn_Calcul.Name = "Btn_Calcul";
            this.Btn_Calcul.Size = new System.Drawing.Size(150, 34);
            this.Btn_Calcul.TabIndex = 6;
            this.Btn_Calcul.Text = "Calculer";
            this.Btn_Calcul.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Moyenne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ecart Type";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Calcul);
            this.Controls.Add(this.Cb_Cas);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.Text = "That Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.HelpProvider helpProvider1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button Btn_Quitter;
      private System.Windows.Forms.ComboBox Cb_Cas;
      private System.Windows.Forms.Button Btn_Calcul;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}

