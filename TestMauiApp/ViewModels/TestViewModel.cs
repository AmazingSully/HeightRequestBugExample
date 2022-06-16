using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMauiApp.Enums;
using TestMauiApp.Models;

namespace TestMauiApp.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(nameof(SearchText)); Task.Run(() => RefineSearchResults()); }
        }

        private RefinementType refinementType;
        public RefinementType RefinementType
        {
            get { return refinementType; }
            set { refinementType = value; OnPropertyChanged(nameof(RefinementType)); Task.Run(() => RefineSearchResults()); }
        }

        public TestViewModel()
        { 

        }

        public void RefineSearchResults()
        {
            //DO STUFF
        }
    }
}
