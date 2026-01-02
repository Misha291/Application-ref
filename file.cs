public static void WriteAllNumbersFromText(string text)
{
    int pos = 0;
    while (true)
    {
        // skip spaces
        SkipSpaces(text, ref pos);
        // read next number
        var num = ReadNumber(text, ref pos);
        if (num == "") break;
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
