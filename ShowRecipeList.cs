namespace BF_Client
{
    public class ShowRecipeList : ShowList<Recipe, Recipe>
    {
        public ShowRecipeList(DataGridView dataGridView) : base(dataGridView, "/api/Recipe") { }

        protected override string GetAddTitle() => "Рецепт";

        protected override Recipe CreateNewElement() => new();

        override public void Set()
        {
            DefaultListForm form = new();
            form.Text = "Список ингридиентов";

            ShowIngredientForRecipeList list = new(form.GetDataGridView());
            list.SetRecipe(this.dataSelected);

            form.DoLoadData += list.Load;
            form.DoSetData += list.Set;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;

            form.ShowDialog();            
        }

    }
}
