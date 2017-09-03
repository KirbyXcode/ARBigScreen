using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebServer
{
    public partial class UploadImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //提供了一个服务器与客户端通信的接口
            HttpPostedFile hpf = Request.Files["post"];

            if (hpf != null) 
            {
                //通过时间来给上传的文件命名
                string imageName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                //把上传来的图片以imageName来命名并且储存在网站根目录的Image文件夹中
                hpf.SaveAs(HttpContext.Current.Request.MapPath("Image") + "/"+ imageName);
                //向客户端返回图片在服务器中的地址
                Response.Write("http://47.92.102.137/Image/" + imageName);
            }

        }
    }
}