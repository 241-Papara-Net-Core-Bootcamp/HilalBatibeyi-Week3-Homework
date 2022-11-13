using PaparaThirdWeek.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PaparaThirdWeek.Services.Abstracts
{
    public interface ICarService
    {
        Car GetById(int id);

        public IEnumerable<Car> GetAll();

        public void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
