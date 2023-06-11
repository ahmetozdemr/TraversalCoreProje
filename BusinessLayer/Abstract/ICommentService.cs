using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.Destination;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> TGetDestiantionById(int id);
    }
}
