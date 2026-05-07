using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class XmlSerializerService
{
    public byte[] Serialize(List<LaneData> data)
    {
        var serializer = new XmlSerializer(typeof(List<LaneData>));

        using var memoryStream = new MemoryStream();
        serializer.Serialize(memoryStream, data);

        return memoryStream.ToArray();
    }

    public List<LaneData> Deserialize(byte[] bytes)
    {
        var serializer = new XmlSerializer(typeof(List<LaneData>));

        using var memoryStream = new MemoryStream(bytes);

        return (List<LaneData>)serializer.Deserialize(memoryStream)!;
    }
}