using System;
using System.Collections;
class Program
{

    static void WriteList(ArrayList list)
    {
        foreach (object o in list)
            Console.WriteLine(o);
    }
    static void Main()
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        
        }
        WriteList(list);
    } 
        }
    

