using KyPcT.Core.Entities;

namespace KyPcT.Entities.Entities
{
    public class Category:EntityBase
    {
            
        public string Name { get; set; }    
        public ICollection<Article> Articles { get; set; }  
    }
}
