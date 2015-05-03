﻿using System;
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
                  //fermeture sans enregistrement du fichier excel
                  wb.Close(false);
                  App.Quit();
              }
              catch(Exception e)
              {
                  MessageBox.Show("Erreur lors de la lecture");
              }
                                

       }
      }

      private void CalculInferieur()
      {

          double value = (double.Parse(Tb_Value_A.Text) - double.Parse(Tb_Moyenne.Text)) / double.Parse(Tb_Ecart.Text);
          SetCotePourRecherche(value);
      
      
      }
      private void Cb_Cas_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void Btn_Calcul_Click(object sender, EventArgs e)
      {
          CalculInferieur();
      }

      private String[] SetCotePourRecherche(double value)
      {

          int firstpart = (int)value; // converti en int pour perdre la decimal avoir juste l'entier
          int secondpart = (int)((value - firstpart) * 1000); //retourne chercher la partie decimal du nombre l

          String coteZ = Math.Abs(firstpart) + "," + ((int)(Math.Abs(secondpart / 100f))).ToString(); //construction de mes chaines pour la recherche dans la table
          String decpart = (((int)Math.Round(secondpart / 10f))).ToString(); //construction de la partie decimal pour la recherche dans la table
          decpart = "0,0" + decpart[1];
          MessageBox.Show(coteZ + "             " + decpart);

          return new String[] { coteZ, decpart };
      
      
      }
     
   }
}
