using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBug;

public partial class NewPage1ViewModel
{
    [RelayCommand]
    async Task Back()
    {
        await Shell.Current.GoToAsync("..", true, new Dictionary<string, object> { { "a", 1 } });
    }
}
