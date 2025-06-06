// <auto-generated/>

//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

using JSONREADER = System.Text.Json.Utf8JsonReader;
using JSONWRITER = System.Text.Json.Utf8JsonWriter;
using FIELDINFO = SharpGLTF.Reflection.FieldInfo;


namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// glTF extension that defines the sheen material model.
	/// </summary>
	#if NET6_0_OR_GREATER
	[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.NonPublicConstructors | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)]
	#endif
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("SharpGLTF.CodeGen", "1.0.0.0")]
	partial class MaterialSheen : ExtraProperties
	{
	
		#region reflection
	
		public new const string SCHEMANAME = "KHR_materials_sheen";
		protected override string GetSchemaName() => SCHEMANAME;
	
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			yield return "sheenColorFactor";
			yield return "sheenColorTexture";
			yield return "sheenRoughnessFactor";
			yield return "sheenRoughnessTexture";
			foreach(var f in base.ReflectFieldsNames()) yield return f;
		}
		protected override bool TryReflectField(string name, out FIELDINFO value)
		{
			switch(name)
			{
				case "sheenColorFactor": value = FIELDINFO.From("sheenColorFactor",this, instance => instance._sheenColorFactor ?? Vector3.Zero); return true;
				case "sheenColorTexture": value = FIELDINFO.From("sheenColorTexture",this, instance => instance._sheenColorTexture); return true;
				case "sheenRoughnessFactor": value = FIELDINFO.From("sheenRoughnessFactor",this, instance => instance._sheenRoughnessFactor ?? 0); return true;
				case "sheenRoughnessTexture": value = FIELDINFO.From("sheenRoughnessTexture",this, instance => instance._sheenRoughnessTexture); return true;
				default: return base.TryReflectField(name, out value);
			}
		}
	
		#endregion
	
		#region data
	
		private static readonly Vector3 _sheenColorFactorDefault = Vector3.Zero;
		private Vector3? _sheenColorFactor = _sheenColorFactorDefault;
		
		private TextureInfo _sheenColorTexture;
		
		private const Single _sheenRoughnessFactorDefault = 0;
		private const Single _sheenRoughnessFactorMinimum = 0;
		private const Single _sheenRoughnessFactorMaximum = 1;
		private Single? _sheenRoughnessFactor = _sheenRoughnessFactorDefault;
		
		private TextureInfo _sheenRoughnessTexture;
		
		#endregion
	
		#region serialization
	
		protected override void SerializeProperties(JSONWRITER writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "sheenColorFactor", _sheenColorFactor, _sheenColorFactorDefault);
			SerializePropertyObject(writer, "sheenColorTexture", _sheenColorTexture);
			SerializeProperty(writer, "sheenRoughnessFactor", _sheenRoughnessFactor, _sheenRoughnessFactorDefault);
			SerializePropertyObject(writer, "sheenRoughnessTexture", _sheenRoughnessTexture);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref JSONREADER reader)
		{
			switch (jsonPropertyName)
			{
				case "sheenColorFactor": DeserializePropertyValue<MaterialSheen, Vector3?>(ref reader, this, out _sheenColorFactor); break;
				case "sheenColorTexture": DeserializePropertyValue<MaterialSheen, TextureInfo>(ref reader, this, out _sheenColorTexture); break;
				case "sheenRoughnessFactor": DeserializePropertyValue<MaterialSheen, Single?>(ref reader, this, out _sheenRoughnessFactor); break;
				case "sheenRoughnessTexture": DeserializePropertyValue<MaterialSheen, TextureInfo>(ref reader, this, out _sheenRoughnessTexture); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
		#endregion
	
	}

}
