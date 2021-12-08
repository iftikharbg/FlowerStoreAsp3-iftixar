using FlowerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.ViewModel
{
    public class HomeViewModel
    {
        public Slider slider { get; set; }

        public Valentine valentine { get; set; }

        public List<ListItem> listItem { get; set; }

        public List<Product> product { get; set; }

        public List<Category> category { get; set; }

        public SubscribeTable subscribeTable { get; set; }

        public List<Expert> experts { get; set; }

        public Title title { get; set; }
    }
}
