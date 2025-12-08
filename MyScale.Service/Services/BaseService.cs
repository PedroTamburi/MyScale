using AutoMapper;
using FluentValidation;
using MyScale.Domain.Base;
using Microsoft.IdentityModel.Tokens.Experimental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Service;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
{
    private readonly IBaseRepository<TEntity> _baseRepository;
    private readonly IMapper _mapper;

    public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
    {
        _baseRepository = baseRepository;
        _mapper = mapper;
    }

    public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string> includes = null) where TOutputModel : class
    {
        var entities = _baseRepository.Select(includes);

        return _mapper.Map<IEnumerable<TOutputModel>>(entities);
    }

    public TOutputModel GetById<TOutputModel>(int id, IList<string> includes = null) where TOutputModel : class
    {
        var entity = _baseRepository.Select(id, includes);

        return _mapper.Map<TOutputModel>(entity);
    }

    public void AttachObject(object obj)
    {
        _baseRepository.AttachObject(obj);
    }

    public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
        where TInputModel : class
        where TOutputModel : class
        where TValidator : AbstractValidator<TEntity>
    {

        var entity = _mapper.Map<TEntity>(inputModel);

        Validate(entity, Activator.CreateInstance<TValidator>());

        _baseRepository.Insert(entity);

        var outputModel = _mapper.Map<TOutputModel>(entity);

        return outputModel;
    }

    public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
        where TInputModel : class
        where TOutputModel : class
        where TValidator : AbstractValidator<TEntity>
    {
        var entity = _mapper.Map<TEntity>(inputModel);

        Validate(entity, Activator.CreateInstance<TValidator>());

        _baseRepository.Update(entity);

        var outputModel = _mapper.Map<TOutputModel>(entity);

        return outputModel;
    }

    public void Delete(int id)
    {
        _baseRepository.CleanChageTracker();
        _baseRepository.Delete(id);
    }

    private void Validate<TValidator>(TEntity entity, TValidator validator) where TValidator : AbstractValidator<TEntity>
    {
        if (entity is null)
            throw new Exception("Entidade nula");

        validator.ValidateAndThrow(entity);
    }
}
