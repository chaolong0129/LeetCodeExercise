namespace ex771 {
    public class Solution {
        public int NumJewelsInStones (string J, string S) {
            var jArrays = J.ToCharArray();
            var sArrays = S.ToCharArray();
            int count = 0;
            foreach (var j in jArrays)
            {
                foreach (var s in sArrays)
                {
                    if (s.CompareTo(j)==0)
                        count++;
                }
            }
            return count;
        }
    }
}