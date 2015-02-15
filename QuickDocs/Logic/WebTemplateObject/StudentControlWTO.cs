using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuickDocs.Models.Domain.Entities;

namespace QuickDocs.Logic.WebTemplateObject
{
    public class StudentControlWTO:ControlWTO
    {
        string namecontrolType;
        string namediscipline;

        public StudentControlWTO(Control control,ControlType controlType,Discipline discipline):base(control)
        {
            controlType.Name=namecontrolType;
            discipline.Name=namediscipline;
        }

        public string NameControlType
        {
            get { return namecontrolType; }
        }
        public string NameDiscipline
        {
            get { return namediscipline; }
        }
    }
}