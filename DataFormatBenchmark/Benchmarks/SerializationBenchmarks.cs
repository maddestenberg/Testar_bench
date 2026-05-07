using BenchmarkDotNet.Attributes;
using DataFormatBenchmark.Models;
using DataFormatBenchmark.Services;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataFormatBenchmark.Benchmarks;

[MemoryDiagnoser]
public class SerializationBenchmarks
{
    private List<LaneData> _data;

    private readonly DataLoader _loader = new();
    private readonly JsonSerializerService _jsonService = new();
    private readonly XmlSerializerService _xmlService = new();
    private readonly ProtobufSerializerService _protoService = new();

    private byte[] _jsonBytes;
    private byte[] _xmlBytes;
    private byte[] _protoBytes;

    // CPU-time variabler
    private double _jsonCpuTime;
    private double _xmlCpuTime;
    private double _protoCpuTime;

    [GlobalSetup]
    public void Setup()
    {
        _data = _loader.LoadLaneDataFromJson("Data/data2.json");

        // Vanlig serialization
        _jsonBytes = _jsonService.Serialize(_data);
        _xmlBytes = _xmlService.Serialize(_data);
        _protoBytes = _protoService.Serialize(_data);

        // CPU-time mätning
        var process = Process.GetCurrentProcess();

        // JSON
        var cpuBeforeJson = process.TotalProcessorTime;
        _jsonService.Serialize(_data);
        var cpuAfterJson = process.TotalProcessorTime;
        _jsonCpuTime = (cpuAfterJson - cpuBeforeJson).TotalMilliseconds;

        // XML
        var cpuBeforeXml = process.TotalProcessorTime;
        _xmlService.Serialize(_data);
        var cpuAfterXml = process.TotalProcessorTime;
        _xmlCpuTime = (cpuAfterXml - cpuBeforeXml).TotalMilliseconds;

        // Protobuf
        var cpuBeforeProto = process.TotalProcessorTime;
        _protoService.Serialize(_data);
        var cpuAfterProto = process.TotalProcessorTime;
        _protoCpuTime = (cpuAfterProto - cpuBeforeProto).TotalMilliseconds;

        // Payload output
        Console.WriteLine("\n=== Payload Size (bytes) ===");
        Console.WriteLine($"JSON      : {_jsonBytes.Length,8:N0}");
        Console.WriteLine($"XML       : {_xmlBytes.Length,8:N0}");
        Console.WriteLine($"Protobuf  : {_protoBytes.Length,8:N0}");

        // CPU output
        Console.WriteLine("\n=== CPU Time (ms) ===");
        Console.WriteLine($"JSON      : {_jsonCpuTime:F6} ms");
        Console.WriteLine($"XML       : {_xmlCpuTime:F6} ms");
        Console.WriteLine($"Protobuf  : {_protoCpuTime:F6} ms");
    }

    // SERIALIZATION

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

   // DESERIALIZATION

[Benchmark]
public List<LaneData>? Json_Deserialize()
{
    return _jsonService.Deserialize(_jsonBytes);
}

[Benchmark]
public List<LaneData> Xml_Deserialize()
{
    return _xmlService.Deserialize(_xmlBytes);
}

[Benchmark]
public List<LaneData> Protobuf_Deserialize()
{
    return _protoService.Deserialize(_protoBytes);
}
}