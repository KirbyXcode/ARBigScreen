using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebServer
{  
    public partial class UploadAR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile hpf = Request.Files["post"];

            if (hpf != null)
            {
                DirectoryInfo imgDirectory = new DirectoryInfo(HttpContext.Current.Request.MapPath("ARImages"));
                FileInfo[] imgFiles = imgDirectory.GetFiles();
                int index = Convert.ToInt32(imgFiles.Last().Name.Split('.')[0]);

                index += 1;

                //003
                string imageNumber = FormatImage(index);
                //003.jpg
                string imageName = imageNumber + ".jpg";

                hpf.SaveAs(HttpContext.Current.Request.MapPath("ARImages/") + imageName);

                Response.Write(imageNumber);
            }
        }

        private string FormatImage(int index)
        {
            string imageStr = null;

            if (index < 10) 
            {
                imageStr = "00" + index.ToString();
            }
            else if(index < 100)
            {
                imageStr = "0" + index.ToString();
            }
            else
            {
                imageStr = index.ToString();
            }

            return imageStr;
        }
    }
}