using HomeWork9_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    internal class BCipher : ACipher
    {
        public BCipher(string base_str) : base(base_str) { }

        public override string Encode()
        {
            foreach (char c in Base_str)
            {
                string rus_lang = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                string eng_lang = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (rus_lang.Contains(c.ToString().ToUpper()))
                {
                    char temp = rus_lang[rus_lang.Length - 1 - rus_lang.IndexOf(char.ToUpper(c))];
                    if (char.IsLower(c))
                    {
                        New_str += char.ToLower(temp);
                    }
                    else
                    {
                        New_str += temp;
                    }
                }
                else if (eng_lang.Contains(c.ToString().ToUpper()))
                {
                    char temp = eng_lang[eng_lang.Length - 1 - eng_lang.IndexOf(char.ToUpper(c))];
                    if (char.IsLower(c))
                    {
                        New_str += char.ToLower(temp);
                    }
                    else
                    {
                        New_str += temp;
                    }
                }
                else
                {
                    New_str += c;
                }
            }
            return New_str;
        }
    }
}
