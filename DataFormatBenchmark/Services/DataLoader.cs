using System.Text.Json;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class DataLoader
{
    public List<LaneData> LoadLaneDataFromJson(string path)
    {
        var json = File.ReadAllText(path);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var response = JsonSerializer.Deserialize<LaneApiResponse>(json, options);

        var data = response?.RESPONSE?.RESULT?[0].AntalKörfält2 
                   ?? new List<LaneData>();

        Console.WriteLine($"Loaded LaneData objects: {data.Count}");

        return data;
    }
}