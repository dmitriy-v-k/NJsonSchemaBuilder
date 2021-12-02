using NJsonSchemaBuilder.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public abstract class AbstractJsonSchema<T, IT> : IJsonDocument
        where T : IAnyInstance<IT>
        where IT : IInstanceType
    {
        protected readonly T typedInstance;

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
        public string Description
        { 
            get => typedInstance.Description;
        }

        [JsonPropertyOrder(4)]
        public IT Type => typedInstance.Type;

        protected AbstractJsonSchema(T typedInstance)
        {
            this.typedInstance = typedInstance;
        }

        public string AsJsonString()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            var basicInstanceTypeConverter = new BasicInstanceTypeConverter(options);
            options.Converters.Add(basicInstanceTypeConverter);
            return JsonSerializer.Serialize<object>(this, options);
        }
    }
}
