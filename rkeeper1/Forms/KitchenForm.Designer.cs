namespace rkeeper1
{
    partial class KitchenForm
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
            this.TableNewOrder = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TableAcceptedOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableNewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAcceptedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMenu
            // 
            this.TableNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableNewOrder.Location = new System.Drawing.Point(3, 29);
            this.TableNewOrder.Name = "TableMenu";
            this.TableNewOrder.RowTemplate.Height = 25;
            this.TableNewOrder.Size = new System.Drawing.Size(795, 190);
            this.TableNewOrder.TabIndex = 0;
            this.TableNewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableNewOrder_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новые заказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Принятые заказы";
            // 
            // TableOrder
            // 
            this.TableAcceptedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAcceptedOrders.Location = new System.Drawing.Point(3, 255);
            this.TableAcceptedOrders.Name = "TableOrder";
            this.TableAcceptedOrders.RowTemplate.Height = 25;
            this.TableAcceptedOrders.Size = new System.Drawing.Size(795, 193);
            this.TableAcceptedOrders.TabIndex = 2;
            this.TableAcceptedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableAcceptedOrders_CellClick);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableAcceptedOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNewOrder);
            this.Name = "KitchenForm";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableNewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAcceptedOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TableNewOrder;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private DataGridView TableAcceptedOrders;
    }
}