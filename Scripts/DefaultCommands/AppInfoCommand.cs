using MobileConsole.UI;

namespace MobileConsole
{
	[ExecutableCommand(name = "System/App and device info")]
	public class AppInfoCommand : Command
	{
		AppInfoViewBuilder _viewBuilder = new AppInfoViewBuilder();

		public override void Execute()
		{
			this.info.actionAfterExecuted = ActionAfterExecuted.DoNothing;
			LogConsole.PushSubView(_viewBuilder);
		}
	}

	public class AppInfoViewBuilder : ViewBuilder
	{
		Node _infoNode;
		public AppInfoViewBuilder()
		{
			actionButtonIcon = "share";
			actionButtonCallback = Share;
			actionAfterExecuted = ActionAfterExecuted.CloseAllSubView;

			Node node = CreateCategory("App and device info", "command");
			_infoNode = AddResizableText("", node);
		}

		public override void OnPrepareToShow()
		{
			base.OnPrepareToShow();
			_infoNode.name = AppAndDeviceInfo.FullInfos();
		}

		public void Share()
		{
			NativeShare.Share(_infoNode.name);
		}
	}
}
