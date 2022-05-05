using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LessonManager : ILessonService
    {
            ILessonDal _lessonDal;

            public LessonManager(ILessonDal lessondal)
            {
                _lessonDal = lessondal;
            }
            public Lesson GetById(int id)
        {
            return _lessonDal.GetByID(id);
        }

        public List<Lesson> GetList()
        {
            return _lessonDal.GetListAll();
        }

        public void LessonAdd(Lesson lesson)
        {
            _lessonDal.Insert(lesson);
        }

        public void LessonDelete(Lesson lesson)
        {
            _lessonDal.Update(lesson);
        }

        public void LessonUpdate(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
        }
    }
}
