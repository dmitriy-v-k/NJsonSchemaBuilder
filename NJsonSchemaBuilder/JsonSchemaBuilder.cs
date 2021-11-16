using NJsonSchemaBuilder.JsonSchemas;
using System;

namespace NJsonSchemaBuilder
{
    public sealed class JsonSchemaBuilder : IBuilder<IJsonSchema>
    {
        public IJsonSchema Build()
        {
            return new EmptyJsonSchema();
        }
    }
}
