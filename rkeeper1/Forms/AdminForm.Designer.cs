namespace rkeeper1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateUser_button = new System.Windows.Forms.Button();
            this.RepPasswordtextBox = new System.Windows.Forms.TextBox();
            this.RepPassword_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TableUser = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CreateDish_button = new System.Windows.Forms.Button();
            this.PriceDish_textBox = new System.Windows.Forms.TextBox();
            this.PriceDish_label = new System.Windows.Forms.Label();
            this.TypeDish_label = new System.Windows.Forms.Label();
            this.TypeDish_comboBox = new System.Windows.Forms.ComboBox();
            this.NameDish_textBox = new System.Windows.Forms.TextBox();
            this.NameDish_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableUser)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreateUser_button);
            this.tabPage2.Controls.Add(this.RepPasswordtextBox);
            this.tabPage2.Controls.Add(this.RepPassword_label);
            this.tabPage2.Controls.Add(this.Password_textBox);
            this.tabPage2.Controls.Add(this.Password_label);
            this.tabPage2.Controls.Add(this.LastName_textBox);
            this.tabPage2.Controls.Add(this.LastName_label);
            this.tabPage2.Controls.Add(this.FirstName_textBox);
            this.tabPage2.Controls.Add(this.FirstName_label);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить официанта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateUser_button
            // 
            this.CreateUser_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateUser_button.Location = new System.Drawing.Point(275, 350);
            this.CreateUser_button.Name = "CreateUser_button";
            this.CreateUser_button.Size = new System.Drawing.Size(243, 63);
            this.CreateUser_button.TabIndex = 8;
            this.CreateUser_button.Text = "Создать";
            this.CreateUser_button.UseVisualStyleBackColor = true;
            this.CreateUser_button.Click += new System.EventHandler(this.CreateUser_button_Click);
            // 
            // RepPasswordtextBox
            // 
            this.RepPasswordtextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepPasswordtextBox.Location = new System.Drawing.Point(3, 301);
            this.RepPasswordtextBox.Name = "RepPasswordtextBox";
            this.RepPasswordtextBox.PasswordChar = '*';
            this.RepPasswordtextBox.Size = new System.Drawing.Size(783, 43);
            this.RepPasswordtextBox.TabIndex = 7;
            // 
            // RepPassword_label
            // 
            this.RepPassword_label.AutoSize = true;
            this.RepPassword_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepPassword_label.Location = new System.Drawing.Point(3, 261);
            this.RepPassword_label.Name = "RepPassword_label";
            this.RepPassword_label.Size = new System.Drawing.Size(247, 37);
            this.RepPassword_label.TabIndex = 6;
            this.RepPassword_label.Text = "Повторите пароль";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.Location = new System.Drawing.Point(3, 215);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(783, 43);
            this.Password_textBox.TabIndex = 5;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_label.Location = new System.Drawing.Point(3, 175);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(110, 37);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Пароль";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_textBox.Location = new System.Drawing.Point(3, 129);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(780, 43);
            this.LastName_textBox.TabIndex = 3;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName_label.Location = new System.Drawing.Point(3, 86);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(130, 37);
            this.LastName_label.TabIndex = 2;
            this.LastName_label.Text = "Фамилия";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName_textBox.Location = new System.Drawing.Point(3, 40);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(780, 43);
            this.FirstName_textBox.TabIndex = 1;
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName_label.Location = new System.Drawing.Point(3, 0);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(70, 37);
            this.FirstName_label.TabIndex = 0;
            this.FirstName_label.Text = "Имя";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TableUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить официанта";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TableUser
            // 
            this.TableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUser.Location = new System.Drawing.Point(-4, 0);
            this.TableUser.Name = "TableUser";
            this.TableUser.RowTemplate.Height = 25;
            this.TableUser.Size = new System.Drawing.Size(796, 420);
            this.TableUser.TabIndex = 0;
            this.TableUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableUser_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CreateDish_button);
            this.tabPage4.Controls.Add(this.PriceDish_textBox);
            this.tabPage4.Controls.Add(this.PriceDish_label);
            this.tabPage4.Controls.Add(this.TypeDish_label);
            this.tabPage4.Controls.Add(this.TypeDish_comboBox);
            this.tabPage4.Controls.Add(this.NameDish_textBox);
            this.tabPage4.Controls.Add(this.NameDish_label);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Добавить блюдо";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CreateDish_button
            // 
            this.CreateDish_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateDish_button.Location = new System.Drawing.Point(303, 314);
            this.CreateDish_button.Name = "CreateDish_button";
            this.CreateDish_button.Size = new System.Drawing.Size(186, 54);
            this.CreateDish_button.TabIndex = 6;
            this.CreateDish_button.Text = "Добавить";
            this.CreateDish_button.UseVisualStyleBackColor = true;
            this.CreateDish_button.Click += new System.EventHandler(this.CreateDish_button_Click);
            // 
            // PriceDish_textBox
            // 
            this.PriceDish_textBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceDish_textBox.Location = new System.Drawing.Point(7, 217);
            this.PriceDish_textBox.Name = "PriceDish_textBox";
            this.PriceDish_textBox.Size = new System.Drawing.Size(776, 43);
            this.PriceDish_textBox.TabIndex = 5;
            // 
            // PriceDish_label
            // 
            this.PriceDish_label.AutoSize = true;
            this.PriceDish_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceDish_label.Location = new System.Drawing.Point(7, 177);
            this.PriceDish_label.Name = "PriceDish_label";
            this.PriceDish_label.Size = new System.Drawing.Size(81, 37);
            this.PriceDish_label.TabIndex = 4;
            this.PriceDish_label.Text = "Цена";
            // 
            // TypeDish_label
            // 
            this.TypeDish_label.AutoSize = true;
            this.TypeDish_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeDish_label.Location = new System.Drawing.Point(7, 89);
            this.TypeDish_label.Name = "TypeDish_label";
            this.TypeDish_label.Size = new System.Drawing.Size(63, 37);
            this.TypeDish_label.TabIndex = 3;
            this.TypeDish_label.Text = "Вид";
            // 
            // TypeDish_comboBox
            // 
            this.TypeDish_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDish_comboBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeDish_comboBox.FormattingEnabled = true;
            this.TypeDish_comboBox.Location = new System.Drawing.Point(7, 129);
            this.TypeDish_comboBox.Name = "TypeDish_comboBox";
            this.TypeDish_comboBox.Size = new System.Drawing.Size(776, 45);
            this.TypeDish_comboBox.TabIndex = 2;
            // 
            // NameDish_textBox
            // 
            this.NameDish_textBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameDish_textBox.Location = new System.Drawing.Point(7, 43);
            this.NameDish_textBox.Name = "NameDish_textBox";
            this.NameDish_textBox.Size = new System.Drawing.Size(776, 43);
            this.NameDish_textBox.TabIndex = 1;
            // 
            // NameDish_label
            // 
            this.NameDish_label.AutoSize = true;
            this.NameDish_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameDish_label.Location = new System.Drawing.Point(7, 3);
            this.NameDish_label.Name = "NameDish_label";
            this.NameDish_label.Size = new System.Drawing.Size(136, 37);
            this.NameDish_label.TabIndex = 0;
            this.NameDish_label.Text = "Название";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableUser)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label NameDish_label;
        private TextBox NameDish_textBox;
        private ComboBox TypeDish_comboBox;
        private Label TypeDish_label;
        private Button CreateDish_button;
        private TextBox PriceDish_textBox;
        private Label PriceDish_label;
        private TextBox FirstName_textBox;
        private Label FirstName_label;
        private Button CreateUser_button;
        private TextBox RepPasswordtextBox;
        private Label RepPassword_label;
        private TextBox Password_textBox;
        private Label Password_label;
        private TextBox LastName_textBox;
        private Label LastName_label;
        private DataGridView TableUser;
    }
}