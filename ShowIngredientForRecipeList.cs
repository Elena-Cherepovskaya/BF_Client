namespace BF_Client
{
    public class ShowIngredientForRecipeList : ShowList<IngredientForRecipe, IngredientForRecipe>
    {
        public ShowIngredientForRecipeList(DataGridView dataGridView) : base(dataGridView, "/api/IngredientForRecipe") { }

        protected override string GetAddTitle() => "Ингридиент";

        protected override IngredientForRecipe CreateNewElement() => new () { RecipeName = _recipe.Name };

        private Recipe _recipe;

        public void SetRecipe(Recipe recipe)
        {
            _recipe = recipe;
        }

        override public async void Load()
        {
            if (_dataGridView != null)
                _dataGridView.DataSource = null;

            List<IngredientForRecipe> res = await Rest.RestPost<List<IngredientForRecipe>>(_restPrefix, _recipe);

            _data.Clear();
            _data.AddRange(res);
            if (_dataGridView != null)
            {
                _dataGridView.DataSource = _data;
                _dataGridView.Refresh();
            }
        }
    }
}
