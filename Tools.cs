using System.Drawing;
using System.Text;

namespace ConsoleTools
{
    public static class Tools
    {
        public static void FillConsole(string symbols = "", int consoleWidth = 1, int consoleHeight = 1)
        {
           ///<summary>
           ///Fills the console window with any text you want.
           /// </summary>
            if(consoleHeight != 0)
            {
                if(symbols == "")
                {
                    symbols = "#";
                }

                int count = consoleWidth / StrWidth(symbols);
                string text = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    text += symbols;
                }

                for(int y = 0; y < consoleHeight; y++)
                {
                    Console.WriteLine(text);
                }
            } 
        }
        private static int StrWidth(string str)
        {
            var length = 0;
            for (var i = 0; i < str.Length; i++)
            {
                byte[] bytes = Encoding.Default.GetBytes(str.Substring(i, 1));
                if (bytes.Length > 1)
                {
                    length += 2;
                }
                else
                {
                    length += 1;
                }
            }
            return length;
        }
    }
}