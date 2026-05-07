using System.Collections.Generic;

namespace DataFormatBenchmark.Models;

public class LaneApiResponse
{
    public LaneResponse? RESPONSE { get; set; }
}

public class LaneResponse
{
    public List<LaneResult>? RESULT { get; set; }
}

public class LaneResult
{
    public List<LaneData>? AntalKörfält2 { get; set; }
}