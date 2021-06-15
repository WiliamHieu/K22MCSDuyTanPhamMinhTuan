using System.Data;
using System.Collections;
using System;

namespace MTDecisionTreeID3
{
    public class TreeID3
    {
		private DataTable dtSource;
		private int totalRowsPositives = 0;
		private int totalRows = 0;
		private string colTarget = string.Empty;
		private double entropySet = 0.0;

		private int CountTotalPositives(DataTable dtDataSource)
		{
            int result = 0;
            foreach (DataRow row in dtDataSource.Rows)
            {
                if (Convert.ToBoolean(row[colTarget]) == true)
                    result++;
            }
            return result;
        }

		private double CalcEntropy(int positives, int negatives)
		{
			int total = positives + negatives;
			double ratioPositive = (double)positives / total;
			double ratioNegative = (double)negatives / total;

			if (ratioPositive != 0)
				ratioPositive = -(ratioPositive) * Math.Log(ratioPositive, 2);
			if (ratioNegative != 0)
				ratioNegative = -(ratioNegative) * Math.Log(ratioNegative, 2);

			double result = ratioPositive + ratioNegative;

			return result;
		}

		private void GetValuesToAttribute(DataTable dtDataSource, AttributeID3 attribute, string value, out int positives, out int negatives)
		{
            positives = 0; negatives = 0;

            foreach (DataRow row in dtDataSource.Rows)
            {
                if (row[attribute.AttributeName].ToString() == value)
                {
                    if (Convert.ToBoolean(row[colTarget]) == true)
                        positives++;
                    else
                        negatives++;
                }
            }
        }

		private double Gain(DataTable dtDataSource, AttributeID3 attribute)
		{
			string[] values = attribute.Values;
			double sum = 0.0;

			int positives, negatives;
			for (int i = 0; i < values.Length; i++)
			{
				positives = negatives = 0;

				GetValuesToAttribute(dtDataSource, attribute, values[i], out positives, out negatives);

				double entropy = CalcEntropy(positives, negatives);
				sum += -(double)(positives + negatives) / totalRows * entropy;
			}
			return entropySet + sum;
		}

		private AttributeID3 GetBestAttribute(DataTable dtDataSource, AttributeID3[] attributes)
		{
			double maxGain = 0.0;
			AttributeID3 result = null;

			foreach (AttributeID3 attribute in attributes)
			{
				double aux = Gain(dtDataSource, attribute);
				if (aux > maxGain)
				{
					maxGain = aux;
					result = attribute;
				}
			}
			return result;
		}

		private bool AllSamplesPositives(DataTable dtDataSource, string targetAttribute)
		{
			foreach (DataRow row in dtDataSource.Rows)
			{
				if (Convert.ToBoolean(row[targetAttribute]) == false)
					return false;
			}

			return true;
		}

		private bool AllSamplesNegatives(DataTable dtDataSource, string targetAttribute)
		{
			foreach (DataRow row in dtDataSource.Rows)
			{
				if (Convert.ToBoolean(row[targetAttribute]) == true)
					return false;
			}

			return true;
		}

		private ArrayList GetDistinctValues(DataTable dtDataSource, string targetAttribute)
		{
			ArrayList distinctValues = new ArrayList(dtDataSource.Rows.Count);

			foreach (DataRow row in dtDataSource.Rows)
			{
				if (distinctValues.IndexOf(row[targetAttribute]) == -1)
					distinctValues.Add(row[targetAttribute]);
			}

			return distinctValues;
		}

		private object GetMostCommonValue(DataTable dtDataSource, string targetAttribute)
		{
			ArrayList distinctValues = GetDistinctValues(dtDataSource, targetAttribute);
			int[] count = new int[distinctValues.Count];

			foreach (DataRow row in dtDataSource.Rows)
			{
				int index = distinctValues.IndexOf(row[targetAttribute]);
				count[index]++;
			}

			int maxIndex = 0;
			int maxCount = 0;

			for (int i = 0; i < count.Length; i++)
			{
				if (count[i] > maxCount)
				{
					maxCount = count[i];
					maxIndex = i;
				}
			}

			return distinctValues[maxIndex];
		}

		private TreeNodeID3 InternalMountTree(DataTable dtDataSource, string targetAttribute, AttributeID3[] attributes)
		{
			if (AllSamplesPositives(dtDataSource, targetAttribute) == true)
				return new TreeNodeID3(new AttributeID3(true));

			if (AllSamplesNegatives(dtDataSource, targetAttribute) == true)
				return new TreeNodeID3(new AttributeID3(false));

			if (attributes.Length == 0)
				return new TreeNodeID3(new AttributeID3(GetMostCommonValue(dtDataSource, targetAttribute)));

			totalRows = dtDataSource.Rows.Count;
			colTarget = targetAttribute;
			totalRowsPositives = CountTotalPositives(dtDataSource);

			entropySet = CalcEntropy(totalRowsPositives, totalRows - totalRowsPositives);

			AttributeID3 bestAttribute = GetBestAttribute(dtDataSource, attributes);

			TreeNodeID3 root = new TreeNodeID3(bestAttribute);

			DataTable aDataSource = dtDataSource.Clone();

			foreach (string value in bestAttribute.Values)
			{
				aDataSource.Rows.Clear();

				DataRow[] rows = dtDataSource.Select(bestAttribute.AttributeName + " = " + "'" + value + "'");

				foreach (DataRow row in rows)
				{
					aDataSource.Rows.Add(row.ItemArray);
				}
				ArrayList lstAttributes = new ArrayList(attributes.Length - 1);
				for (int i = 0; i < attributes.Length; i++)
				{
					if (attributes[i].AttributeName != bestAttribute.AttributeName)
						lstAttributes.Add(attributes[i]);
				}
				if (aDataSource.Rows.Count == 0)
				{
					return new TreeNodeID3(new AttributeID3(GetMostCommonValue(aDataSource, targetAttribute)));
				}
				else
				{
                    try
                    {
						TreeID3 tree = new TreeID3();
						TreeNodeID3 childNode = tree.MountTree(aDataSource, targetAttribute, (AttributeID3[])lstAttributes.ToArray(typeof(AttributeID3)));
						root.AddTreeNode(childNode, value);
					}
					catch (Exception ex)
                    {
                        throw ex;
                    }
				}
			}

			return root;
		}

		public TreeNodeID3 MountTree(DataTable dtDataSource, string targetAttribute, AttributeID3[] attributes)
		{
			dtSource = dtDataSource;
			return InternalMountTree(dtSource, targetAttribute, attributes);
		}
	}
}
