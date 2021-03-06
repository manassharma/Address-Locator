﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.ServiceReference1;

namespace WebApplication2
{
    public partial class FindStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client myStoreLocatorClient = new Service1Client();
            string zipCode = TextBox1.Text;
            string storeName = TextBox2.Text;
            string queryResult = myStoreLocatorClient.findNearestStore(zipCode, storeName);
            Label2.Text = queryResult;
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e) { }
        protected void TextBox2_TextChanged(object sender, EventArgs e) { }
    }
}