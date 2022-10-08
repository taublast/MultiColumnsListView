﻿using MultiColumnMonkeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiColumnMonkeys.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {

            new Item
            {
                Text = "Baboon",
                Location = "Africa & Asia",
                Description = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Olivebaboon.jpg/275px-Olivebaboon.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Capuchin Monkey",
                Location = "Central & South America",
                Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Blue Monkey",
                Location = "Central and East Africa",
                Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Squirrel Monkey",
                Location = "Central & South America",
                Description = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Golden Lion Tamarin",
                Location = "Brazil",
                Description = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Howler Monkey",
                Location = "South America",
                Description = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Japanese Macaque",
                Location = "Japan",
                Description = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Description = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Proboscis Monkey",
                Location = "Borneo",
                Description = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            },

            //repeat
           new Item
            {
                Text = "Baboon",
                Location = "Africa & Asia",
                Description = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Olivebaboon.jpg/275px-Olivebaboon.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Capuchin Monkey",
                Location = "Central & South America",
                Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Blue Monkey",
                Location = "Central and East Africa",
                Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Squirrel Monkey",
                Location = "Central & South America",
                Description = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Golden Lion Tamarin",
                Location = "Brazil",
                Description = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Howler Monkey",
                Location = "South America",
                Description = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Japanese Macaque",
                Location = "Japan",
                Description = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Description = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Proboscis Monkey",
                Location = "Borneo",
                Description = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            },
           new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Baboon",
                Location = "Africa & Asia",
                Description = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Capuchin Monkey",
                Location = "Central & South America",
                Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Blue Monkey",
                Location = "Central and East Africa",
                Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Squirrel Monkey",
                Location = "Central & South America",
                Description = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Golden Lion Tamarin",
                Location = "Brazil",
                Description = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Howler Monkey",
                Location = "South America",
                Description = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Japanese Macaque",
                Location = "Japan",
                Description = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Description = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            },
            new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Proboscis Monkey",
                Location = "Borneo",
                Description = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            },


        };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}