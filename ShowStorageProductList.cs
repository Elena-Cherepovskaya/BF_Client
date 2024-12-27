namespace BF_Client
{
    public class ShowStorageProductList : ShowList<StorageProduct, StorageProduct>
    {
        public ShowStorageProductList(DataGridView dataGridView) : base(dataGridView, "/api/StorageProduct") { }

        protected override StorageProduct CreateNewElement() => new StorageProduct();
 
        protected override string GetAddTitle() => "Продукция";
    }
}
