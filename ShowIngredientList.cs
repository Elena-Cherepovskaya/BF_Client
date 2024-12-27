namespace BF_Client
{
    public class ShowIngredientList : ShowList<Ingredient, Ingredient>
    {

        public ShowIngredientList(DataGridView dataGridView) : base(dataGridView, "/api/Ingredient") { }

        protected override Ingredient CreateNewElement() => new Ingredient();

        protected override string GetAddTitle() => "Ингредиент";
    }
}
