namespace BridgeDesignPattern
{
	public class BasicRemote
	{
		protected IDevice _device;
		public BasicRemote(IDevice device)
		{
			_device = device;
		}

		public virtual void ToggleSwitch()
		{
			_device.ToggleSwitch();
			_device.GetStatus();
		}

		public virtual void SetChannel(int channel)
		{
			_device.SetChannel(channel);
		}

		public virtual void UpVolume()
		{
			_device.SetVolume(_device.GetVolume() + 1);
		}

        public virtual void DownVolume()
        {
            _device.SetVolume(_device.GetVolume() - 1);
        }
    }
}

