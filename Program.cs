using Lets_Speak_Discionario.Classes;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

Dicionario fisk = new Dicionario();

if (File.Exists("dictionary.bin"))
{
    using (Stream stream = File.Open("dictionary.bin", FileMode.Open))
    {
        BinaryFormatter bin = new BinaryFormatter();
        fisk.Termos = (Dictionary<string, string>)bin.Deserialize(stream);
    }
}
    

Menu.Solucao(fisk);

