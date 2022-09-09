using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBug;

public partial class MainPageViewModel : IQueryAttributable
{
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Trace.WriteLine(query);
    }

    [RelayCommand]
    async Task GoToNewPage1()
    {
        await Shell.Current.GoToAsync("NewPage1", true);
    }
}
