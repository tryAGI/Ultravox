
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Specification for a voice served by some generic REST-based TTS API. The API must<br/>
    ///  accept an application/json POST request (as defined below) and return either WAV<br/>
    ///  or raw PCM audio with an appropriate Content-Type response header.<br/>
    ///  Note that this simple API implies a lack of either input streaming or audio timing<br/>
    ///  information, so more specific voice types are preferable when available.
    /// </summary>
    public sealed partial class UltravoxV1GenericVoice
    {
        /// <summary>
        /// The endpoint to which requests are sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Headers to include in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The request body to send. Some field should include a placeholder for text<br/>
        ///  represented as {text}. The placeholder will be replaced with the text to synthesize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// The sample rate of the audio returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseSampleRate")]
        public int? ResponseSampleRate { get; set; }

        /// <summary>
        /// An estimate of the speaking rate of the returned audio in words per minute. This is<br/>
        ///  used for transcript timing while audio is streamed in the response. (Once the response<br/>
        ///  is complete, Ultravox Realtime uses the real audio duration to adjust the timing.)<br/>
        ///  Defaults to 150 and is unused for non-streaming responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseWordsPerMinute")]
        public int? ResponseWordsPerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1GenericVoice" /> class.
        /// </summary>
        /// <param name="url">
        /// The endpoint to which requests are sent.
        /// </param>
        /// <param name="headers">
        /// Headers to include in the request.
        /// </param>
        /// <param name="body">
        /// The request body to send. Some field should include a placeholder for text<br/>
        ///  represented as {text}. The placeholder will be replaced with the text to synthesize.
        /// </param>
        /// <param name="responseSampleRate">
        /// The sample rate of the audio returned by the API.
        /// </param>
        /// <param name="responseWordsPerMinute">
        /// An estimate of the speaking rate of the returned audio in words per minute. This is<br/>
        ///  used for transcript timing while audio is streamed in the response. (Once the response<br/>
        ///  is complete, Ultravox Realtime uses the real audio duration to adjust the timing.)<br/>
        ///  Defaults to 150 and is unused for non-streaming responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1GenericVoice(
            string? url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? body,
            int? responseSampleRate,
            int? responseWordsPerMinute)
        {
            this.Url = url;
            this.Headers = headers;
            this.Body = body;
            this.ResponseSampleRate = responseSampleRate;
            this.ResponseWordsPerMinute = responseWordsPerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1GenericVoice" /> class.
        /// </summary>
        public UltravoxV1GenericVoice()
        {
        }
    }
}