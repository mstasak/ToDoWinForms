using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoWinForms
{
    public partial class MainForm : Form
    {
        internal ToDoContext Ctx { get; private set; }

        //public DataSet StaticDS { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindComponents();
            //BindComponentsToStaticData();
        }

        
        void BindComponents()
        {
            //set up itemlist
            Ctx = new ToDoContext("ToDos");
            var toDoItemList = Ctx.ToDoItems;
            toDoItemList.Load();
            bindingSource1.DataSource = toDoItemList.Local.ToBindingList();
            //DataMember = "DailyItems"
            dataGridViewToDo.AutoGenerateColumns = true;
        }
        

        /*
        void BindComponentsToStaticData()
        {
            //set up itemlist
            StaticDS = new DataSet("DailyItemsDS");
            DataTable dt = new DataTable("DailyItems");

            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = System.Type.GetType("System.UInt64"),
                DefaultValue = 0,
                AllowDBNull = false,
                Caption = "Id",
                ReadOnly = true,
            });
            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "ItemName",
                DataType = System.Type.GetType("System.String"),
                DefaultValue = "",
                AllowDBNull = false,
                Caption = "Item",
                ReadOnly = true,
            });
            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "Description",
                DataType = System.Type.GetType("System.String"),
                DefaultValue = "",
                AllowDBNull = false,
                Caption = "Description",
                ReadOnly = true,
            });
            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "CompletedToday",
                DataType = System.Type.GetType("System.Boolean"),
                DefaultValue = false,
                AllowDBNull = true,
                Caption = "Done",
                ReadOnly = true,
            });

            dt.Rows.Add(new object[] { 1, "Good Morning", "Wake up", false });
            dt.Rows.Add(new object[] { 2, "Eat", "Breakfast", false });

            StaticDS.Tables.Add(dt);

            bindingSource1.DataSource = StaticDS;
            bindingSource1.DataMember = "DailyItems";
            dataGridViewToDo.AutoGenerateColumns = true;
        }
        */

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Ctx != null)
            {
                Ctx.SaveChanges();
            }
        }

    }
}
