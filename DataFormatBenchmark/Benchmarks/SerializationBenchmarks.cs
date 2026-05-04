using BenchmarkDotNet.Attributes;
using DataFormatBenchmark.Models;
using DataFormatBenchmark.Services;
using System.Collections.Generic;

namespace DataFormatBenchmark.Benchmarks;

[MemoryDiagnoser]
public class SerializationBenchmarks
{
    private List<TrainAnnouncement> _data;

    private readonly DataLoader _loader = new();
    private readonly JsonSerializerService _jsonService = new();
    private readonly XmlSerializerService _xmlService = new();
    private readonly ProtobufSerializerService _protoService = new();

    private byte[] _jsonBytes;
    private byte[] _xmlBytes;
    private byte[] _protoBytes;

    [GlobalSetup]
    public void Setup()
    {
        _data = _loader.LoadTrainAnnouncementsFromJson("Data/data.json");

        _jsonBytes = _jsonService.Serialize(_data);
        _xmlBytes = _xmlService.Serialize(_data);
        _protoBytes = _protoService.Serialize(_data);
    }

    // =====================
    // SERIALIZATION
    // =====================

    [Benchmark]
    public byte[] Json_Serialize()
    {
        return _jsonService.Serialize(_data);
    }

    [Benchmark]
    public byte[] Xml_Serialize()
    {
        return _xmlService.Serialize(_data);
    }

    [Benchmark]
    public byte[] Protobuf_Serialize()
    {
        return _protoService.Serialize(_data);
    }

    // =====================
    // DESERIALIZATION
    // =====================

    [Benchmark]
    public List<TrainAnnouncement>? Json_Deserialize()
    {
        return _jsonService.Deserialize(_jsonBytes);
    }

    [Benchmark]
    public List<TrainAnnouncement> Xml_Deserialize()
    {
        return _xmlService.Deserialize(_xmlBytes);
    }

    [Benchmark]
    public List<TrainAnnouncement> Protobuf_Deserialize()
    {
        return _protoService.Deserialize(_protoBytes);
    }

    // =====================
    // CLEANUP (PRINT RESULT)
    // =====================

    [GlobalCleanup]
    public void PrintPayloadSizes()
    {
        Console.WriteLine("\n=== Payload Size (bytes) ===");
        Console.WriteLine($"JSON      : {_jsonBytes.Length,8:N0}");
        Console.WriteLine($"XML       : {_xmlBytes.Length,8:N0}");
        Console.WriteLine($"Protobuf  : {_protoBytes.Length,8:N0}");
    }
}