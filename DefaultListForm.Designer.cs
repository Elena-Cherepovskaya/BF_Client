namespace BF_Client
{
    partial class DefaultListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            userBindingSource = new BindingSource(components);
            buttonDelect = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonUse = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.Location = new Point(12, 12);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(776, 386);
            dataGridView.TabIndex = 1;
            dataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // buttonDelect
            // 
            buttonDelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelect.Location = new Point(638, 404);
            buttonDelect.Name = "buttonDelect";
            buttonDelect.Size = new Size(150, 34);
            buttonDelect.TabIndex = 2;
            buttonDelect.Text = "Удалить";
            buttonDelect.UseVisualStyleBackColor = true;
            buttonDelect.Click += ButtonDelect_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(326, 404);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 34);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEdit.Location = new Point(482, 404);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 34);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonUse
            // 
            buttonUse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUse.Location = new Point(12, 404);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(150, 34);
            buttonUse.TabIndex = 5;
            buttonUse.Text = "Использовать";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += ButtonUse_Click;
            // 
            // DefaultListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUse);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelect);
            Controls.Add(dataGridView);
            Name = "DefaultListForm";
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Button buttonDelect;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonUse;
    }
}