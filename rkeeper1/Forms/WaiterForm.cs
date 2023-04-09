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
    public partial class WaiterForm : Form
    {
        User _user;
        List<Dish> listDish = new List<Dish>();

        public WaiterForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UpdateTableMenu() // обновление таблицы с меню
        {
            TableMenu.Rows.Clear();

            TableMenu.ColumnCount = 2;
            TableMenu.Columns[0].Name = "Блюдо";
            TableMenu.Columns[0].ReadOnly = true;
            TableMenu.Columns[1].Name = "Цена";
            TableMenu.Columns[1].ReadOnly = true;

            TableMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableMenu.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn";
            btn.Text = "Добавить";
            TableMenu.Columns.Add(btn);
            btn.Width = 75;

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishTypes = db.DishTypes.ToList();
                var dishs = db.Dishs.ToList();

                foreach (var item in dishs)
                {
                    TableMenu.Rows.Add(item.Name, item.Price);
                }
            }
        }
        private void UpdateTableOrder() // обновление таблицы с новым заказом 
        {
            TableOrder.Rows.Clear();

            TableOrder.ColumnCount = 2;
            TableOrder.Columns[0].Name = "Блюдо";
            TableOrder.Columns[0].ReadOnly = true;
            TableOrder.Columns[1].Name = "Цена";
            TableOrder.Columns[1].ReadOnly = true;

            TableOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableOrder.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn";
            btn.Text = "Удалить";
            TableOrder.Columns.Add(btn);
            btn.Width = 75;

            foreach (var item in listDish)
            {
                TableOrder.Rows.Add(item.Name, item.Price);
            }
        }
        private void UpdateTableGettingReady() // обновление таблицы заказов которые готовятся
        {
            TableGettingReady.Rows.Clear();

            TableGettingReady.ColumnCount = 4;
            TableGettingReady.Columns[0].Name = "Id";
            TableGettingReady.Columns[0].ReadOnly = true;
            TableGettingReady.Columns[1].Name = "Блюдо";
            TableGettingReady.Columns[1].ReadOnly = true;
            TableGettingReady.Columns[2].Name = "Стол";
            TableGettingReady.Columns[2].ReadOnly = true;
            TableGettingReady.Columns[3].Name = "Состояние";
            TableGettingReady.Columns[3].ReadOnly = true;

            TableGettingReady.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableGettingReady.AllowUserToAddRows = false;


            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();
                var orders = db.Orders.Where(p => p.User.Id == _user.Id && p.Status.Id == 2).ToList();

                foreach (var item in orders)
                {
                    TableGettingReady.Rows.Add(item.Id, item.Dish.Name, item.Table, item.Status.Name);
                }
            }
        }
        private void UpdateTableReady() // обновление таблицы заказов которые готовы
        {
            TableReady.Rows.Clear();

            TableReady.ColumnCount = 4;
            TableReady.Columns[0].Name = "Id";
            TableReady.Columns[0].ReadOnly = true;
            TableReady.Columns[1].Name = "Блюдо";
            TableReady.Columns[1].ReadOnly = true;
            TableReady.Columns[2].Name = "Стол";
            TableReady.Columns[2].ReadOnly = true;
            TableReady.Columns[3].Name = "Состояние";
            TableReady.Columns[3].ReadOnly = true;

            TableReady.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableReady.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn1";
            btn.Text = "Отдан";
            TableReady.Columns.Add(btn);
            btn.Width = 75;


            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();
                var orders = db.Orders.Where(p => p.User.Id == _user.Id && p.Status.Id == 3).ToList();

                foreach (var item in orders)
                {
                    TableReady.Rows.Add(item.Id, item.Dish.Name, item.Table, item.Status.Name);
                }
            }
        }
        private void UpdateTableRefusal() // обновление таблицы с отказами
        {
            TableRefusal.Rows.Clear();

            TableRefusal.ColumnCount = 4;
            TableRefusal.Columns[0].Name = "Id";
            TableRefusal.Columns[0].ReadOnly = true;
            TableRefusal.Columns[1].Name = "Блюдо";
            TableRefusal.Columns[1].ReadOnly = true;
            TableRefusal.Columns[2].Name = "Стол";
            TableRefusal.Columns[2].ReadOnly = true;
            TableRefusal.Columns[3].Name = "Состояние";
            TableRefusal.Columns[3].ReadOnly = true;

            TableRefusal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableRefusal.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn1";
            btn.Text = "Ок";
            TableRefusal.Columns.Add(btn);
            btn.Width = 75;


            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();
                var orders = db.Orders.Where(p => p.User.Id == _user.Id && p.Status.Id == 5).ToList();

                foreach (var item in orders)
                {
                    TableRefusal.Rows.Add(item.Id, item.Dish.Name, item.Table, item.Status.Name);
                }
            }
        }
        private void UpdateTableAwaitingСonfirmation()
        {
            TableAwaitingСonfirmation.Columns.Clear();

            TableAwaitingСonfirmation.ColumnCount = 4;
            TableAwaitingСonfirmation.Columns[0].Name = "Id";
            TableAwaitingСonfirmation.Columns[0].ReadOnly = true;
            TableAwaitingСonfirmation.Columns[1].Name = "Блюдо";
            TableAwaitingСonfirmation.Columns[1].ReadOnly = true;
            TableAwaitingСonfirmation.Columns[2].Name = "Стол";
            TableAwaitingСonfirmation.Columns[2].ReadOnly = true;
            TableAwaitingСonfirmation.Columns[3].Name = "Состояние";
            TableAwaitingСonfirmation.Columns[3].ReadOnly = true;

            TableAwaitingСonfirmation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableAwaitingСonfirmation.AllowUserToAddRows = false;


            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishes = db.Dishs.ToList();
                var users = db.Users.ToList();
                var statuses = db.Statuses.ToList();
                var orders = db.Orders.Where(p => p.User.Id == _user.Id && p.Status.Id == 1).ToList();

                foreach (var item in orders)
                {
                    TableAwaitingСonfirmation.Rows.Add(item.Id, item.Dish.Name, item.Table, item.Status.Name);
                }
            }
        }

        private void WaiterForm_Load(object sender, EventArgs e) // загружаем виды блюд для comboBox, меню для TableMenu и таблицы с заказами
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishTypes = db.DishTypes.ToList();
                foreach (var item in dishTypes)
                {
                    TypeDish_comboBox.Items.Add(item.Name);
                }
            }

            UpdateTableMenu();
            UpdateTableOrder();
            UpdateTableGettingReady();
            UpdateTableReady();
            UpdateTableRefusal();
        }

        private void TypeDish_comboBox_SelectedIndexChanged(object sender, EventArgs e) // выбор вида блюд 
        {
            TableMenu.Rows.Clear();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var dishTypes = db.DishTypes.ToList();
                var dishs = db.Dishs.Where(p => p.DishType.Name == TypeDish_comboBox.Text).ToList();

                foreach (var item in dishs)
                {
                    TableMenu.Rows.Add(item.Name, item.Price);
                }
            }
        }

        private void TableMenu_CellClick(object sender, DataGridViewCellEventArgs e) // добавление блюд в заказ
        {
            if (e.ColumnIndex == 2)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var dishTypes = db.DishTypes.ToList();
                    Dish dish = db.Dishs.First(p => p.Name == TableMenu.Rows[e.RowIndex].Cells[0].Value.ToString());
                    listDish.Add(dish);
                }
            }

            UpdateTableMenu();
            UpdateTableOrder();
        }

        private void TableOrder_CellClick(object sender, DataGridViewCellEventArgs e) // удаление блюда из заказа
        {
            if (e.ColumnIndex == 2)
            {
                Dish dish = listDish.First(p => p.Name == TableOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
                listDish.Remove(dish);
            }

            UpdateTableOrder();
        }

        private void CreateOrder_button_Click(object sender, EventArgs e) // подтверждение заказа
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                //var users = db.Users.ToList();
                
                Status status = db.Statuses.First(p => p.Id == 1);
                foreach (var item in listDish)
                {
                    Dish dish = db.Dishs.First(p => p.Id == item.Id);
                    User user = db.Users.First(p => p.Id == _user.Id);
                    Order order = new Order() { Table = int.Parse(Desk_comboBox.Text), Status = status, User = user, Dish = dish };
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Заказ сформирован");
            UpdateTableMenu();
            TableOrder.Rows.Clear();
            Desk_comboBox.Text = null;
        }

        private void TableReady_CellClick(object sender, DataGridViewCellEventArgs e) // кнопка "заказ отдан" 
        {
            if (e.ColumnIndex == 4)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    Order order = db.Orders.First(p => p.Id.ToString() == TableReady.Rows[e.RowIndex].Cells[0].Value.ToString());
                    db.Orders.Remove(order);
                    db.SaveChanges();

                    UpdateTableReady();
                }
            }
        }

        private void TableRefusal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    Order order = db.Orders.First(p => p.Id.ToString() == TableRefusal.Rows[e.RowIndex].Cells[0].Value.ToString());
                    db.Orders.Remove(order);
                    db.SaveChanges();

                    UpdateTableRefusal();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTableGettingReady();
            UpdateTableReady();
            UpdateTableRefusal();
            UpdateTableAwaitingСonfirmation();
        }
    }
}
