using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Tag:ModelBase
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string FriendlyUrl { get; set; }
    }
}
