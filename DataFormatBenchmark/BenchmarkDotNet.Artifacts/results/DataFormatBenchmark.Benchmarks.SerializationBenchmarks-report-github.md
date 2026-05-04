```

BenchmarkDotNet v0.15.8, macOS Tahoe 26.3.1 (a) (25D771280a) [Darwin 25.3.0]
Apple M4, 1 CPU, 10 logical and 10 physical cores
.NET SDK 8.0.417
  [Host]     : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a


```
| Method               | Mean      | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|--------------------- |----------:|----------:|----------:|-------:|-------:|----------:|
| Json_Serialize       |  9.346 μs | 0.0593 μs | 0.0526 μs | 0.9613 |      - |   7.89 KB |
| Xml_Serialize        | 29.682 μs | 0.2276 μs | 0.2018 μs | 8.7891 | 0.7324 |  72.76 KB |
| Protobuf_Serialize   |  5.580 μs | 0.0170 μs | 0.0159 μs | 0.6790 |      - |   5.56 KB |
| Json_Deserialize     | 19.321 μs | 0.1116 μs | 0.1044 μs | 1.8005 | 0.0916 |  14.77 KB |
| Xml_Deserialize      | 54.775 μs | 0.4912 μs | 0.4594 μs | 4.8828 | 0.2441 |  41.51 KB |
| Protobuf_Deserialize | 10.149 μs | 0.0270 μs | 0.0240 μs | 1.9226 | 0.0916 |   15.8 KB |
