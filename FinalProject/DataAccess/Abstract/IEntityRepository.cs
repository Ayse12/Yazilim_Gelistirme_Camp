using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Kısıt generic
    //Generic Constraint
    //class:referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //IEntity interface olduğu için newlenemez
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //Categori ye göre listele gibi linq yapısıyla çağırdığımız işlemler için kullanmamız yeterlidir
        //x=>x.CategoryID (Kategori Idye göre getir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Tek bir filtrenin detayına
        //Örneğin bankada birden faz<la hesabınız var. Sen birine ait detay istiyorsun bu yüzde kullanırız.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
