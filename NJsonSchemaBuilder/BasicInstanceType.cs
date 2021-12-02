namespace NJsonSchemaBuilder.JsonSchemas
{
    public class BasicInstanceType : IInstanceType
    {
        public string TypeValue { get; }

        public BasicInstanceType(string typeValue)
        {
            TypeValue = typeValue;
        }
    }
}