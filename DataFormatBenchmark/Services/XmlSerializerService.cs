using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DataFormatBenchmark.Models;

namespace DataFormatBenchmark.Services;

public class XmlSerializerService
{
    public byte[] Serialize(List<TrainAnnouncement> data)
    {
        var serializer = new XmlSerializer(typeof(List<TrainAnnouncement>));

        using var stream = new MemoryStream();
        serializer.Serialize(stream, data);

        return stream.ToArray();
    }

    public List<TrainAnnouncement> Deserialize(byte[] bytes)
    {
        var serializer = new XmlSerializer(typeof(List<TrainAnnouncement>));

        using var stream = new MemoryStream(bytes);
        return (List<TrainAnnouncement>)serializer.Deserialize(stream)!;
    }
}