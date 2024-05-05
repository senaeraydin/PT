using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public class State
    {
        public string? StateId { get; set; }
        public string? StateName { get; set; }
        public string? Description { get; set; }

        // 0 or more catalog items can be associated with one state
        public List<CatalogItem> CatalogItems { get; set; }
    }
}
