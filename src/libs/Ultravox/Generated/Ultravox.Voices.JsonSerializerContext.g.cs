
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStyleEnum), TypeInfoPropertyName = "BillingStyleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ExternalVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OwnershipEnum), TypeInfoPropertyName = "OwnershipEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedVoiceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1LmntVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GoogleVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1RespeecherVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding), TypeInfoPropertyName = "UltravoxV1GenericVoiceJsonByteEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode), TypeInfoPropertyName = "UltravoxV1InworldVoiceDeliveryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListBillingStyle), TypeInfoPropertyName = "VoicesListBillingStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListOwnership), TypeInfoPropertyName = "VoicesListOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListProviderItem), TypeInfoPropertyName = "VoicesListProviderItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStyleEnum?), TypeInfoPropertyName = "NullableBillingStyleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OwnershipEnum?), TypeInfoPropertyName = "NullableOwnershipEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?), TypeInfoPropertyName = "NullableUltravoxV1GenericVoiceJsonByteEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?), TypeInfoPropertyName = "NullableUltravoxV1InworldVoiceDeliveryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListBillingStyle?), TypeInfoPropertyName = "NullableVoicesListBillingStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListOwnership?), TypeInfoPropertyName = "NullableVoicesListOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListProviderItem?), TypeInfoPropertyName = "NullableVoicesListProviderItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Ultravox.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Ultravox.BillingStyleEnum)

                    || typeToConvert == typeof(global::Ultravox.BillingStyleEnum?)

                    || typeToConvert == typeof(global::Ultravox.OwnershipEnum)

                    || typeToConvert == typeof(global::Ultravox.OwnershipEnum?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?)

                    || typeToConvert == typeof(global::Ultravox.VoicesListBillingStyle)

                    || typeToConvert == typeof(global::Ultravox.VoicesListBillingStyle?)

                    || typeToConvert == typeof(global::Ultravox.VoicesListOwnership)

                    || typeToConvert == typeof(global::Ultravox.VoicesListOwnership?)

                    || typeToConvert == typeof(global::Ultravox.VoicesListProviderItem)

                    || typeToConvert == typeof(global::Ultravox.VoicesListProviderItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ultravox.BillingStyleEnum))
                {
                    return new global::Ultravox.JsonConverters.BillingStyleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.BillingStyleEnum?))
                {
                    return new global::Ultravox.JsonConverters.BillingStyleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.OwnershipEnum))
                {
                    return new global::Ultravox.JsonConverters.OwnershipEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.OwnershipEnum?))
                {
                    return new global::Ultravox.JsonConverters.OwnershipEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1InworldVoiceDeliveryModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1InworldVoiceDeliveryModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListBillingStyle))
                {
                    return new global::Ultravox.JsonConverters.VoicesListBillingStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListBillingStyle?))
                {
                    return new global::Ultravox.JsonConverters.VoicesListBillingStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListOwnership))
                {
                    return new global::Ultravox.JsonConverters.VoicesListOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListOwnership?))
                {
                    return new global::Ultravox.JsonConverters.VoicesListOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListProviderItem))
                {
                    return new global::Ultravox.JsonConverters.VoicesListProviderItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.VoicesListProviderItem?))
                {
                    return new global::Ultravox.JsonConverters.VoicesListProviderItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}