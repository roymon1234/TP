using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ThirdPartyTools;
using System.Collections.Generic;
using FileData;


namespace FileDataUnitTest
{
    [TestClass]
    public class FileUnitTest
    {
        List<string> fileVersion = new List<string>() { "-v,--v, /v,--version" };
        List<string> fileSize = new List<string>() { "-s,--s, /s,--size" };
        string filePath = "c:/text.txt";
        FileBase objDetails = new FileBase();
        
        /// <summary>
        /// get the file  version  
        /// </summary>
        [TestMethod] 
        public void Get_File_Version()
        {
           
            //Arrange           
            var version = "-v";
            var actual = string.Empty;
            var expected = ".";

            //Act
            if (fileVersion[0].Contains(version))
                actual = objDetails.getFileVersion(filePath);

            //Assert            
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        /// get the file  size  
        /// </summary>
        [TestMethod] 
        public void Get_File_Size()
        {
            //Arrange                      
            var version = "-s";
            var actual = 0;
            var expected = ".";

            //Act
            if (fileSize[0].Contains(version))
                actual = objDetails.getFileSize(filePath);            

            //Assert            
            Assert.IsFalse(actual.ToString().Contains(expected));
        }

       

        /// <summary>
        /// check the  size parameter
        /// </summary>
        [TestMethod]
        public void Get_File_Size_Parm_True()
        {
            //Arrange
            var version = "--s";
            var actual = false;

            //Act
            actual = fileSize[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Get_File_Version_Parm_True()
        {
            //Arrange
            var version = "--v";
            var actual = false;

            //Act
            actual = fileVersion[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }         
    }
}
