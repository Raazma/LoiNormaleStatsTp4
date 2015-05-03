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

          if(file.ShowDialog() == DialogResult.OK)
          { 
              try
              {
                  //declaration des objet pour la lecture d'un fichier excel
                  Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                  Workbook wb = App.Workbooks.Open(file.FileName);
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
                  wb.Close(false);
                  App.Quit();
              }
              catch(Exception e)
              {
                  MessageBox.Show("Erreur lors de la lecture");
              }
              

            //fermeture sans enregistrement du fichier excel
          

       }
      }

      private void Cb_Cas_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

     
   }
}
