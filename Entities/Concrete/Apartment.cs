using Core.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Entities.Concrete
{
    public class Apartment : IEntity
    {
        public int ApartmentId { get; set; }
        public bool Status { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public int BlockId { get; set; }

    }
}