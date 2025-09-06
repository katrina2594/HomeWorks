using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class HeaderViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<SubHeaderViewModel> SubHeaders { get; set; } = new ObservableCollection<SubHeaderViewModel>();
    }
}
