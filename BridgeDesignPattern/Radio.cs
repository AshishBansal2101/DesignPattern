using System;
namespace BridgeDesignPattern
{
    public class Radio : IDevice
    {
        private int _volume = 10;
        private bool _isOn = false;
        private int _channel = 100;
        public Radio()
        {
        }

        public void GetStatus()
        {
            Console.WriteLine("Radio: Current Status switch button is  :   " + _isOn + "   channel number is  " + _channel);
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine("Channel is set to in radio:" + channel);

        }

        public void SetVolume(int vol)
        {
            _volume = vol;
            Console.WriteLine("Volumn is set in radio to :" + _volume);
        }

        public void ToggleSwitch()
        {
            _isOn = !_isOn;
        }

        public void UpVolume()
        {
            _volume += 1;
            Console.WriteLine("Volumn is increased by 1 in radio to :" + _volume);
        }
    }
}

