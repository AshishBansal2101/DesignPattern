using System;
namespace StateDesignPattern
{
	public class LowBatteryPhoneStatus : PhoneState
	{
		public LowBatteryPhoneStatus()
		{
		}

        public override void PlugInCharger()
        {
            Console.WriteLine("BATTERY IS VERY LOW___ LET IT CHARGE ... GO AWAY NOWW");
            _phone.TransitionState(new LockedPhoneStatus());
        }

        public override void PressPowerButton()
        {
            Console.WriteLine("CHARGE YOUR PHONE... DONT PLAY AROUNDDDDD");
        }
    }
}

