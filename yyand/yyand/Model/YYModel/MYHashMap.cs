using System;
using System.Collections.Generic;
using System.Linq;

namespace ZHANHUO.Model.YYModel
{
	public class MYHashMap
	{
		protected int length;

		protected Dictionary<string, object> _content;

		public Dictionary<string, object> content
		{
			get
			{
				return _content;
			}
		}

		public MYHashMap()
		{
			length = 0;
			_content = new Dictionary<string, object>();
		}

		public int size()
		{
			return length;
		}

		public bool isEmpty()
		{
			return length == 0;
		}

		public List<string> keys()
		{
			return _content.Keys.ToList();
		}

		public List<object> values()
		{
			return _content.Values.ToList();
		}

		public bool containsKey(string _arg1)
		{
			if (_content.Keys != null && _content.Keys.Contains(_arg1))
			{
				return true;
			}
			return false;
		}

		public bool containsValue(object _arg1)
		{
			if (_content.Values != null && _content.Values.Contains(_arg1))
			{
				return true;
			}
			return false;
		}

		public object get(string _arg1)
		{
			if (_content.Keys != null && _content.Keys.Contains(_arg1))
			{
				object obj = _content[_arg1];
				if (obj != null)
				{
					return obj;
				}
			}
			return null;
		}

		public void clear()
		{
			_content = new Dictionary<string, object>();
		}

		public object put(string _arg1, object _arg2)
		{
			new object();
			if (_arg1 == null)
			{
				throw new Exception("cannot put a value with undefined or null key!");
			}
			if (!containsKey(_arg1))
			{
				length++;
			}
			object result = get(_arg1);
			_content[_arg1] = _arg2;
			return result;
		}

		public object remove(string _arg1)
		{
			if (!containsKey(_arg1))
			{
				return null;
			}
			object result = _content[_arg1];
			content.Remove(_arg1);
			length--;
			return result;
		}
	}
}
