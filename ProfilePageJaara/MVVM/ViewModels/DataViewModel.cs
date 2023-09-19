using ProfilePageJaara.Models;
using ProfilePageJaara.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilePageJaara.MVVM.ViewModels
{
    public class DataViewModel
    {
        public ObservableCollection<PageElems> PageElements { get; set; }

        public DataViewModel()
        {
            PageElements = new ObservableCollection<PageElems>
            {
                new PageElems { Name = "View Profile", Image = "profile.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Notifications", Image = "notifications.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Change Pin", Image = "key.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "ID Verification", Image = "verified.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Terms & Conditions", Image = "file.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Privacy Policy", Image = "warning.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "FAQs", Image = "questions.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Contact Us", Image = "chat.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Logout", Image = "logout.svg", Chevvy = "chevron.svg" },
                new PageElems { Name = "Delete Account", Image = "delete.svg", Chevvy = "chevron.svg" },
            };


        }
    }
}
