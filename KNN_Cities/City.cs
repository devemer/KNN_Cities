using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN_Cities
{
	public class City
	{
        [Name("id")]
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Name { get; set; }
        [Index(2)]
        public string State { get; set; }
        [Index(3)]
        public double Lat { get; set; }
        [Index(4)]
        public double Lng { get; set; }
        [Index(5)]
        public double Population { get; set; }
    }
}

