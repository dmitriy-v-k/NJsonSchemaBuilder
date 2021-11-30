using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public abstract class AbstractJsonSchema: IJsonDocument
    {
        private readonly string type;

        [JsonPropertyName("$schema")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyOrder(0)]
        public Uri Schema { get; set; }

        [JsonPropertyName("$id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyOrder(1)]
        public Uri Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyOrder(2)]
        public string Title { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyOrder(3)]
        public string Description { get; set; }

        [JsonPropertyOrder(4)]
        public string Type => type;

        protected AbstractJsonSchema(string type)
        {
            this.type = type;
        }

        public string AsJsonString()
        {
            return JsonSerializer.Serialize<object>(this, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            });
        }
    }
}
