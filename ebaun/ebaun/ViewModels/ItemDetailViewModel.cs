using System;

using ebaun.Models;

namespace ebaun.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Ders_adi;
            Item = item;
        }
    }
}
