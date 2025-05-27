using System;
namespace BridgeDesignPattern
{
	public class Television : IDevice
	{
        private int _volume = 10;
        private bool _isOn = false;
        private int _channel = 100;
		public Television()
		{
		}

        public int GetVolume()
        {
            return _volume;
        }

        public void GetStatus()
        {
            Console.WriteLine("TV: Current Status switch button is  :  " + _isOn + "  channel number is   " + _channel);
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine("TV: Channel is set to :" + channel);

        }

        public void ToggleSwitch()
        {
            _isOn = !_isOn;
        }

        public void UpVolume()
        {
            _volume += 1;
            Console.WriteLine("TV: Volumn is increased by 1 to :" + _volume);
        }

        public void SetVolume(int vol)
        {
            _volume = vol;
            Console.WriteLine("Volumn is set in TV to :" + _volume);
        }
    }
}

