﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.About;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
    }
}