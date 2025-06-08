using System;
namespace StateDesignPattern
{
	public class Phone : IPhone
	{
        private PhoneState _phoneState;

		public Phone(PhoneState phoneState)
		{
            TransitionState(phoneState);
        }

        public void PlugInCharger()
        {
            _phoneState.PlugInCharger();
        }

        public void PressPowerButton()
        {
            _phoneState.PressPowerButton();

        }

        public void TransitionState(PhoneState phoneState)
        {
            Console.WriteLine($"State is Set to  {phoneState.GetType().Name}");
            _phoneState = phoneState;
            _phoneState.SetPhoneState(this);

        }
    }
}

