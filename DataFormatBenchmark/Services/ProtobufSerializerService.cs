using System.Collections.Generic;
using System.IO;
using DataFormatBenchmark.Models;
using ProtoBuf;

namespace DataFormatBenchmark.Services;

public class ProtobufSerializerService
{
    public byte[] Serialize(List<TrainAnnouncement> data)
    {
        using var stream = new MemoryStream();
        Serializer.Serialize(stream, data);
        return stream.ToArray();
    }

    public List<TrainAnnouncement> Deserialize(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        return Serializer.Deserialize<List<TrainAnnouncement>>(stream);
    }
}