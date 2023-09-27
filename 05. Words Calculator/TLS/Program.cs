Console.Write("Enter some long sentence: ");
string sentence = Console.ReadLine();
string[] sentence_split = sentence.Split(' ');

Console.WriteLine("The sentence you've entered contains {0} words.", sentence_split.Length);
Console.ReadKey();
