using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Framework.Integration.Repository;
using System.Data.Entity;
using System.Configuration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DP.Core.Integration.Repository
{
    public partial class CoreContext : DataContext, IDataContext
    {
        static CoreContext()
        {
            Database.SetInitializer<CoreContext>(new MigrateDatabaseToLatestVersion<CoreContext,
                                                     Migrations.Configuration>());
            Database.SetInitializer<CoreContext>(null);
        }

        public CoreContext() 
            : base("Name=CoreContext")
        {
            int commandTimeOut = 12000;
            var configCommandTimeout = ConfigurationManager.AppSettings["DBcommandTimeOut"];

            if (!string.IsNullOrWhiteSpace(configCommandTimeout))
            {
                if (int.TryParse(configCommandTimeout, out commandTimeOut).Equals(false))
                {
                    throw new InvalidCastException("A chave'DBcommandTimeOut' está em um formato incorreto ou não existe.");
                }
            }

            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = commandTimeOut;
        }

        public virtual void ChangeLazyLoad(bool lazyLoad)
        {
            this.Configuration.LazyLoadingEnabled = lazyLoad;
        }

        #region Entities



        #endregion

        #region Views

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //System.Data.Entity.ModelConfiguration.Conventions.NavigationPropertyNameForeignKeyDiscoveryConvention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<NavigationPropertyNameForeignKeyDiscoveryConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new BaseMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new CriterionMap());
            modelBuilder.Configurations.Add(new DPSpecificationMap());
            modelBuilder.Configurations.Add(new ExpressionMap());
            modelBuilder.Configurations.Add(new FieldMap());
            modelBuilder.Configurations.Add(new ValueCriterionMap());
            modelBuilder.Configurations.Add(new ServiceMap());
            //modelBuilder.Configurations.Add(new SegmentMap());
        }
    }
}
