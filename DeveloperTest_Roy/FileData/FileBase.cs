using System.Collections.Generic;
using System.Linq;

using System.Configuration;
using ThirdPartyTools;

namespace FileData
{
    public class FileBase
    {

        FileDetails objFileDetails = new FileDetails();        

        /// <summary>
        /// get the file version
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public  string getFileVersion(string filename )
        {
             return (objFileDetails.Version(filename));      
           
        }

        /// <summary>
        /// get the file size 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public  int getFileSize(string filename)
        {

            return (objFileDetails.Size(filename));
        }

        /// <summary>
        /// get file version parameter from App.config
        /// </summary>
        /// <returns></returns>
        public  List<string> getFileVersionParam()
        {
            string verList = ConfigurationManager.AppSettings["Version"];        
            List<string>  verLst  = verList.Split(',').ToList<string>();
            return verLst;
        }

        /// <summary>
        /// get file size parameter from App.config
        /// </summary>
        /// <returns></returns>
        public  List<string> getFileSizeParam()
        {
            string  sizeList = ConfigurationManager.AppSettings["Size"];            
            List<string> sizeLst = sizeList.Split(',').ToList<string>();
            return sizeLst;
            
        }
    }
}
