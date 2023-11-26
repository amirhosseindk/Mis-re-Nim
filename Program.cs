int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
	int n = Convert.ToInt32(Console.ReadLine().Trim());

	List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

	string result = misereNim(s);

	Console.WriteLine(result);
}

static string misereNim(List<int> s)
{
	var arraySum = s.Sum();
	var arraySize = s.Count();

	if (arraySum == arraySize)
		return (arraySize % 2 == 0) ? "First" : "Second";
	else
	{
		var xor = 0;
		foreach (var stoneSize in s)
			xor ^= stoneSize;

		return xor > 0 ? "First" : "Second";
	}
}