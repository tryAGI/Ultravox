# Ultravox

[![Nuget package](https://img.shields.io/nuget/vpre/Ultravox)](https://www.nuget.org/packages/Ultravox/)
[![dotnet](https://github.com/tryAGI/Ultravox/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Ultravox/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Ultravox)](https://github.com/tryAGI/Ultravox/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Ultravox OpenAPI specification](https://raw.githubusercontent.com/Ultravox/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Ultravox;

using var client = new UltravoxClient(apiKey);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Ultravox/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Ultravox/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).