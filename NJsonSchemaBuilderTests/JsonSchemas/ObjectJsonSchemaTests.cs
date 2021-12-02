using NUnit.Framework;
using NJsonSchemaBuilder.JsonSchemas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

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
            var expected = JsonSerializer.Serialize(
                JsonSerializer.Deserialize<object>(
                    File.ReadAllText("./TestData/schema.json")));

            var actual = schema.AsJsonString();
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }
    }
}