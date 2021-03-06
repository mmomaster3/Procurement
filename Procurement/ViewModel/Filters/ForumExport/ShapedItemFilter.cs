﻿using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class ShapedItemFilter : IFilter
    {
        public bool CanFormCategory
        {
            get
            {
                return false;
            }
        }

        public string Keyword
        {
            get
            {
                return "Shaped Items";
            }
        }

        public string Help
        {
            get
            {
                return "All Shaped Items";
            }
        }

        public FilterGroup Group
        {
            get
            {
                return FilterGroup.Default;
            }
        }

        public bool Applicable(Item item)
        {
            return item.Shaper;
        }
    }
}