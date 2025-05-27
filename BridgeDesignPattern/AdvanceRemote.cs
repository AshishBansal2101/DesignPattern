using System;
namespace BridgeDesignPattern
{
	public class AdvanceRemote : BasicRemote
	{
		public AdvanceRemote(IDevice device) : base(device) 
		{
		}

		public void Mute()
		{
			_device.SetVolume(0);
		}

	}
}

