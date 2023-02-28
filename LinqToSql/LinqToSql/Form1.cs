namespace LinqToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            dataGridView1.DataSource = ctx.Products;
            cmbKategori.DataSource = ctx.Categories;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryID";
            cmbTedarikci.DataSource = ctx.Suppliers;
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "SupplierID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            Product urn = new Product();
            urn.ProductName=txtUrunAdi.Text;
            urn.UnitPrice = numFiyat.Value;
            urn.UnitsInStock = (short)numStok.Value;
            urn.CategoryID = (int)cmbKategori.SelectedValue;
            urn.SupplierID = (int)cmbTedarikci.SelectedValue;

            ctx.Products.InsertOnSubmit(urn);
            ctx.SubmitChanges();

            dataGridView1.DataSource=ctx.Products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productid =(int) dataGridView1.CurrentRow.Cells["ProductID"].Value;
            KuzeyYeliDataContext ctx =new KuzeyYeliDataContext();
            Product urn = ctx.Products.SingleOrDefault(urun =>urun.ProductID==productid);
            ctx.Products.DeleteOnSubmit(urn);
            ctx.SubmitChanges();
            dataGridView1.DataSource=ctx.Products;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView row = dataGridView1.CurrentRow;
            txtUrunAdi.Text = row.Cells["ProductName"].Value.ToString();
            txtUrunAdi.Tag = row.Cells["ProductID"].Value;
            cmbKategori.SelectedValue = row.Cells["CategoryID"].Value;
            cmbTedarikci.SelectedValue = row.Cells["SupplierId"].Value;
            numFiyat.Value = (decimal)row.Cells["UnitPrice"].Value;
            numStok.Value = (short)row.Cells["UnitsInStock"].Value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int urunid = (int)txtUrunAdi.Tag;
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            Product urn = ctx.Products.SingleOrDefault(urun => urun.ProductId == urunid);
            urn.ProductName = txtUrunAdi.Text;
            urn.UnitPrice=numFiyat.Value;
            urn.UnitsInStock=(short)numStok.Value;
            urn.SupplierID = (int)cmbTedarikci.SelectedValue;
            urn.CategoryID=(int)cmbKategori.SelectedValue;

            ctx.SubmitChanges();
            
            dataGridView1.DataSource = ctx.Products;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            dataGridView1.DataSource = ctx.Products.Where(x => x.ProductName.Contains(textBox1.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            if (rdbUrunAdi.Checked)
                dataGridView1.DataSource = ctx.Products.OrderBy(x => x.ProductName);
            else if (rdbStok.Checked)
                dataGridView1.DataSource = ctx.Products.OrderByDescending(x => x.UnitsInStock);
            else if (rdbFiyat.Checked)
                dataGridView1.DataSource = ctx.Products.OrderByDescending(x => x.UnitPrice);
        }
    }
}