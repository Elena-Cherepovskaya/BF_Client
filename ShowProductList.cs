namespace BF_Client
{
    public class ShowProductList : ShowList<Product, Product>
    {
        public ShowProductList(DataGridView dataGridView) : base(dataGridView, "/api/Product") { }

        protected override Product CreateNewElement() => new Product();

        protected override string GetAddTitle() => "Продукт";
    }
}
