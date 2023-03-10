using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concreate
{
	public class WriterUserManager : IWriterUserService
	{
		IWriterUserDal _writeUserDal;

		public WriterUserManager(IWriterUserDal writeUserDal)
		{
			_writeUserDal = writeUserDal;
		}

		public void TAdd(WriterUser t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(WriterUser t)
		{
			throw new NotImplementedException();
		}

		public WriterUser TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<WriterUser> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(WriterUser t)
		{
			throw new NotImplementedException();
		}
	}
}
