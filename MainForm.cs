using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A7_Shopping_List
{
    /// <summary>
    /// This is a windows Form that help the user plan / create a shopping list
    /// The user can add products and decide how much and how many they want.
    /// Additional functionality are the pre-made Favourite lists that the user can look at and pick(double click)
    /// items from. The Favourite lists are editable and the user can create new ones.
    /// The shopping list can be saved to/opened from, a text file
    /// </summary>
        public partial class MainForm : Form
    {
        private const string path = @"C:\Users\Micke\Documents\Universitet\Malmö\C# Projcets\Module 6\" +
            @"OpenSaveDialog\Resources\bitBild.bmp";
        //Current Shopping List
        private ProductManager currShopList;
        //Store currShopList during edit of favList
        private ProductManager storecurrShopList;
        //Declare a Favourite list
        private FavouriteLists favLists;
        //One default file to save a shop list to
        private string fileName = Application.StartupPath + "\\ShopList.txt";

        //Listview 
        //Mode
        //showFavlist. Lable : true --> Show Favourite lists | false --> Show products of a Favourite list
        private bool showFavLists;
        //Store selected index
        private int indexFavList;
        //Listbox
        //Mode
        //editFavList. Lable : true --> Edit <Favlist.listName> | false --> Shopping list
        private bool editFavlist;
        //editcurrList
        private bool editcurrShopList;
        //Store selected index
        private int indexProductList;

        //---------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            
        }
        /// <summary>
        /// Initiate the forms GUI at start up and when called to reset the program
        /// </summary>
        private void InitializeGUI()
        {
            //Ready combobox    ***********************************************
            // Alt 1
            //cmboxUnits.DataSource = Enum.GetValues(typeof(Units));    ******
            // Alt 2
            cmboxUnits.Items.AddRange(Enum.GetNames(typeof(Units)));

            //Set default values  ************************************
            SetDefault();

            //Set Tooltips *************************************
            Tooltips();

            //ready listview    ************************************
            lstviewFavList.Items.Clear();
            //set view style to list
            lstviewFavList.View = System.Windows.Forms.View.List;
            //Set Listview to show Favourite lists
            showFavLists = true;
            //Set to not editing Favlist
            editFavlist = false;
            //Initiate stored index
            indexFavList = -1;

            //Ready ListBox     ************************************
            lstbxProducts.Items.Clear();
            //Initiate stored index
            indexProductList = -1;

            //Initiate the lists ***********************************
            //Initiate the favLists
            favLists = new FavouriteLists();

            //Create Favourite list
            MakeFavLists();
            //Set new current product list
            ResetcurrShopList();

            //Test methods and the like **************************************
            //CreateMyListView();
            //TestProducts();


        }
        //---------------------------------------------------------------
        #region Test for code developing
        private void TestProducts()
        {
            string vara = "En vara";
            Product tryout = new Product(vara);
            string varor = "Köttbullar";
            int antal = 2;
            double storlek = 400;
            string note = "In i \nkylskåpet snabbt";        //comment
            Units u = Units.gram;
            Product längre = new Product(varor, antal, storlek, u);
            string pro = "Falafelsås med flaflaflar";
            Units vikt = Units.hg;
            Product pro3 = new Product(pro, antal, storlek, vikt);

            //currShopList.AddProduct(tryout);
            //currShopList.AddProduct(längre);
            //currShopList.AddProduct(pro3);
            //UpdateShopList();

        }
        
        private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            Image im = Properties.Resources.bitBild;
            imageListSmall.Images.Add(im);
            imageListSmall.Images.Add(Properties.Resources.bitBild);
            imageListLarge.Images.Add(im);
            imageListLarge.Images.Add(im);
            //imageListLarge.Images.Add(Bitmap.FromFile.Icon

                //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
            listView1.View = View.LargeIcon;
            listView1.View = View.Details;

            //        ********************************

            //Test
            //lstviewFavList.Columns.Add("my column", -2, HorizontalAlignment.Left);
            //lstviewFavList.FullRowSelect = true;
            //lstviewFavList.GridLines = true;
            //lstviewFavList.View = System.Windows.Forms.View.List;
            //lstviewFavList.Items.Add("hej");

            

        }
        #endregion
        //---------------------------------------------------------------
        /// <summary>
        /// Makes some Favourite lists. Fika, Mejeri, Grönsaker, Torrvaror and Övrigt
        /// </summary>
        private void MakeFavLists()
        {

            //Create a product list
            Product p1 = new Product("Saft");

            currShopList = new ProductManager("Fika");
            currShopList.AddProduct(p1);
            currShopList.AddProduct(new Product("Kaffe"));
            currShopList.AddProduct(new Product("Te"));
            currShopList.AddProduct(new Product("Fikabröd"));
            currShopList.AddProduct(new Product("Kakor"));
            //Save list to favLists
            favLists.AddProductList(currShopList);

            //Create list Mejeri
            currShopList = new ProductManager("Mejeri");
            //Add products
            currShopList.AddProduct(new Product("Mjölk"));
            currShopList.AddProduct(new Product("Grädde"));
            currShopList.AddProduct(new Product("Creame´ fraich"));
            currShopList.AddProduct(new Product("Kvarg"));
            currShopList.AddProduct(new Product("Smör"));
            currShopList.AddProduct(new Product("Yoghurt"));
            currShopList.AddProduct(new Product("Fil"));
            currShopList.AddProduct(new Product("Hällsmör"));
            currShopList.AddProduct(new Product("Ägg"));
            currShopList.AddProduct(new Product("Ost"));
            currShopList.AddProduct(new Product("Fetaost"));
            //Save list
            favLists.AddProductList(currShopList);

            //Create list Grönsaker
            currShopList = new ProductManager("Grönsaker");
            //Add products
            currShopList.AddProduct(new Product("Tomat"));
            currShopList.AddProduct(new Product("Gurka"));
            currShopList.AddProduct(new Product("Paprika"));
            currShopList.AddProduct(new Product("Grönkol"));
            currShopList.AddProduct(new Product("Sallad"));
            currShopList.AddProduct(new Product("Citron"));
            currShopList.AddProduct(new Product("Lime"));
            currShopList.AddProduct(new Product("Morot"));
            currShopList.AddProduct(new Product("Palsternacka"));
            currShopList.AddProduct(new Product("Kålrot"));
            currShopList.AddProduct(new Product("Selleri"));
            currShopList.AddProduct(new Product("Zucchini/Aubergine"));
            currShopList.AddProduct(new Product("Ingefära"));
            currShopList.AddProduct(new Product("Vitlök"));
            currShopList.AddProduct(new Product("Gul lök"));
            currShopList.AddProduct(new Product("Purjolök"));
            currShopList.AddProduct(new Product("Salladslök"));
            currShopList.AddProduct(new Product("Svamp"));
            currShopList.AddProduct(new Product("Avokado"));
            //Sava list
            favLists.AddProductList(currShopList);

            //Create list Torrvaror
            currShopList = new ProductManager("Torrvaror");
            //Add products
            currShopList.AddProduct(new Product("Pasta"));
            currShopList.AddProduct(new Product("Ris"));
            currShopList.AddProduct(new Product("Bulgur"));
            currShopList.AddProduct(new Product("Linser"));
            currShopList.AddProduct(new Product("Bönor"));
            currShopList.AddProduct(new Product("Potatis"));
            currShopList.AddProduct(new Product("Nötter"));
            currShopList.AddProduct(new Product("Bröd"));
            currShopList.AddProduct(new Product("Flingor"));
            currShopList.AddProduct(new Product("Mjöl"));
            //Sava list
            favLists.AddProductList(currShopList);


            //Create list Övrigt
            currShopList = new ProductManager("Övrigt");
            //Add products
            currShopList.AddProduct(new Product("Tvål"));
            currShopList.AddProduct(new Product("Schampo"));
            currShopList.AddProduct(new Product("Balsam"));
            currShopList.AddProduct(new Product("Tandborste"));
            currShopList.AddProduct(new Product("Tandkräm"));
            currShopList.AddProduct(new Product("Diskmedel"));
            currShopList.AddProduct(new Product("Diskmaskinstabletter"));
            currShopList.AddProduct(new Product("Hushållspapper"));
            currShopList.AddProduct(new Product("Toapapper"));
            currShopList.AddProduct(new Product("Diskborste"));
            //Sava list
            favLists.AddProductList(currShopList);

            // ++++ Write on listview ++++
            
            //Load data
            UpdateFavLists();



        }
        //---------------------------------------------------------------
        #region Properties // None
        #endregion
        //---------------------------------------------------------------
        #region Methods
        // **************************************************************** 
        #region General 
        /// <summary>
        /// Set default values in txtboxes, combobox and numUpAndDown
        /// </summary>
        private void SetDefault()
        {
            txtAddProduct.Text = string.Empty;
            txtNameList.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cmboxUnits.SelectedIndex = (int)Units.Select;
            numUpDown.Value = 1;
            
        }
        /// <summary>
        /// Reset currShopList to empty product list
        /// </summary>
        private void ResetcurrShopList()
        {
            currShopList = new ProductManager();
        }
        /// <summary>
        /// Change top right title depending on showFavlists mode
        /// </summary>
        private void ChangeFavlistLable()
        {
            if (showFavLists)
            {
                lblFavouriteLists.Text = "Favourite Lists";
            }
            else
            {
                lblFavouriteLists.Text = "Products to choose";
            }

            
        }
        /// <summary>
        /// Change top left title debending on editFavlist mode
        /// </summary>
        /// <param name="index"></param>
        private void LableEditFavList(int index)
        {
            if (editFavlist)
            {
                lblShopList.Text = "Edit " + favLists.GetProductList(index).ListName;
            }
            else
            {
                lblShopList.Text = "Shopping list";
            }
        }
        /// <summary>
        /// Contains all tooltips of this application
        /// </summary>
        private void Tooltips()
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtNameList, "Write name of list when saving to Favourite lists");
            string tip = "Write product you want to add to the shopping list";
            toolTip1.SetToolTip(txtAddProduct, tip);
            tip = "How much you want off the product";
            toolTip1.SetToolTip(txtQuantity, tip);
            tip = "Set how many you want of selected product";
            toolTip1.SetToolTip(numUpDown, tip);
            tip = "Select unit, ex kg or liter";
            toolTip1.SetToolTip(cmboxUnits, tip);
            tip = "Select product and change information, then press to save changes";
            toolTip1.SetToolTip(btnChange, tip);
            tip = "Delete selected product";
            toolTip1.SetToolTip(btnDeleteShopList, tip);
            tip = "Save current shopping list to your Favourite list, remember to give it a name";
            toolTip1.SetToolTip(btnShopList, tip);
            tip = "Start with a new shopping list, the old one gets deleted";
            toolTip1.SetToolTip(btnNewShopList, tip);
            tip = "Create your shopping list here";
            toolTip1.SetToolTip(lstbxProducts, tip);
            tip = "Inspect your Favourite lists here";
            toolTip1.SetToolTip(lblFavouriteLists, tip);
            tip = "Click to open your Favourite lists. Double click on an item to add it to the shopping list";
            toolTip1.SetToolTip(lstviewFavList, tip);
            tip = "Move back to view your lists";
            toolTip1.SetToolTip(btnBack, tip);
            tip = "Edit selected list in the left window. Save list by clicking 'Save Edit' button";
            toolTip1.SetToolTip(btnEditFavList, tip);
            tip = "Delete selected list";
            toolTip1.SetToolTip(btnDeleteFavList, tip);
            tip = "Save your edited Favourite list";
            toolTip1.SetToolTip(btnSaveEditFavlist, tip);
            //toolTip1.SetToolTip(, tip);
        }
        /// <summary>
        /// if products inputs are valid,  read input to Product: name, amount, quantity and unit
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>
        /// true if products inputs are valid
        /// </returns>
        private bool ReadInputShopList(Product Product)        //Forts byta till bool ist för Product
        {
            bool inputOK = false;
            inputOK = validateInput();
            //Read values if unput is ok
            if (inputOK)
            {
               
                //Read: Name, Amount, Quantity and Unit
                Product.Name = txtAddProduct.Text;

                //Only read values if they are changed from default values!
               
                //Read if txtQuantity is not empty
                if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    Product.Quantity = double.Parse(txtQuantity.Text);
                    
                }

                //Read if a Unit is selected i.e. not Units.Select
                if (!cmboxUnits.SelectedIndex.Equals(Units.Select))
                {
                    Product.Unit = (Units)cmboxUnits.SelectedIndex;
                }
            }

            return inputOK; 

        }
        
        /// <summary>
        /// Check that product has a name; if quantity is filled in, it is a number > 0 and amount > 0
        /// </summary>
        /// <returns>
        /// true if all correct
        /// </returns>
        private bool validateInput()
        {
            bool ok = false;
            //Check name
            ok = string.IsNullOrWhiteSpace(txtAddProduct.Text);
            if (ok)
            {
                MessageBox.Show("Give product a name", "Error");
                return false;
            }
            //Only check txtQuantity if it is written
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                //Check txtQuantity has a valid number (double)
                ok = double.TryParse(txtQuantity.Text, out double number);
                if (!ok || number <= 0)
                {
                    MessageBox.Show("Quantity must be a number and over zero", "Error");
                    return false;
                }
            }
              
            //Check amount
            ok = numUpDown.Value > 0;
            if (!ok)
            {
                MessageBox.Show("Amount must be over zero", "Error");
                return false;
            }
            return ok;
        }
        
        /// <summary>
        /// Show notification if selected object was deleted or not
        /// </summary>
        /// <param name="deleted"></param>
        private void Notify(bool deleted)
        {
            if (deleted)
            {
                MessageBox.Show("Delete complited", "Confirmation");
            }
            else
            {
                MessageBox.Show("Failed to delet object", "Error");
            }
            
        }
        #endregion End General
        // ****************************************************************
        #region Listbox
        /// <summary>
        /// Get selected index in lstbxProducts
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// true and index, if item selected
        /// </returns>
        private bool GetSelectedIndexList(out int index)
        {
            index = lstbxProducts.SelectedIndex;
            if (lstbxProducts.SelectedIndex >= 0)
            {
                return true;        //Item selected
            }
            else
            {
                MessageBox.Show("Select item first", "Error");
            }
            return false;
        }

        //      ++++++
        #region Listbox events
        /// <summary>
        /// Make a new shop list and remove the old one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewShopList_Click(object sender, EventArgs e)
        {
            ResetcurrShopList();
            SetDefault();
            UpdateShopList();
        }
        /// <summary>
        /// Make validation of inputs and add the product to the shopping list if passed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)   
        {
            //create a new product
            Product newProduct = new Product();
            //add to list if input values are ok
            if (ReadInputShopList(newProduct))
            {
                
                //Add product
                currShopList.AddProduct(newProduct);
                SetDefault();
                UpdateShopList();
            }
            
        }
        /// <summary>
        /// Make changes to selected product if inputs are correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //Get index
            if (GetSelectedIndexList(out int index))
            {
                
                
                //Read input to edited
                Product edited = new Product();
                // if input correct
                if (ReadInputShopList(edited))
                {
                    currShopList.EditProduct(indexProductList, edited);

                    //Reset settings and update the  list
                    SetDefault();
                    UpdateShopList();
                }

            }

        }
        
        /// <summary>
        /// Delete selected product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteShopList_Click(object sender, EventArgs e)
        {
            //Get index
            if (GetSelectedIndexList(out int index))
            {
                //Remove product at index
                bool deleted = currShopList.DeleteProduct(index);
                //Norify user
                Notify(deleted);
                UpdateShopList();
            }
        }
        /// <summary>
        /// Show input information for the selected product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbxProducts_SelectedIndexChanged(object sender, EventArgs e)         
        {
            if (GetSelectedIndexList(out int index))
            {
                //Save index
                indexProductList = index;

                txtAddProduct.Text = currShopList.GetProduct(index).Name;
                numUpDown.Value = currShopList.GetProduct(index).Amount;
                cmboxUnits.SelectedIndex = (int)currShopList.GetProduct(index).Unit;
                //Write if quantity other then zero
                if (currShopList.GetProduct(index).Quantity == 0)
                {
                    txtQuantity.Text = string.Empty;
                }
                else
                {
                    txtQuantity.Text = currShopList.GetProduct(index).Quantity.ToString();
                }
            }
            
            
        }
        /// <summary>
        /// Change the amount of selected product when pushing the numupdown arrows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)                // Fungerar!!! 
        {
            
            //if item selected
            //Use saved index - indexProductList
            if (indexProductList >= 0)
            {
                Product pro = currShopList.GetProduct(indexProductList);
                pro.Amount = currShopList.GetProduct(indexProductList).Amount = numUpDown.Value;
                currShopList.EditProduct(indexProductList, pro);
                
                UpdateShopList();
            }
        }
        #endregion End Listbox events
        //      ++++++
        #endregion Listbox
        // ****************************************************************

        #region Listview 

        /// <summary>
        /// Read name of list
        /// </summary>
        /// <returns>
        /// false if empty
        /// </returns>
        
        private bool CheckListName()
        {
            if (!string.IsNullOrWhiteSpace(txtNameList.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Give list a name first", "Error");
            }
            return false;
        }
        
        /// <summary>
        /// Get selsected index in Favourite list
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// true if an item is selected and its index > 0
        /// </returns>
        private bool GetSelectedIndexListview(out int index)
        {
            index = -2;
            //Check number of selected items
            int count = lstviewFavList.SelectedItems.Count;
            if (count > 0)      //Only react if an item is selected
            {                   // count = 0 leads to run time exeption for selectedIndices[0]!
                index = lstviewFavList.SelectedIndices[0];
                return true;
            }
            else
            {
                MessageBox.Show("Select item first, Error");
            }

            return false;
        }
        //      ++++++
        #region Listview events
        /// <summary>
        /// Save current shopping list to Favourite lists, if inputs are correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveShopList_Click(object sender, EventArgs e)
        {
            //Check that user has given the list a name
            if (CheckListName())
            {
                //Copy current shopping list
                ProductManager newFavList = new ProductManager(currShopList);
                newFavList.ListName = txtNameList.Text;
                //Reset all attributes to default, except name
                newFavList.ResetAllExceptName();
                
                //save to favLists
                if (favLists.AddProductList(newFavList))
                {
                    //List added if inputs correct
                    //Reset setting and update list
                    SetDefault();
                    UpdateFavLists();
                    ResetcurrShopList();
                }
            }
            
            
                
            
            //newFavList was not added
        }
        /// <summary>
        /// Push to make selected Favourite list editable in the shopping list window, left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFavList_Click(object sender, EventArgs e)
        {
            
            bool indexOK = GetSelectedIndexListview(out int index);
            if (indexOK)
            {
                //Set edit Favlist on
                editFavlist = true;
                //Copy currShopList to a temporary variable
                storecurrShopList = new ProductManager(currShopList);
                //store selected favList to currShopList
                currShopList = new ProductManager(favLists.GetProductList(index));
                //Change lable
                LableEditFavList(index);
                //Disable Save button
                btnShopList.Enabled = false;
                //Save index
                indexFavList = index;
                
                UpdateShopList();
            }
        }
        /// <summary>
        /// Push to save current editable Favourite list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEditFavlist_Click(object sender, EventArgs e)
        {
            //if editFavlist on
            if (editFavlist)
            {
                //Edit favlist if all inputs are ok
                if (favLists.EditProductList(indexFavList, currShopList))
                {
                    //favlist edited!!

                    // ++++ Reset setting and update list +++++
                    //Reset all attributes to default, except name
                    favLists.GetProductList(indexFavList).ResetAllExceptName();      
                    //Set editFavlist off
                    editFavlist = false;
                    //Change lable back
                    LableEditFavList(indexFavList);
                    //Enable save button
                    btnShopList.Enabled = true;
                    
                    SetDefault();
                    //Get the stored shop list
                    currShopList = storecurrShopList;
                    UpdateFavListProducts(indexFavList);

                    //Confirm
                    MessageBox.Show("Edit Completed", "Notification");
                }
                else
                {
                    MessageBox.Show("Edit failed", "Error");
                }
            }
        }
        /// <summary>
        /// Ask if user want to delete selected Favourite list - Delete if Yes!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteFavList_Click(object sender, EventArgs e)
        {
            //Get index
            if (GetSelectedIndexListview(out int index))
            {
                DialogResult answer = MessageBox.Show("Do you want to delete this list from Favourite lists?",
                    "Attention", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    bool deleted = favLists.DeleteProductList(index);
                    UpdateFavLists();
                    //Confirm
                    Notify(deleted);
                }
            }
        }
        /// <summary>
        /// Move back from product list to Favourite lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateFavLists();
            showFavLists = true;            //Show Favourite lists
            ChangeFavlistLable();
        }
        /// <summary>
        /// Double click on a Favourite list to see its products. Opens a productList
        /// Or Add product to shoppping list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstviewFavList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Check index 
            bool indexOK = GetSelectedIndexListview(out int index);
            if (indexOK)
            {
                //Check Listview showFavlis
                if (showFavLists)       //Viewing Favourite lists
                {
                    UpdateFavListProducts(index);
                    showFavLists = false;       //Show products of a Favourite list
                    ChangeFavlistLable();
                }
                else                   //Viewing products of a Favourite list
                {
                    string name = lstviewFavList.SelectedItems[0].Text;
                    Product favProduct = new Product(name);
                    currShopList.AddProduct(favProduct);
                    UpdateShopList();
                }
            }
            
            
        }
        #endregion End Listview  events
        //      ++++++
        #endregion  End Listview methods

        // ****************************************************************
        #region Menu
        /// <summary>
        /// Create a new shopping list and clear out the old
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileNew_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Current shop list will be " +
                "deleted! Do you want to continue?", "Alert",
                MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                ResetcurrShopList();
                SetDefault();
                lstbxProducts.Items.Clear();
            }
            
        }
        /// <summary>
        /// Open a saved shopping list from text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            ResetcurrShopList();
            bool ok = currShopList.OpenTxtFile(currShopList ,fileName);
            if (ok)
            {
                UpdateShopList();
                MessageBox.Show("File opened");
            }
            else
            {
                MessageBox.Show("File couldn´t open", "Error");
            }

        }
        /// <summary>
        /// Save current shopping list to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            bool ok = currShopList.SaveShopList(currShopList, fileName);
            if (ok)
            {
                MessageBox.Show("Shop list saved to file: " + Environment.NewLine + fileName);
            }
            else
            {
                MessageBox.Show("Failed to save shop list", "Error");
            }
        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult click = MessageBox.Show("Sure you want to exit?",
                "Exiting program", MessageBoxButtons.YesNo);
            if (click == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Opens a form that show information about this application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            //Create object of AboutBox
            AboutBox1 newBox = new AboutBox1();
            

            //Manage click
            DialogResult myClick = newBox.ShowDialog();
            if (myClick == DialogResult.OK)
            {
                this.Close();
            }
        }
        #endregion
        // ****************************************************************
        /// <summary>
        /// Update listbox with products for a shopping list
        /// </summary>
        private void UpdateShopList()
        {
            lstbxProducts.Items.Clear();
            for (int i = 0; i < currShopList.NumOfProducts(); i++ )
            {
                lstbxProducts.Items.Add(currShopList.GetProduct(i).ToString());
            }
        }
        
        /// <summary>
        /// Update listview with a list of the Favourite lists
        /// </summary>
        private void UpdateFavLists()
        {
            lstviewFavList.Items.Clear();
            for (int i = 0; i < favLists.NumOfLists(); i++)
            {
                ListViewItem lvi = new ListViewItem(favLists.GetProductList(i).ListName);
                lstviewFavList.Items.Add(lvi);
            }
            
        }
        /// <summary>
        /// Update listview with a list of products for selected Favourite list
        /// </summary>
        /// <param name="index"></param>
        private void UpdateFavListProducts(int index)
        {
            lstviewFavList.Items.Clear();
            for (int i = 0; i < favLists.GetProductList(index).NumOfProducts(); i++)
            {
                ListViewItem lvi = new ListViewItem(favLists.GetProductList(index).GetProduct(i).Name);
                lstviewFavList.Items.Add(lvi);
            }
        }

        
        #endregion Methods
        //---------------------------------------------------------------




    }
}
