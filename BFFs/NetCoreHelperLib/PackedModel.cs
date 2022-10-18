using System.Text.Json.Serialization;

namespace NetCoreHelperLib
{
    public class PackedModel
    {
        [JsonPropertyName("b")]
        public byte[] ByteArray { get; set; }

        [JsonPropertyName("p")]
        public uint PackedSize { get; set; }
    }
}
