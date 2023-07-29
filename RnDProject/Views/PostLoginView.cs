using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDProject.Views
{
    public interface PostLoginView
    {
        string UsernameText { get; set; }
        string PasswordText { get; set; }
        string UserDataText { get; set; }
    }
}
