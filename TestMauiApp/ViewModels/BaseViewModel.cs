using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMauiApp.Models;

namespace TestMauiApp.ViewModels
{
    public class BaseViewModel : BaseNotifyPropertyChangedModel
    {
        public INavigation Navigation { get; set; }
    }
}
