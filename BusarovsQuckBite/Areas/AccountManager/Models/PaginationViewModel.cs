﻿namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class PaginationViewModel<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}
