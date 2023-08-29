using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string shadowmourne = "Shadowmourne";
            string valanyr = "Valanyr";
            string dragonwrath = "Dragonwrath";
            string obtained = " obtained!";

            Dictionary<string, int> keyMaterialsAndJunkMaterials = new Dictionary<string, int>();

            bool getOut = false;

            while (true)
            {
                string input = Console.ReadLine();

                string[] materials = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

                for (int i = 0; i < materials.Length; i += 2)
                {
                    if (keyMaterialsAndJunkMaterials.Keys.Contains(materials[i + 1]))
                    {
                        keyMaterialsAndJunkMaterials[materials[i + 1]] += int.Parse(materials[i]);
                    }
                    else
                    {
                        keyMaterialsAndJunkMaterials.Add(materials[i + 1], int.Parse(materials[i]));
                    }

                    if (keyMaterialsAndJunkMaterials.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").Any(x => x.Value >= 250))
                    {
                        getOut = true;
                        break;
                    }
                }

                if (getOut)
                {
                    break;
                }
            }

            if (keyMaterialsAndJunkMaterials.Keys.Contains("shards"))
            {
                if (keyMaterialsAndJunkMaterials["shards"] >= 250)
                {
                    Console.WriteLine(shadowmourne + obtained);
                    keyMaterialsAndJunkMaterials["shards"] -= 250;
                }
            }
            else
            {
                keyMaterialsAndJunkMaterials.Add("shards", 0);
            }

            if (keyMaterialsAndJunkMaterials.Keys.Contains("fragments"))
            {
                if (keyMaterialsAndJunkMaterials["fragments"] >= 250)
                {
                    Console.WriteLine(valanyr + obtained);
                    keyMaterialsAndJunkMaterials["fragments"] -= 250;
                }
            }
            else
            {
                keyMaterialsAndJunkMaterials.Add("fragments", 0);
            }

            if (keyMaterialsAndJunkMaterials.Keys.Contains("motes"))
            {
                if (keyMaterialsAndJunkMaterials["motes"] >= 250)
                {
                    Console.WriteLine(dragonwrath + obtained);
                    keyMaterialsAndJunkMaterials["motes"] -= 250;
                }
            }
            else
            {
                keyMaterialsAndJunkMaterials.Add("motes", 0);
            }

            var keyMaterials = keyMaterialsAndJunkMaterials.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes")
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var junkMaterials = keyMaterialsAndJunkMaterials.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes")
                .OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var keyMaterial in keyMaterials)
            {
                Console.WriteLine(keyMaterial.Key + ": " + keyMaterial.Value);
            }

            foreach (var junkMaterial in junkMaterials)
            {
                Console.WriteLine(junkMaterial.Key + ": " + junkMaterial.Value);
            }
        }
    }
}
