namespace LCOPN 
{
    public class Program
    {
        public static void Main()
        {
            
        }
    }
    public class Solution
    {
        private static readonly string[] Alphabet = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" }; //8
        public static IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            Dfs(digits, result);
            return result;
        }

        public static void Dfs(string digits, List<string> result, string state = "" )
        {
            if (state.Length > digits.Length - 1)
                return;
            var i = digits[state.Length] - '0';
            var buttonLetters = Alphabet[i - 2];
            foreach (var letter in buttonLetters)
            {
                Dfs(digits, result, state + letter);
                if (state.Length == digits.Length - 1)
                    result.Add(state + letter);
            }
        }
    }

}

