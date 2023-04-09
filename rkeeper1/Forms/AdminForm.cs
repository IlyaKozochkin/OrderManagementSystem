using rkeeper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rkeeper1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        void UpdateTableUser() // обновление таблицы официантов
        {
            TableUser.Rows.Clear();

            TableUser.ColumnCount = 3;
            TableUser.Columns[0].Name = "id";
            TableUser.Columns[0].ReadOnly = true;
            TableUser.Columns[1].Name = "Имя";
            TableUser.Columns[1].ReadOnly = true;
            TableUser.Columns[2].Name = "Фамилия";
            TableUser.Columns[2].ReadOnly = true;


            TableUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableUser.AllowUserToAddRows = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            btn.Name = "myBtn";
            btn.Text = "Удалить";
            TableUser.Columns.Add(btn);
            btn.Width = 75;
            TableUser.Columns[0].Width = 40;

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var users = db.Users.ToList();
                foreach (var item in users)
                {
                    TableUser.Rows.Add(item.Id, item.FirstName, item.LastName);
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e) // загружжаем виды блюд для comboBox и таблицу с офицантами
        {
            using (ApplicationDbContext db = new ApplicationDbContext()) 
            {
                var dishTypes = db.DishTypes.ToList();
                foreach (var item in dishTypes)
                {
                    TypeDish_comboBox.Items.Add(item.Name);
                }
            }

            UpdateTableUser();
        }

        private void CreateDish_button_Click(object sender, EventArgs e) // добавление нового блюда
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                ulong beforeParse;
                bool resultParse = ulong.TryParse(PriceDish_textBox.Text, out beforeParse);
                var dishTypes = db.DishTypes.ToList();

                if (!resultParse)
                {
                    MessageBox.Show("Укажите корректную цену");
                    return;
                }

                Dish dish = new Dish() { Name = NameDish_textBox.Text, Price = beforeParse, DishType = dishTypes.First(p => p.Name == TypeDish_comboBox.Text) };

                db.Dishs.Add(dish);

                db.SaveChanges();
                MessageBox.Show("Блюдо добавлено");
            }

            NameDish_textBox.Clear();
            PriceDish_textBox.Clear();
            TypeDish_comboBox.SelectedItem = null;
        }

        private void CreateUser_button_Click(object sender, EventArgs e) // добавление нового официанта
        {
            if (Password_textBox.Text == RepPasswordtextBox.Text)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var roles = db.Roles.ToList();

                    User user = new User() { FirstName = FirstName_textBox.Text, LastName = LastName_textBox.Text, Password = Password_textBox.Text, Role = roles.First(p => p.Id == 2) };

                    db.Users.Add(user);

                    db.SaveChanges();
                    MessageBox.Show($"Новый аккаунт официанта создан \nЛогин: {user.Id}");
                }

                FirstName_textBox.Clear();
                LastName_textBox.Clear();
                Password_textBox.Clear();
                RepPasswordtextBox.Clear();

                UpdateTableUser();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void TableUser_CellClick(object sender, DataGridViewCellEventArgs e) // удаление официанта
        {
            if (e.ColumnIndex == 3) 
            {
                using(ApplicationDbContext db = new ApplicationDbContext())
                {
                    User user = db.Users.First(p => p.Id.ToString() == TableUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }

            UpdateTableUser();
        }
    }
}
