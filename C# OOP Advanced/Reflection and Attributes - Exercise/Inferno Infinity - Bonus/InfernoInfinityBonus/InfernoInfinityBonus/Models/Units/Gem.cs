using InfernoInfinityBonus.Models.Enums;
using System;

namespace InfernoInfinityBonus.Models.Units
{
    public class Gem
    {
        public GemEnum GemType { get; set; }
        public GemClarityEnum Clarity { get; set; }

        public Gem(string type, string clarity)
        {
            Enum.TryParse(type, out GemEnum gemType);
            Enum.TryParse(clarity, out GemClarityEnum gemClarity);

            GemType = gemType;
            Clarity = gemClarity;
        }
    }
}
