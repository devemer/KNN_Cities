// See https://aka.ms/new-console-template for more information
using System.Globalization;
using CsvHelper;
using KNN_Cities;

using (var reader = new StreamReader("../../../uscities.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var usCities = csv.GetRecords<City>();

    foreach (var r in usCities)
    {
        Console.WriteLine("City {0},{1},{2:N} {3:N} ", r.Name , r.State, r.Lat, r.Lng);
    }
}

