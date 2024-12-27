namespace BF_Client
{
    partial class BF_Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            UseRecipeToolStripMenuItem = new ToolStripMenuItem();
            guideToolStripMenuItem = new ToolStripMenuItem();
            IngredientToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            recipeToolStripMenuItem = new ToolStripMenuItem();
            storageToolStripMenuItem = new ToolStripMenuItem();
            storageIngredientToolStripMenuItem = new ToolStripMenuItem();
            storageProductToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(24, 24);
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, guideToolStripMenuItem, storageToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 33);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, toolStripSeparator1, UseRecipeToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(69, 29);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Enabled = false;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(234, 34);
            usersToolStripMenuItem.Text = "Пользователи";
            usersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(234, 34);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // UseRecipeToolStripMenuItem
            // 
            UseRecipeToolStripMenuItem.Name = "UseRecipeToolStripMenuItem";
            UseRecipeToolStripMenuItem.Size = new Size(234, 34);
            UseRecipeToolStripMenuItem.Text = "Производство";
            UseRecipeToolStripMenuItem.Click += UseRecipeToolStripMenuItem_Click;
            // 
            // guideToolStripMenuItem
            // 
            guideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { IngredientToolStripMenuItem, productToolStripMenuItem, recipeToolStripMenuItem });
            guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            guideToolStripMenuItem.Size = new Size(139, 29);
            guideToolStripMenuItem.Text = "Справочники";
            // 
            // IngredientToolStripMenuItem
            // 
            IngredientToolStripMenuItem.Name = "IngredientToolStripMenuItem";
            IngredientToolStripMenuItem.Size = new Size(223, 34);
            IngredientToolStripMenuItem.Text = "Ингредиенты";
            IngredientToolStripMenuItem.Click += IngredientToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(223, 34);
            productToolStripMenuItem.Text = "Продукция";
            productToolStripMenuItem.Click += ProductToolStripMenuItem_Click;
            // 
            // recipeToolStripMenuItem
            // 
            recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            recipeToolStripMenuItem.Size = new Size(223, 34);
            recipeToolStripMenuItem.Text = "Рецепты";
            recipeToolStripMenuItem.Click += RecipeToolStripMenuItem_Click;
            // 
            // storageToolStripMenuItem
            // 
            storageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storageIngredientToolStripMenuItem, storageProductToolStripMenuItem });
            storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            storageToolStripMenuItem.Size = new Size(89, 29);
            storageToolStripMenuItem.Text = "Склады";
            // 
            // storageIngredientToolStripMenuItem
            // 
            storageIngredientToolStripMenuItem.Name = "storageIngredientToolStripMenuItem";
            storageIngredientToolStripMenuItem.Size = new Size(223, 34);
            storageIngredientToolStripMenuItem.Text = "Ингредиенты";
            storageIngredientToolStripMenuItem.Click += StorageIngredientToolStripMenuItem_Click;
            // 
            // storageProductToolStripMenuItem
            // 
            storageProductToolStripMenuItem.Name = "storageProductToolStripMenuItem";
            storageProductToolStripMenuItem.Size = new Size(223, 34);
            storageProductToolStripMenuItem.Text = "Продукция";
            storageProductToolStripMenuItem.Click += StorageProductToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(231, 6);
            // 
            // BF_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "BF_Client";
            Text = "BF_Client";
            Load += BF_Client_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem guideToolStripMenuItem;
        private ToolStripMenuItem IngredientToolStripMenuItem;
        private ToolStripMenuItem storageIngredientToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem storageToolStripMenuItem;
        private ToolStripMenuItem storageProductToolStripMenuItem;
        private ToolStripMenuItem recipeToolStripMenuItem;
        private ToolStripMenuItem UseRecipeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}
