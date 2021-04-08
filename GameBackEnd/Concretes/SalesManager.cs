using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class SalesManager : ISalesService
    {
        private ISalesDal _salesDal;
        private ILoggerService _loggerService;

        public SalesManager(ISalesDal salesDal, ILoggerService loggerService)
        {
            _salesDal = salesDal;
            _loggerService = loggerService;
        }

        public void Delete(Sales sales)
        {
            // Transactional islemleri ve kontroller
            _salesDal.Delete(sales);
            _loggerService.Log();
        }

        public List<Game> GetMyGames(int id)
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _salesDal.GetMyGames(id);
        }

        public void Save(Sales sales)
        {
            // Transactional islemleri ve kontroller
            _salesDal.Save(sales);
            _loggerService.Log();
        }

        public void Update(Sales sales)
        {
            // Transactional islemleri ve kontroller
            _salesDal.Update(sales);
            _loggerService.Log();
        }
    }
}
