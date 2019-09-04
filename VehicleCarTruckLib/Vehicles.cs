using System;

namespace VehicleCarTruckLib {
    public class Vehicles {

        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal Price { get; set; }


        public virtual string Print() {//POLYMORPHISM
            return $"{this.GetType().Name}:: Vin: {Vin}, Make: {Make}, Model: {Model}, Trim: {Trim},  Price: {Price.ToString("C")}";
        }

        public Vehicles(string vin, string make, string model, string trim, decimal price) {
            Vin = vin;
            Make = make;
            Model = model;
            Trim = trim;
            Price = price;
        }
    }
}
        
