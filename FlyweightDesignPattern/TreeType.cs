using System;
namespace FlyweightDesignPattern
{
	public class TreeType
	{
		private string _name { get; set; }
        private string _color { get; set; }
        private string _texture { get; set; }

        public TreeType(string name, string color, string texture)
		{
			_name = name;
			_color = color;
			_texture = texture;
		}

		public void Draw(int x, int y)
		{
			Console.WriteLine($"Drawing tree at coordinates {x}, {y} which has color {_color}, which is called by the name of : {_name} and has a {_texture} texture");
		}
	}
}

