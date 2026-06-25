
public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        if (s is null || t is null ||  s.Length != t.Length)
            return false;

        char[] charsCount = new char[255];
  
        for (int i = 0; i < s.Length; i++)
        {

            ++charsCount[s[i]];
            --charsCount[t[i]];

        }

        foreach (var i in charsCount)
            if (i != 0)
                return false;

        return true;

    }
}
