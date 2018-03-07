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
            try
            {
                base.ViewDidLoad();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            //MvxFluentBindingDescriptionSet<TabInfoView, TabInfoViewModel> set = this.CreateBindingSet<TabInfoView, TabInfoViewModel>();
            //set.Bind(lblName).To(vm => vm.RestaurantContent.Name);
            //set.Bind(lblCuisines).To(vm => vm.RestaurantContent.Cuisines);
            //set.Bind(lblScore).To(vm => vm.RestaurantContent.Score);
            //set.Bind(lblPriceRange).To(vm => vm.RestaurantContent.PriceRange);
            //set.Bind(lblAddress).To(vm => vm.RestaurantContent.Location);
            //set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}