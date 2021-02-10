using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constrait generic kısıt demek
    //10. satırdaki class aslında class değil referans tip olabilir demek
    //10. satırdaki IEntity ise hem IEntity olabilir hem de onu implemente eden nesneler olabilri demek aslında
    //10. satırdaki new () ise bu sadece new()'lenebilen bisey olabilir aslında diyoruz yani IEntity olarak almasını
    //engelliyoruz çünkü aslında IEntity bir soyut nesne, interface yani kullanamayız o yüzden işimizi aslında sağlama aldık
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
