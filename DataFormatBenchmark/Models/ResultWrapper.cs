using System.Collections.Generic;
using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class ResultWrapper
{
    [ProtoMember(1)]
    public List<TrainAnnouncement>? TrainAnnouncement { get; set; }
}