﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SmiteBuilder.Models
{
    public class MenuItems
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public MenuItems(string d, string v)
        {
            Description = d;
            Value = v;
        }
    }
    public class ItemDescription
    {
        public string Description { get; set; }
        public List<MenuItems> MenuItems { get; set; }
        public string SecondaryDescription { get; set; }
        public ItemDescription(string d, string d1, string v1, string d2, string v2, string sd)
        {
            Description = d;
            SecondaryDescription = sd;
            MenuItems = new List<MenuItems>();
            MenuItems.Add(new MenuItems(d1, v1));
            MenuItems.Add(new MenuItems(d2, v2));
        }
    }
    public class ItemModel
    {
        public int ChildItemId { get; set; }
        public string DeviceName { get; set; }
        public int IconId { get; set; }
        public ItemDescription ItemDescription { get; set; }
        public int ItemId { get; set; }
        public int ItemTier { get; set; }
        public int Price { get; set; }
        public int RootItemId { get; set; }
        public string ShortDesc { get; set; }
        public bool StartingItem { get; set; }
        public string Type { get; set; } // Item, Consumable, Active
        public string itemIcon_URL { get; set; }
        public string Role { get; set; } // Assassin/Warrior, Mage/Guardian, Hunter, Ratatoskr
    }

    public class ItemRole
    {
        public int ItemId { get; set; }
        public string Role { get; set; }
    }

    public class ItemSetModel : Model
    {
        public List<ItemModel> ItemSet { get; set; }
        public List<ItemRole> ItemRoleSet { get; set; }

        public ItemSetModel()
        {
            string path = "items.json";
            ItemSet = new List<ItemModel>();
            string json = FileFormat(System.IO.File.ReadAllText(path), "ItemSet");
            JsonConvert.PopulateObject(json, this);

            path = "itemrole.json";
            json = System.IO.File.ReadAllText(path);
            ItemRoleSet = new List<ItemRole>();
            JsonConvert.PopulateObject(json, this);

            foreach(ItemModel element in ItemSet)
            {
                var returnvalue = ItemRoleSet.Find(x => x.ItemId.Equals(element.RootItemId));
                if(returnvalue != null)
                    element.Role = returnvalue.Role;
            }
        }
    }
}
