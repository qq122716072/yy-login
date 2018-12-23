using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace 战火协议.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	[CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default
		{
			get
			{
				return defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ZhanHuo.mdf;Integrated Security=True;Connect Timeout=30")]
		[ApplicationScopedSetting]
		public string ZhanHuoConnectionString
		{
			get
			{
				return (string)this["ZhanHuoConnectionString"];
			}
		}

		static Settings()
		{
			defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
