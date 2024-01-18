using System.Reflection;
using System.Threading.Channels;
class Work
{
    static void Main()
    {
        Assembly asm = Assembly.LoadFrom("Lib.dll");
        Type[] types = asm.GetTypes();
        MethodInfo? objs;
        List<string> nameMethod = new List<string>()
        {
            "Show","Reverse"
        };
        foreach (Type t in types)
        {
            for (int counterMethod = 0; counterMethod < nameMethod.Count; counterMethod++)
            {
                objs = t.GetMethod(nameMethod[counterMethod], BindingFlags.NonPublic | BindingFlags.Static);
                if (objs != null)
                {
                    objs?.Invoke(null, new object[] { "World" });
                }
            }
        }
    }
}
