using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FirstWebApiProject.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        public static readonly List<Product> Products = new List<Product>
        {
            new Product{ID = 1, Name ="Playstation Bundle", Price = 299m},
            new Product{ID = 2, Name ="LifeProof iPhone 6 Case", Price = 79m},
            new Product{ID = 3, Name ="New Balance Trainers", Price = 89m},
            new Product{ID = 4, Name ="StarWars BattleFront PS4", Price = 59.99m},

        };
    }
}