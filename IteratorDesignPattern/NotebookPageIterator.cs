namespace IteratorDesignPattern
{
	public class NotebookPageIterator : PageIterator
	{
        private readonly Notebook _notebook;
        private readonly bool _reverse;
        private int _position;
		public NotebookPageIterator(Notebook notebook, bool reverse)
		{
            _notebook = notebook;
            _reverse = reverse;
            _position = reverse ? notebook.pages.Count : -1;
		}

        public override object GetCurrentPage()
        {
           return _notebook.pages[_position];
        }

        public override bool MoveNext()
        {
            _position += _reverse ? -1 : 1;
            return _reverse ? _position >= 0 : _position < _notebook.pages.Count;
            //return _position < _notebook.pages.Count && _position >= 0;

        }

        public override void Reset()
        {
           _position =  _reverse? _notebook.pages.Count-1 : 0;
        }
    }
}

