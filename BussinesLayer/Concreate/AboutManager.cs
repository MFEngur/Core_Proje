﻿using BussinesLayer.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concreate
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
          _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}