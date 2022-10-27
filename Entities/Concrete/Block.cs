using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Block : IEntity
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
    }
}
