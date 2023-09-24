using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Codi
    {
        public static List<string> Codificacion(string entrada)
        {
            Dictionary<string, int> dictionari = new Dictionary<string, int>();
            List<string> compresion = new List<string>();
            int IndiDicc = 0;
            string Similar = " ";
            if (Similar == " ")
            {
                // Verificar si la clave existe antes de agregarla
                if (dictionari.ContainsKey(Similar))
                {
                    compresion.Add(dictionari[Similar].ToString());
                }
                else
                {
                    compresion.Add(Similar[Similar.Length - 1].ToString());
                }
            }
            foreach (char c in entrada )
            {
                Similar += c;
                 
                if (!dictionari.ContainsKey(Similar))
                {
                    dictionari.Add(Similar, IndiDicc++);
                    if (Similar == Similar)
                    {
                        IndiDicc = IndiDicc++;
                        Console.WriteLine("< " + Similar + " " + IndiDicc + " >");
                    }
                    else
                    {
                        IndiDicc = IndiDicc;
                        Console.WriteLine("< " + Similar + " " + IndiDicc + " >");
                    }
                   //compresion.Add(dictionari[Similar.Substring(0, Similar.Length - 1)].ToString() + c);
                    Similar = " ";
                }
            }
            return compresion; 
        }
        public static string Decompresion(List<string> compresion)
        {
            Dictionary<int,string> dictionari = new Dictionary<int,string>();
            StringBuilder decompresion = new StringBuilder();
            int IndiDiccio = 0;
            
            foreach(string token in compresion)
            {
                if (int.TryParse(token, out int indice))
                {
                    string Entrada = dictionari.ContainsKey(indice) ? dictionari[indice] : "";
                    Entrada += token[token.Length - 1];
                    decompresion.Append(Entrada);
                    dictionari[IndiDiccio++] = Entrada; 
                }
                else
                {
                    decompresion.Append(token);
                    dictionari[IndiDiccio++] = token; 
                }
            }
            return decompresion.ToString(); 
        }
    }
}
