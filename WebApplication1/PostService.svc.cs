using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApplication1.DTOs;

namespace WebApplication1
{
    // NOT: "PostService" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde PostService.svc veya PostService.svc.cs öğesini seçin ve hata ayıklamaya başlayın.
    public class PostService : IPostService
    {
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = new List<PostDto>();
            var post1 = new PostDto() { Id = 1, Title = "Deneme", Description = "Açıklama" };
            var post2 = new PostDto() { Id = 2, Title = "Yazı 2", Description = "Yazı Açıklama 2"};
            posts.Add(post1);
            posts.Add(post2);

            return posts;
        }
    }
}
