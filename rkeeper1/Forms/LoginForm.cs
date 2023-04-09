using rkeeper;
namespace rkeeper1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            KitchenForm formKitcken = new KitchenForm();
            formKitcken.Show();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                try
                {
                    var roles = db.Roles.ToList();
                    var user = db.Users.First(p => p.Id.ToString() == Login_textBox.Text);
                    if (user.Password == Password_textBox.Text)
                    {
                        if (user.Role.Id == 1) // Админ
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (user.Role.Id == 2) // Официант
                        {
                            WaiterForm waiterForm = new WaiterForm(user);
                            waiterForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
            }
        }
    }
}