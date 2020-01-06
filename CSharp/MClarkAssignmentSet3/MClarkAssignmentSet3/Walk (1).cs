using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClarkAssignmentSet3
{
    public partial class Walk : Component
    {
        public Walk()
        {
            InitializeComponent();
        }

        public Walk(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
