using System.Collections.Generic;
using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class ResponseWrapper
{
    [ProtoMember(1)]
    public List<ResultWrapper>? RESULT { get; set; }
}