using System;
namespace FlyweightDesignPattern
{
	public class Tree
	{
		private readonly int _x;
		private readonly int _y;
		private readonly TreeType _treeType;
		public Tree(int x,int y, TreeType treeType)
		{
			_x = x;
			_y = y;
			_treeType = treeType;
		}

		public void DrawTree()
		{
			_treeType.Draw(_x, _y);
		}
	}
}

