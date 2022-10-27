using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApartmentManager : IApartmentService
    {
        IApartmentDal _apartmentDal;

        public ApartmentManager(IApartmentDal apartmentDal)
        {
            _apartmentDal = apartmentDal;
        }

        public IResult Add(Apartment apartment)
        {
          _apartmentDal.Add(apartment);
            return new SuccessResult("asdasdads");
        }

        public IDataResult<List<Apartment>> GetAll()
        {
            return new SuccessDataResult<List<Apartment>>(_apartmentDal.GetAll(), "Daireler getirildi.");
        }

        public IDataResult<List<Apartment>> GetAllByFloor(int floorNum)
        {
            return new SuccessDataResult<List<Apartment>>(_apartmentDal.GetAll(a=>a.Floor==floorNum),"Daireler getirildi.");
        }

        public IDataResult<Apartment> GetById(int apartmentId)
        {
            return new SuccessDataResult<Apartment>(_apartmentDal.Get(a => a.ApartmentId == apartmentId),"dfsdfsdfsf");
        }

        public IResult Update(Apartment apartment)
        {
            _apartmentDal.Update(apartment);
            return new SuccessResult("dfadfsdfsdfsdfs");
        }
    }
}
