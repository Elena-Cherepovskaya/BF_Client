namespace BF_Client
{
    partial class DefaultProperyForm
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
            propertyGrid = new PropertyGrid();
            buttonOk = new Button();
            buttonCamcel = new Button();
            SuspendLayout();
            // 
            // propertyGrid
            // 
            propertyGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propertyGrid.Location = new Point(12, 12);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.PropertySort = PropertySort.NoSort;
            propertyGrid.Size = new Size(776, 509);
            propertyGrid.TabIndex = 0;
            propertyGrid.ToolbarVisible = false;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(558, 527);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCamcel
            // 
            buttonCamcel.DialogResult = DialogResult.Cancel;
            buttonCamcel.Location = new Point(676, 527);
            buttonCamcel.Name = "buttonCamcel";
            buttonCamcel.Size = new Size(112, 34);
            buttonCamcel.TabIndex = 2;
            buttonCamcel.Text = "Cancel";
            buttonCamcel.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(buttonCamcel);
            Controls.Add(buttonOk);
            Controls.Add(propertyGrid);
            Name = "UserForm";
            Text = "Параметры";
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid;
        private Button buttonOk;
        private Button buttonCamcel;
    }
}