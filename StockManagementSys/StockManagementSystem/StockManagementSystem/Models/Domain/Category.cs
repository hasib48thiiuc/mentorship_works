﻿using System.ComponentModel.DataAnnotations;

namespace StockManagementSystem.Models.Domain
{
    public class Category
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Item>? Items { get; set; }


    }
}
