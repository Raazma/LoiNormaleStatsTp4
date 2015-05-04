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
         this.Tb_Moyenne = new System.Windows.Forms.TextBox();
         this.Tb_Ecart = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.Tb_Value_A = new System.Windows.Forms.TextBox();
         this.Tb_Value_B = new System.Windows.Forms.TextBox();
         this.Lb_Choice = new System.Windows.Forms.Label();
         this.Lb_Et = new System.Windows.Forms.Label();
         this.Lb_Inf = new System.Windows.Forms.Label();
         this.TB_Inferieur = new System.Windows.Forms.TextBox();
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
         this.Btn_Quitter.Location = new System.Drawing.Point(40, 268);
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
         this.Btn_Calcul.Location = new System.Drawing.Point(259, 268);
         this.Btn_Calcul.Name = "Btn_Calcul";
         this.Btn_Calcul.Size = new System.Drawing.Size(150, 34);
         this.Btn_Calcul.TabIndex = 6;
         this.Btn_Calcul.Text = "Calculer";
         this.Btn_Calcul.UseVisualStyleBackColor = true;
         this.Btn_Calcul.Click += new System.EventHandler(this.Btn_Calcul_Click);
         // 
         // Tb_Moyenne
         // 
         this.Tb_Moyenne.Location = new System.Drawing.Point(211, 54);
         this.Tb_Moyenne.Name = "Tb_Moyenne";
         this.Tb_Moyenne.ShortcutsEnabled = false;
         this.Tb_Moyenne.Size = new System.Drawing.Size(81, 20);
         this.Tb_Moyenne.TabIndex = 7;
         this.Tb_Moyenne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Moyenne_KeyPress);
         // 
         // Tb_Ecart
         // 
         this.Tb_Ecart.Location = new System.Drawing.Point(328, 53);
         this.Tb_Ecart.Name = "Tb_Ecart";
         this.Tb_Ecart.Size = new System.Drawing.Size(81, 20);
         this.Tb_Ecart.TabIndex = 8;
         this.Tb_Ecart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Ecart_KeyPress);
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
         // Tb_Value_A
         // 
         this.Tb_Value_A.Location = new System.Drawing.Point(59, 119);
         this.Tb_Value_A.Name = "Tb_Value_A";
         this.Tb_Value_A.Size = new System.Drawing.Size(71, 20);
         this.Tb_Value_A.TabIndex = 11;
         this.Tb_Value_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Value_A_KeyPress);
         // 
         // Tb_Value_B
         // 
         this.Tb_Value_B.Location = new System.Drawing.Point(185, 120);
         this.Tb_Value_B.Name = "Tb_Value_B";
         this.Tb_Value_B.Size = new System.Drawing.Size(74, 20);
         this.Tb_Value_B.TabIndex = 12;
         this.Tb_Value_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Value_B_KeyPress);
         // 
         // Lb_Choice
         // 
         this.Lb_Choice.AutoSize = true;
         this.Lb_Choice.Location = new System.Drawing.Point(10, 123);
         this.Lb_Choice.Name = "Lb_Choice";
         this.Lb_Choice.Size = new System.Drawing.Size(35, 13);
         this.Lb_Choice.TabIndex = 13;
         this.Lb_Choice.Text = "Entre:";
         // 
         // Lb_Et
         // 
         this.Lb_Et.AutoSize = true;
         this.Lb_Et.Location = new System.Drawing.Point(151, 122);
         this.Lb_Et.Name = "Lb_Et";
         this.Lb_Et.Size = new System.Drawing.Size(17, 13);
         this.Lb_Et.TabIndex = 14;
         this.Lb_Et.Text = "Et";
         // 
         // Lb_Inf
         // 
         this.Lb_Inf.AutoSize = true;
         this.Lb_Inf.Location = new System.Drawing.Point(13, 167);
         this.Lb_Inf.Name = "Lb_Inf";
         this.Lb_Inf.Size = new System.Drawing.Size(57, 13);
         this.Lb_Inf.TabIndex = 15;
         this.Lb_Inf.Text = "Inferieur a:";
         // 
         // TB_Inferieur
         // 
         this.TB_Inferieur.Location = new System.Drawing.Point(76, 164);
         this.TB_Inferieur.Name = "TB_Inferieur";
         this.TB_Inferieur.Size = new System.Drawing.Size(71, 20);
         this.TB_Inferieur.TabIndex = 16;
         this.TB_Inferieur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(469, 340);
         this.Controls.Add(this.TB_Inferieur);
         this.Controls.Add(this.Lb_Inf);
         this.Controls.Add(this.Lb_Et);
         this.Controls.Add(this.Lb_Choice);
         this.Controls.Add(this.Tb_Value_B);
         this.Controls.Add(this.Tb_Value_A);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Tb_Ecart);
         this.Controls.Add(this.Tb_Moyenne);
         this.Controls.Add(this.Btn_Calcul);
         this.Controls.Add(this.Cb_Cas);
         this.Controls.Add(this.Btn_Quitter);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "Menu";
         this.Text = "That Normal Calculator";
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
      private System.Windows.Forms.TextBox Tb_Moyenne;
      private System.Windows.Forms.TextBox Tb_Ecart;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox Tb_Value_A;
      private System.Windows.Forms.TextBox Tb_Value_B;
      private System.Windows.Forms.Label Lb_Choice;
      private System.Windows.Forms.Label Lb_Et;
      private System.Windows.Forms.Label Lb_Inf;
      private System.Windows.Forms.TextBox TB_Inferieur;
   }
}

