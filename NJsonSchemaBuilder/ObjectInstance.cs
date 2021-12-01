using System.Collections.Generic;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public class ObjectInstance : IObjectInstance<ObjectInstance>
    {
        public string Type => "object";

        public string Description { get; private set; }

        public IDictionary<string, object> Properties { get; private set; }

        public IList<string> Required { get; private set; }

        public ObjectInstance AddProperty(IObjectInstanceProperty objectInstanceProperty)
        {
            if (Properties is null)
            {
                Properties = new Dictionary<string, object>();
            }
            Properties.Add(objectInstanceProperty.Name, objectInstanceProperty.Object);

            if(Required is null)
            {
                Required = new List<string>();
            }
            if(objectInstanceProperty.IsRequired)
            {
                Required.Add(objectInstanceProperty.Name);
            }

            return this;
        }
    }
}