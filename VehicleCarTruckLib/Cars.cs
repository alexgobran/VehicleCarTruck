using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLib {
    public class Cars : Vehicles {
       public bool Convertible { get; set; }
        public bool Hatchback { get; set; }
        public bool Hybrid { get; set; }

        public override string Print() {
            var convertible = Convertible ? " Convertible" : "";
            var hatchback = 
            return base.Print() + $", Convertible: {Convertible}, Hatchback: {Hatchback}, Hybrid: {Hybrid}";
        }

        //if you create this constructor you must list everything in parameters for base class and derive class
        public Cars(string vin, string make, string model, string price, bool convertible,bool hatchback, bool hybrid)
            : base(vin, make, model, price) {
            this.Convertible = convertible;
            this.Hatchback = hatchback;
            this.Hybrid = hybrid;


        }
}




