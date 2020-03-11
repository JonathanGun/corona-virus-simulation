# Corona-virus-simulator
Corona-virus-simulator is a corona virus spreading pandemic simulator that utilizes C# .NET WinForms and MSAGL to show the spread of the virus

## Installation
1. Install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
1. Install [Microsoft MSAGL](https://www.nuget.org/packages/Microsoft.Msagl/) package from Package Manager
1. Install [Microsoft MSAGL Graph Viewer GDI](https://www.nuget.org/packages/Microsoft.Msagl.GraphViewerGDI/) package from Package Manager
1. Install [Microsoft MSAGL Drawing](https://www.nuget.org/packages/Microsoft.Msagl.Drawing/) package drom Package Manager

## Usage
Currently only supports Windows .NET Platform

1. Run `Corruption.exe`
2. Select Population Config file,

you can create your own population config with the format
```
[Number of Cities] [Start City]
[City 1] [Population1]
[City 2] [Population2]
[City 3] [Population3]
...
[City n] [PopulationN]
```

or use this example
```
7 WHN
WHN 2000
SGP 5000
MLY 8000
THA 10000
JKT 3000
BDG 1500
HKG 1000
```
save as txt file

3. Select Map Config file,

you can create your own map config with the format
```
[Number of Connection Between Cities]
[City From 1] [City To 1] [Transfer Rate / Travelling Rate 1]
[City From 2] [City To 2] [Transfer Rate / Travelling Rate 2]
[City From 3] [City To 3] [Transfer Rate / Travelling Rate 3]
...
[City From N] [City To N] [Transfer Rate / Travelling Rate N]
```
or use this example
```
22
WHN SGP 0.001
WHN THA 0.001
WHN MLY 0.002
THA WHN 0.0008
SGP WHN 0.0004
SGP MLY 0.005
MLY SGP 0.015
SGP JKT 0.005
MLY JKT 0.006
JKT SGP 0.01
JKT MLY 0.005
HKG JKT 0.004
WHN HKG 0.001
THA SGP 0.001
THA HKG 0.0008
HKG THA 0.0006
HKG MLY 0.001
JKT BDG 0.02
SGP BDG 0.0008
MLY BDG 0.001
BDG MLY 0.001
BDG THA 0.0004
```
save as txt file

4. Fill number of days to simulate
5. Simulate!
6. Click reset to start over with new config files or just enter the new number of days to simulate with the same config files

## Editing and Contributing
1. Open Project Solution (`Corruption.sln`) using Visual Studio

## Acknowledgement
This project is made to fulfill IF2211 Algorithm Strategy course.

## Contributors
This project is created by :
- Jovan Karuna Cahyadi
- Jonathan Yudi Gunawan
- William
