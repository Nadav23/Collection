using Collection;

void printList<T>(List<T> lst)
{
    foreach (T item in lst)
    {
        Console.Write(item + " ");
    }
}

CollectionOperations co = new CollectionOperations();

List<string> list = new List<string>();
list.Add("nadav");
list.Add("ido");
list.Add("liel");
list.Add("ido");
list.Add("course59");
list.Add("mama");

printList<string>(list);
co.ListOperations(list);
Console.WriteLine();
printList<string>(list);