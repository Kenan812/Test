using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Linq;

namespace ConsoleApp1
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    interface IPropertyInterface
    {
        event PropertyEventHandler PropertyChanged;
    }

    public class PropertyEventArgs
    {
        public PropertyEventArgs(string name)
        {
            Name = name;
        }

        public PropertyEventArgs()
        {
            Name = "";
        }

        public string Name { get; set; }
    }


    class SomeProp : IPropertyInterface
    {
        public event PropertyEventHandler PropertyChanged;

        public void ChangeProperty(string newName)
        {
            PropertyChanged.Invoke(this, new PropertyEventArgs(newName));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SomeProp someProp = new SomeProp();

            someProp.PropertyChanged += PropertyChange;

            someProp.ChangeProperty("new property name");



        }

        static void PropertyChange(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Property name: {e.Name}");
        }
    }
}
