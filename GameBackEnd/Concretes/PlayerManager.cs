using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerDal _playerDal;
        private ICustomerCheckService _customerCheckService;
        private ILoggerService _loggerService;

        public PlayerManager(IPlayerDal playerDal, ICustomerCheckService customerCheckService ,ILoggerService loggerService)
        {
            _playerDal = playerDal;
            _customerCheckService = customerCheckService;
            _loggerService = loggerService;
        }

        public void Delete(Player player)
        {
            // Transactional islemleri ve kontroller
            _playerDal.Delete(player);
            _loggerService.Log();
        }

        public List<Player> GetAll()
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _playerDal.GetAll();
        }

        public Player GetById(int id)
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _playerDal.GetById(id);
        }

        public Player GetByPlayerName(string name)
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _playerDal.GetByName(name);
        }

        public void Save(Player player)
        {
            // Transactional islemleri ve kontroller
            if (_customerCheckService.CheckIfRealPerson(player))
            {
                _playerDal.Save(player);
                _loggerService.Log();
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }

        public void Update(Player player)
        {
            // Transactional islemleri ve kontroller
            _playerDal.Update(player);
            _loggerService.Log();
        }
    }
}
