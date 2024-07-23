using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pizza Type Selection Fn1353

            if (smallradio.Checked == true)
            {
                if (normalradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("320");
                    listView1.Items.Add(item);
         
                }
                else if (cheesyradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("320");
                    listView1.Items.Add(item);
               
                }
                else if (sausageradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("320");
                    listView1.Items.Add(item);
             
                }

            }

            else if (mediumradio.Checked == true)
            {
                if (normalradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("560");
                    listView1.Items.Add(item);
              
                }
                else if (cheesyradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("560");
                    listView1.Items.Add(item);
             
                }
                else if (sausageradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("560");
                    listView1.Items.Add(item);
                
                }
            }

            else if (largeradio.Checked == true)
            {
                if (normalradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("800");
                    listView1.Items.Add(item);
              
                }
                else if (cheesyradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("800");
                    listView1.Items.Add(item);
              
                }
                else if (sausageradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("800");
                    listView1.Items.Add(item);
            
                }
            }

            else if (exlargeradio.Checked == true)
            {
                if (normalradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1040");
                    listView1.Items.Add(item);
            
                }
                else if (cheesyradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1040");
                    listView1.Items.Add(item);
               
                }
                else if (sausageradio.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1040");
                    listView1.Items.Add(item);
              
                }
            }


            //Pizza Topping Selection

            if (pepcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
           
            }
            
            if (excheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
          
            }

            if (mushcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
         
            }

            if (hamcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
             
            }

            if (baconcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
            
            }

            if (beefcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ground Beef Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
          
            }

            if (jalapenocheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Jalapeno Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
            
            }

            if (pincheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pineapple Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
       
            }

            if (dscheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Dried Shrimps Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
            
            }

            if (anchcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Anchovies Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
        
            }

            if (sdtcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Sun Dried Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
              
            }

            if (spanichcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spinach Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
       
            }


            if (rgcheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Roasted Garlic Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
           
            }

            if (chickencheck.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Shredded Chicken Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("40");
                listView1.Items.Add(item);
        
            }

            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke - Can");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
          
            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke - Can");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
             
            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea - Can");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
              
            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ginger Ale - Can");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite - Can");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Root Beer - Can");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 80;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bottled Water");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 40;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

            //Other Items Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add("");
                item.SubItems.Add("240");
                listView1.Items.Add(item);
          
            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Poutine");
                item.SubItems.Add("");
                item.SubItems.Add("240");
                listView1.Items.Add(item);
             
            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("240");
                listView1.Items.Add(item);
               
            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("240");
                listView1.Items.Add(item);
          
            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0");
                listView1.Items.Add(item);
          
            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0");
                listView1.Items.Add(item);
              
            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0");
                listView1.Items.Add(item);
             
            }

  
            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = 40;
            totaldue = hst + total;

            string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");
            
            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            smallradio.Checked = true;
            normalradio.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            //textBox21.Enabled = false;
            
            comboBox1.Items.Add("Gujarat");
            comboBox1.Items.Add("Goa");
            comboBox1.Items.Add("Himachal ");
            comboBox1.Items.Add("Delhi");
            comboBox1.Items.Add("Panjab");
            comboBox1.Items.Add("karnataka");
            comboBox1.Items.Add("Uttar Pradesh");
            comboBox1.Items.Add("Assam");
            comboBox1.Items.Add("Sikkim");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            comboBox2.Items.Add("Promo Card");

            button8.Enabled = false;

        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
    
            else
            {
                string money = textBox19.Text;
                char[] inr = { '$' };
                string paymoney = money.TrimStart(inr);
                double paymentDue;
                bool isValidPaymentDue= double.TryParse(paymoney,out paymentDue);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
               // textBox21.Text = change.ToString("c2");

                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }

                else
                {
                    button8.Enabled = true;
                }
                  

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

           if (dialog == DialogResult.Yes)
           {

               //Clearing all data
               pepcheck.Checked = false;
               excheck.Checked = false;
               mushcheck.Checked = false;
               hamcheck.Checked = false;
               baconcheck.Checked = false;
               beefcheck.Checked = false;
               jalapenocheck.Checked = false;
               pincheck.Checked = false;
               dscheck.Checked = false;
               anchcheck.Checked = false;
               sdtcheck.Checked = false;
               spanichcheck.Checked = false;
               rgcheck.Checked = false;
               chickencheck.Checked = false;
               checkBox15.Checked = false;
               checkBox16.Checked = false;
               checkBox17.Checked = false;
               checkBox18.Checked = false;
               checkBox19.Checked = false;
               checkBox20.Checked = false;
               checkBox21.Checked = false;
               checkBox22.Checked = false;
               checkBox23.Checked = false;
               checkBox24.Checked = false;
               checkBox25.Checked = false;
               checkBox26.Checked = false;
               checkBox27.Checked = false;
               checkBox28.Checked = false;

               textBox1.Text = "";
               textBox2.Text = "";
               textBox3.Text = "";
               textBox4.Text = "";
               textBox5.Text = "";
               textBox6.Text = "";
               textBox7.Text = "";

               listView1.Items.Clear();
               textBox8.Text = "";
               textBox9.Text = "";
               textBox10.Text = "";

               textBox11.Text = "";
               textBox12.Text = "";
               textBox13.Text = "";
               textBox14.Text = "";
               textBox15.Text = "";
               textBox16.Text = "";
               textBox17.Text = "";
               textBox18.Text = "";
               textBox19.Text = "";
               textBox20.Text = "";
               //textBox21.Text = "";
               comboBox1.Text = "";
               comboBox2.Text = "";

               tabControl1.SelectTab("tabPage1");
           }

           else if(dialog == DialogResult.No)
           {
               this.Close();
           }
        
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 

