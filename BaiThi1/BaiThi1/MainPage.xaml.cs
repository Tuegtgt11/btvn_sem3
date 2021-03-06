using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BaiThi1.Models.Entity;
using BaiThi1.Service;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaiThi1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            RenderCategoriesToHome();
        }
        public async void RenderCategoriesToHome()
        {
            ApiService apiService = new ApiService();
            DTO.Employees employees = await apiService.GetHome();
            if (employees != null)
            {
                foreach (var c in employees.employee_list)
                {
                    Products.Items.Add(new BaiThi1.Models.Product() { name = c.name, role = c.role, birthyear = c.birthyear });
                }
            }
        }
    }
}
