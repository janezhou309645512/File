using fileupload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace fileupload.Controllers
{
    public class FileController : Controller
    {
        FtpClient ftp = new FtpClient("120.79.146.123", "jane.zhou1", "309645512");
        // GET: File
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {

            return View();
        }

        public ActionResult Upload()
        {




            return View();
        }
        public string UploadFile(HttpPostedFileBase file)
        {
          
            ftp.WebUpload(file);
            return "上传成功";
        }


        //-rw-r--r-- 1 ftp ftp 13158 Nov 17 13:34 a.png        -rw-r--r-- 1 ftp ftp 13158 Nov 18 14:57 abcd.png-rw-r--r-- 1 ftp ftp 0 Nov 18 14:51 chrome.exe.sig-rw-r--r-- 1 ftp ftp 0 Nov 18 14:46 chrome_100_percent.pak-rw-r--r-- 1 ftp ftp 436 Nov 15 2017 StudyDay.txtdrwxr-xr-x 1 ftp ftp 0 Nov 18 15:02 UserImage-rw-r--r-- 1 ftp ftp 168 Nov 17 12:34 web.config-rw-r--r-- 1 ftp ftp 2734 Nov 17 13:31 鍗楁嫵濡堝 - 涓嬮洦澶?896b9ecf93cacce134b1f8d537123287-26615577-00000000.krc-rw-r--r-- 1 ftp ftp 60718 Nov 17 13:35 鎴浘00.png-rw-r--r-- 1 ftp ftp 16029 Nov 17 13:41 姣忔棩鏁版嵁姹囨姤.xlsx-rw-r--r-- 1 ftp ftp 907734 Nov 17 13:34 鑻遍泟鏃跺埢_20171008-05鐐?5鍒?2s.avi
          public string AllFiles()
        {


           List<string> ftpFiles  = ftp.GetFileDetails();
            string str = "";
            for (int i = 0; i < ftpFiles.Count; i++)
            {

               str += ftpFiles[i];



            }



            return str;
        } 



    }
}