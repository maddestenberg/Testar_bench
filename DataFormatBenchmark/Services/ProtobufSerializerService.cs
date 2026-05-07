using System.Collections.Generic;
using System.IO;
using ProtoBuf;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class ProtobufSerializerService
{
    public byte[] Serialize(List<LaneData> data)
    {
        using var memoryStream = new MemoryStream();

        Serializer.Serialize(memoryStream, data);

        return memoryStream.ToArray();
    }

    public List<LaneData> Deserialize(byte[] bytes)
    {
        using var memoryStream = new MemoryStream(bytes);

        return Serializer.Deserialize<List<LaneData>>(memoryStream);
    }
}