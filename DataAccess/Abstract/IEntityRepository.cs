using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //T:class demek T türü sadece referans tür alabilir demek
    //T:class,IEntity diyerek T için IEntity veya IEntity implement eden bir nesne olabilir demek.
    //T : class,IEntity,new() diyerek sadece new lenebilen nesneler olabilir demiş oluyoruz bu nedenle artık T IEntity olamaz. 
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
