using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Shopping_List
{
    /// <summary>
    /// Handles a list of Product-lists, add, edit, delete possibilities
    /// </summary>
    class FavouriteLists
    {
        //Fields
        //Declare a currProductList
        private ProductManager currProductList;
        //Create a List of productLists, aka "Favourite list"
        private List<ProductManager> favList;
        //---------------------------------------------------------------
        #region Constructor
        public FavouriteLists()
        {
            //Initiate favList
            favList = new List<ProductManager>();
            
        }
        #endregion
        //---------------------------------------------------------------
        #region Properties
        #endregion
        //---------------------------------------------------------------
        #region Methods
        /// <summary>
        /// Copy Product list at index and return it
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ProductManager GetProductList(int index)
        {
            ProductManager copyList = new ProductManager(favList[index]);
            return copyList;
        }
        /// <summary>
        /// Perfomres validation that the list has a name other then the default name
        /// </summary>
        /// <param name="addList"></param>
        /// <returns>
        /// true if name of list is valide and then adds the list to the end of favList
        /// </returns>
        public bool AddProductList(ProductManager addList)
        {
            //Perform validation
            if (addList.ValidateListName())
            {
                favList.Add(addList);   //add list to Favourite list
                return true;
            }
            
            return false;
        }
        /// <summary>
        /// If index; list name and product names are ok, edit list at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="editList"></param>
        /// <returns>
        /// true if successful
        /// </returns>
        public bool EditProductList(int index, ProductManager editList)
        {
            bool ok;
            //Perform validation
            ok = editList.ValidateListName();
            ok = editList.ValidateProductList();
            ok = Checkindex(index);

            if (ok)
            {
                favList[index] = editList;
            }
            return ok;
        }
        /// <summary>
        /// Delete list at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="deleteList"></param>
        public bool DeleteProductList(int index)
        {
            bool ok = Checkindex(index);
            if (ok)
            {
                favList.RemoveAt(index);
            }
            return ok;
        }
        /// <summary>
        /// Check index is inside range of favList
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool Checkindex(int index)
        {
            if (index < favList.Count)
            {
                return true;    //index OK
            }   
            return false;       //index outside range
        }
        public int NumOfLists()
        {
            return favList.Count;
        }
        
       
        #endregion
        //---------------------------------------------------------------
    }
}
