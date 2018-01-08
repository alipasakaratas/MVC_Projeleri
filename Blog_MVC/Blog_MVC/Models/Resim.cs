using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Resim
    {
        public int ResimId { get; set; }
        public string KucukBoyut { get; set; }
        public string OrtaBoyut { get; set; }
        public string BuyulBoyut { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleID { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
