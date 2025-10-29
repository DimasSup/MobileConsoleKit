using System;

namespace MobileConsole
{
	public class Command
	{
		public CommandInfo info = new CommandInfo();
		public Action refreshUI;

		public virtual void InitDefaultVariableValue() {}

		public virtual void OnVariableValueLoaded() {}

		public virtual void Execute() {}

		public virtual void OnValueChanged(string varName) {}
	}
}