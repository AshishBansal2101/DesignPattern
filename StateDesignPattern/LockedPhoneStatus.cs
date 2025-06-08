using System;
namespace StateDesignPattern
{
	public class LockedPhoneStatus : PhoneState
	{
		public LockedPhoneStatus()
		{
		}

        public override void PlugInCharger()
        {
            Console.WriteLine("Charging Phone in locked Phone Status __ NOTHING TO DOOO");
        }

        public override void PressPowerButton()
        {
            Console.WriteLine("Power Button pressed from locked screen ---> SWITCHED ON PHONE PLAY GAMESSSS");
            _phone.TransitionState(new UnlockPhoneStatus());
        }
    }
}

