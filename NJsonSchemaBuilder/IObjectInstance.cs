using System.Collections.Generic;

namespace NJsonSchemaBuilder.JsonSchemas
{
    public interface IObjectInstance<out T>: IAnyInstance
        where T : IObjectInstance<T>
    {
        IDictionary<string, object> Properties { get; }

        IList<string> Required { get; }

        T AddProperty(IObjectInstanceProperty objectInstanceProperty);
    }
}