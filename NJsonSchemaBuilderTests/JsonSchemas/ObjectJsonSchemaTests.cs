using NUnit.Framework;
using NJsonSchemaBuilder.JsonSchemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace NJsonSchemaBuilder.JsonSchemas.Tests
{
    [TestFixture()]
    public class ObjectJsonSchemaTests
    {
        private ObjectJsonSchema schema;

        [SetUp]
        public void BeforeEach()
        {
            schema = new ObjectJsonSchema();
        }

        [Test()]
        public void AsJsonTest()
        {
            StringAssert.AreEqualIgnoringCase("{}", schema.AsJson());
        }
    }
}