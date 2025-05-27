using System;
using System.Collections;

namespace IteratorDesignPattern
{
	public abstract class PageIterator : IEnumerator
	{
		public abstract bool MoveNext();
		public abstract object GetCurrentPage();
		object IEnumerator.Current => GetCurrentPage();
		public abstract void Reset();
	}
}

