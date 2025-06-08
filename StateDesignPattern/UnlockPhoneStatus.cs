using System;
namespace StateDesignPattern
{
	public class UnlockPhoneStatus : PhoneState
	{
		public UnlockPhoneStatus()
		{
		}

        public override void PlugInCharger()
        {
            Console.WriteLine("Charing Phone in Unlocked Phone Status -> PLAY GAMES WHILE CHARGING");
        }

        public override void PressPowerButton()
        {
            Console.WriteLine("Power Button pressed from unlocked screen ---> switching to locked screen __ GET OUT CANT DO ANYTHING");
            _phone.TransitionState(new LockedPhoneStatus());
        }
    }
}

