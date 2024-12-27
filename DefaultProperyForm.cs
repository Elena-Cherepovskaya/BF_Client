namespace BF_Client
{
    public partial class DefaultProperyForm : Form
    {
        public DefaultProperyForm()
        {
            InitializeComponent();
        }

        public void Set(object value)
        {
            propertyGrid.SelectedObject = value;
        }
    }
}
