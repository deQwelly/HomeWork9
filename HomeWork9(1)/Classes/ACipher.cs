using HomeWork9_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    public class ACipher : ICipher
    {
        string base_str;
        string new_str;

        public ACipher(string base_str)
        {
            this.base_str = base_str;
        }

        public string Base_str
        {
            get
            {
                return base_str;
            }
        }

        public string New_str
        {
            get
            {
                return new_str;
            }
            set
            {
                new_str = value;
            }
        }

        public virtual string Encode()
        {
            foreach (char c in base_str)
            {
                if ("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(c.ToString().ToUpper()))
                {
                    if (c.ToString().ToLower().Equals("я"))
                    {
                        new_str += "а";
                    }
                    else if (c.ToString().ToLower().Equals("z"))
                    {
                        new_str += "a";
                    }
                    else
                    {
                        new_str += (char)((int)c + 1);
                    }
                }
                else
                {
                    new_str += c;
                }
            }
            return new_str;
        }

        public string Decode()
        {
            return base_str;
        }
    }
}
