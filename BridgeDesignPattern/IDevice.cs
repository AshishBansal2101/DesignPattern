using System;
namespace BridgeDesignPattern
{
	public interface IDevice
	{
		void SetVolume(int vol);
		int GetVolume();
		void ToggleSwitch();
		void GetStatus();
		void SetChannel(int channel);
	}
}

