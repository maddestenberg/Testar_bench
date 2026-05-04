using System;
using System.Collections.Generic;
using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class TrainAnnouncement
{
    [ProtoMember(1)]
    public string? ActivityId { get; set; }

    [ProtoMember(2)]
    public string? ActivityType { get; set; }

    [ProtoMember(3)]
    public bool Advertised { get; set; }

    [ProtoMember(4)]
    public DateTime AdvertisedTimeAtLocation { get; set; }

    [ProtoMember(5)]
    public string? AdvertisedTrainIdent { get; set; }

    [ProtoMember(6)]
    public bool Canceled { get; set; }

    [ProtoMember(7)]
    public bool Deleted { get; set; }

    [ProtoMember(8)]
    public List<CodeDescription>? Deviation { get; set; }

    [ProtoMember(9)]
    public List<LocationInfo>? FromLocation { get; set; }

    [ProtoMember(10)]
    public string? LocationSignature { get; set; }

    [ProtoMember(11)]
    public DateTime ModifiedTime { get; set; }

    [ProtoMember(12)]
    public string? Operator { get; set; }

    [ProtoMember(13)]
    public List<CodeDescription>? ProductInformation { get; set; }

    [ProtoMember(14)]
    public DateTime ScheduledDepartureDateTime { get; set; }

    [ProtoMember(15)]
    public List<LocationInfo>? ToLocation { get; set; }

    [ProtoMember(16)]
    public string? TrackAtLocation { get; set; }

    [ProtoMember(17)]
    public List<CodeDescription>? TypeOfTraffic { get; set; }

    [ProtoMember(18)]
    public string? WebLink { get; set; }

    [ProtoMember(19)]
    public string? WebLinkName { get; set; }
}