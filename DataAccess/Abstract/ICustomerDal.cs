﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}
