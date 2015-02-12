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
        int maxpoints;
        int minpoints;
        int modulenum;
        int numcontrol;
        int week;

        public ControlWTO(Control control)
        {
            name = control.Name;
            maxpoints = control.MaxPoints;
            minpoints = control.MinPoints;
            modulenum = control.ModuleNum;
            numcontrol = control.NumControl;
            week = control.Week;
        }

        public string Name
        {
            get { return name; }
        }
        public int MaxPoints
        {
            get { return maxpoints; }
        }
        public int MinPoints
        {
            get { return minpoints; }
        }
        public int ModuleNum
        {
            get { return modulenum; }
        }
        public int NumControl
        {
            get { return numcontrol; }
        }
        public int Week
        {
            get { return week; }
        }
    }
}