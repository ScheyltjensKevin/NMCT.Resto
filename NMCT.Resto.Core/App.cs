using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using NMCT.Resto.Core.Services;
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
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes().EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();


            RegisterNavigationServiceAppStart<ViewModels.TabInfoViewModel>();
        }

        //private IRestoDataService _restoDataService;
        //public App(IRestoDataService restoData)
        //{
        //    _restoDataService = restoData;
        //}
    }
}
