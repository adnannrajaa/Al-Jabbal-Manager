using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASDBFramework.Utillities.Lists
{
    public class ListData
    {
        //..............................Load Data into ComboBox Start....................
        public static void LoadDataInToComboBox(ComboBox cb, string storedProceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProceName);
            cb.DisplayMember = "Description";
            //cb.ValueMember = "Id";

            cb.SelectedIndex = -1;
            // cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void LoadDataInToComboBox(ComboBox cb, string storedProceName, DBParameter paremeter)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProceName, paremeter);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";

            cb.SelectedIndex = -1;
            // cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }   
        //..............................Load Data into ComboBox End....................

        //..............................Load Data into DataGridView Start....................
        public static void LoadDataInToDataGridView(DataGridView dgv, string storedProceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(storedProceName);
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //..............................Load Data into DataGridView End....................

        //..............................Load Data into ListBox Start....................
        public static void LoadDataInToListBox(ListBox lb, string storedProceName, DBParameter paremeter)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            lb.DataSource = db.GetDataList(storedProceName, paremeter);
            lb.DisplayMember = "ProductType";
            lb.ValueMember = "ProductType";

        }
        //..............................Load Data into ListBox End....................
    }
}
