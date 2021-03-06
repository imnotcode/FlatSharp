``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.14393.3930 (1607/AnniversaryUpdate/Redstone1), VM=Hyper-V
Intel Xeon CPU E5-2667 v3 3.20GHz, 1 CPU, 8 logical and 8 physical cores
  [Host]                  : .NET Framework 4.8 (4.8.4240.0), X64 RyuJIT
  MediumRun-.NET 4.7      : .NET Framework 4.8 (4.8.4240.0), X64 RyuJIT
  MediumRun-.NET Core 2.1 : .NET Core 2.1.22 (CoreCLR 4.6.29220.03, CoreFX 4.6.29220.01), X64 RyuJIT
  MediumRun-.NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  MediumRun-.NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

IterationCount=15  LaunchCount=2  WarmupCount=10  

```
|                            Method |                     Job |       Runtime | TraversalCount |  DeserializeOption | VectorLength |        Mean |     Error |      StdDev |
|---------------------------------- |------------------------ |-------------- |--------------- |------------------- |------------- |------------:|----------:|------------:|
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |               **Lazy** |            **3** |  **1,975.5 ns** |  **15.81 ns** |    **23.66 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |               Lazy |            3 |  1,464.6 ns |   8.06 ns |    12.07 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |            3 |    864.0 ns |  10.05 ns |    15.04 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |            3 |    688.6 ns |  10.94 ns |    16.38 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |            3 |    898.4 ns |   9.80 ns |    14.37 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |            3 |    710.6 ns |  10.78 ns |    15.45 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |            3 |    882.5 ns |   8.94 ns |    12.53 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |            3 |    709.1 ns |  12.40 ns |    18.18 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |               **Lazy** |           **30** | **15,236.3 ns** | **154.86 ns** |   **231.79 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |               Lazy |           30 | 10,245.2 ns |  78.91 ns |   115.66 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |           30 |  6,441.1 ns |  87.37 ns |   130.77 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |           30 |  4,727.6 ns | 103.00 ns |   154.16 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |           30 |  6,725.2 ns |  51.54 ns |    73.92 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |           30 |  4,898.5 ns |  41.64 ns |    62.33 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |           30 |  6,706.0 ns |  28.13 ns |    42.11 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |           30 |  4,956.5 ns | 113.03 ns |   169.18 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **PropertyCache** |            **3** |  **2,090.2 ns** |  **22.78 ns** |    **34.09 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      PropertyCache |            3 |  1,570.6 ns |  22.57 ns |    33.79 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |            3 |    971.0 ns |   6.19 ns |     9.07 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |            3 |    766.3 ns |  11.19 ns |    16.40 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |            3 |    996.3 ns |   8.62 ns |    12.36 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |            3 |    802.2 ns |   8.62 ns |    12.64 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |            3 |    982.3 ns |   7.63 ns |    11.42 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |            3 |    787.1 ns |  12.42 ns |    18.58 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **PropertyCache** |           **30** | **16,276.1 ns** |  **86.23 ns** |   **126.40 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      PropertyCache |           30 | 10,845.2 ns | 103.09 ns |   154.30 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |           30 |  7,384.1 ns | 131.90 ns |   197.42 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |           30 |  5,267.8 ns | 167.43 ns |   240.13 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |           30 |  7,599.8 ns |  42.22 ns |    60.56 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |           30 |  5,500.1 ns |  84.05 ns |   123.20 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |           30 |  7,644.0 ns |  74.49 ns |   111.49 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |           30 |  5,388.2 ns |  69.41 ns |   103.89 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |        **VectorCache** |            **3** |  **2,151.3 ns** |   **6.65 ns** |     **9.53 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |        VectorCache |            3 |  1,598.0 ns |  14.43 ns |    21.15 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |            3 |  1,025.0 ns |  23.68 ns |    35.45 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |            3 |    814.3 ns |  17.61 ns |    26.36 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |            3 |  1,097.4 ns |   6.77 ns |     9.71 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |            3 |    885.7 ns |   7.47 ns |    10.95 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |            3 |  1,080.4 ns |   8.11 ns |    11.63 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |            3 |    889.4 ns |  12.78 ns |    19.12 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |        **VectorCache** |           **30** | **16,951.0 ns** | **147.07 ns** |   **215.57 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |        VectorCache |           30 | 11,392.8 ns | 191.64 ns |   286.84 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |           30 |  7,816.1 ns | 122.87 ns |   183.91 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |           30 |  5,586.4 ns | 130.40 ns |   187.02 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |           30 |  8,204.5 ns |  64.84 ns |    95.05 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |           30 |  6,202.1 ns |  34.63 ns |    49.66 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |           30 |  8,126.8 ns |  35.58 ns |    53.26 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |           30 |  6,205.8 ns |  71.46 ns |   104.74 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** | **VectorCacheMutable** |            **3** |  **2,121.2 ns** |  **10.81 ns** |    **15.84 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 | VectorCacheMutable |            3 |  1,602.3 ns |  17.93 ns |    25.72 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |            3 |  1,030.8 ns |  11.29 ns |    16.91 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |            3 |    817.8 ns |   9.01 ns |    13.48 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |            3 |  1,060.8 ns |   6.13 ns |     8.99 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |            3 |    867.6 ns |   6.40 ns |     9.18 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |            3 |  1,062.8 ns |   6.59 ns |     9.45 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |            3 |    854.2 ns |   3.43 ns |     4.70 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** | **VectorCacheMutable** |           **30** | **16,697.4 ns** |  **75.09 ns** |   **110.07 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 | VectorCacheMutable |           30 | 11,387.2 ns | 108.03 ns |   161.69 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |           30 |  7,731.6 ns |  74.18 ns |   111.02 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |           30 |  5,417.7 ns | 222.92 ns |   333.66 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |           30 |  8,075.9 ns |  68.89 ns |   103.11 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |           30 |  6,108.8 ns |  45.36 ns |    63.58 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |           30 |  7,994.0 ns |  55.63 ns |    77.99 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |           30 |  5,981.5 ns |  70.69 ns |   101.38 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |             **Greedy** |            **3** |  **2,099.9 ns** |  **14.12 ns** |    **20.25 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |             Greedy |            3 |  2,090.9 ns |  12.55 ns |    18.00 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |            3 |  1,010.3 ns |  10.97 ns |    15.73 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |            3 |    971.6 ns |   7.59 ns |    11.12 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |            3 |  1,048.0 ns |   8.95 ns |    13.12 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |            3 |  1,007.7 ns |   7.42 ns |    11.10 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |            3 |  1,040.5 ns |   9.19 ns |    13.19 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |            3 |  1,005.2 ns |  11.02 ns |    16.15 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |             **Greedy** |           **30** | **16,197.8 ns** | **108.15 ns** |   **158.53 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |             Greedy |           30 | 16,047.7 ns | 124.04 ns |   177.90 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |           30 |  7,395.0 ns |  58.56 ns |    85.83 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |           30 |  7,023.5 ns | 105.66 ns |   158.15 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |           30 |  7,649.5 ns |  67.55 ns |   101.10 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |           30 |  7,328.0 ns |  36.36 ns |    52.15 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |           30 |  7,719.4 ns |  48.75 ns |    69.91 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |           30 |  7,281.9 ns |  53.67 ns |    78.67 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **GreedyMutable** |            **3** |  **2,064.3 ns** |  **15.88 ns** |    **22.26 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      GreedyMutable |            3 |  2,039.2 ns |  18.11 ns |    25.39 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |            3 |    981.3 ns |  18.29 ns |    27.38 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |            3 |    964.6 ns |  16.54 ns |    23.72 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |            3 |  1,016.5 ns |   7.23 ns |    10.37 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |            3 |    962.9 ns |   4.98 ns |     6.99 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |            3 |    999.5 ns |   9.72 ns |    14.54 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |            3 |    968.2 ns |   8.01 ns |    11.75 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **GreedyMutable** |           **30** | **16,107.2 ns** | **121.62 ns** |   **174.43 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      GreedyMutable |           30 | 15,807.3 ns |  90.04 ns |   131.98 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |           30 |  7,305.3 ns |  64.24 ns |    94.16 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |           30 |  6,998.5 ns |  81.88 ns |   122.55 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |           30 |  7,631.7 ns |  64.27 ns |    92.17 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |           30 |  7,284.5 ns |  77.63 ns |   111.33 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |           30 |  7,461.1 ns |  41.84 ns |    58.66 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |           30 |  7,158.5 ns |  60.68 ns |    88.94 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |               **Lazy** |            **3** |  **9,626.0 ns** |  **80.78 ns** |   **120.91 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |               Lazy |            3 |  6,942.2 ns |  57.95 ns |    86.74 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |            3 |  3,984.4 ns |  74.81 ns |   104.87 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |            3 |  3,138.0 ns |  44.88 ns |    67.18 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |            3 |  4,203.9 ns |  26.56 ns |    38.94 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |            3 |  3,315.5 ns |  26.10 ns |    38.26 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |            3 |  4,216.1 ns |  32.64 ns |    48.86 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |            3 |  3,305.1 ns |  45.18 ns |    67.62 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |               **Lazy** |           **30** | **77,196.6 ns** | **378.12 ns** |   **554.24 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |               Lazy |           30 | 51,125.6 ns | 327.89 ns |   459.66 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |           30 | 31,956.2 ns | 352.03 ns |   516.01 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |           30 | 22,624.0 ns | 431.70 ns |   632.78 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |           30 | 33,655.0 ns | 317.77 ns |   475.62 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |           30 | 25,082.7 ns | 321.97 ns |   481.91 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |           30 | 33,545.7 ns | 328.63 ns |   481.70 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |           30 | 24,335.0 ns | 378.46 ns |   554.74 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **PropertyCache** |            **3** |  **8,910.8 ns** | **110.93 ns** |   **166.03 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      PropertyCache |            3 |  6,065.7 ns |  48.95 ns |    71.75 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |            3 |  3,863.2 ns |  46.43 ns |    69.50 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |            3 |  2,886.9 ns |  41.76 ns |    59.89 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |            3 |  4,071.7 ns |  33.50 ns |    49.11 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |            3 |  3,066.1 ns |  32.04 ns |    47.96 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |            3 |  4,018.1 ns |  25.08 ns |    35.16 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |            3 |  3,082.0 ns |  28.60 ns |    41.92 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **PropertyCache** |           **30** | **79,079.9 ns** | **578.30 ns** |   **865.58 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      PropertyCache |           30 | 51,777.8 ns | 696.68 ns | 1,042.75 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |           30 | 35,655.6 ns | 477.26 ns |   684.48 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |           30 | 25,813.4 ns | 240.10 ns |   351.93 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |           30 | 37,425.2 ns | 245.85 ns |   360.36 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |           30 | 26,284.1 ns | 151.87 ns |   217.81 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |           30 | 36,831.8 ns | 250.86 ns |   367.70 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |           30 | 26,523.8 ns | 136.60 ns |   191.49 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |        **VectorCache** |            **3** |  **2,574.1 ns** |  **17.30 ns** |    **25.35 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |        VectorCache |            3 |  1,876.1 ns |  13.36 ns |    19.59 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |            3 |  1,484.2 ns |  17.96 ns |    25.75 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |            3 |  1,110.3 ns |  13.26 ns |    19.85 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |            3 |  1,522.3 ns |   9.59 ns |    13.75 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |            3 |  1,129.6 ns |   7.03 ns |    10.52 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |            3 |  1,506.9 ns |   8.38 ns |    11.46 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |            3 |  1,133.8 ns |   5.10 ns |     7.31 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |        **VectorCache** |           **30** | **20,444.6 ns** | **168.18 ns** |   **246.51 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |        VectorCache |           30 | 13,969.0 ns | 202.06 ns |   302.44 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |           30 | 11,733.8 ns |  90.53 ns |   135.50 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |           30 |  7,877.1 ns | 105.04 ns |   153.96 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |           30 | 12,055.7 ns | 100.38 ns |   150.24 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |           30 |  7,893.3 ns |  58.21 ns |    87.13 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |           30 | 12,021.0 ns | 105.44 ns |   154.55 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |           30 |  8,021.9 ns |  93.96 ns |   131.72 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** | **VectorCacheMutable** |            **3** |  **2,503.6 ns** |  **27.00 ns** |    **40.41 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 | VectorCacheMutable |            3 |  1,806.1 ns |  27.46 ns |    40.25 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |            3 |  1,418.4 ns |  15.17 ns |    22.24 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |            3 |  1,015.9 ns |  10.16 ns |    14.90 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |            3 |  1,453.7 ns |  13.62 ns |    20.39 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |            3 |  1,076.4 ns |   6.59 ns |     9.66 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |            3 |  1,448.4 ns |  16.94 ns |    24.83 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |            3 |  1,063.2 ns |   6.25 ns |     9.36 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** | **VectorCacheMutable** |           **30** | **19,954.8 ns** | **142.41 ns** |   **199.63 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 | VectorCacheMutable |           30 | 12,812.5 ns | 162.59 ns |   243.35 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |           30 | 11,008.0 ns |  97.78 ns |   140.24 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |           30 |  7,159.9 ns | 117.04 ns |   175.18 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |           30 | 11,554.3 ns | 104.54 ns |   156.47 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |           30 |  7,659.6 ns |  60.58 ns |    86.88 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |           30 | 11,495.5 ns |  80.15 ns |   117.48 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |           30 |  7,704.2 ns |  36.61 ns |    54.79 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |             **Greedy** |            **3** |  **2,438.9 ns** |  **17.50 ns** |    **26.19 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |             Greedy |            3 |  2,259.5 ns |  16.35 ns |    24.48 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |            3 |  1,312.6 ns |   7.85 ns |    11.74 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |            3 |  1,175.2 ns |  12.89 ns |    19.29 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |            3 |  1,364.0 ns |   7.76 ns |    11.37 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |            3 |  1,181.4 ns |   3.81 ns |     5.46 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |            3 |  1,343.5 ns |  10.01 ns |    14.68 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |            3 |  1,210.4 ns |  10.67 ns |    15.65 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |             **Greedy** |           **30** | **19,014.3 ns** | **115.82 ns** |   **169.76 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |             Greedy |           30 | 17,376.7 ns |  83.16 ns |   119.27 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |           30 | 10,185.9 ns |  72.35 ns |   106.05 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |           30 |  8,450.2 ns | 179.27 ns |   262.78 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |           30 | 10,569.5 ns |  72.31 ns |   108.23 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |           30 |  8,808.7 ns | 105.96 ns |   158.60 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |           30 | 10,236.2 ns |  61.60 ns |    90.29 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |           30 |  8,777.3 ns |  39.25 ns |    56.29 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **GreedyMutable** |            **3** |  **2,353.9 ns** |  **22.72 ns** |    **34.01 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      GreedyMutable |            3 |  2,188.6 ns |  19.01 ns |    28.45 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |            3 |  1,258.1 ns |   9.32 ns |    13.66 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |            3 |  1,109.6 ns |  10.40 ns |    15.57 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |            3 |  1,288.6 ns |   7.23 ns |    10.60 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |            3 |  1,139.3 ns |   4.81 ns |     6.91 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |            3 |  1,270.7 ns |   6.83 ns |     9.79 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |            3 |  1,144.0 ns |   9.94 ns |    14.57 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **GreedyMutable** |           **30** | **18,568.8 ns** | **185.73 ns** |   **277.99 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      GreedyMutable |           30 | 17,095.8 ns | 103.47 ns |   145.05 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |           30 |  9,724.5 ns | 137.77 ns |   197.58 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |           30 |  8,127.8 ns | 147.39 ns |   220.61 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |           30 |  9,917.7 ns |  39.12 ns |    54.85 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |           30 |  8,474.2 ns |  87.47 ns |   125.44 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |           30 |  9,851.5 ns |  77.12 ns |   115.44 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |           30 |  8,556.5 ns |  74.16 ns |   111.00 ns |
