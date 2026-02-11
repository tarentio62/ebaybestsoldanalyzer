using EbayBestSoldAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EbayBestSoldAnalyzer.Models
{
    public class ItemDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public ItemMode Mode { get; set; }



        public ItemDto(Item it)
        {
            this.Name = it.Name;
            this.Url = it.Url;
            this.Count = it.Count;
            this.Mode = it.BestOn;
            this.Image = it.Image;

        }


    }


}
