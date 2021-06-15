using System;
using System.Collections;

namespace MTDecisionTreeID3
{
    public class AttributeID3
	{
		private ArrayList mValues;
		private object mLabel;
        private string mName;

		public AttributeID3(object label)
		{
			mLabel = label;
			mName = string.Empty;
			mValues = null;
		}

		public AttributeID3(string name, string[] values)
		{
			mName = name;
			mValues = new ArrayList(values);
			mValues.Sort();
		}

		public string AttributeName
		{
			get
			{
				return mName;
			}
		}

		public string[] Values
		{
			get
			{
				if (mValues != null)
					return (string[])mValues.ToArray(typeof(string));
				else
					return null;
			}
		}

		public int IndexValue(string value)
		{
			if (mValues != null)
				return mValues.BinarySearch(value);
			else
				return -1;
		}

		public override string ToString()
		{
			if (mName != string.Empty)
			{
				return mName;
			}
			else
			{
				return mLabel.ToString();
			}
		}
	}
}
