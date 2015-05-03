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
       private object[,] Table = new object[42,11] ;
      
      public Menu()
      {
         InitializeComponent();
         ReadNormalTable();

      }

      private void Menu_Load(object sender, EventArgs e)
      {
          
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
          Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
          Workbook wb = App.Workbooks.Open(file.FileName);
          Worksheet ws = wb.ActiveSheet;
          Range range = ws.UsedRange;
          Range value;
          int I = 0;
           int J = 0;

          for (int i = 1; i <= range.Rows.Count; i++)
          {
              for (int j = 1; j <= range.Columns.Count; j++)
              {                
                 Table[i-1, j-1] = ((Range)ws.Cells[i, j]).Value2;
                                
              }
            
          }

          wb.Close(false);
         App.Quit();

       }
      }

     
   }
}
