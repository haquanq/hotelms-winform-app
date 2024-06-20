using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace QLTD
{
    public static class Helper
    {
        public static string AutoNextID(string lastID)
        {
            string text;
            int num;

            text = Regex.Replace(lastID, @"[0-9]|\-", "");
            num = Convert.ToInt32(Regex.Replace(lastID, @"[a-zA-Z]|\-", "")) + 1;
            lastID = text + "-" + num.ToString().PadLeft(Regex.Replace(lastID, @"[a-zA-Z]|\-", "").Length, '0');

            return lastID;
        }
        public static DataTable SingleObjectToData(object o)
        {
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            o.GetType().GetProperties().ToList().ForEach(f =>
            {
                f.GetValue(o, null);
                dt.Columns.Add(f.Name, f.PropertyType);
                dt.Rows[0][f.Name] = f.GetValue(o, null);
            });

            return dt;
        }

        public static string GetConString()
        {
            return ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        }

        public static DataTable GenderOption()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("key", typeof(string));
            dt.Columns.Add("text", typeof(string));
            dt.Rows.Add("M", "Nam");
            dt.Rows.Add("F", "Nữ");
            dt.Rows.Add("O", "Khác");
            return dt;
        }

        public static DataTable RoleOption()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(string));
            dt.Columns.Add("text", typeof(string));
            dt.Rows.Add("Assistant", "Trợ lý");
            dt.Rows.Add("Librarian", "Thủ thư");
            dt.Rows.Add("Admin", "Quản trị viên");
            return dt;
        }

    }
}
