namespace BF_Client
{
    public class ShowStorageIngredientList : ShowList<StorageIngredient, StorageIngredient>
    {
        public ShowStorageIngredientList(DataGridView dataGridView) : base(dataGridView, "/api/StorageIngredient") { }

        protected override StorageIngredient CreateNewElement() => new StorageIngredient();

        protected override string GetAddTitle() => "Ингридиент";
    }
}
