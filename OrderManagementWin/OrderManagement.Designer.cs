namespace OrderManagementWin
{
    partial class OrderManagement
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
            orderitemview = new DataGridView();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            create = new Button();
            del = new Button();
            searchtext = new TextBox();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)orderitemview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // orderitemview
            // 
            orderitemview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderitemview.Location = new Point(23, 248);
            orderitemview.Name = "orderitemview";
            orderitemview.RowHeadersWidth = 82;
            orderitemview.RowTemplate.Height = 40;
            orderitemview.Size = new Size(1223, 510);
            orderitemview.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(442, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(804, 200);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(create);
            panel1.Controls.Add(del);
            panel1.Controls.Add(searchtext);
            panel1.Controls.Add(search);
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 200);
            panel1.TabIndex = 3;
            // 
            // create
            // 
            create.Location = new Point(203, 79);
            create.Name = "create";
            create.Size = new Size(179, 98);
            create.TabIndex = 3;
            create.Text = "创建订单";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // del
            // 
            del.Location = new Point(17, 79);
            del.Name = "del";
            del.Size = new Size(169, 98);
            del.TabIndex = 2;
            del.Text = "删除订单";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // searchtext
            // 
            searchtext.Location = new Point(155, 21);
            searchtext.Name = "searchtext";
            searchtext.Size = new Size(227, 38);
            searchtext.TabIndex = 1;
            // 
            // search
            // 
            search.Location = new Point(17, 16);
            search.Name = "search";
            search.Size = new Size(120, 46);
            search.TabIndex = 0;
            search.Text = "查找订单";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 790);
            Controls.Add(orderitemview);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "OrderManagement";
            Text = "OrderManagement";
            ((System.ComponentModel.ISupportInitialize)orderitemview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderitemview;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button create;
        private Button del;
        private TextBox searchtext;
        private Button search;
    }
}