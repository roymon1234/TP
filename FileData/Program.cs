using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Configuration;


namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                var verList = ConfigurationManager.AppSettings["Size"];  // get the size parameter formats 
                var sizeList = ConfigurationManager.AppSettings["Version"]; //get the version parameter formats

                List<string> verLst = verList.Split(',').ToList<string>();
                List<string> sizeLst = sizeList.Split(',').ToList<string>();

                FileDetails objFileDetails = new FileDetails();

                if (args.Length > 0)
                {

                    if (args[0] != string.Empty)
                    {

                        if (verLst.Contains(args[0]))
                        {
                            // call version                             
                            Console.WriteLine(ConfigurationManager.AppSettings["FileVerMsg"].ToString());
                            Console.WriteLine(ConfigurationManager.AppSettings["FileNameMsg"].ToString(), args[1]);
                            Console.WriteLine(ConfigurationManager.AppSettings["FileVersionMsg"].ToString(), objFileDetails.Version(args[1]));

                        }

                        else if (sizeLst.Contains(args[0]))
                        {
                            // call size
                            Console.WriteLine(ConfigurationManager.AppSettings["FileSizeHeadMsg"].ToString());
                            Console.WriteLine(ConfigurationManager.AppSettings["FileNameMsg"].ToString(), args[1]);
                            Console.WriteLine(ConfigurationManager.AppSettings["FileSizeMsg"].ToString(), objFileDetails.Size(args[1]));
                        }
                        else
                        {
                            // alert please enter corrrect values
                            Console.WriteLine(ConfigurationManager.AppSettings["AlertMsgHdr1"].ToString());
                            Console.WriteLine(ConfigurationManager.AppSettings["AlertMsgHdr2"].ToString(), verList);
                            Console.WriteLine(ConfigurationManager.AppSettings["AlertMsgHdr3"].ToString(), sizeList);
                        }

                    }

                }


            }
            catch (Exception ex)
            {

                //throw ex;  e.mesages
                Console.WriteLine(ConfigurationManager.AppSettings["AlertErrMsg"].ToString(), ex.ToString());
            }


            Console.WriteLine(ConfigurationManager.AppSettings["AlertExitMsg"].ToString());
            Console.ReadKey(); 
            
        }
    }
}
