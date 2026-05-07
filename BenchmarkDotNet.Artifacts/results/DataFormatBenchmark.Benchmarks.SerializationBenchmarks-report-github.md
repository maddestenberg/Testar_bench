```

BenchmarkDotNet v0.15.8, macOS Tahoe 26.3.1 (a) (25D771280a) [Darwin 25.3.0]
Apple M4, 1 CPU, 10 logical and 10 physical cores
.NET SDK 8.0.417
  [Host]     : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a


```
| Method               | Mean      | Error    | StdDev   | Gen0     | Gen1     | Gen2     | Allocated  |
|--------------------- |----------:|---------:|---------:|---------:|---------:|---------:|-----------:|
| Json_Serialize       | 194.26 μs | 2.056 μs | 1.822 μs | 184.0820 | 184.0820 |  52.4902 |  197.64 KB |
| Xml_Serialize        | 514.42 μs | 6.382 μs | 5.970 μs | 302.7344 | 287.1094 | 248.0469 | 1051.24 KB |
| Protobuf_Serialize   |  81.20 μs | 0.221 μs | 0.207 μs |  23.3154 |        - |        - |  192.65 KB |
| Json_Deserialize     | 369.65 μs | 1.541 μs | 1.366 μs |  35.6445 |  11.2305 |        - |   291.3 KB |
| Xml_Deserialize      | 660.85 μs | 5.513 μs | 4.887 μs |  39.0625 |  11.7188 |   3.9063 |  320.76 KB |
| Protobuf_Deserialize | 100.47 μs | 0.219 μs | 0.205 μs |  27.5879 |   8.6670 |        - |  225.74 KB |
