using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;
        private ILoggerService _loggerService;

        public GameManager(IGameDal gameDal, ILoggerService loggerService)
        {
            _gameDal = gameDal;
            _loggerService = loggerService;
        }

        public void Delete(Game game)
        {
            // Transactional islemleri ve kontroller
            _gameDal.Delete(game);
            _loggerService.Log();
        }

        public List<Game> GetAll()
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _gameDal.GetAll();
        }

        public Game GetById(int id)
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _gameDal.GetById(id);
        }

        public Game GetByName(string name)
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _gameDal.GetByName(name);
        }

        public void Save(Game game)
        {
            // Transactional islemleri ve kontroller
            _gameDal.Save(game);
            _loggerService.Log();
        }

        public void Update(Game game)
        {
            // Transactional islemleri ve kontroller
            _gameDal.Update(game);
            _loggerService.Log();
        }
    }
}
