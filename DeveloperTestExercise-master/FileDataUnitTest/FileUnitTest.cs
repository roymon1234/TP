using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;
using System.Collections.Generic;


namespace FileDataUnitTest
{
    [TestClass]
    public class FileUnitTest
    {
        List<string> fileVersion = new List<string>() { "-v,--v, /v,--version" };
        List<string> fileSize = new List<string>() { "-s,--s, /s,--size" };
        string filePath = "c:/text.txt";
        
        /// <summary>
        /// get the file  version  
        /// </summary>
        [TestMethod] 
        public void Get_File_Version()
        {
            //Arrange
            FileDetails objDetails = new FileDetails();           
            var version = "-v";
            var actual = string.Empty;
            var expected = "4.2.9";

            //Act
            if (fileVersion.Contains(version))
                actual = objDetails.Version(filePath);

            //Assert 
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// get the file  size  
        /// </summary>
        [TestMethod] 
        public void Get_File_Size()
        {
            //Arrange
            FileDetails objDetails = new FileDetails();           
            var version = "-s";
            int actual = 0;
            var expected = "4.2.9";

            //Act
            if (fileSize.Contains(version))
                actual = objDetails.Size(filePath);

            //Assert 
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// check the  version parameter
        /// </summary>
        [TestMethod] 
        public void Get_File_Version_Param_True()
        {
            //Arrange
            var version = "--v";
            var actual = false;           

            //Act
            actual = fileVersion[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// check the  version parameter
        /// </summary>
        [TestMethod]  
        public void Get_File_Version_Param_False()
        {
            //Arrange
            var version = "p";
            var actual = false;            

            //Act
            actual = fileVersion[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
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

        /// <summary>
        /// check the  size parameter
        /// </summary>
        [TestMethod] 
        public void Get_File_Size_Param_False()
        {
            //Arrange
            var version = "p";
            var actual = false;          

            //Act
            actual = fileSize[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }

    }
}
