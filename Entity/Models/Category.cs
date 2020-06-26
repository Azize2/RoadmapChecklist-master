using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Category : ModelBase
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string FriendlyUrl { get; set; }
    }
}
