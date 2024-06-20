using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace HotelMs
{
    public static class Helper
    {
        public static void SaveReportFileToFolders(byte[] bytes)
        {
            var save = new SaveFileDialog();
            save.Title = "Luu tep tin";
            save.Filter = "PDF Document (*.pdf)|*.pdf";
            DialogResult res = save.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fileName = save.FileName;
                File.WriteAllBytes(fileName, bytes);
                System.Diagnostics.Process.Start(fileName);
            }
        }


        public static string GetConString()
        {
            return ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        }
        public static string NumberToVND(double num)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            if (num == 0) return "0 vnd";
            return string.Format(cul, "{0:0,0} vnd", num);
        }
        public static string AddCommaNumber(double num)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            if (num == 0) return "0";
            return string.Format(cul, "{0:0,0}", num);
        }

        public static void printPrettyDatatable(DataTable data)
        {
            Console.WriteLine();
            Dictionary<string, int> colWidths = new Dictionary<string, int>();

            foreach (DataColumn col in data.Columns)
            {
                Console.Write(col.ColumnName);
                var maxLabelSize = data.Rows.OfType<DataRow>()
                        .Select(m => (m.Field<object>(col.ColumnName)?.ToString() ?? "").Length)
                        .OrderByDescending(m => m).FirstOrDefault();

                colWidths.Add(col.ColumnName, maxLabelSize);
                for (int i = 0; i < maxLabelSize - col.ColumnName.Length + 10; i++) Console.Write(" ");
            }

            Console.WriteLine();

            foreach (DataRow dataRow in data.Rows)
            {
                for (int j = 0; j < dataRow.ItemArray.Length; j++)
                {
                    Console.Write(dataRow.ItemArray[j]);
                    for (int i = 0; i < colWidths[data.Columns[j].ColumnName] - dataRow.ItemArray[j].ToString().Length + 10; i++) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
