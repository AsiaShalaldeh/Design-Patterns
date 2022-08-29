using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class Pizza
	{
		private IList<string> ingredients;
		public Pizza()
		{
			ingredients = new List<string>();
		}
		public void Add(string part)
		{
			ingredients.Add(part);
		}
		public string Show()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("New Pizza: ");
			foreach (string item in ingredients)
				sb.AppendLine(item);
			return sb.ToString();
		}
	}

}
