using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApartmentService
    {
        IDataResult<List<Apartment>> GetAll();
        IResult Add(Apartment apartment);
        IResult Update(Apartment apartment);


        IDataResult<Apartment> GetById(int apartmentId);
    }
}
