// See https://aka.ms/new-console-template for more information
using System.Globalization;
using CsvHelper;
using KNN_Cities;


var usCities = new List<City>();

using (var reader = new StreamReader("../../../uscities.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var records = csv.GetRecords<City>();

    foreach (var r in records)
    {
        Console.WriteLine("City {0} {1:N} {2:N}", r.Name , r.Lat, r.Lng);
    }
}

