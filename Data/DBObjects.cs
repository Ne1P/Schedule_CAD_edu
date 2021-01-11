using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ScheduleCad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCad.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           


            if (!content.Group.Any())
                content.Group.AddRange(Groups.Select(c => c.Value));


            if (!content.Lesson.Any())
            {
                content.AddRange(

                    //---------------

                    new Lesson { LesNum = 2, LesName = "Технології захисту інформації", LecName = "Томюк В.В.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 1, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 3, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 1, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 4, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 1, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 5, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 1, Group = Groups["КН-304"] },

                    new Lesson { LesNum = 1, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 1, Day = 2, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 1, LesName = "Проектування інформаційних систем", LecName = "Бокла Н.І.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 2, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 2, LesName = "Проектування інформаційних систем", LecName = "Бокла Н.І.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 2, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 2, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 4, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "525", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = false, TimeSet = 0, Day = 2, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 5, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "321", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 0, Day = 2, Group = Groups["КН-304"] },


                    new Lesson { LesNum = 1, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 2, LesName = "Технології захисту інформації", LecName = "Томюк В.В.", Room = "321", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 3, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 2, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 3, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 4, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 5, LesName = "Методи та системи штучного інтелекту", LecName = "Головацький Р.І.", Room = "321", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 3, Group = Groups["КН-304"] },

                    new Lesson { LesNum = 3, LesName = "Фізичне виховання", LecName = "", Room = "", Build = "", LesType = "Практична", AllGroup = true, AllTime = true, Day = 4, Group = Groups["КН-304"] },

                    new Lesson { LesNum = 1, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 5, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 5, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 3, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 5, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 3, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 4, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 0, Day = 5, Group = Groups["КН-304"] },
                    new Lesson { LesNum = 4, LesName = "Моделювання систем", LecName = "Тимощук П.В.", Room = "321", Build = "IV н.к.", LesType = "Практична", AllGroup = true, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-304"] },
                   
                    // -------------------

                    new Lesson { LesNum = 1 , LesName = "Методи і засоби комп'ютерних інфромаційних технологій ІІ", LecName = "Мазур В.В.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 1, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 2, LesName = "Методи та системи штучного інтелекту", LecName = "Головацький Р.І.", Room = "321", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 1, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day =1, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 4, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 1, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 5, LesName = "Технології захисту інформації", LecName = "Томюк В.В.", Room = "319", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 1, Group = Groups["КН-305"] },

                    new Lesson { LesNum = 1, LesName = "Методи та системи штучного інтелекту", LecName = "Головацький Р.І.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day =2, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 2, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 1, Day = 2, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 2, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 4, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "525", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = false, TimeSet = 0, Day =2, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 4, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 1, Day = 2, Group = Groups["КН-305"] },

                    new Lesson { LesNum = 1, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 1, LesName = "Проектування інформаційних систем", LecName = "Бокла Н.І.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 2, LesName = "Проектування інформаційних систем", LecName = "Бокла Н.І.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 4, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 5, LesName = "Технології захисту інформації", LecName = "Томюк В.В.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-305"] },

                    new Lesson { LesNum = 3, LesName = "Фізичне виховання", LecName = "", Room = "", Build = "", LesType = "Практична", AllGroup = true, AllTime = true, Day =4, Group = Groups["КН-305"] },

                    new Lesson { LesNum = 1, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 5, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 5, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 0, Day = 5, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 0, Day = 5, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Тимощук П.В.", Room = "321", Build = "IV н.к.", LesType = "Практична", AllGroup = true, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-305"] },
                    new Lesson { LesNum = 4, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day =5, Group = Groups["КН-305"] },

                    //------------------
                    
                    new Lesson { LesNum = 1, LesName = "Теорія захисту інформації", LecName = "Томюк В.В.", Room = "318", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day =1, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 1, LesName = "Методи та системи штучного інтелекту", LecName = "Головацький Р.І.", Room = "321", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 1, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 1, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 3, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 1, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 4, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 1, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 5, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day =1, Group = Groups["КН-306"] },

                    new Lesson { LesNum = 1, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 1, Day = 2, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 1, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 0, Day = 2, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Методи і засоби комп'ютерних інформаційних технологій ІІ", LecName = "Мазур В.В.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 2, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 2, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 4, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "525", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = false, TimeSet = 0, Day = 2, Group = Groups["КН-306"] },
                    
                    new Lesson { LesNum = 1, LesName = "Системи із самоорганізацією та самонавчанням", LecName = "Юрчак І.Ю.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day = 3, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 1, LesName = "Технології захисту інформації", LecName = "Томюк В.В.", Room = "319", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Системи із самоорганізацією та самонавчанням", LecName = "Юрчак І.Ю.", Room = "327", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 3, LesName = "Методи та системи штучного інтелекту", LecName = "Головацький Р.І.", Room = "323", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = true, Day =3, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 3, LesName = "Системи із самоорганізацією та самонавчанням", LecName = "Юрчак І.Ю.", Room = "322", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = true, Day = 3, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 4, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day = 3, Group = Groups["КН-306"] },
                    
                    new Lesson { LesNum = 3, LesName = "Фізичне виховання", LecName = "", Room = "", Build = "", LesType = "Практична", AllGroup = true, AllTime = true, Day = 4, Group = Groups["КН-306"] },

                    new Lesson { LesNum = 1, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "325", Build = "IV н.к.", LesType = "Лекція", AllGroup = true, AllTime = true, Day =5, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Моделювання систем", LecName = "Тимощук П.В.", Room = "318", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 0, Day = 5, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 0, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Інтелектуальний аналіз даних", LecName = "Керницький А.Б.", Room = "501", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 0, Day = 5, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 2, LesName = "Моделювання систем", LecName = "Тимощук П.В.", Room = "318", Build = "IV н.к.", LesType = "Лабораторна", AllGroup = false, NumSubGroup = 1, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-306"] },
                    new Lesson { LesNum = 3, LesName = "Моделювання систем", LecName = "Тимощук П.В.", Room = "321", Build = "IV н.к.", LesType = "Практична", AllGroup = true, AllTime = false, TimeSet = 1, Day = 5, Group = Groups["КН-306"] }
                    
                    );
            }

            if (!content.Exam.Any())
            {
                content.AddRange(

                    //---------------

                    new Exam { DateTime = new DateTime(2019, 12, 21), LesNum = 1, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group=Groups["КН-304"]},
                    new Exam { DateTime = new DateTime(2019, 12, 24), LesNum = 1, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-304"] },
                    new Exam { DateTime = new DateTime(2019, 12, 27), LesNum = 2, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-304"] },
                    new Exam { DateTime = new DateTime(2019, 12, 30), LesNum = 1, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-304"] },
                    new Exam { DateTime = new DateTime(2020, 01, 03), LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-304"] },

                    new Exam { DateTime = new DateTime(2019, 12, 21), LesNum = 1, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 24), LesNum = 2, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 0, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 24), LesNum = 2, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 1, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 27), LesNum = 2, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 0, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 27), LesNum = 2, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 1, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 30), LesNum = 1, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 0, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2019, 12, 30), LesNum = 2, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = false, NumSubGroup = 1, Group = Groups["КН-305"] },
                    new Exam { DateTime = new DateTime(2020, 01, 03), LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-305"] },

                    new Exam { DateTime = new DateTime(2019, 12, 21), LesNum = 1, LesName = "Проектування інформаційних систем", LecName = "Файтас О.І.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-306"] },
                    new Exam { DateTime = new DateTime(2019, 12, 24), LesNum = 2, LesName = "Методи та системи штучного інтелекту", LecName = "Стех Ю.В.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-306"] },
                    new Exam { DateTime = new DateTime(2019, 12, 27), LesNum = 2, LesName = "Моделювання систем", LecName = "Кособуцький П.С.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-306"] },
                    new Exam { DateTime = new DateTime(2019, 12, 27), LesNum = 2, LesName = "Технології захисту інформації", LecName = "Іванців Р.Д.", Room = "325", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-306"] },
                    new Exam { DateTime = new DateTime(2020, 01, 03), LesNum = 2, LesName = "Теоретичні основи САПР", LecName = "Колесник К.К.", Room = "327", Build = "IV н.к.", LesType = "Екзамен", AllGroup = true, Group = Groups["КН-306"] }

                    );
            }

            content.SaveChanges();
        }





        private static Dictionary<string, Group> groups;
        public static Dictionary<string, Group> Groups
        {
            get
            {
                if (groups == null)
                {
                    var list = new Group[]
                    {
                         new Group{ GroupName="КН-304"},
                         new Group{ GroupName="КН-305"},
                         new Group{ GroupName="КН-306"},
                         
                    };

                    groups = new Dictionary<string, Group>();
                    foreach(Group el in list)
                    {
                        groups.Add(el.GroupName, el);
                    }
                }

                return groups;
            }
        }

       

    }
}
