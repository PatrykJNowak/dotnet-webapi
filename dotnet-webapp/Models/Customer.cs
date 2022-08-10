using System.Collections.Generic;

namespace dotnet_webapp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string BirthInfo { get; set; }
        public List<SellData> SellData { get; set; }

    }
}