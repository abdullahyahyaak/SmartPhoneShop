using SmartPhoneShop.DataAcsessLayer.Concrete.EntityFramework;
using SmartPhoneShop.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPhoneShop.DataAcsessLayer.Concrete.ADONET;

namespace SmartPhoneShop.FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var smartphonemanager = new SmartPhoneManager(new AdoSmartPhoneDal());
            dataGridView1.DataSource = smartphonemanager.GetAll();
        }
    }
}
