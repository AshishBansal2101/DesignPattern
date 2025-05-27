using System;
using System.Collections;

namespace IteratorDesignPattern
{
	public abstract class NotebookEnumerable : IEnumerable
	{
        public abstract IEnumerator GetEnumerator();
    }
}

