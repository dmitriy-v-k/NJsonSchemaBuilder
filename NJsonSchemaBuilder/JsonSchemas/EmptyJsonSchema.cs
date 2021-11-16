using System;
using System.Collections.Generic;
using System.Text;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public sealed class EmptyJsonSchema : IJsonSchema
    {
        public string AsJson()
        {
            return "{}";
        }
    }
}
