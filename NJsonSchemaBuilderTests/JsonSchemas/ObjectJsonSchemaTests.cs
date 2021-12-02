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
            schema.AddProperty(new ObjectInstanceProperty("n1", true, new StringInstance { Description = "d1" }));
        }

        [Test()]
        public void AsJsonTest()
        {
            var jsonSchema = schema.AsJsonString();
            StringAssert.AreEqualIgnoringCase("{\r\n  \"$schema\": \"https://json-schema.org/draft/2020-12/schema\",\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"n1\": {\r\n      \"type\": \"string\",\r\n      \"description\": \"d1\"\r\n    }\r\n  },\r\n  \"required\": [\r\n    \"n1\"\r\n  ]\r\n}", schema.AsJsonString());
        }
    }
}