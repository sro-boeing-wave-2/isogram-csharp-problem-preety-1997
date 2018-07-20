using System;
using System.Linq;
namespace Isogram
{
    public class Isogram
    {
		public static bool IsIsogram(string input) {
			bool Flag = false;
			String str = "";
			for (int i=0;i<input.Length;i++) {
				if (((int)input[i] >= (int)'a' && (int)input[i] <= (int)'z') ||
					((int)input[i] >= (int)'A' && (int)input[i] <= (int)'Z'))
				{
					str += input[i];
				}
				
			}
			var DistinctChar = str.Distinct<char>();
			if (DistinctChar.Count() == str.Length) {
				Flag = true;

			}

			return Flag;
		}
    }
}
