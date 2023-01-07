string[] a=new string[5] {"123", "cdaas", "def", "12365", "-1"};
string[] b=new string[a.Length];
void NewArray(string[] a, string[] b)
{
    int j=0;
    for (int i=0;i<a.Length;i++)
    {
        if (a[i].Length<=3)
        {
            b[j]=a[i];
            j++;
        }
    } 
}

void PrintArray(string[] b)
{
    for (int i=0;i<b.Length;i++)
    {
        Console.Write($"{b[i]} ");
    }
    Console.WriteLine();
}

NewArray(a, b);
PrintArray(a);
System.Console.WriteLine();
PrintArray(b);