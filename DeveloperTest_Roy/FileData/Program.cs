using System;
using System.Configuration;


namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            try
            {

                FileBase objFileBase = new FileBase(); 

                if (args.Length != 2) throw new ArgumentException(ConfigurationManager.AppSettings["InvalidFileMsg"].ToString());
                {

                    if (args[0] != string.Empty)
                    {
                        var verLst = objFileBase.getFileVersionParam();
                        var sizeLst = objFileBase.getFileSizeParam();

                        if (verLst.Contains(args[0]))
                        {
                              Console.WriteLine(ConfigurationManager.AppSettings["FileVersionMsg"].ToString(), objFileBase.getFileVersion(args[1]));                           
                        }

                        else if (sizeLst.Contains(args[0]))
                        {                           
                            Console.WriteLine(ConfigurationManager.AppSettings["FileSizeMsg"].ToString(), objFileBase.getFileSize(args[1]));
                        }
                        else
                        {                            
                            Console.WriteLine(ConfigurationManager.AppSettings["AlertMsgHdr1"].ToString());                            
                        }

                    }

                }

            }
            catch (Exception ex)
            {                
                Console.WriteLine(ConfigurationManager.AppSettings["AlertErrMsg"].ToString(), ex.ToString());
            }
            Console.WriteLine(ConfigurationManager.AppSettings["AlertExitMsg"].ToString());
            Console.ReadKey(); 
            
        }
    }
}
