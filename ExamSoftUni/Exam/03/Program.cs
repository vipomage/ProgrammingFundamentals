using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Evolution
    {
        public string Evo { get; set; }

        public int Index { get; set; }
    }

    class Pokemon
    {
        public string Name { get; set; }

        public List<Evolution> Evolutions = new List<Evolution>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pokemon> pokemonsDict = new Dictionary<string, Pokemon>();

            string input = Console.ReadLine();

            while (input.ToLower() != "wubbalubbadubdub")
            {
                string[] array = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);


                if (pokemonsDict.ContainsKey(array[0]) && array.Length <2 )
                {
                    foreach (KeyValuePair<string, Pokemon> keyValuePair in pokemonsDict.Where(k => k.Key == array[0]))
                    {
                        Console.WriteLine($"# {keyValuePair.Value.Name}");

                        foreach (Evolution valueEvolution in keyValuePair.Value.Evolutions)
                        {
                            Console.WriteLine($"{valueEvolution.Evo} <-> {valueEvolution.Index}");
                        }
                    }
                }
                else
                {
                    if (pokemonsDict.ContainsKey(array[0]))
                    {
                        pokemonsDict[array[0]].Evolutions.Add(new Evolution()
                        {
                            Evo = array[1],
                            Index = int.Parse(array[2])
                        });
                    }
                    else if(!pokemonsDict.ContainsKey(array[0]) && array.Length != 1)
                    {
                        Pokemon pokemon = new Pokemon()
                        {
                            Name = array[0],
                            Evolutions = new List<Evolution>()
                            {
                                new Evolution()
                                {
                                    Evo = array[1],
                                    Index = int.Parse(array[2])
                                }
                            }
                        };
                        pokemonsDict[array[0]] = pokemon;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var pokemonsDictValue in pokemonsDict.Values)
            {
                Console.WriteLine($"# {pokemonsDictValue.Name}");
                foreach (var evolution in pokemonsDictValue.Evolutions.OrderByDescending(i => i.Index))
                {
                    Console.WriteLine($"{evolution.Evo} <-> {evolution.Index}");
                }
            }
        }
    }
}
