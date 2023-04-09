namespace rkeeper1
{
    partial class WaiterForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TableOrder_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TableOrder = new System.Windows.Forms.DataGridView();
            this.TableMenu = new System.Windows.Forms.DataGridView();
            this.Desk_label = new System.Windows.Forms.Label();
            this.Desk_comboBox = new System.Windows.Forms.ComboBox();
            this.TypeDish_comboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Refusal_label = new System.Windows.Forms.Label();
            this.TableRefusal = new System.Windows.Forms.DataGridView();
            this.TableReady_label = new System.Windows.Forms.Label();
            this.TableReady = new System.Windows.Forms.DataGridView();
            this.TableGettingReady_label = new System.Windows.Forms.Label();
            this.TableGettingReady = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AwaitingСonfirmation_label = new System.Windows.Forms.Label();
            this.TableAwaitingСonfirmation = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableRefusal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGettingReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAwaitingСonfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TableOrder_label);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TableOrder);
            this.tabPage1.Controls.Add(this.TableMenu);
            this.tabPage1.Controls.Add(this.Desk_label);
            this.tabPage1.Controls.Add(this.Desk_comboBox);
            this.tabPage1.Controls.Add(this.TypeDish_comboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новый заказ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TableOrder_label
            // 
            this.TableOrder_label.AutoSize = true;
            this.TableOrder_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableOrder_label.Location = new System.Drawing.Point(0, 309);
            this.TableOrder_label.Name = "TableOrder_label";
            this.TableOrder_label.Size = new System.Drawing.Size(79, 32);
            this.TableOrder_label.TabIndex = 7;
            this.TableOrder_label.Text = "Заказ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подтвердить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateOrder_button_Click);
            // 
            // TableOrder
            // 
            this.TableOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOrder.Location = new System.Drawing.Point(0, 344);
            this.TableOrder.Name = "TableOrder";
            this.TableOrder.RowTemplate.Height = 25;
            this.TableOrder.Size = new System.Drawing.Size(1073, 224);
            this.TableOrder.TabIndex = 5;
            this.TableOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOrder_CellClick);
            // 
            // TableMenu
            // 
            this.TableMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMenu.Location = new System.Drawing.Point(0, 60);
            this.TableMenu.Name = "TableMenu";
            this.TableMenu.RowTemplate.Height = 25;
            this.TableMenu.Size = new System.Drawing.Size(1070, 246);
            this.TableMenu.TabIndex = 4;
            this.TableMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableMenu_CellClick);
            // 
            // Desk_label
            // 
            this.Desk_label.AutoSize = true;
            this.Desk_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Desk_label.Location = new System.Drawing.Point(8, 3);
            this.Desk_label.Name = "Desk_label";
            this.Desk_label.Size = new System.Drawing.Size(53, 25);
            this.Desk_label.TabIndex = 3;
            this.Desk_label.Text = "Стол";
            // 
            // Desk_comboBox
            // 
            this.Desk_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Desk_comboBox.FormattingEnabled = true;
            this.Desk_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Desk_comboBox.Location = new System.Drawing.Point(8, 31);
            this.Desk_comboBox.Name = "Desk_comboBox";
            this.Desk_comboBox.Size = new System.Drawing.Size(53, 23);
            this.Desk_comboBox.TabIndex = 2;
            // 
            // TypeDish_comboBox
            // 
            this.TypeDish_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDish_comboBox.FormattingEnabled = true;
            this.TypeDish_comboBox.Location = new System.Drawing.Point(76, 31);
            this.TypeDish_comboBox.Name = "TypeDish_comboBox";
            this.TypeDish_comboBox.Size = new System.Drawing.Size(140, 23);
            this.TypeDish_comboBox.TabIndex = 1;
            this.TypeDish_comboBox.SelectedIndexChanged += new System.EventHandler(this.TypeDish_comboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AwaitingСonfirmation_label);
            this.tabPage2.Controls.Add(this.TableAwaitingСonfirmation);
            this.tabPage2.Controls.Add(this.Refusal_label);
            this.tabPage2.Controls.Add(this.TableRefusal);
            this.tabPage2.Controls.Add(this.TableReady_label);
            this.tabPage2.Controls.Add(this.TableReady);
            this.tabPage2.Controls.Add(this.TableGettingReady_label);
            this.tabPage2.Controls.Add(this.TableGettingReady);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статус заказов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Refusal_label
            // 
            this.Refusal_label.AutoSize = true;
            this.Refusal_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refusal_label.Location = new System.Drawing.Point(0, 328);
            this.Refusal_label.Name = "Refusal_label";
            this.Refusal_label.Size = new System.Drawing.Size(72, 30);
            this.Refusal_label.TabIndex = 7;
            this.Refusal_label.Text = "Отказ";
            // 
            // TableRefusal
            // 
            this.TableRefusal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableRefusal.Location = new System.Drawing.Point(0, 358);
            this.TableRefusal.Name = "TableRefusal";
            this.TableRefusal.RowTemplate.Height = 25;
            this.TableRefusal.Size = new System.Drawing.Size(1070, 89);
            this.TableRefusal.TabIndex = 6;
            this.TableRefusal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableRefusal_CellClick);
            // 
            // TableReady_label
            // 
            this.TableReady_label.AutoSize = true;
            this.TableReady_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableReady_label.Location = new System.Drawing.Point(0, 169);
            this.TableReady_label.Name = "TableReady_label";
            this.TableReady_label.Size = new System.Drawing.Size(87, 30);
            this.TableReady_label.TabIndex = 5;
            this.TableReady_label.Text = "Готовы";
            // 
            // TableReady
            // 
            this.TableReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableReady.Location = new System.Drawing.Point(0, 199);
            this.TableReady.Name = "TableReady";
            this.TableReady.RowTemplate.Height = 25;
            this.TableReady.Size = new System.Drawing.Size(1070, 129);
            this.TableReady.TabIndex = 4;
            this.TableReady.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableReady_CellClick);
            // 
            // TableGettingReady_label
            // 
            this.TableGettingReady_label.AutoSize = true;
            this.TableGettingReady_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableGettingReady_label.Location = new System.Drawing.Point(3, 1);
            this.TableGettingReady_label.Name = "TableGettingReady_label";
            this.TableGettingReady_label.Size = new System.Drawing.Size(114, 30);
            this.TableGettingReady_label.TabIndex = 3;
            this.TableGettingReady_label.Text = "Готовятся";
            // 
            // TableGettingReady
            // 
            this.TableGettingReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGettingReady.Location = new System.Drawing.Point(0, 36);
            this.TableGettingReady.Name = "TableGettingReady";
            this.TableGettingReady.RowTemplate.Height = 25;
            this.TableGettingReady.Size = new System.Drawing.Size(1070, 133);
            this.TableGettingReady.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AwaitingСonfirmation_label
            // 
            this.AwaitingСonfirmation_label.AutoSize = true;
            this.AwaitingСonfirmation_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AwaitingСonfirmation_label.Location = new System.Drawing.Point(0, 447);
            this.AwaitingСonfirmation_label.Name = "AwaitingСonfirmation_label";
            this.AwaitingСonfirmation_label.Size = new System.Drawing.Size(284, 30);
            this.AwaitingСonfirmation_label.TabIndex = 9;
            this.AwaitingСonfirmation_label.Text = "Ожидают подтверждения";
            // 
            // TableAwaitingСonfirmation
            // 
            this.TableAwaitingСonfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAwaitingСonfirmation.Location = new System.Drawing.Point(0, 477);
            this.TableAwaitingСonfirmation.Name = "TableAwaitingСonfirmation";
            this.TableAwaitingСonfirmation.RowTemplate.Height = 25;
            this.TableAwaitingСonfirmation.Size = new System.Drawing.Size(1070, 96);
            this.TableAwaitingСonfirmation.TabIndex = 8;
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "WaiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Официант";
            this.Load += new System.EventHandler(this.WaiterForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableRefusal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGettingReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAwaitingСonfirmation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox TypeDish_comboBox;
        private DataGridView TableOrder;
        private DataGridView TableMenu;
        private Label Desk_label;
        private ComboBox Desk_comboBox;
        private Label TableOrder_label;
        private Button button1;
        private DataGridView TableGettingReady;
        private Label Refusal_label;
        private DataGridView TableRefusal;
        private Label TableReady_label;
        private DataGridView TableReady;
        private Label TableGettingReady_label;
        private System.Windows.Forms.Timer timer1;
        private Label AwaitingСonfirmation_label;
        private DataGridView TableAwaitingСonfirmation;
    }
}