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
        public string NameText { get; set; }
        public string SurnameText { get; set; }
        public string MailText { get; set; }
        public bool IsXML { get; set; } = true;
        public bool IsJson { get; set; } = false;
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
                    else
                    {
                        adapter = new JsonAdapter(new Json());

                    }
                    Person = new Person
                    {
                        Email = MailText,
                        Surname = SurnameText,
                        Name = NameText
                    };
                    Application application = new Application(adapter);
                    application.StartSerialize(Person);
                }
                );
        }
    }
}
