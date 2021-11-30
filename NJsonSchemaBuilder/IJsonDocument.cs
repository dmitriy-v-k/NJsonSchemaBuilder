using System.Text.Json;

namespace NJsonSchemaBuilder
{
    public interface IJsonDocument
    {
        string AsJsonString();
    }
}