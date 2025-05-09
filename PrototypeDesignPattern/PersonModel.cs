namespace PrototypeDesignPattern
{
	public class PersonModel 
	{
		public string? Name { get; set; }
        public int Age { get; set; }
		public IdInfo? Info { get; set; }

		public PersonModel ShallowCopy()
		{
			return (PersonModel)MemberwiseClone();
		}
		public PersonModel DeepCopy()
		{
			PersonModel copy = (PersonModel)MemberwiseClone();
			copy.Info = new IdInfo(Info?.Id);
			return copy;
        }
	}

	public class IdInfo
	{
		public int? Id { get; set; }
		public IdInfo(int? id)
		{
			Id = id;
		}
	}
}

