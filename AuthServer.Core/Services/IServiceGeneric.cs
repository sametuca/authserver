﻿using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IServiceGeneric<TEntity,TDto> 
        where TEntity : class 
        where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IQueryable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity,bool>> expression);
        Task<Response<TDto>> AddAsync(TEntity entity);
        Task<Response<NoDataDto>> Remove(TEntity entity);
        Task<Response<NoDataDto>> UpdateAsync(TEntity entity);
     
    }
}
