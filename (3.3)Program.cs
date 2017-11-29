using System;

public partial class DynamicInstanceList
{
    private static string instanceSpec = "System.EventArgs;System.Random;" +
        "System.Exception;System.Object;System.Version";

    public static void Main()
    {
        string[] instances = instanceSpec.Split(';');
        Array instlist = Array.CreateInstance(typeof(object), instances.Length);
        object item;
        for (int i = 0; i < instances.Length; i++)
        {
            // create the object from the specification string
            Console.WriteLine("Creating instance of: {0}", instances[i]);
            item = Activator.CreateInstance(Type.GetType(instances[i]));
            instlist.SetValue(item, i);
        }
        Console.WriteLine("\nObjects and their default values:\n");
        foreach (object o in instlist)
        {
            Console.WriteLine("Type:     {0}\nValue:    {1}\nHashCode: {2}\n",
                o.GetType().FullName, o.ToString(), o.GetHashCode());
        }
    }
}
