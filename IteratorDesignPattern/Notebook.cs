using System.Collections;

namespace IteratorDesignPattern
{
	public class Notebook : NotebookEnumerable
	{
		public List<string> pages = new();
		private bool _reverse = false;
		public Notebook()
		{

		}

		public void AddPage(string page)
		{
			pages.Add(page);
		}

		public void SetReverse()
		{
			_reverse = !_reverse;
		}

        public override IEnumerator GetEnumerator()
        {
			return new NotebookPageIterator(this, _reverse);
        }

       
	}
}

