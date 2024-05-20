using app07.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12;
internal class Repository
{
    protected AppDbContext ctx { get; set; }    

    public Repository()
    {
        ctx = new AppDbContext();
    }

    //CRUD

    public void SaveChanges()
    {
        ctx.SaveChanges();
    }

    public T Create<T>(T model) where T : class
    {
        ctx.Set<T>().Add(model);
        return model;
    }


    public T Update<T>(T model) where T : class
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return model;
    }

    public T Find<T>(int id) where T : class
    {
        return ctx.Set<T>().Find(id);
    }

    public void Delete<T>(T model) where T : class
    {
        ctx.Set<T>().Remove(model);
    }

    public void Delete<T>(int id) where T : class
    {
        var model = Find<T>(id);
        ctx.Set<T>().Remove(model);
    }

    public IQueryable<T> AsQueryable<T>() where T : class
    {
        return ctx.Set<T>().AsQueryable();
    }
}
