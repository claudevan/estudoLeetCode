using estudoLeetCode;

Console.WriteLine("Resolution Exercise 49: /r/n");

var exercise49 = new Exercise49();
var resultado = exercise49.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
var arrayOfArrays = resultado.Select(g => g.ToArray()).ToArray();
Console.WriteLine("[" + string.Join(", ", arrayOfArrays.Select(arr => "[" + string.Join(", ", arr.Select(s => $"\"{s}\"")) + "]")) + "]");

