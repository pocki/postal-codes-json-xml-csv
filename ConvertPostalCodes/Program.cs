using System.IO.Compression;
using System.Xml.Linq;

var file_name = "allCountries.txt";
var downloadUrl = "http://download.geonames.org/export/zip/allCountries.zip";

if (!File.Exists(file_name))
{
    using HttpClient client = new();
    using HttpResponseMessage response = await client.GetAsync(downloadUrl);
    using Stream streamToReadFrom = await response.Content.ReadAsStreamAsync();
    ZipArchive archive = new(streamToReadFrom);
    archive.ExtractToDirectory(".");
}
var data = File.ReadAllLines(file_name);

var dataset = new List<Dictionary<string, string>>();
foreach (var line in data)
{
    var attributes = line.Split("\t");
    dataset.Add(new Dictionary<string, string>
            {
                { "country_code", attributes[0] },
                { "zipcode", attributes[1] },
                { "place", attributes[2] },
                { "state", attributes[3] },
                { "state_code", attributes[4] },
                { "province", attributes[5] },
                { "province_code", attributes[6] },
                { "community", attributes[7] },
                { "community_code", attributes[8] },
                { "latitude", attributes[9] },
                { "longitude", attributes[10] }
            });
}

var countries = dataset.Select(d => d["country_code"]).Distinct();

foreach (var country in countries)
{
    // make sure directory exists
    Directory.CreateDirectory("data");

    // filter to country
    var subset = dataset.Where(d => d["country_code"] == country).ToList();

    var zipname = $"data/{country}.zip";
    if (File.Exists(zipname))
    {
        File.Delete(zipname);
    }

    using (var zipfile = ZipFile.Open(zipname, ZipArchiveMode.Create))
    {
        // json
        var json = System.Text.Json.JsonSerializer.Serialize(subset, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
        var entry = zipfile.CreateEntry($"zipcodes.{country.ToLower()}.json", CompressionLevel.SmallestSize);
        using (var stream = entry.Open())
        using (var writer = new StreamWriter(stream))
        {
            writer.Write(json);
        }

        // xml
        var xml = new XElement("zipcodes",
            subset.Select(x => new XElement("object",
                new XElement("country_code", x["country_code"]),
                new XElement("zipcode", x["zipcode"]),
                new XElement("place", x["place"]),
                new XElement("state", x["state"]),
                new XElement("state_code", x["state_code"]),
                new XElement("province", x["province"]),
                new XElement("province_code", x["province_code"]),
                new XElement("community", x["community"]),
                new XElement("community_code", x["community_code"]),
                new XElement("latitude", x["latitude"]),
                new XElement("longitude", x["longitude"])
            ))
        );
        entry = zipfile.CreateEntry($"zipcodes.{country.ToLower()}.xml", CompressionLevel.SmallestSize);
        using (var stream = entry.Open())
        using (var writer = new StreamWriter(stream))
        {
            writer.Write(xml);
        }

        // csv
        var csv = new StringWriter();
        csv.WriteLine(string.Join(",", dataset[0].Keys));
        foreach (var x in subset)
        {
            csv.WriteLine(string.Join(",", x.Values));
        }
        entry = zipfile.CreateEntry($"zipcodes.{country.ToLower()}.csv", CompressionLevel.SmallestSize);
        using (var stream = entry.Open())
        using (var writer = new StreamWriter(stream))
        {
            writer.Write(csv.ToString());
        }
    }

    Console.WriteLine($"- {country} ({subset.Count})");
}
