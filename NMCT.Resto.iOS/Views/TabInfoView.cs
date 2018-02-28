using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using NMCT.Resto.Core.ViewModels;
using System;
using UIKit;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabInfoView : MvxViewController
    {
        public TabInfoView (IntPtr handle) : base (handle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MvxFluentBindingDescriptionSet<TabInfoView, TabInfoViewModel> set = this.CreateBindingSet<TabInfoView, TabInfoViewModel>();
            set.Bind(lblName).To(vm => vm.Name);
            set.Apply();
        }
    }
}