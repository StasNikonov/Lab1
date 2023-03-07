List<string> list = new List<string> { "abc", "cbd", "bsrt", "retyu", "sptrpef" };
var newList = list.Select(i => i.Length % 2 == 0 ? i[i.Length - 1] : i[0]);
newList.OrderByDescending(c => (int)c);
foreach (var item in newList)
{
    Console.Write(item + "\t");
}


