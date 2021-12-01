namespace NJsonSchemaBuilder.JsonSchemas
{
    public class ObjectInstanceProperty: IObjectInstanceProperty
    {
        public string Name { get; private set; }
        public bool IsRequired { get; private set; }
        public IAnyInstance Object { get; private set; }

        public ObjectInstanceProperty(string name, bool isRequired, IAnyInstance @object)
        {
            Name = name;
            IsRequired = isRequired;
            Object = @object;
        }
    }
}