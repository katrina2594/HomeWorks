using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class SubHeaderViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<ThirdLevelHeaderViewModel> SubHeaders { get; set; } = new ObservableCollection<ThirdLevelHeaderViewModel>();
    }
}
