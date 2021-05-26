using Domain.Interface.InterfacesProduct;
using Entities.Entities;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct
    {
        public Task<Product> GetEntiryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
