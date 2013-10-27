using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide;

namespace SimpleMonoDevelopAddin
{
	public class ShowMessageHandler : CommandHandler
	{
		protected override void Run ()
		{
			string message = String.Format(
				"App: {0}, Version: {1}",
				BrandingService.ApplicationName,
				IdeApp.Version);
			MessageService.ShowMessage(message);
		}
	}
}
