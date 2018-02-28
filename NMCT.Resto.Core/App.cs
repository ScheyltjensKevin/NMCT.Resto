using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMCT.Resto.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewModels.TabInfoViewModel>();
        }
    }
}
