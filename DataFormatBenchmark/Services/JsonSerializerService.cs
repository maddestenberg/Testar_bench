using System.Collections.Generic;
using System.Text.Json;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class JsonSerializerService
{
    public byte[] Serialize(List<LaneData> data)
    {
        return JsonSerializer.SerializeToUtf8Bytes(data);
    }

    public List<LaneData>? Deserialize(byte[] bytes)
    {
        return JsonSerializer.Deserialize<List<LaneData>>(bytes);
    }
}