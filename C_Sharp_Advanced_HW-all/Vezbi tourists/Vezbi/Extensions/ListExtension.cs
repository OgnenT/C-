using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbi.Extensions
{
    public static class ListExtension
    {
        public static List<string> Country(this Dictionary<int, string> dictList, Func<int, bool> call)
        {
            var res = new List<string>();
            foreach (var item in dictList)
            {
                var m = call(item.Key);
                if (m)
                {
                    res.Add(item.Value);
                }
            }
            return res;
        }
    }
}
