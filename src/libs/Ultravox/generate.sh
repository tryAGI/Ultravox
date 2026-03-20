set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://api.ultravox.ai/api/schema/
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
