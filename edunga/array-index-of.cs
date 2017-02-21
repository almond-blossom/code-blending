/**
 * 2017-02-21
 * 찾을 문자열과 문자열 목록을 받아서 배열로 만들고
 * 찾을 문자열이 문자열 목록의 몇 번째에 있는지 index 구하기
 * ex) bar foo bar baz => index는 1
 * ex) par foo bar baz => index는 -1
 */

using System;

public class Program
{
    static string[] parseItems(string[] args) {
        string[] result = new string[args.Length];
        for (int i = 1; i < args.Length; i++) {
            result[i - 1] = args[i];
        }
        return result;
    }

    static int indexOf(string[] arr, string target) {
        int i = 0;
        foreach (var val in arr) {
            if (val == target) return i;
            i++;
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        if (args.Length < 3) {
            Console.WriteLine("Usage: dotnet run KEYWORD ITEM1 ...");
            return;
        }

        string[] list = parseItems(args);
        string targ = args[0];
        int pos = indexOf(list, targ);
        Console.WriteLine("Index Of: " + pos);
    }
}
