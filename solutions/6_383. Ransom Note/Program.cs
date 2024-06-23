IDictionary dictionary = new Dictionary<char, int>();

public bool CanConstruct(string ransomNote, string magazine) {
    var dictionary = PopulateDictionary(magazine);
    int count = 0;

    for (int i = 0; i < ransomNote.Length; i++) 
    {
        if (dictionary.ContainsKey(ransomNote[i]) && dictionary[ransomNote[i]] > 0) {
            count++;
            dictionary[ransomNote[i]] -= 1;
        }
    }

    return count == ransomNote.Length;
}

    Dictionary<char, int> PopulateDictionary(string magazine)
    {
        var dictionary = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (dictionary.ContainsKey(magazine[i])) 
            {
                dictionary[magazine[i]] += 1;
            }
            else
            {
                dictionary.Add(magazine[i], 1);
            }
        }

        return dictionary;
    }
