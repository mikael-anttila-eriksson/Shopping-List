using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Shopping_List
{
    /// <summary>
    /// This class handles a list of Product, add, delete and edit. Can save and open tasks to a textfile.
    /// </summary>
    class ProductManager
    {
        //Fields
        private List<Product> productList;
        //The listName of the list - Defaul "Shopping list"
        private string listName;
        //---------------------------------------------------------------
        #region Constructor
        /// <summary>
        /// Constructor with default name
        /// </summary>
        public ProductManager() : this("Shopping list")
        {
            //productList = new List<Product>();
            //listName = "Shopping list";
        }
        /// <summary>
        /// Constructor, choose name
        /// </summary>
        /// <param name="nameofList"></param>
        public ProductManager(string nameofList)
        {
            productList = new List<Product>();
            listName = nameofList;
        }
        /// <summary>
        /// Copy constructor, copies the whole product list
        /// </summary>
        /// <param listName="copyList"></param>
        public ProductManager(ProductManager copyList)
        {
            this.productList = copyList.productList;
            this.listName = copyList.listName;
        }
        #endregion
        //---------------------------------------------------------------
        #region Properties
        //The list is an object. Giving access here will only  
        //return the address of the object

        // Name 
        public string ListName
        {
            get
            {
                return listName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    listName = value;
                }
            }
        }
        #endregion
        //---------------------------------------------------------------
        #region Methods
        /// <summary>
        /// Returns a copy of the product at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Product GetProduct(int index)
        {
            Product proCopy = new Product( productList[index] );
            return proCopy;
        }
        /// <summary>
        /// Add product to the end of the List
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns>
        /// False if products name is nullOrWhiteSpace
        /// </returns>
        public bool AddProduct(Product newProduct)
        {
            bool ok = false;
            if (!string.IsNullOrWhiteSpace(newProduct.Name))
            {
                productList.Add(newProduct);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Edit product at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="editedProduct"></param>
        /// <returns>
        /// True if index is inside range of List
        /// </returns>
        public bool EditProduct(int index, Product editedProduct)
        {
            if (CheckIndex(index))
            {
                productList[index] = editedProduct;
                return true;
            }
            //else
            return false;

        }
        /// <summary>
        /// Delete product at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// True if index is inside range of List
        /// </returns>
        public bool DeleteProduct(int index)
        {
            if (CheckIndex(index))
            {
                productList.RemoveAt(index);
                return true;
            }
            //else
            return false;
        }
        /// <summary>
        /// Reset all information to default, except name
        /// </summary>
        public void ResetAllExceptName()
        {
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i] = new Product(productList[i].Name);
            }
        }
        /// <summary>
        /// Check index is inside range of productList
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// True if yes
        /// </returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < productList.Count)
            {
                return true;    //index OK
            }
            //else
            return false;       //index outside range
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// int number of products in the list
        /// </returns>
        public int NumOfProducts()
        {
            return productList.Count;
        }
        
        /// <summary>
        /// Check that all products in the list have a name
        /// </summary>
        /// <returns>
        /// True if yes
        /// </returns>
        public bool ValidateProductList()
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(productList[i].Name))
                {
                    return false;
                }
            }
            // If all have names
            return true;
        }
        /// <summary>
        /// Check that the productList has a valid name, i.e. not default name  (Shopping list
        /// </summary>
        /// <returns>
        /// true if correct
        /// </returns>
        public bool ValidateListName()
        {
            if (!string.IsNullOrWhiteSpace(ListName) || listName != "Shopping list")
            {
                return true;    //ProductList has a valid name
            }
            return false;       //ProductList has no, or default name
        }
        //      Open / Save
        /// <summary>
        /// Open a  text file containg a shop list, from input file directory
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>
        /// true if file opens correctly
        /// </returns>
        public bool OpenTxtFile(ProductManager shopList, string fileName)
        {
            FileManager open = new FileManager();
            return open.OpenShopListFromFile(shopList ,fileName);
        }
        /// <summary>
        /// Saves current shop list to a text file, to input file directory
        /// </summary>
        /// <param name="shopList"></param>
        /// <param name="fileName"></param>
        /// <returns>
        /// true if save successful
        /// </returns>
        public bool  SaveShopList(ProductManager shopList, string fileName)
        {
            FileManager save = new FileManager();
            return save.SaveShopListToFile(shopList, fileName);
        }
        #endregion
        //---------------------------------------------------------------
    }
}
