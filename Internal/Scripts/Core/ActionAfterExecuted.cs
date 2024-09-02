namespace MobileConsole
{
	public enum ActionAfterExecuted
	{
		DoNothing,
		CloseAllSubView,
		CloseConsole,
	}

	public static class ActionAfterExecutedExtensions
	{
		public static void Process(this ActionAfterExecuted action)
		{
			switch (action)
			{
				case ActionAfterExecuted.CloseAllSubView:
					LogConsole.CloseAllSubView();
					break;
				case ActionAfterExecuted.CloseConsole:
					LogConsole.CloseAllSubView();
					LogConsole.ToggleShow();
					break;
			}
		}
	}
}
