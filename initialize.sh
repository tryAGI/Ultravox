dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Ultravox \
  UltravoxClient \
  https://api.ultravox.ai/api/schema/ \
  tryAGI \
  --output .
