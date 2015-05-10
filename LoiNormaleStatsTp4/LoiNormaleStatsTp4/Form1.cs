using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace LoiNormaleStatsTp4
{
   public partial class Menu : Form
   {
       private object[,] Table;
      
      public Menu()
      {
         InitializeComponent();
         ReadNormalTable();

      }

      private void Menu_Load(object sender, EventArgs e)
      {
          Cb_Cas.SelectedIndex = 0;
      }

      private void Btn_Quitter_Click(object sender, EventArgs e)
      {
          this.Close();
      }
      private void ReadNormalTable()
      {
          OpenFileDialog file = new OpenFileDialog();

       //   if(file.ShowDialog() == DialogResult.OK)
       //   { 
              try

              {
                
                // string exeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                // Excel.Workbook wkbook = exapp.Workbooks.Open(System.IO.Path.Combine(exeDir, "test.xlsx"));
                  //declaration des objet pour la lecture d'un fichier excel
                  Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                  Workbook wb = App.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + "\\tablenormale.xlsx", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                  Worksheet ws = wb.ActiveSheet;
                  Range range = ws.UsedRange;//le nombre de ligne et de colonne dans le fichier excel
                  Table = new object[range.Rows.Count, range.Columns.Count]; //instancie le tableau avec les bonne grosseur

                  //Lecture  des donnees
                  for (int i = 1; i <= range.Rows.Count; i++)
                  {
                      for (int j = 1; j <= range.Columns.Count; j++)
                      {
                          //pas le choix de mettre -1 vue quon commence a 1 la boucle
                          Table[i - 1, j - 1] = ((Range)ws.Cells[i, j]).Value2;
                      }
                  }
                  //fermeture sans enregistrement du fichier excel
                  wb.Close(false);
                  App.Quit();
              }
              catch(Exception e)
              {
                  MessageBox.Show("Erreur lors de la lecture");
              }
                                

     //  }
      }

      private void CalculInferieur()
      {
         String Resultat = "Le pourcentage de valeurs qui peuvent être inférieur à " + Tb_Inf.Text + " est selon \n"
                          + "la moyenne : " + Tb_Moyenne.Text + "\n et \n"
                           + "l'écart type de: " + Tb_Ecart.Text + "\n"
                           +"égal à ";

         double value = (double.Parse(Tb_Inf.Text) - double.Parse(Tb_Moyenne.Text)) / double.Parse(Tb_Ecart.Text);
         String[] Recherche =  SetCotePourRecherche(value);
         Resultat += Math.Round((float.Parse(RechercheDansLaTable(Recherche[0], Recherche[1]).ToString()) * 100),4);
         
         MessageBox.Show(Resultat);
      
      }
      private void CalculSuperieur()
      {
         String Resultat = "Le pourcentage de valeurs qui peuvent être supérieur à " + Tb_Sup.Text + " est selon \n"
                         + "la moyenne : " + Tb_Moyenne.Text + "\net \n"
                          + "l'écart type de: " + Tb_Ecart.Text + "\n"
                          + "égal à ";

         double value = (double.Parse(Tb_Sup.Text) - double.Parse(Tb_Moyenne.Text)) / double.Parse(Tb_Ecart.Text);
         String[] Recherche = SetCotePourRecherche(value);             
         Resultat +=  Math.Round(((0.5 - float.Parse(RechercheDansLaTable(Recherche[0], Recherche[1]).ToString())) * 100),4);
         MessageBox.Show(Resultat);
      }

      private void CalculInterval()
      { 
         String Resultat = "Le pourcentage de valeurs qui peuvent être entre " + Tb_Value_A.Text +  " et " + Tb_Value_B.Text + " est selon \n"
                          + "la moyenne : " + Tb_Moyenne.Text + "\net \n"
                          + "l'écart type de: " + Tb_Ecart.Text + "\n"
                          + "égal à ";
         bool FlagValueA = false;
         bool FlagValueB = false;
         

         double valueA = (double.Parse(Tb_Value_A.Text) - double.Parse(Tb_Moyenne.Text)) / double.Parse(Tb_Ecart.Text);
         if (valueA < 0)
            FlagValueA = true;         
         String[] RechercheA = SetCotePourRecherche(valueA);        
         double ValueA =  (float.Parse(RechercheDansLaTable(RechercheA[0], RechercheA[1]).ToString()) * 100);

       
         double valueB = (double.Parse(Tb_Value_B.Text) - double.Parse(Tb_Moyenne.Text)) / double.Parse(Tb_Ecart.Text);
         if (valueB < 0)
            FlagValueB = true; 
         String[] RechercheB = SetCotePourRecherche(valueB);
         double  ValueB = (float.Parse(RechercheDansLaTable(RechercheB[0], RechercheB[1]).ToString())) * 100;
        
         if ((FlagValueA && !FlagValueB)
          || (!FlagValueA && FlagValueB))
         {
            Resultat += (Math.Round(ValueA + ValueB,4)).ToString();
         }        
         else
         {
            if(valueA>valueB)
            Resultat += (Math.Round(ValueA - ValueB,4)).ToString();
            else
            Resultat += (Math.Round(ValueB - ValueA,4)).ToString();
         }
         
         MessageBox.Show(Resultat);
        
         
      }

      private void Cb_Cas_SelectedIndexChanged(object sender, EventArgs e)
      {
         Lb_Tb_Visibility();
      }

      private void Lb_Tb_Visibility()
      {
          //Gestion d'affichage
         Tb_Value_A.Visible = false;
         Tb_Value_B.Visible = false;
         Lb_Entre.Visible = false;
         Lb_Et.Visible = false;
         
         Tb_Inf.Visible = false;
         Lb_Inf.Visible = false;  


         Tb_Sup.Visible = false;
         Lb_Sup.Visible = false;

         if (Cb_Cas.SelectedIndex == 0)
         {
            Tb_Value_A.Visible = true;
            Tb_Value_B.Visible = true;
            Lb_Entre.Visible = true;
            Lb_Et.Visible = true;                   

         }
         else if (Cb_Cas.SelectedIndex == 1)
         {
            Tb_Inf.Visible = true;
            Lb_Inf.Visible = true;  
         }
         else
         {
            Tb_Sup.Visible = true;
            Lb_Sup.Visible = true;
         }
      }

      private void Btn_Calcul_Click(object sender, EventArgs e)
      {         
          //////////////////////////////////////////////////////////////////
         ////verifie dans quelle etat on se trouve pour pouvoir appeler le
        ///bon calcule
        /////////////////////////////////////////////////////////////////////
         if(Tb_Ecart.Text!=String.Empty && Tb_Moyenne.Text != String.Empty)
         {
            if(Cb_Cas.SelectedIndex==0)
            {
               if(Tb_Value_A.Text!=String.Empty && Tb_Value_B.Text!=String.Empty)
               CalculInterval();
                             
            }
            else if(Cb_Cas.SelectedIndex==1)
            {
               if (Tb_Inf.Text != String.Empty)
               CalculInferieur();
            }
            else
            {
               if (Tb_Sup.Text != String.Empty)
               CalculSuperieur();
            }
         }
         else
         {
            MessageBox.Show("Veuillez Entrez une Moyenne ainsi qu'une Écart type");
         }
          
      }

      private String[] SetCotePourRecherche(double value)
      {

          int firstpart = (int)value; // converti en int pour perdre la decimal avoir juste l'entier
          int secondpart = (int)((value - firstpart) * 1000); //retourne chercher la partie decimal du nombre 

          String coteZ = Math.Abs(firstpart) + "," + ((int)(Math.Abs(secondpart / 100f))).ToString(); //construction de mes chaines pour la recherche dans la table
          String decpart = (((int)Math.Round(secondpart / 10f))).ToString(); //construction de la partie decimal pour la recherche dans la table
          decpart = "0,0" + (decpart.Length > 1 ? decpart[1] : decpart[0]); //suite de la construction de la partie decimal

          MessageBox.Show(coteZ + "    " + decpart);

          return new String[] { coteZ, decpart};            

      }

      private object RechercheDansLaTable(String coteZ, String decPart)
      {
          if (coteZ[2].ToString().Equals("0"))     //pour la recherche    
              coteZ = coteZ[0].ToString();
          if (decPart[2].ToString().Equals("0"))  //pour la recherche    
              decPart = decPart[0].ToString();


         int x = 0,y = 0;
         bool trouver = false;

         for (int i = 1; i < 42 && !trouver; i++)         
            if (trouver = (coteZ == Table[x =  i, 0].ToString())){} //Recherche de la ligne de la code z
                       
         trouver = false;
         
         for (int i = 0; i < 11 && !trouver; i++)
            if (trouver = (decPart == Table[0, y = i].ToString())) {} //Recherche de la colonne de la partie decimale


         return Table[x, y];
      
      }

    //La partie suivante est simplement de la gestion de touche 
      private void BlockLetter(KeyPressEventArgs e)
      {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
         {
            e.Handled = true;
         }  
      }

      private void Tb_Moyenne_KeyPress(object sender, KeyPressEventArgs e)
      {
         BlockLetter(e);
      }
     

      private void Tb_Ecart_KeyPress(object sender, KeyPressEventArgs e)
      {
         BlockLetter(e);
      }

      private void Tb_Value_A_KeyPress(object sender, KeyPressEventArgs e)
      {
         BlockLetter(e);
      }

      private void Tb_Value_B_KeyPress(object sender, KeyPressEventArgs e)
      {
         BlockLetter(e);
      }

      private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
      {
         BlockLetter(e);
      }     
  
   }
}
