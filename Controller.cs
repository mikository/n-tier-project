using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    public static class Controller
    {
        public static event EventHandler<FormEventArgs> FormOpened;
        public static event EventHandler FormClosed;
        public static event EventHandler StudentPassed;
        public static event EventHandler ResourcePassed;
        private static Template[] forms = new Template[3];
        public static void OpenFrom(Template t, Template from = null)
        {
            if (from is null)
                t.panel = 1;
            else if (from.panel != 3)
                t.panel = from.panel + 1;
            else if (from.panel == 3)
                t.panel = 3;
            FormOpened.Invoke(t, new FormEventArgs(from));
        }

        internal static void CloseFrom(Template form)
        {
            FormClosed.Invoke(form, EventArgs.Empty);
        }

        public static void AssignStudent(Models.Student s)
        {
            StudentPassed.Invoke(s, EventArgs.Empty);
        }
        public static void AssignResource(Resource r)
        {
            ResourcePassed.Invoke(r, EventArgs.Empty);
        }
    }
   
    public class FormEventArgs : EventArgs
    {
        public FormEventArgs(Template f)
        {
            form = f;
        }
        public Template form;
    }
}
