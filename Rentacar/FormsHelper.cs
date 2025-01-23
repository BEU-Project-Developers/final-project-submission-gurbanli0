using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentacar.model.dto;

namespace Rentacar
{
    public class FormsHelper
    {
        public static CustomerDto CURRENT_CUSTOMER = null;

        public static void ShowInfoForm<T>(List<T> items)
        {
            var fi = new InformationForm();
            fi.ShowInfo(items);
            fi.ShowDialog();
        }
    }
}
