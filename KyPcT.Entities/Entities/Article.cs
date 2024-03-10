﻿using KyPcT.Core.Entities;
using KyPcT.Entities.Entities;

namespace KyPcT.Entities.Entities
{
    public class Article:EntityBase
    {
        
        public  string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public Guid CategoriyId { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; } 
    

    }
} 

