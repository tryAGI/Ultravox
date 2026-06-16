#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.ultravox.ai/api/schema/ (+ AsyncAPI)
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://api.ultravox.ai/api/schema/
autosdk generate openapi.yaml \
  --namespace Ultravox \
  --clientClassName UltravoxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ultravox.ai \
  --security-scheme ApiKey:Header:X-API-Key

autosdk generate asyncapi.json \
  --namespace Ultravox.Realtime \
  --websocket-class-name UltravoxRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated
