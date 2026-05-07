using ProtoBuf;

namespace DataFormatBenchmark.Models;

[ProtoContract]
public class LaneData
{
    [ProtoMember(1)]
    public string? Valid_From { get; set; }

    [ProtoMember(2)]
    public string? Valid_To { get; set; }

    [ProtoMember(3)]
    public int GID { get; set; }

    [ProtoMember(4)]
    public string? Element_Id { get; set; }

    [ProtoMember(5)]
    public string? Feature_Oid { get; set; }

    [ProtoMember(6)]
    public double Start_Measure { get; set; }

    [ProtoMember(7)]
    public double End_Measure { get; set; }

    [ProtoMember(8)]
    public string? Updated { get; set; }

    [ProtoMember(9)]
    public string? Körfältsantal { get; set; }

    [ProtoMember(10)]
    public string? Körfält_I_Vägens_Framriktning { get; set; }

    [ProtoMember(11)]
    public string? Körfält_I_Vägens_Bakriktning { get; set; }

    [ProtoMember(12)]
    public bool Deleted { get; set; }

    [ProtoMember(13)]
    public Geometry? Geometry { get; set; }

    [ProtoMember(14)]
    public string? ModifiedTime { get; set; }
}

[ProtoContract]
public class Geometry
{
    [ProtoMember(1)]
    public string? WKT_SWEREF99TM_3D { get; set; }

    [ProtoMember(2)]
    public string? WKT_WGS84_3D { get; set; }
}