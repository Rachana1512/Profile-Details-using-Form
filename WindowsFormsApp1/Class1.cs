using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public string name { get; set; }
        public Image img { get; set; }
        public DateTime Dob { get; set; }
        public string Gend { get; set; }
        public string Addre { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public List<string> skills = new List<string>();
        public String Resume { get; set; }
    }
}
