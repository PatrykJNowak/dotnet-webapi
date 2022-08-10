using System.Collections.Generic;

namespace dotnet_webapp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Win { get; set; }
        public string Color { get; set; }
        public int YearOfProduction { get; set; }
        public int Course { get; set; }
        public bool IsAvailable { get; set; }
        public List<SellData> SellData { get; set; }
    }
}