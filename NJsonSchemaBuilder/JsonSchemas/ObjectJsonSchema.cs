using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public sealed class ObjectJsonSchema : IJsonSchema
    {
        public string AsJson()
        {
            using var stream = new MemoryStream();
            using var jsonWriter = new Utf8JsonWriter(stream);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
