﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OrderManagementWin
{
    public partial class OrderManagement : Form
    {
        OrderService orderService = new OrderService();
        List<Order> orders;
        List<OrderItem> orderItems;
        IEnumerable<Order> p;

        int row = -1;
        int mutex = 0;
        public OrderManagement()
        {
            InitializeComponent();
            OrderItem o1 = new OrderItem("apple", 000101, 15, 1);
            List<OrderItem> oi = new List<OrderItem>();
            oi.Add(o1);
            orderService.AddOrder("001", "miles", 1, 15, oi);
        }

        private void search_Click(object sender, EventArgs e)
        {
            row = -1;
            mutex = 0;
            string find = searchtext.Text;
            p = orderService.Search_order_num(find);
            if (p.Count() == 0)
            {
                p = orderService.Search_commoditLy_name(find);
                if (p.Count() == 0)
                {
                    p = orderService.Search_customer(find);
                }
            }
            orders = p.ToList();
            dataGridView1.DataSource = orders;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mutex = 1;
            Object o = dataGridView1.Rows[e.RowIndex].DataBoundItem;
            row = e.RowIndex;
            foreach (object i in p)
            {
                if (o == i)
                {
                    Order order = (Order)o;
                    orderitemview.DataSource = order.details;
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            Object o = dataGridView1.Rows[row].DataBoundItem;
            orderService.DelOrder((Order)o);
            searchtext.Text = "";
            dataGridView1.DataSource = null;
            orderitemview.DataSource = null;
        }

        private void create_Click(object sender, EventArgs e)
        {
            new CreateNewOrder(orderService).ShowDialog();
        }
    }
}
