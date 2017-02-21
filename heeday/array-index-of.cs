// 2017-02-21
// Find index
using System;
using System.Collections.Generic;
    
public class Program
{    
    public static void Main(string[] args)
    {
        var target = args[0];
        var found = -1;
        List<int> foundArray = new List<int>();
        for (var arg = 1; arg < args.Length; arg++) {
            if (target == args[arg]) { 
                found = arg-1;
                foundArray.Add(arg);
            }
        }
        Console.WriteLine("Target : " + target);
        if (found > -1) {
            Console.Write("IndexOf : [");
            for (var i = 0; i < foundArray.Count; i++) {
                if (i == foundArray.Count - 1)
                    Console.WriteLine(foundArray[i] + "]");
                else 
                    Console.Write(foundArray[i] + ", ");
            }
        } else {
            Console.WriteLine("I can't find it");
        }
    }
}
