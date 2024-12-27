﻿namespace haircutUI.ViewModel
{
    public class HaircutMenuItemViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Time { get; set; }
        public int HaircutMenuCategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string? CategoryName { get; set; } // For display in the index view
    }
}
