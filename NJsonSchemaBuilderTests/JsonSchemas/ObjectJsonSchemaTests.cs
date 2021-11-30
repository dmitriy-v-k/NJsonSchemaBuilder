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
            schema.Schema = new Uri("https://json-schema.org/draft/2020-12/schema");
        }

        [Test()]
        public void AsJsonTest()
        {
            var jsonSchema = schema.AsJsonString();
            StringAssert.AreEqualIgnoringCase("{}", schema.AsJsonString());
        }
    }
}