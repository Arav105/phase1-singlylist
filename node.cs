﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace phase1_singlylist
{
    public class node
    {
        private string data;
        private node next = null;
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

    }


}

