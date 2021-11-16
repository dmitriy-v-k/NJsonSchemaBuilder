using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public sealed class EmptyJsonSchema : AbstractJsonSchema
    {
        protected override void WriteContent(Utf8JsonWriter jsonWriter)
        {
        }
    }
}
