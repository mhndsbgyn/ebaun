using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBAUNAPP.Models;

namespace EBAUNAPP.Services
{
    public class ClassesData : IDataStore<Classes>
    {
        List<Classes> items;

        public ClassesData()
        {
            items = new List<Classes>();
            var mockItems = new List<Classes>
            {
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "Web Tasarım" },
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "Matematik", Egitmen_adi = "Recep " },
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "Programlama" , Egitmen_adi = "Gültekin Kuvat" },
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "Java", Egitmen_adi = "Kamil Topal" },
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "PHP",  Egitmen_adi = "Hüseyin Güneş" },
                new Classes { Id = Guid.NewGuid().ToString(), Ders_adi = "Görsel Programlama", Egitmen_adi = "Gültekin Kuvat" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Classes item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Classes item)
        {
            var oldItem = items.Where((Classes arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
           

            return await Task.FromResult(true);
        }

        public async Task<Classes> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Classes>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}