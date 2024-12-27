namespace BF_Client
{
    public abstract class ShowList<T, T_add> where T : class, ICloneable where T_add : new()
    {
        abstract protected string GetAddTitle();//Заголок окна, который будет открывать из него

        abstract protected T_add CreateNewElement();//Когда добавляется новый элемент. строка

        protected readonly List<T> _data = [];
        protected T dataSelected { get => _data[_dataGridView.SelectedRows[0].Index]; }//Вернуть выделенную строчку

        protected DataGridView? _dataGridView;

        protected string _restPrefix;
        
        protected ShowList(DataGridView dataGridView, string rest)
        {
            _dataGridView = dataGridView;
            _restPrefix = rest;
        }

        virtual public async void Load()
        {
            if (_dataGridView != null)
                _dataGridView.DataSource = null;

            List<T> res = await Rest.RestGet<List<T>>(_restPrefix);
            _data.Clear();
            _data.AddRange(res);
            if (_dataGridView != null)
            {
                _dataGridView.DataSource = _data;
                _dataGridView.Refresh();
            }            
        }

        virtual public async void Set()
        {
            DefaultProperyForm userForm = new();
            userForm.Text = GetAddTitle();
            
            T data = (T)_data[_dataGridView.SelectedRows[0].Index].Clone();
            userForm.Set(data);

            if (userForm.ShowDialog() == DialogResult.OK)
            {
                await Rest.RestPut<T>(_restPrefix + "/Set", data);
                Load();
            }
        }

        public async void Add()
        {
            DefaultProperyForm userForm = new();
            userForm.Text = GetAddTitle();

            T_add data = CreateNewElement();
            userForm.Set(data);
            
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                await Rest.RestPut<T_add>(_restPrefix + "/Add", data);
                Load();
            }
        }

        public async void Delete()
        {
            if (_dataGridView == null)
                return;

            if (_dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are your sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await Rest.RestPut<T>(_restPrefix + "/Delete", _data[_dataGridView.SelectedRows[0].Index]);
                    Load();
                }
            }
        }

        public async void Use()
        {
            if (_dataGridView == null)
                return;

            if (_dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are your sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool res = await Rest.RestPost<bool>(_restPrefix + "/Use", _data[_dataGridView.SelectedRows[0].Index]);
                    {
                        //todo Добавить инфомарцию о завершении действия
                    }

                }
            }
            return;
        }
    }
}
