
namespace A7_Shopping_List
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param listName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hej"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Listview",
            "Sub item",
            "mera"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstbxProducts = new System.Windows.Forms.ListBox();
            this.lstviewFavList = new System.Windows.Forms.ListView();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.txtAddProduct = new System.Windows.Forms.TextBox();
            this.btnNewShopList = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDeleteShopList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmboxUnits = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnShopList = new System.Windows.Forms.Button();
            this.btnEditFavList = new System.Windows.Forms.Button();
            this.btnDeleteFavList = new System.Windows.Forms.Button();
            this.txtNameList = new System.Windows.Forms.TextBox();
            this.lblNameList = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblShopList = new System.Windows.Forms.Label();
            this.lblFavouriteLists = new System.Windows.Forms.Label();
            this.btnSaveEditFavlist = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxProducts
            // 
            this.lstbxProducts.FormattingEnabled = true;
            this.lstbxProducts.HorizontalScrollbar = true;
            this.lstbxProducts.ItemHeight = 16;
            this.lstbxProducts.Location = new System.Drawing.Point(46, 96);
            this.lstbxProducts.Name = "lstbxProducts";
            this.lstbxProducts.Size = new System.Drawing.Size(288, 292);
            this.lstbxProducts.TabIndex = 0;
            this.lstbxProducts.SelectedIndexChanged += new System.EventHandler(this.lstbxProducts_SelectedIndexChanged);
            // 
            // lstviewFavList
            // 
            this.lstviewFavList.HideSelection = false;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            this.lstviewFavList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lstviewFavList.Location = new System.Drawing.Point(609, 96);
            this.lstviewFavList.Name = "lstviewFavList";
            this.lstviewFavList.Size = new System.Drawing.Size(333, 298);
            this.lstviewFavList.TabIndex = 1;
            this.lstviewFavList.UseCompatibleStateImageBehavior = false;
            
            this.lstviewFavList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstviewFavList_MouseDoubleClick);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Location = new System.Drawing.Point(387, 119);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(93, 17);
            this.lblAddProduct.TabIndex = 2;
            this.lblAddProduct.Text = " Add product ";
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Location = new System.Drawing.Point(362, 154);
            this.txtAddProduct.Multiline = true;
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(195, 84);
            this.txtAddProduct.TabIndex = 3;
            // 
            // btnNewShopList
            // 
            this.btnNewShopList.Location = new System.Drawing.Point(405, 25);
            this.btnNewShopList.Name = "btnNewShopList";
            this.btnNewShopList.Size = new System.Drawing.Size(106, 60);
            this.btnNewShopList.TabIndex = 4;
            this.btnNewShopList.Text = "Create New Shopping List";
            this.btnNewShopList.UseVisualStyleBackColor = true;
            this.btnNewShopList.Click += new System.EventHandler(this.btnNewShopList_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(46, 403);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 33);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDeleteShopList
            // 
            this.btnDeleteShopList.Location = new System.Drawing.Point(144, 403);
            this.btnDeleteShopList.Name = "btnDeleteShopList";
            this.btnDeleteShopList.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteShopList.TabIndex = 6;
            this.btnDeleteShopList.Text = "Delete";
            this.btnDeleteShopList.UseVisualStyleBackColor = true;
            this.btnDeleteShopList.Click += new System.EventHandler(this.btnDeleteShopList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(416, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmboxUnits
            // 
            this.cmboxUnits.FormattingEnabled = true;
            this.cmboxUnits.Location = new System.Drawing.Point(474, 346);
            this.cmboxUnits.Name = "cmboxUnits";
            this.cmboxUnits.Size = new System.Drawing.Size(83, 24);
            this.cmboxUnits.TabIndex = 8;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(494, 323);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 17);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Unit";
            // 
            // btnShopList
            // 
            this.btnShopList.Location = new System.Drawing.Point(239, 403);
            this.btnShopList.Name = "btnShopList";
            this.btnShopList.Size = new System.Drawing.Size(75, 33);
            this.btnShopList.TabIndex = 10;
            this.btnShopList.Text = "Save";
            this.btnShopList.UseVisualStyleBackColor = true;
            this.btnShopList.Click += new System.EventHandler(this.btnSaveShopList_Click);
            // 
            // btnEditFavList
            // 
            this.btnEditFavList.Location = new System.Drawing.Point(636, 412);
            this.btnEditFavList.Name = "btnEditFavList";
            this.btnEditFavList.Size = new System.Drawing.Size(75, 33);
            this.btnEditFavList.TabIndex = 11;
            this.btnEditFavList.Text = "Edit";
            this.btnEditFavList.UseVisualStyleBackColor = true;
            this.btnEditFavList.Click += new System.EventHandler(this.btnEditFavList_Click);
            // 
            // btnDeleteFavList
            // 
            this.btnDeleteFavList.Location = new System.Drawing.Point(748, 412);
            this.btnDeleteFavList.Name = "btnDeleteFavList";
            this.btnDeleteFavList.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteFavList.TabIndex = 12;
            this.btnDeleteFavList.Text = "Delete";
            this.btnDeleteFavList.UseVisualStyleBackColor = true;
            this.btnDeleteFavList.Click += new System.EventHandler(this.btnDeleteFavList_Click);
            // 
            // txtNameList
            // 
            this.txtNameList.Location = new System.Drawing.Point(214, 28);
            this.txtNameList.Name = "txtNameList";
            this.txtNameList.Size = new System.Drawing.Size(100, 22);
            this.txtNameList.TabIndex = 13;
            // 
            // lblNameList
            // 
            this.lblNameList.AutoSize = true;
            this.lblNameList.Location = new System.Drawing.Point(105, 31);
            this.lblNameList.Name = "lblNameList";
            this.lblNameList.Size = new System.Drawing.Size(82, 17);
            this.lblNameList.TabIndex = 14;
            this.lblNameList.Text = "Name of list";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(471, 386);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Amount";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(387, 384);
            this.numUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(63, 22);
            this.numUpDown.TabIndex = 18;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(554, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 36);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(387, 322);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(362, 346);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1032, 30);
            this.MainMenu.TabIndex = 22;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.BackColor = System.Drawing.SystemColors.Control;
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.MenuFileSave,
            this.MenuFileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(46, 26);
            this.MenuFile.Text = "File";
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.Name = "MenuFileNew";
            this.MenuFileNew.Size = new System.Drawing.Size(224, 26);
            this.MenuFileNew.Text = "New";
            this.MenuFileNew.Click += new System.EventHandler(this.MenuFileNew_Click);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.MenuFileOpen.Text = "Open";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.Size = new System.Drawing.Size(224, 26);
            this.MenuFileSave.Text = "Save";
            this.MenuFileSave.Click += new System.EventHandler(this.MenuFileSave_Click);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(224, 26);
            this.MenuFileExit.Text = "Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(55, 26);
            this.MenuHelp.Text = "Help";
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(224, 26);
            this.MenuHelpAbout.Text = "About";
            this.MenuHelpAbout.Click += new System.EventHandler(this.MenuHelpAbout_Click);
            // 
            // lblShopList
            // 
            this.lblShopList.AutoSize = true;
            this.lblShopList.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopList.ForeColor = System.Drawing.Color.Red;
            this.lblShopList.Location = new System.Drawing.Point(41, 56);
            this.lblShopList.Name = "lblShopList";
            this.lblShopList.Size = new System.Drawing.Size(167, 29);
            this.lblShopList.TabIndex = 23;
            this.lblShopList.Text = "Shopping list";
            // 
            // lblFavouriteLists
            // 
            this.lblFavouriteLists.AutoSize = true;
            this.lblFavouriteLists.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavouriteLists.ForeColor = System.Drawing.Color.Red;
            this.lblFavouriteLists.Location = new System.Drawing.Point(668, 56);
            this.lblFavouriteLists.Name = "lblFavouriteLists";
            this.lblFavouriteLists.Size = new System.Drawing.Size(178, 29);
            this.lblFavouriteLists.TabIndex = 24;
            this.lblFavouriteLists.Text = "Favourite lists\r\n";
            // 
            // btnSaveEditFavlist
            // 
            this.btnSaveEditFavlist.Location = new System.Drawing.Point(855, 412);
            this.btnSaveEditFavlist.Name = "btnSaveEditFavlist";
            this.btnSaveEditFavlist.Size = new System.Drawing.Size(75, 33);
            this.btnSaveEditFavlist.TabIndex = 25;
            this.btnSaveEditFavlist.Text = "Save edit";
            this.btnSaveEditFavlist.UseVisualStyleBackColor = true;
            this.btnSaveEditFavlist.Click += new System.EventHandler(this.btnSaveEditFavlist_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 471);
            this.Controls.Add(this.btnSaveEditFavlist);
            this.Controls.Add(this.lblFavouriteLists);
            this.Controls.Add(this.lblShopList);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNameList);
            this.Controls.Add(this.txtNameList);
            this.Controls.Add(this.btnDeleteFavList);
            this.Controls.Add(this.btnEditFavList);
            this.Controls.Add(this.btnShopList);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.cmboxUnits);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteShopList);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnNewShopList);
            this.Controls.Add(this.txtAddProduct);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.lstviewFavList);
            this.Controls.Add(this.lstbxProducts);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Shopping list - Project by Mikael Anttila-Eriksson";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxProducts;
        private System.Windows.Forms.ListView lstviewFavList;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.TextBox txtAddProduct;
        private System.Windows.Forms.Button btnNewShopList;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDeleteShopList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmboxUnits;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnShopList;
        private System.Windows.Forms.Button btnEditFavList;
        private System.Windows.Forms.Button btnDeleteFavList;
        private System.Windows.Forms.TextBox txtNameList;
        private System.Windows.Forms.Label lblNameList;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuFileNew;
        private System.Windows.Forms.Label lblShopList;
        private System.Windows.Forms.Label lblFavouriteLists;
        private System.Windows.Forms.Button btnSaveEditFavlist;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

