using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;


namespace DP.Core.Integration.Repository.Mapping.Common
{
    public abstract class KeyEntityMap<T> : EntityTypeConfiguration<T> where T : KeyEntity
    {
        public KeyEntityMap()
        {

            //this.ToTable(tableName.ToUpper(), schemaName.ToUpper());

            #region Primary Key

            this.HasKey(o => o.UniqueId);
            this.Property(o => o.UniqueId)
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #endregion

        }

    }
}
