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
        public string Name { get; set; } = null!;
        [Index(2)]
        public string State { get; set; } = null!;
        [Index(3)]
        public double Lat { get; set; }
        [Index(4)]
        public double Lng { get; set; }
    }
}

