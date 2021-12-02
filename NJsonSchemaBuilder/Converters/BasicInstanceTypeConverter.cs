using NJsonSchemaBuilder.JsonSchemas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NJsonSchemaBuilder.Converters
{
    internal class BasicInstanceTypeConverter : JsonConverter<BasicInstanceType>
	{
		private readonly JsonSerializerOptions ConverterOptions;
		public BasicInstanceTypeConverter(JsonSerializerOptions converterOptions)
		{
			ConverterOptions = converterOptions;
		}
		public override BasicInstanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			//Very important: Pass in ConverterOptions here, not the 'options' method parameter.
			return JsonSerializer.Deserialize<BasicInstanceType>(ref reader, ConverterOptions);
		}

		public override void Write(Utf8JsonWriter writer, BasicInstanceType value, JsonSerializerOptions options)
		{
			//Very important: Pass in ConverterOptions here, not the 'options' method parameter.
			JsonSerializer.Serialize(writer, value.TypeValue, ConverterOptions);
		}
	}
}
