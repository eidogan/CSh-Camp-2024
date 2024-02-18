﻿using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager //operasyon tutucu sınıf
{
    Course[] courses = new Course[3]; //global scope
    public CourseManager() //constructor
    {
        
        Course course1 = new Course(); 

        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET8 vs...";
        course1.Price = 0;

        Course course2 = new Course(); //
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "JAVA 17...";
        course2.Price = 10;

        Course course3 = new Course(); //
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12...";
        course3.Price = 20;

        //courses = { course1, course2, course3};
        courses[0]= course1;
        courses[1]= course2;
        courses[2]= course3;
    
    }
    
    /*public void GetAll() //void bir şey döndürmez
    {
        //veri kaynağından çekilir...
        //Console.WriteLine("Kurslar listelendi");

    }*/
    
    public Course[] GetAll()//metod
    {
        return courses;
    }
}
