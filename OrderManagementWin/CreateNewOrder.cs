using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWin
{
    public partial class CreateNewOrder : Form
    {
        Order order;
        List<OrderItem> orderItems = new List<OrderItem>();
        OrderService orderService;

        string onum;
        string cus;
        int tnum;
        double tp = 0;
        List<OrderItem> list;
        int i;
        public CreateNewOrder(OrderService orderService)
        {
            this.orderService = orderService;
            InitializeComponent();
        }

        private void orderinfor_Click(object sender, EventArgs e)
        {
            onum = ddhtext.Text;
            cus = yhmtext.Text;
            tnum = Convert.ToInt32(spstext.Text);
            tx.Text = "需添加" + tnum + "种商品";
            i = tnum;
        }

        private void goodinfor_Click(object sender, EventArgs e)
        {
            try
            {
                OrderItem oi1 = new OrderItem(spmtext.Text, Convert.ToInt32(IDtext.Text),
                    Convert.ToDouble(djtext.Text), Convert.ToInt32(sltext.Text));
                orderItems.Add(oi1);
                i = i - 1;
                tx.Text = "需添加" + i + "种商品";
                dataGridView1.DataSource = orderItems;
                if (i == 0)
                {
                    foreach (OrderItem oi in orderItems)
                    {
                        tp = tp + oi.per_price * oi.number;
                    }

                    orderService.AddOrder(onum, cus, tnum, tp, orderItems);
                    Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                Close();
            }
        }
    }
}
