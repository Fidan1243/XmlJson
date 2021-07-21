using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Commands;
using WpfApp19.Extentions;
using WpfApp19.Models;
using WpfApp19.Views;

namespace WpfApp19.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Window1 MainWindow { get; set; }
        public Person Person { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand TextCommand { get; set; }
        public RelayCommand CheckedChanged { get; set; }
        public bool IsXML { get; set; } = true;
        public MainViewModel()
        {
            SaveCommand = new RelayCommand
                ((e) =>
                {
                    IAdapter adapter;
                    if (IsXML)
                    {
                        adapter = new XMLAdapter(new XML());
                        
                    }
                }
                );
        }
    }
}
