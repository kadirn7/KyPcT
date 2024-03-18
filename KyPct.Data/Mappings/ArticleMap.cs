//using KyPcT.Entities.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.ComponentModel;

//namespace KyPct.Data.Mappings
//{
//    public class ArticleMap : IEntityTypeConfiguration<Article>
//    {            //arayüzü 
//        public void Configure(EntityTypeBuilder<Article> builder)
//        {
//            //  builder.Property(x => x.Title).IsRequired(false); //null geçilebilir hale getirmeye yarar.
//            //  builder.Property(x=>x.Title).HasMaxLength(150);
//            builder.HasData(new Article
//            {
//                Id = Guid.NewGuid(),
//                Title = "Asp.net Core Deneme Makalesi 1 ",
//                Content = "Örnek data ile ilgili ",
//                ViewCount = 15,

//                CategoryId = Guid.Parse(" E87090DC - B625 - 4638 - 8F4F - 768A191C721E "),
//                ImageId = Guid.Parse(" B7E068DC - 0054 - 4892 - 8E20 - 3EEB7FD815EE "),
//                CreatedBy = "Admin Test",
//                CreatedDate = DateTime.Now,
//                IsDeleted = false

//            }); 
//        } 
//    }
//}
