using System.Collections.Generic;
using System.Text.Json;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class JsonSerializerService
{
    public byte[] Serialize(List<TrainAnnouncement> data)
    {
        return JsonSerializer.SerializeToUtf8Bytes(data);
    }

    public List<TrainAnnouncement>? Deserialize(byte[] bytes)
    {
        return JsonSerializer.Deserialize<List<TrainAnnouncement>>(bytes);
    }
}