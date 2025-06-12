using System;
namespace FlyweightDesignPattern
{
	public class Forest
	{
		private readonly List<Tree> _trees;
		private readonly TreeFactory _treeFactory;
		public Forest()
		{
			_trees = new();
			_treeFactory = new();
        }

		public void AddTree(string name, string color, string texture, int x, int y)
		{
			TreeType treeType = _treeFactory.GetTreeType(name, color, texture);
			Tree tree= new Tree(x, y, treeType);
			_trees.Add(tree);
		}

		public void DrawTrees()
		{
			foreach(var tree in _trees)
			{
				tree.DrawTree();
			}
		}

		public void ShowTypes()
		{
			_treeFactory.AllTreeTypes();
		}
	}
}

