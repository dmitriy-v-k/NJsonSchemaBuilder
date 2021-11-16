using System;
using System.Collections.Generic;
using System.Text;

namespace NJsonSchemaBuilder
{
    internal interface IBuilder<T>
    {
        T Build();
    }
}
