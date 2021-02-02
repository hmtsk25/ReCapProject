using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //"Car" nesnemizle ilgili veritabanında yapacağımız operasyonları içerir
    public interface ICarDal
    {
        //interface metotları default olarka "public" olduğu için başlarında public olarak belirtmeye gerek yok.
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
