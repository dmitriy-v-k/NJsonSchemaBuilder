namespace NJsonSchemaBuilder.JsonSchemas
{
    public interface IObjectInstanceProperty
    {
        public string Name { get; }
        public bool IsRequired { get; }
        public IAnyInstance Object { get; }
    }
}