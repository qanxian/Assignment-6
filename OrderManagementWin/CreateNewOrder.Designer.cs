namespace OrderManagementWin
{
    partial class CreateNewOrder
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
            panel1 = new Panel();
            spstext = new TextBox();
            yhmtext = new TextBox();
            ddhtext = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            IDtext = new TextBox();
            sltext = new TextBox();
            djtext = new TextBox();
            spmtext = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            orderinfor = new Button();
            goodinfor = new Button();
            tx = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(spstext);
            panel1.Controls.Add(yhmtext);
            panel1.Controls.Add(ddhtext);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 238);
            panel1.TabIndex = 0;
            // 
            // spstext
            // 
            spstext.Location = new Point(117, 184);
            spstext.Name = "spstext";
            spstext.Size = new Size(230, 38);
            spstext.TabIndex = 5;
            // 
            // yhmtext
            // 
            yhmtext.Location = new Point(117, 103);
            yhmtext.Name = "yhmtext";
            yhmtext.Size = new Size(230, 38);
            yhmtext.TabIndex = 4;
            // 
            // ddhtext
            // 
            ddhtext.Location = new Point(117, 21);
            ddhtext.Name = "ddhtext";
            ddhtext.Size = new Size(230, 38);
            ddhtext.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 184);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 2;
            label3.Text = "商品数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 103);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 1;
            label2.Text = "用户名";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 0;
            label1.Text = "订单号";
            // 
            // panel2
            // 
            panel2.Controls.Add(IDtext);
            panel2.Controls.Add(sltext);
            panel2.Controls.Add(djtext);
            panel2.Controls.Add(spmtext);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(383, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 238);
            panel2.TabIndex = 1;
            // 
            // IDtext
            // 
            IDtext.Location = new Point(117, 186);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(263, 38);
            IDtext.TabIndex = 7;
            // 
            // sltext
            // 
            sltext.Location = new Point(117, 128);
            sltext.Name = "sltext";
            sltext.Size = new Size(263, 38);
            sltext.TabIndex = 6;
            // 
            // djtext
            // 
            djtext.Location = new Point(117, 68);
            djtext.Name = "djtext";
            djtext.Size = new Size(263, 38);
            djtext.TabIndex = 5;
            // 
            // spmtext
            // 
            spmtext.Location = new Point(117, 12);
            spmtext.Name = "spmtext";
            spmtext.Size = new Size(263, 38);
            spmtext.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 186);
            label7.Name = "label7";
            label7.Size = new Size(63, 31);
            label7.TabIndex = 3;
            label7.Text = "ID号";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 128);
            label6.Name = "label6";
            label6.Size = new Size(62, 31);
            label6.TabIndex = 2;
            label6.Text = "数量";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 68);
            label5.Name = "label5";
            label5.Size = new Size(62, 31);
            label5.TabIndex = 1;
            label5.Text = "单价";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 12);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 0;
            label4.Text = "商品名";
            // 
            // orderinfor
            // 
            orderinfor.Location = new Point(12, 267);
            orderinfor.Name = "orderinfor";
            orderinfor.Size = new Size(213, 87);
            orderinfor.TabIndex = 2;
            orderinfor.Text = "确认订单信息";
            orderinfor.UseVisualStyleBackColor = true;
            orderinfor.Click += orderinfor_Click;
            // 
            // goodinfor
            // 
            goodinfor.Location = new Point(12, 360);
            goodinfor.Name = "goodinfor";
            goodinfor.Size = new Size(213, 93);
            goodinfor.TabIndex = 3;
            goodinfor.Text = "确认商品信息";
            goodinfor.UseVisualStyleBackColor = true;
            goodinfor.Click += goodinfor_Click;
            // 
            // tx
            // 
            tx.AutoSize = true;
            tx.Location = new Point(28, 466);
            tx.Name = "tx";
            tx.Size = new Size(172, 31);
            tx.TabIndex = 4;
            tx.Text = "需添加0种商品";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(540, 230);
            dataGridView1.TabIndex = 5;
            // 
            // CreateNewOrder
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 517);
            Controls.Add(dataGridView1);
            Controls.Add(tx);
            Controls.Add(goodinfor);
            Controls.Add(orderinfor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CreateNewOrder";
            Text = "CreateNewOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox ddhtext;
        private TextBox spstext;
        private TextBox yhmtext;
        private TextBox djtext;
        private TextBox spmtext;
        private TextBox IDtext;
        private TextBox sltext;
        private Button orderinfor;
        private Button goodinfor;
        private Label tx;
        private DataGridView dataGridView1;
    }
}