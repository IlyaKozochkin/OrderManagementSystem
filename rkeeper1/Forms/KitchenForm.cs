using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rkeeper;

namespace rkeeper1
{
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
        }

        public void UpdateTableNewOrder() // обновление таблицы новых заказов 
        {
            TableNewOrder.Rows.Clear();

            TableNewOrder.ColumnCount = 5;
            TableNewOrder.Columns[0].Name = "Id";
            TableNewOrder.Columns[0].ReadOnly = true;
            TableNewOrder.Columns[1].Name = "Блюдо";
            TableNewOrder.Columns[1].ReadOnly = true;
            TableNewOrder.Columns[2].Name = "Стол";
            TableNewOrder.Columns[2].ReadOnly = true;
            TableNewOrder.Columns[3].Name = "Официант";
            TableNewOrder.Columns[3].ReadOnly = true;
            TableNewOrder.Columns[4].Name = "Состояние";
            TableNewOrder.Columns[4].ReadOnly = true;

            TableNewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableNewOrder.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.UseColumnTextForButtonValue = true;
            btn1.HeaderText = "";
            btn1.Name = "myBtn1";
            btn1.Text = "Принять";
            TableNewOrder.Columns.Add(btn1);
            btn1.Width = 75;

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.UseColumnTextForButtonValue = true;
            btn2.HeaderText = "";
            btn2.Name = "myBtn2";
            btn2.Text = "Отклонить";
            TableNewOrder.Columns.Add(btn2);
            btn2.Width = 75;



            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var orders = db.Orders.Where(p => p.Status.Id == 1).ToList();
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();

                foreach (var item in orders)
                {
                    TableNewOrder.Rows.Add(item.Id, item.Dish.Name, item.Table, item.User.LastName, item.Status.Name);
                }
            }
        }
        public void UpdateTableAcceptedOrders() // обновление таблицы новых заказов 
        {
            TableAcceptedOrders.Rows.Clear();

            TableAcceptedOrders.ColumnCount = 5;
            TableAcceptedOrders.Columns[0].Name = "Id";
            TableAcceptedOrders.Columns[0].ReadOnly = true;
            TableAcceptedOrders.Columns[1].Name = "Блюдо";
            TableAcceptedOrders.Columns[1].ReadOnly = true;
            TableAcceptedOrders.Columns[2].Name = "Стол";
            TableAcceptedOrders.Columns[2].ReadOnly = true;
            TableAcceptedOrders.Columns[3].Name = "Официант";
            TableAcceptedOrders.Columns[3].ReadOnly = true;
            TableAcceptedOrders.Columns[4].Name = "Состояние";
            TableAcceptedOrders.Columns[4].ReadOnly = true;

            TableAcceptedOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableAcceptedOrders.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn1";
            btn.Text = "Готово";
            TableAcceptedOrders.Columns.Add(btn);
            btn.Width = 75;



            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var orders = db.Orders.Where(p => p.Status.Id == 2).ToList();
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();

                foreach (var item in orders)
                {
                    TableAcceptedOrders.Rows.Add(item.Id, item.Dish.Name, item.Table, item.User.LastName, item.Status.Name);
                }
            }
        }

        private void KitchenForm_Load(object sender, EventArgs e) // загрузка таблиц при запуске программы 
        {
            UpdateTableNewOrder();
            UpdateTableAcceptedOrders();
        } 

        private void timer1_Tick(object sender, EventArgs e) // обновление таблицы с новыми заказами
        {
            UpdateTableNewOrder();
        } 

        private void TableNewOrder_CellClick(object sender, DataGridViewCellEventArgs e) // принятие/отклон заказов
        {
            if (e.ColumnIndex == 5)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    
                    var dishes = db.Dishs.ToList();
                    Order order = db.Orders.First(p => p.Id.ToString() == TableNewOrder.Rows[e.RowIndex].Cells[0].Value.ToString());

                    order.Status = db.Statuses.First(p => p.Id == 2);
                     
                    db.Update(order);
                    db.SaveChanges();

                    UpdateTableNewOrder();
                    UpdateTableAcceptedOrders();
                }
            }

            if (e.ColumnIndex == 6)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {

                    var dishes = db.Dishs.ToList();
                    Order order = db.Orders.First(p => p.Id.ToString() == TableNewOrder.Rows[e.RowIndex].Cells[0].Value.ToString());

                    order.Status = db.Statuses.First(p => p.Id == 5);

                    db.Update(order);
                    db.SaveChanges();

                    UpdateTableNewOrder();
                }
            }
        }

        private void TableAcceptedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {

                    var dishes = db.Dishs.ToList();
                    Order order = db.Orders.First(p => p.Id.ToString() == TableAcceptedOrders.Rows[e.RowIndex].Cells[0].Value.ToString());

                    order.Status = db.Statuses.First(p => p.Id == 3);

                    db.Update(order);
                    db.SaveChanges();

                    UpdateTableNewOrder();
                    UpdateTableAcceptedOrders();
                }
            }
        } // заказ готов
    }
}
