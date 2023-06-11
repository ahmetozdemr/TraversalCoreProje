using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.Destination;

namespace BusinessLayer.Concrete
{

    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void TAdd(Comment c)
        {
            _commentDal.Insert(c);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetDestiantionById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
