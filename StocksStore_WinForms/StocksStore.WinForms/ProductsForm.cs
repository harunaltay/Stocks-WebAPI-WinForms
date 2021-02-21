using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using StocksStore.WinForms.Models;

// TODO: ComboBox 'lar işlenmesi lazım! Elle giriş yasaklanması lazım. Açılışta otomatik set ediliyor mu, kontrol edilmesi lazım.


namespace StocksStore.WinForms
{
    public partial class ProductsForm : Form
    {
        private HttpClient client = new HttpClient(); 
        
        public ProductsForm()
        {
            client.BaseAddress = new Uri("https://localhost:44335/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        private async void ProductsForm_Load(object sender, EventArgs e)
        {
            await Load_the_comboBox_Category();
            await Load_the_comboBox_Supplier();

            await List();
        }

        private async Task Load_the_comboBox_Category()
        {
            HttpResponseMessage httpResponse = await client.GetAsync("api/Categories");
            httpResponse.EnsureSuccessStatusCode();

            var stringValue = await httpResponse.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<Category>>(stringValue);
            comboBox_Category.DataSource = categories;
            comboBox_Category.DisplayMember = "CategoryName";
            comboBox_Category.ValueMember = "CategoryID";
        }

        private async Task Load_the_comboBox_Supplier()
        {
            HttpResponseMessage httpResponse = await client.GetAsync("api/Suppliers");
            httpResponse.EnsureSuccessStatusCode();

            var stringValue = await httpResponse.Content.ReadAsStringAsync();
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(stringValue);
            comboBox_Supplier.DataSource = suppliers;
            comboBox_Supplier.DisplayMember = "SupplierName";
            comboBox_Supplier.ValueMember = "SupplierID";
        }

        private async Task List()
        {
            HttpResponseMessage httpResponse = await client.GetAsync("api/Products");
            httpResponse.EnsureSuccessStatusCode();

            var stringValue = await httpResponse.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(stringValue);
            dataGridView_Products.DataSource = products;
            
            // ?
            //comboBox_Category.DisplayMember = "CategoryName";
            //comboBox_Category.ValueMember = "CategoryID";

            //comboBox_Supplier.DisplayMember = "SupplierName";
            //comboBox_Supplier.ValueMember = "SupplierID";
        }

        private async void btn_Insert_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = Convert.ToInt32(textBox_ProductID.Text),
                ProductName = textBox_ProductName.Text,
                UnitPrice = decimal.Parse(textBox_UnitPrice.Text),
                CategoryID = Convert.ToInt32(comboBox_Category.SelectedValue),
                SupplierID = Convert.ToInt32(comboBox_Supplier.SelectedValue)
                //CategoryID = Convert.ToInt32(comboBox_Category.Text),
                //SupplierID = Convert.ToInt32(comboBox_Supplier.Text)
            };

            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await client.PostAsync("api/Products", data);
            httpResponse.EnsureSuccessStatusCode();

            await List();
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = Convert.ToInt32(textBox_ProductID.Text),
                ProductName = textBox_ProductName.Text,
                UnitPrice = decimal.Parse(textBox_UnitPrice.Text),
                CategoryID = Convert.ToInt32(comboBox_Category.SelectedValue),
                SupplierID = Convert.ToInt32(comboBox_Supplier.SelectedValue)
                //CategoryID = Convert.ToInt32(comboBox_Category.Text),
                //SupplierID = Convert.ToInt32(comboBox_Supplier.Text)
            };

            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponse = await client.PostAsync($"api/Products/{product.ProductID}", data);
            httpResponse.EnsureSuccessStatusCode();

            await List();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            HttpResponseMessage httpResponse =
                await client.DeleteAsync($"api/Products/{Convert.ToInt32(textBox_ProductID.Text)}");
            MessageBox.Show(httpResponse.StatusCode.ToString());

            await List();
        }

        private void btn_ClearForm_Click(object sender, EventArgs e)
        {
            textBox_ProductID.Text = "";
            textBox_ProductName.Text = "";
            textBox_UnitPrice.Text = "";
            comboBox_Category.Text = "";
            comboBox_Supplier.Text = "";
        }

        private void dataGridView_Products_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ProductID.Text = dataGridView_Products.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
            textBox_ProductName.Text = dataGridView_Products.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            textBox_UnitPrice.Text = dataGridView_Products.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            comboBox_Category.Text = dataGridView_Products.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
            comboBox_Supplier.Text = dataGridView_Products.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
        }
    }
}
