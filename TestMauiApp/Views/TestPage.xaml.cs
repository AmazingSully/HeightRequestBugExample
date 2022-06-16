using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMauiApp.Enums;
using TestMauiApp.ViewModels;

namespace TestMauiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        private static readonly IList<string> SearchButtonPressedClass = new ReadOnlyCollection<string>(new List<string> { "SearchFilterButtonPressed" });
        private static readonly IList<string> SearchButtonNotPressedClass = new ReadOnlyCollection<string>(new List<string> { "SearchFilterButton" });

        public TestPage()
        {
            InitializeComponent();
            TestViewModel vm = (TestViewModel)App.GetViewModel<TestViewModel>();
            vm.RefinementType = RefinementType.Name;
            this.BindingContext = vm;

            //NameButton.IsVisible = false;
            //ReferenceButton.IsVisible = false;
            //TownCityButton.IsVisible = false;
            //PostCodeButton.IsVisible = false;

            NameButton.StyleClass = SearchButtonPressedClass;
            ReferenceButton.StyleClass = SearchButtonNotPressedClass;
            TownCityButton.StyleClass = SearchButtonNotPressedClass;
            PostCodeButton.StyleClass = SearchButtonNotPressedClass;
        }

        private void NameButton_Pressed(object sender, EventArgs e)
        {
            NameButton.StyleClass = SearchButtonPressedClass;
            ReferenceButton.StyleClass = SearchButtonNotPressedClass;
            TownCityButton.StyleClass = SearchButtonNotPressedClass;
            PostCodeButton.StyleClass = SearchButtonNotPressedClass;
        }

        private void ReferenceButton_Pressed(object sender, EventArgs e)
        {
            NameButton.StyleClass = SearchButtonNotPressedClass;
            ReferenceButton.StyleClass = SearchButtonPressedClass;
            TownCityButton.StyleClass = SearchButtonNotPressedClass;
            PostCodeButton.StyleClass = SearchButtonNotPressedClass;
        }

        private void TownCityButton_Pressed(object sender, EventArgs e)
        {
            NameButton.StyleClass = SearchButtonNotPressedClass;
            ReferenceButton.StyleClass = SearchButtonNotPressedClass;
            TownCityButton.StyleClass = SearchButtonPressedClass;
            PostCodeButton.StyleClass = SearchButtonNotPressedClass;
        }

        private void PostCodeButton_Pressed(object sender, EventArgs e)
        {
            NameButton.StyleClass = SearchButtonNotPressedClass;
            ReferenceButton.StyleClass = SearchButtonNotPressedClass;
            TownCityButton.StyleClass = SearchButtonNotPressedClass;
            PostCodeButton.StyleClass = SearchButtonPressedClass;
        }

        private void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            //NameButton.IsVisible = true;
            //ReferenceButton.IsVisible = true;
            //TownCityButton.IsVisible = true;
            //PostCodeButton.IsVisible = true;

            Animation animate = new Animation(d => ButtonPanel.HeightRequest = d, 0, 30, Easing.Linear);
            animate.Commit(ButtonPanel, "a", 1, 500);
        }
    }
}