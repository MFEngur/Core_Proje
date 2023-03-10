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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;
        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
           _portfolioDal.Update(t);
        }
    }
}