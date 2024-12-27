using System.Runtime.CompilerServices;

namespace BF_Client
{
    public partial class DefaultListForm : Form
    {
        public DefaultListForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        public Action DoLoadData;
        public Action DoUseData;
        public Action DoSetData;
        public Action DoAddData;
        public Action DoDeleteData;

        public DataGridView GetDataGridView() => dataGridView;


        private void OnLoad(object sender, EventArgs e)
        {
            buttonEdit.Enabled = (DoSetData != null);
            buttonAdd.Enabled = (DoAddData != null);
            buttonDelect.Enabled = (DoDeleteData != null);
            if (DoUseData == null)
                buttonUse.Hide();
            DoLoadData?.Invoke();
        }

        private void EditSelectItem(object sender, EventArgs e)
        {
            DoSetData?.Invoke();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectItem(sender, e);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            DoAddData?.Invoke();
        }

        private void ButtonDelect_Click(object sender, EventArgs e)
        {
            DoDeleteData?.Invoke();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditSelectItem(sender, e);
        }

        private void ButtonUse_Click(object sender, EventArgs e)
        {
            DoUseData?.Invoke();
        }
    }
}
