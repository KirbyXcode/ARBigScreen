using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebServer
{
    public partial class GetARImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetImage(object sender, EventArgs e)
        {
            //定义图片在服务器文件夹中的位置， 即获取图片网址
            string imageURL = "http://47.92.102.137/ARImages/" + Tex_ImageNum.Text + ".jpg";

            //判断服务器文件夹中是否存在此图片
            if(File.Exists(Server.MapPath("ARImages/" + Tex_ImageNum.Text + ".jpg")))
            {
                //在现实图片的页面中吧对应的图片显示出来
                Response.Redirect("ShowARImage.aspx?url=" + imageURL);
            }
        }
    }
}