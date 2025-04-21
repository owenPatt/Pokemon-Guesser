using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;

namespace PokemonGuesser
{
    public class clsPokemonDetails
    {
        /// <summary>
        /// Initializes a new pokemon with all of the information needed
        /// </summary>
        /// <param name="_Name"></param>
        /// <param name="_Height"></param>
        /// <param name="_Weight"></param>
        /// <param name="_HP"></param>
        /// <param name="_Attack"></param>
        /// <param name="_Defense"></param>
        /// <param name="_SpecialAttack"></param>
        /// <param name="_SpecialDefense"></param>
        /// <param name="_Speed"></param>
        /// <param name="_Type"></param>
        /// <param name="_EvoSet"></param>
        /// <param name="_Info"></param>
        public clsPokemonDetails(string _Name, string _Height, string _Weight, string _HP, string _Attack, string _Defense, string _SpecialAttack, string _SpecialDefense, string _Speed, string _Type, string _EvoSet, string _Info)
        {
            Name = char.ToUpper(_Name[0]) + _Name.Substring(1);
            Height = (float.Parse(_Height) * 0.1).ToString() + "m";
            Weight = (float.Parse(_Weight) * 0.1).ToString() + "kg";
            HP = _HP;
            Attack = _Attack;
            Defense = _Defense;
            SpecialAttack = _SpecialAttack;
            SpecialDefense = _SpecialDefense;
            Speed = _Speed;
            Type = _Type.Trim('{', '}').Split(',').Select(t => t.Trim()).ToArray();
            EvoSet = _EvoSet;
            Info = FixEncoding(_Info);
            ImageURL = checkImageName(_Name);
        }

        // Sets up all of the public variables that can be called within the pokemon
        public string ID { get; }
        public string Name { get; }
        public string Height { get; }
        public string Weight { get; }
        public string HP { get; }
        public string Attack { get; }
        public string Defense { get; }
        public string SpecialAttack { get; }
        public string SpecialDefense { get; }
        public string Speed { get; }
        public string[] Type { get; }
        public string EvoSet { get; }
        public string Info { get; }
        public string ImageURL { get; }

        /// <summary>
        /// In the information of the pokemon, many words or phrases appear weird. This function cleans them up.
        /// </summary>
        /// <param name="input">The string that needs to be cleaned (in this case the pokemon information)</param>
        /// <returns></returns>
        private string FixEncoding(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            byte[] win1252Bytes = Encoding.GetEncoding(1252).GetBytes(input);
            string utf8Fixed = Encoding.UTF8.GetString(win1252Bytes);

            //Manual fixes for common characters
            utf8Fixed = utf8Fixed.Replace("PokÃ©mon", "Pokémon")
                                 .Replace("POKéMON", "Pokémon")
                                 .Replace("â€™", "’")
                                 .Replace("â€œ", "“")
                                 .Replace("â€", "”")
                                 .Replace("â€“", "–")
                                 .Replace("â€”", "—")
                                 .Replace("â€¦", "…")
                                 .Replace("?Ts", "’s")
                                 .Replace("?s", "’s")
                                 .Replace("�", "’");

            return utf8Fixed;
        }

        /// <summary>
        /// This checks the image URL. Some pokemon have different URLs than just their name, so this function handles that.
        /// </summary>
        /// <param name="name">The name of the pokemon</param>
        /// <returns></returns>
        private string checkImageName(string name)
        {
            //All of the Pokemon names that have alerted image links
            Dictionary<string, string> overrides = new Dictionary<string, string>
            {
                { "urshifu", "https://img.pokemondb.net/artwork/large/urshifu-single-strike.jpg" },
                { "giratina", "https://img.pokemondb.net/artwork/large/giratina-altered.jpg"},
                { "shaymin", "https://img.pokemondb.net/artwork/large/shaymin-land.jpg"},
                { "oricorio", "https://img.pokemondb.net/artwork/large/oricorio-baile.jpg"},
                { "lycanroc", "https://img.pokemondb.net/artwork/large/lycanroc-midday.jpg"},
                { "wishiwashi", "https://img.pokemondb.net/artwork/large/wishiwashi-school.jpg"},
                { "eiscue", "https://img.pokemondb.net/artwork/large/eiscue-ice.jpg"},
                { "morpeko", "https://img.pokemondb.net/artwork/large/morpeko-full-belly.jpg"},
                { "enamorus", "https://img.pokemondb.net/artwork/large/enamorus-incarnate.jpg"},
                { "sinistcha", "https://img.pokemondb.net/sprites/scarlet-violet/normal/sinistcha.png"},
                { "hydrapple", "https://img.pokemondb.net/sprites/scarlet-violet/normal/hydrapple.png"},
                { "gouging-fire", "https://img.pokemondb.net/sprites/scarlet-violet/normal/gouging-fire.png"},
                { "iron-boulder", "https://img.pokemondb.net/sprites/scarlet-violet/normal/iron-boulder.png"},
            };

            //Checks the name to see if it is on the override list
            if (overrides.ContainsKey(name))
                return overrides[name];

            //Formats URL
            return $"https://img.pokemondb.net/artwork/large/{name}.jpg";
        }
    }
}
