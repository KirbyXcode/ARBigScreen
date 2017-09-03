using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServer
{
    public partial class ShowARImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //从获取图片的页面接收到的图片的网址
            string urlStr = Request.QueryString["url"];

            //通过Image组件将图片显示出来
            Image_AR.ImageUrl = urlStr;
        }
    }
}