using QuickDocs.Models.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace QuickDocs.Logic.WebTemplateObject
{
    public class ControlWTO
    {
        string name;
        int maxPoints;
        int minPoints;
        int moduleNum;
        int numControl;
        int week;

        public ControlWTO(Control control)
        {
            name = control.Name;
            maxPoints = control.MaxPoints;
            minPoints = control.MinPoints;
            moduleNum = control.ModuleNum;
            numControl = control.NumControl;
            week = control.Week;
        }

        public string Name
        {
            get { return name; }
        }
        public int MaxPoints
        {
            get { return maxPoints; }
        }
        public int MinPoints
        {
            get { return minPoints; }
        }
        public int ModuleNum
        {
            get { return moduleNum; }
        }
        public int NumControl
        {
            get { return numControl; }
        }
        public int Week
        {
            get { return week; }
        }
    }
}