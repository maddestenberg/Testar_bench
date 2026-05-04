using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class CodeDescription
{
    [ProtoMember(1)]
    public string? Code { get; set; }

    [ProtoMember(2)]
    public string? Description { get; set; }
}