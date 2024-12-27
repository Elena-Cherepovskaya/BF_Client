namespace BF_Client
{
    public partial class BF_Client : System.Windows.Forms.Form
    {
        private User _user;

        public BF_Client()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BF_Client_Load(object sender, EventArgs e)
        {
            LoginForm form = new();
            form.ShowDialog();
            _user = form.GetUser();
            if (_user != null)
                UpdateRules();
        }

        private void UpdateRules()
        {
            usersToolStripMenuItem.Enabled = false;
            guideToolStripMenuItem.Enabled = false;
            storageToolStripMenuItem.Enabled = false;

            switch (_user.Rule)
            {
                case Rule.Admin:
                    usersToolStripMenuItem.Enabled = true;
                    guideToolStripMenuItem.Enabled = true;
                    storageToolStripMenuItem.Enabled = true;
                    break;

                case Rule.Client:
                    break;

                case Rule.Edit:
                    guideToolStripMenuItem.Enabled = true;
                    storageToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            ShowUserList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void IngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Справочник ингридиентов";

            ShowIngredientList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void StorageIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Склад ингридиентов";

            ShowStorageIngredientList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoSetData += list.Set;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Справочник продуции";

            ShowProductList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void StorageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Склад готовой продукции";

            ShowStorageProductList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoSetData += list.Set;
            form.DoAddData += list.Add;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void RecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Рецепты";

            ShowRecipeList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoAddData += list.Add;
            form.DoSetData += list.Set;
            form.DoDeleteData += list.Delete;
            form.ShowDialog();
        }

        private void UseRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultListForm form = new();
            form.Text = "Рецепты";

            ShowRecipeList list = new(form.GetDataGridView());
            form.DoLoadData += list.Load;
            form.DoUseData += list.Use;
            form.ShowDialog();
        }
    }
}
