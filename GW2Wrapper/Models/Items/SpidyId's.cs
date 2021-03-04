using System.Collections.Generic;

namespace GW2Wrapper.Models.Items
{
    public class SpidyId_s
    {
        public int data_id { get; set; } 
        public string name { get; set; } 
        public int rarity { get; set; } 
        public int restriction_level { get; set; } 
        public string img { get; set; } 
        public int type_id { get; set; } 
        public int sub_type_id { get; set; } 
        public string price_last_changed { get; set; } 
        public int max_offer_unit_price { get; set; } 
        public int min_sale_unit_price { get; set; } 
        public int offer_availability { get; set; } 
        public int sale_availability { get; set; } 
        public int sale_price_change_last_hour { get; set; } 
        public int offer_price_change_last_hour { get; set; }
    }
    
    public class Root    {
        public int count { get; set; } 
        public int page { get; set; } 
        public int last_page { get; set; } 
        public int total { get; set; } 
        public List<SpidyId_s> results { get; set; } 
    }
}