using System;

namespace SimpleCrudApi
{
    public class Products {
        public int ID {get; set;}

        public string Name {get; set;}
        
        public string Description {get; set;}

        public decimal Price {get; set;}
    }

    public class ProdutcsFull : Products {
        public DateTime CreationDate { get; set; }

        public DateTime LastUpdated { get; set; } 
    }
}
