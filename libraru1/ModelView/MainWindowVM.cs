using jsonlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVVMlibri.Class1;

namespace libraru1.ModelView
{
    internal class MainWindowVM : BindingHelpers
    {
        public BindableCommand knopka_ser {  get; set; }

        public BindableCommand knopka_des { get; set; }


        string file = "fffrw.json";

        private string txt_box;

        public string Txt_box
        {
            get { return txt_box; }
            set { txt_box = value; OnPropertyChanged(); }
        }
        private string txt_box2;

        public string Txt_box2
        {
            get { return txt_box2; }
            set { txt_box2 = value; OnPropertyChanged(); }
        }

        private string txt_blo;

        public string Txt_blo
        {
            get { return txt_blo; }
            set { txt_blo = value; OnPropertyChanged(); }
        }

        private string txt_blo2;

        public string Txt_blo2
        {
            get { return txt_blo2; }
            set { txt_blo2 = value; OnPropertyChanged(); }
        }


        public MainWindowVM()
        {
            knopka_ser = new BindableCommand(_ => ser());

            knopka_des = new BindableCommand(_ => des());
        }


        public void ser()
        {
            strochka str = new strochka();
            str.strochk = Txt_box;
            str.choto = Txt_box2;
            ConverJson.Serialize(str, file);
        }
        public void des()
        {
            strochka strk = new strochka();
            strk = ConverJson.Desir<strochka>(file);
            Txt_blo2 = strk.choto;
            Txt_blo = strk.strochk;
        }
    }
}
