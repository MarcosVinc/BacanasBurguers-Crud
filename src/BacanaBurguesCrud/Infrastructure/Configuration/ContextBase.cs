using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json congifurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfing());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfing() 
        {
            string strCon = "";
            return strCon;

        
        }

    }
}
