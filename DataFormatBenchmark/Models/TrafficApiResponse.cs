using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class TrafficApiResponse
{
    [ProtoMember(1)]
    public ResponseWrapper? RESPONSE { get; set; }
}