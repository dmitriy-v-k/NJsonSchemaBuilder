using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public sealed class ObjectJsonSchema :
        AbstractJsonSchema<IObjectInstance<ObjectInstance>, BasicInstanceType>,
        IObjectInstance<ObjectJsonSchema>
    {

        [JsonPropertyOrder(5)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IDictionary<string, object> Properties { get => typedInstance.Properties; }

        [JsonPropertyOrder(6)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IList<string> Required { get => typedInstance.Required; }

        public ObjectJsonSchema() :
            base(new ObjectInstance())
        {
        }

        public ObjectJsonSchema AddProperty(IObjectInstanceProperty objectInstanceProperty)
        {
            typedInstance.AddProperty(objectInstanceProperty);
            return this;
        }
    }
}
