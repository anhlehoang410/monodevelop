// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using MonoDevelop.Core;

namespace MonoDevelop.AspNet.Gui
{	
	partial class AspNetConfigurationPanelWidget : Gtk.Bin
	{
		public AspNetConfigurationPanelWidget ()
		{
			this.Build();
		}
		
		public void Load (AspNetAppProjectConfiguration configuration)
		{
			disableCodeBehindGeneration.Active = configuration.DisableCodeBehindGeneration;
		}
		
		public void Store (AspNetAppProjectConfiguration configuration)
		{				
			configuration.DisableCodeBehindGeneration = disableCodeBehindGeneration.Active;
		}
	}
}
