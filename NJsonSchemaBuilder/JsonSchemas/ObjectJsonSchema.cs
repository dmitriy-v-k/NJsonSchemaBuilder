using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public sealed class ObjectJsonSchema : AbstractJsonSchema
    {
        [JsonPropertyOrder(5)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Properties { get; set; }

        [JsonPropertyOrder(6)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Required { get; set; }

        public ObjectJsonSchema():
            base("object")
        {
            Required = new List<string>
            {
                "test",
            };

            Properties = new Dictionary<string, string>
            {
                {"test", "test"},
            };
        }
    }
}
