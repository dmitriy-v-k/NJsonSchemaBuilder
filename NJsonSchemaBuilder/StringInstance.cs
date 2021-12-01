using System.Collections.Generic;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public class StringInstance : IStringInstance
    {
        public string Type => "string";

        public string Description { get; set; }
    }
}