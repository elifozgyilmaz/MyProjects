using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaglikUrunleri.DAL;
using SaglikUrunleri.DAL.Context;

namespace SaglikUrunleri.BLL
{
    public class UnitofWork : IUnitOfWork
    {
        private SaglikContext dbContext;
        //database e bağlanmak için encapsulation kullandık
        public UnitofWork(SaglikContext dbContext) //dependency injection :bağımlı olduğumuz sınıfları, kendi sınıflarımız içine enjekte ederek kullanmak.
        {
            this.dbContext = dbContext;
        }
        public SaglikContext DbContext
        {
            get { return dbContext; }
        }
        public void Commit()
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
