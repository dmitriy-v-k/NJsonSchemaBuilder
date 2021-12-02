namespace NJsonSchemaBuilder.JsonSchemas
{
    public interface IAnyInstance<out IT>
        where IT : IInstanceType
    {
        IT Type { get; }

        string Description { get; }
    }
}