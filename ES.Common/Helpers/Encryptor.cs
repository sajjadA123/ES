using System;
using System.IO;
using System.Security.Cryptography;

namespace ES.Common.Helpers
{
    public class Encryptor
    {
        public static string Encode(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {

                string key = "alizZzZolqadr";
                double keycode = 0;

                for (int pos = 0; pos < key.Length; pos++)
                {
                    keycode += Char.ConvertToUtf32(key, pos);
                }

                string output = "";
                for (int pos = 0; pos < value.Length; pos++)
                {
                    double code = Char.ConvertToUtf32(value, pos);
                    int newcode = (int)(code + keycode);
                    int oldcode = newcode - ((int)keycode);
                    output += Char.ConvertFromUtf32(newcode);
                }

                return output;

            }
            else
            {
                return string.Empty;
            }

        }

        public static string Decode(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                string key = "alizZzZolqadr";
                double keycode = 0;
                for (int pos = 0; pos < key.Length; pos++)
                {
                    keycode += Char.ConvertToUtf32(key, pos);
                }

                string output = "";
                for (int pos = 0; pos < value.Length; pos++)
                {
                    double code = Char.ConvertToUtf32(value, pos);
                    int newcode = (int)code - ((int)keycode);
                    output += Char.ConvertFromUtf32(newcode);
                }

                return output;
            }
            else return string.Empty;
        }

    }
}
