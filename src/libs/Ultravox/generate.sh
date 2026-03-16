dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.ultravox.ai/api/schema/
autosdk generate openapi.yaml \
  --namespace Ultravox \
  --clientClassName UltravoxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ultravox.ai \
  --security-scheme ApiKey:Header:X-API-Key
