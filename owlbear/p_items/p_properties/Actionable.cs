using System;
namespace Items.Properties
{
	public interface Actionable
	{
		int range { get; set; }
		string[] tags { get; }
		ItemAction action { get; set; }

		public ItemAction DoAction();

	}
}

