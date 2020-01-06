using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace EXCELlentKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Works only on .Net Framework


            string path = @"..\..\..\";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path + "sample_table.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            List<string> results = new List<string>();

            for (int i = 1; i <= rowCount; i++)
            {
                string result = string.Empty;
                for (int j = 1; j <= colCount; j++)
                {
                    if (j == 1)
                    {
                        result += "\r\n";
                    }

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        result += xlRange.Cells[i, j].Value2 + "|";
                    }
                }
                results.Add(result);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            results = results.Where(x => x != string.Empty && x != Environment.NewLine).Select(x => x.Trim('\r')).Select(x => x.Trim('\n')).ToList();

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
