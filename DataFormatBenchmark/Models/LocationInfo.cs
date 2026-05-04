using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class LocationInfo
{
    [ProtoMember(1)]
    public string? LocationName { get; set; }

    [ProtoMember(2)]
    public int Priority { get; set; }

    [ProtoMember(3)]
    public int Order { get; set; }
}