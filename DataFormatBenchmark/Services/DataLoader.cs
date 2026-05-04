using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class DataLoader
{
    public List<TrainAnnouncement> LoadTrainAnnouncementsFromJson(string path)
    {
        var json = File.ReadAllText(path);

        var apiResponse = JsonSerializer.Deserialize<TrafficApiResponse>(json);

        return apiResponse?
            .RESPONSE?
            .RESULT?[0]
            .TrainAnnouncement 
            ?? new List<TrainAnnouncement>();
    }
}