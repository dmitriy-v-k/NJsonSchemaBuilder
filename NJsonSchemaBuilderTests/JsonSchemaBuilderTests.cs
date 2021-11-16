using NUnit.Framework;
using NJsonSchemaBuilder;
using System;
using System.Collections.Generic;
using System.Text;
using NJsonSchemaBuilder.JsonSchemas;

namespace NJsonSchemaBuilder.Tests
{
    [TestFixture]
    public class JsonSchemaBuilderTests
    {
        private JsonSchemaBuilder builder;

        [SetUp]
        public void BeforeEach()
        {
            builder = new JsonSchemaBuilder();
        }

        [Test]
        public void BuildTest()
        {
            Assert.IsInstanceOf<IJsonSchema>(builder.Build());
        }
    }
}