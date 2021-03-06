﻿using System.Globalization;
using CsvHelper.Configuration;

namespace RavenBurgerCo.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool DriveThru { get; set; }
        public string DriveThruArea { get; set; }
        public bool Delivery { get; set; }
        public string DeliveryArea { get; set; }

        [CsvField(Ignore = true)]
        public string LocationWkt
        {
            get { return string.Format(CultureInfo.InvariantCulture, "POINT ({0} {1})", Longitude, Latitude); }
        }
    }
}