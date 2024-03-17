using Intro.DataAccess;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal; //dependency injection

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course>GetAll()//metod
    {
        // business rules
        

        return _courseDal.GetAll();
    }

}
