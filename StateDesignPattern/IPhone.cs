namespace StateDesignPattern
{
    public interface IPhone
	{
		void PressPowerButton();
		void PlugInCharger();
		void TransitionState(PhoneState phoneState);
	}
}

