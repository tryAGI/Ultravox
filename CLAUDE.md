# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Ultravox](https://ultravox.ai/) voice AI platform, auto-generated from the Ultravox OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Ultravox.slnx

# Build for release (also produces NuGet package)
dotnet build Ultravox.slnx -c Release

# Run integration tests (requires ULTRAVOX_API_KEY env var)
dotnet test src/tests/IntegrationTests/Ultravox.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Ultravox && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Ultravox/Generated/`.

1. `src/libs/Ultravox/openapi.yaml` -- the Ultravox OpenAPI spec (fetched from `https://api.ultravox.ai/api/schema/`)
3. `src/libs/Ultravox/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Ultravox/` | Main SDK library (`UltravoxClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Ultravox API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
