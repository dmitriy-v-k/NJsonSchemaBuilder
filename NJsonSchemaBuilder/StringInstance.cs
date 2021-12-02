using System.Collections.Generic;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public class StringInstance : IStringInstance
    {
        public BasicInstanceType Type => new BasicInstanceType("string");

        public string Description { get; set; }
    }
}