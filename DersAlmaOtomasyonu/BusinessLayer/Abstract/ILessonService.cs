using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService
    {
        void LessonAdd(Lesson lesson);
        void LessonDelete(Lesson lesson);
        void LessonUpdate(Lesson lesson);
        List<Lesson> GetList();
        Lesson GetById(int id);
    }
}
