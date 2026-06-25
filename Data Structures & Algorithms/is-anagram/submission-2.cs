//namespace test;

//public class Computer
//{

//    public string MotherBoard {  get; set; }
//    public int CPUCores { get; set; }

//    public bool HasWifi { get; set; }
//    public bool HasLTE { get; set; }
//    public DateTime RealseDate { get; set; }
//    public Decimal price { get; set; }
//    public string VideoCard { get; set; }


//}
//class Program
//{


//    static void Main(string[] args) {



//    }
//}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        if (s is null || t is null ||  s.Length != t.Length)
            return false;

        var shash = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var thash = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        foreach (var item in shash)
        {
            if (!thash.ContainsKey(item.Key) || thash[item.Key] !=item.Value)
                return false;
            
        }
        return true;

    }
}
