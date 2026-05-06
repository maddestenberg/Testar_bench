```

BenchmarkDotNet v0.15.8, macOS Tahoe 26.3.1 (a) (25D771280a) [Darwin 25.3.0]
Apple M4, 1 CPU, 10 logical and 10 physical cores
.NET SDK 8.0.417
  [Host]     : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.23 (8.0.23, 8.0.2325.60607), Arm64 RyuJIT armv8.0-a


```
| Method               | Mean      | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|--------------------- |----------:|----------:|----------:|-------:|-------:|----------:|
| Json_Serialize       |  9.250 μs | 0.0770 μs | 0.0683 μs | 0.9613 |      - |   7.89 KB |
| Xml_Serialize        | 29.340 μs | 0.1872 μs | 0.1563 μs | 8.7891 | 0.7324 |  72.76 KB |
| Protobuf_Serialize   |  5.584 μs | 0.0246 μs | 0.0218 μs | 0.6790 |      - |   5.56 KB |
| Json_Deserialize     | 19.314 μs | 0.1251 μs | 0.1170 μs | 1.8005 | 0.0916 |  14.77 KB |
| Xml_Deserialize      | 54.396 μs | 0.3247 μs | 0.3037 μs | 4.8828 | 0.2441 |  41.51 KB |
| Protobuf_Deserialize | 10.136 μs | 0.0202 μs | 0.0189 μs | 1.9226 | 0.0916 |   15.8 KB |
