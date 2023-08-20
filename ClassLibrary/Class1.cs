using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public static string CheckVectorName(string name)
        {
            if (name.Length == 1)
            {
                if (char.IsLetter(name[0]) && char.IsLower(name[0]))
                {
                    return "";
                }
                else return "Вектор может называться только одной маленькой буквой.";
            }
            else return "Вектор может называться только одним символом.";
        }

        public static string CheckVectorNameTwo(string name, string filename)
        {
            string[] input = File.ReadAllLines(filename);

            foreach (string symbol in input)
            {
                if (symbol == name)
                {
                    return "Такой вектор уже существует в файле.";
                }
            }
            return "";
        }

        public static string CheckFileName(string name)
        {
            string message = "";
            if (name.Length <= 20)
            {
                foreach (char symbol in name)
                {
                    if (!char.IsLetter(symbol))
                    {
                        message = "В имени файла могут быть только буквы.";
                        break;
                    }
                }
            }
            else
            {
                message = "Имя файла не может быть больше 20 символов.";
            }

            return message;
        }
    }
}
