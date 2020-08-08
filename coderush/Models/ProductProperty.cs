using System.ComponentModel.DataAnnotations;

namespace coderush.Models
{
    public class ProductProperty
    {
        public int ProductPropertyId {get; set;}
        public int ProductId {get; set;}
        public string Name { get; set; }
        public string Value { get; set; }


    }
}