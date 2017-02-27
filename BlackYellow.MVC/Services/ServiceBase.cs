﻿using BlackYellow.MVC.Domain.Interfaces.Repositories;
using BlackYellow.MVC.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackYellow.MVC.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        // Aqui precisa fazer o Injeção de Dependencia - Verifica com o Arthur se é preciso
        readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public bool Delete(T obj)
        {
           return  _repository.Delete(obj);
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public bool Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}