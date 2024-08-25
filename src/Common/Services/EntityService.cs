using Spokesoft.Clobberfest.Data.Models.Blog;

namespace Spokesoft.Clobberfest.Common.Services
{
    /// <summary>
    /// Entity service interface
    /// </summary>
    public interface IEntityService
    {
    }

    /// <summary>
    /// Generic entity service interface
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntityService<TModel, TKey>
    {
        public TModel Find(TModel id);
        public TModel Find(TKey id);
        public IEnumerable<TModel> FindRange();
        public IEnumerable<TModel> FindRange(TModel[] models);
        public IEnumerable<TModel> FindRange(TKey[] ids);
        public TModel Create(TModel model);
        public IEnumerable<TModel> CreateRange(TModel[] models);
        public TModel Update(TModel model);
        public IEnumerable<TModel> UpdateRange(TModel[] models);
        public TModel Delete(TModel model);
        public TModel Delete(TKey id);
        public IEnumerable<TModel> DeleteRange(TModel[] models);
        public IEnumerable<TModel> DeleteRange(TKey[] ids);

        public Task<TModel> FindAsync(TModel id);
        public Task<TModel> FindAsync(TKey id);
        public Task<IEnumerable<TModel>> FindRangeAsync();
        public Task<IEnumerable<TModel>> FindRangeAsync(TModel[] models);
        public Task<IEnumerable<TModel>> FindRangeAsync(TKey[] ids);
        public Task<TModel> CreateAsync(TModel model);
        public Task<IEnumerable<TModel>> CreateRangeAsync(TModel[] models);
        public Task<TModel> UpdateAsync(TModel model);
        public Task<IEnumerable<TModel>> UpdateRangeAsync(TModel[] models);
        public Task<TModel> DeleteAsync(TModel model);
        public Task<TModel> DeleteAsync(TKey id);
        public Task<IEnumerable<TModel>> DeleteRangeAsync(TModel[] models);
        public Task<IEnumerable<TModel>> DeleteRangeAsync(TKey[] ids);
    }

    public abstract partial class BaseEntityService<TModel, TKey> : IEntityService<TModel, TKey>
    {
        public TModel Create(TModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> CreateAsync(TModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> CreateRange(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> CreateRangeAsync(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public TModel Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public TModel Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> DeleteAsync(TModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> DeleteAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> DeleteRange(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> DeleteRange(TKey[] ids)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> DeleteRangeAsync(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> DeleteRangeAsync(TKey[] ids)
        {
            throw new NotImplementedException();
        }

        public TModel Find(TModel id)
        {
            throw new NotImplementedException();
        }

        public TModel Find(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> FindAsync(TModel id)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> FindAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> FindRange(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> FindRange(TKey[] ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> FindRange()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> FindRangeAsync(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> FindRangeAsync(TKey[] ids)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> FindRangeAsync()
        {
            throw new NotImplementedException();
        }

        public TModel Update(TModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> UpdateAsync(TModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> UpdateRange(TModel[] models)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> UpdateRangeAsync(TModel[] models)
        {
            throw new NotImplementedException();
        }
    }

    public partial class EntityService<TModel, TKey> : BaseEntityService<TModel, TKey>
    {

    }
}