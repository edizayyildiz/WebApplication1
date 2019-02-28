using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication1.DTOs;

namespace WebApplication1
{
    /// <summary>
    /// PostXmlService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class PostXmlService : System.Web.Services.WebService
    {

        [WebMethod]
        public PostDto[] GetPosts()
        {
            var posts = new List<PostDto>();
            var post1 = new PostDto() { Id = 1, Title = "Deneme", Description = "Açıklama" };
            var post2 = new PostDto() { Id = 2, Title = "Yazı 2", Description = "Yazı Açıklama 2" };
            posts.Add(post1);
            posts.Add(post2);

            return posts.ToArray();
        }
    }
}
