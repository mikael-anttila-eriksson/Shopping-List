using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace A7_Shopping_List
{
    /// <summary>
    /// Opens and saves a a Product list to a textfile
    /// </summary>
    class FileManager
    {
        //Fields
        //TOKEN: to write as the first line in the textfiles
        //This way the file is marked as made by this application!
        private const string fileTOKEN = "ShopList_Vt21";
        //A file version
        private const double fileVersionNr = 1.0;
        //---------------------------------------------------------------
        #region Constructor
        #endregion
        //---------------------------------------------------------------
        #region Properties
        /// <summary>
        /// Get version number of this class
        /// </summary>
        public double FileVersionNr
        {
            get { return fileVersionNr; }
        }
        #endregion
        //---------------------------------------------------------------
        #region Methods
        /// <summary>
        /// Save current shop list to a txt-file
        /// </summary>
        /// <param name="shopList"></param>
        /// <param name="fileName"></param>
        /// <returns>
        /// true if successful
        /// </returns>
        public bool SaveShopListToFile(ProductManager shopList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                //Create object that link to default file
                writer = new StreamWriter(fileName);
                //Write TOKEN and file version
                writer.WriteLine(fileTOKEN);
                writer.WriteLine(fileVersionNr);

                //Write down the list
                writer.WriteLine(shopList.ListName + "\n");

                for (int i = 0; i < shopList.NumOfProducts(); i++)
                {
                    writer.WriteLine(shopList.GetProduct(i).Name);
                }
                
            }
            catch (Exception)
            {
                //If error in try-block
                ok = false;
            }
            finally     //Always executed
            {
                if (writer != null)
                {
                    //If writer exist, close it
                    writer.Close();
                }
            }
            return ok;
        }
        //*********************************************************
        /// <summary>
        /// Read a shop list from a txt-file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>
        /// true if successful
        /// </returns>
        public bool OpenShopListFromFile(ProductManager shopList ,string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                //if shopList is parameter, maybe clear it

                //create object and link it to fileName
                reader = new StreamReader(fileName);
                //CHeck file correct
                //TOKEN
                string readTOKEN = reader.ReadLine();
                //File version number
                string versionNr = reader.ReadLine();
                double version = double.Parse(versionNr, CultureInfo.InvariantCulture);

                //Compare to constants
                //token: ShopList_Vt21
                bool token = readTOKEN == fileTOKEN;
                //version number: 1.0
                bool versionNR = version == fileVersionNr;

                //if pass
                if (token && versionNR)
                {
                    
                    Product product = new Product();
                    //Name
                    shopList.ListName = reader.ReadLine();
                    reader.ReadLine(); //read empty line
                    //Products
                    string productName;
                    do                              
                    {
                        
                        //Read product from txt file
                        productName = reader.ReadLine();
                        if (!string.IsNullOrEmpty(productName))
                        {
                            product = new Product(productName);
                            shopList.AddProduct(product);
                        }
                        
                        
                    } while (!string.IsNullOrEmpty(productName));
                           
                }
                else    //Token or version number mismatch
                {
                    ok = false;
                }

            }
            catch (Exception)
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {   //Close reader object
                    reader.Close();
                }
            }
            return ok;
        }
        #endregion
        //---------------------------------------------------------------
    }
}
