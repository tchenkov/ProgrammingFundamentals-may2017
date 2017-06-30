using System;
using MyExcel = Microsoft.Office.Interop.Excel;

namespace P06_EXCELlentKnowledge
{
    class P06_EXCELlentKnowledge
    {
        static void Main(string[] args)
        {
            var xlsApp = new MyExcel.Application();
            var xlsWorkbook = xlsApp.Workbooks.Open(@"C:\Users\todor\Desktop\sample_table.xlsx");
            var xlsSheet = xlsWorkbook.Sheets[1];
            var range = xlsSheet.UsedRange;

            var columnsCount = range.Columns.Count;
            var rowsCount = range.Rows.Count;

            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= columnsCount; j++)
                {
                    if(range.Cells[i, j] == null || range.Cells[i, j].Value2 == null)
                    {
                        goto Break;
                    }
                        Console.Write((range.Cells[i, j].Value2.ToString())+ "|");
                }
                Console.WriteLine();
            }
            Break:

            xlsWorkbook.Close();
            xlsApp.Quit();
        }
    }
}
