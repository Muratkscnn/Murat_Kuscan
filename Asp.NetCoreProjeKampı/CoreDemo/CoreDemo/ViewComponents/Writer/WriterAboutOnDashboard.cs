using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard :ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = writermanager.GetWritertById(1);
            return View(values);
        }

    }
}
