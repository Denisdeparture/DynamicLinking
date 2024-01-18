namespace Lib
{
    public class ClassWork
    {
        private static string BaseText = "Hello World";
        static void Show(string? text) => Console.WriteLine(text ?? BaseText);
        static void Reverse(string text) 
        {
            string t = "";
            for (int i = 0; i < text.Length; i++) t += text[text.Length - i - 1];
            Console.WriteLine(t); 
        }
       
    }
}
