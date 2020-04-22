using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ebaun.Models;

namespace ebaun.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "Web Tasarım", Aciklama="Ders İptaldir arkadaşlar" ,Tarih=DateTime.Now , Egitmen_adi = "Hüseyin Güneş"  },
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "Matematik", Aciklama="Ders İptal edilebilir benden haber ebkleyin" , Tarih=DateTime.Now , Egitmen_adi = "Recep " },
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "Programlama", Aciklama="Ders İptal" , Tarih=DateTime.Now , Egitmen_adi = "Gültekin Kuvat" },
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "Java", Aciklama="Dersin ikinci yarısında çıkanlar yok yazıldı.", Tarih=DateTime.Now , Egitmen_adi = "Kamil Topal" },
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "PHP", Aciklama="Öğleden sonraki ders iptal.", Tarih=DateTime.Now , Egitmen_adi = "Hüseyin Güneş" },
                new Item { Id = Guid.NewGuid().ToString(), Ders_adi = "Görsel Programlama", Aciklama="Ders 15 dk sonra başlayacak.",Tarih=DateTime.Now , Egitmen_adi = "Gültekin Kuvat" },
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