using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarim.Forms.Sample.Models;
using Xamarin.Forms;

namespace Xamarim.Forms.Sample.Services
{
    public class PetDataStore: IDataStore<Item>
    {
        public PetStoreService PetStoreService => DependencyService.Get<PetStoreService>();

        public Task<bool> AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Item> GetItemAsync(string id)
        {
            var items = await GetItemsAsync();

            return items.Single(x => x.Id == id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            var pets = await PetStoreService.GetPetsByStatus();

            var itemsAsync = pets
                .Where(x => x.Category?.Name != null && x.Status != null && x.Name != null)
                .Select(x => new Item
            {
                Id = x.Id.ToString(),
                Description = $"{x.Category.Name}-{x.Status}",
                Text = $"{x.Name} - {x.Id}"
            }).ToList();

            return itemsAsync;
        }
    }

    public class PetStoreService
    {
        public async Task<List<Models.GetPetModel>> GetPetsByStatus()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://petstore.swagger.io/v2/")
            };
            var message = await client.GetAsync("pet/findByStatus?status=available");

            return await message.Content.ReadAsAsync<List<Models.GetPetModel>>();
        }

        public class Models
        {
            public class Category
            {
                public long Id { get; set; }
                public string Name { get; set; }
            }

            public class Tag
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            public class GetPetModel
            {
                public object Id { get; set; }
                public Category Category { get; set; }
                public string Name { get; set; }
                public List<string> PhotoUrls { get; set; }
                public List<Tag> Tags { get; set; }
                public string Status { get; set; }
            }


        }
    }
}