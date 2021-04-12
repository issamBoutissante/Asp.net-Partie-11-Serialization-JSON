using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Partie_11_Serialization_Json
{
    class Program
    {
        const string path = @"C:\Users\ISSAM\Desktop\Web Cote Serveur\cours\exircice de cours\Partie 11 Serialization Json\etudiant.json";
        static void Main(string[] args)
        {
            Deserialize();
            Console.ReadKey();
        }
        static private void Serialize()
        {
            String etudiantJSON = JsonConvert.SerializeObject(new Etudiant()
            {
                numins = 1,
                nom = "boutissane",
                prenom = "issam"
            });
            File.WriteAllText(path, etudiantJSON);
            Console.WriteLine(etudiantJSON);
            Console.WriteLine("Serialization is done");
        }
        static private void Deserialize()
        {
            Etudiant etudiant = JsonConvert.DeserializeObject<Etudiant>(File.ReadAllText(path));
            Console.WriteLine(etudiant);
        }
    }
}
