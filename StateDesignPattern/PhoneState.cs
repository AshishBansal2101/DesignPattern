using System;
namespace StateDesignPattern
{
	public abstract class PhoneState
	{
        protected IPhone _phone;

        public void SetPhoneState(IPhone phone)
        {
			_phone = phone;
        }

        public abstract void PlugInCharger();
		public abstract void PressPowerButton();
        
    }
}

