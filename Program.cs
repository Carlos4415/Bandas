// Este projeto consiste em criar uma lista vazia para armazenar nomes de bandas e, em seguida, 
// adicionar à lista as bandas favoritas do usuário. O projeto permite praticar o uso de coleções 
// (List) em C#, como criar uma lista, adicionar elementos dinamicamente e manipular seus dados.
List<string> bandas = new List<string>();

bandas.Add("The Beatles");
bandas.Add("Pink Floyd");
bandas.Add("U2");
bandas.Add("Ira!");

for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine(bandas[i]);
}