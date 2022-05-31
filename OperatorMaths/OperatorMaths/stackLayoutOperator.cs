using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OperatorMaths
{
    public class stackLayoutOperator : element
    {
        public Entry EntryNumber1 { get; set; }
        public Entry EntryNumber2 { get; set; }
        public Entry EntryNumber3 { get; set; }
        public Label LabelOperator { get; set; }
        protected string _Operateur { get; set; }
        public stackLayoutOperator(String operateur)
        {
            _Operateur = operateur;
            EntryNumber1 = base.entryElement(100);
            EntryNumber2 = base.entryElement(100);
            EntryNumber3 = base.entryElement(100);
            LabelOperator = base.labelElement(operateur, 40, LayoutOptions.Center);
        }

        public StackLayout stack = new StackLayout()
        {
            Orientation = StackOrientation.Horizontal,
            HorizontalOptions = LayoutOptions.Center,
            Children =
            {
            }
        };
        public void InterfaceAddLessMulitplieDivisionEgal()
        {
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(LabelOperator);
            stack.Children.Add(EntryNumber2);
        }
        public void InterfaceRacine()
        {
            LabelOperator.FontSize = Device.GetNamedSize(NamedSize.Header, typeof(Label));
            stack.Children.Add(LabelOperator);
            stack.Children.Add(EntryNumber1);
        }
        public void InterfacePowerSquared()
        {
            EntryNumber1.WidthRequest = 50;
            LabelOperator.Text = "²";
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(LabelOperator);
        }
        public void InterfacePowerN()
        {
            stack.Children.Add(EntryNumber1);
            EntryNumber2.VerticalOptions = LayoutOptions.Start;
            EntryNumber2.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry));
            EntryNumber2.WidthRequest = 20;
            stack.Children.Add(EntryNumber2);
        }
        public void InterfacePoucentage()
        {
            Label lbl = base.labelElement("Number = ", 30, LayoutOptions.Center);
            Label lbl2 = base.labelElement("   %   =", 30, LayoutOptions.Center);
            stack.Orientation = StackOrientation.Vertical;
            StackLayout sl = base.stackLayoutElement(StackOrientation.Horizontal, LayoutOptions.Center);
            sl.Children.Add(lbl);
            sl.Children.Add(EntryNumber1);
            StackLayout sl2 = base.stackLayoutElement(StackOrientation.Horizontal, LayoutOptions.Center);
            sl2.Children.Add(lbl2);
            sl2.Children.Add(EntryNumber2);
            stack.Children.Add(sl);
            stack.Children.Add(sl2);
        }
        public void InterfaceFunction()
        {
            Label a = base.labelElement("x", 30, LayoutOptions.End);
            Label opera = base.labelElement("+", 40, LayoutOptions.Center);
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(a);
            stack.Children.Add(opera);
            stack.Children.Add(EntryNumber2);
        }
        private void InterfaceFunction2x()
        {
            Label a = base.labelElement("x²", 20, LayoutOptions.End);
            a.WidthRequest = 20;
            Label b = base.labelElement("x", 20, LayoutOptions.End);
            LabelOperator.Text = "+";
            Label opera = base.labelElement("+", 40, LayoutOptions.Center);
            EntryNumber1.WidthRequest = 70;
            EntryNumber2.WidthRequest = 70;
            EntryNumber3.WidthRequest = 70;
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(a);
            stack.Children.Add(LabelOperator);
            stack.Children.Add(EntryNumber2);
            stack.Children.Add(b);
            stack.Children.Add(opera);
            stack.Children.Add(EntryNumber3);
        }
        public void InterfaceConvertionHexadecimal()
        {
            EntryNumber1.Keyboard = Keyboard.Chat;
            LabelOperator.VerticalOptions = LayoutOptions.End;
            LabelOperator.FontSize = 20;
            if (_Operateur == "h>d" || _Operateur == "h>b")
                LabelOperator.Text = "16";
            else if (_Operateur == "b>d" || _Operateur == "b>h")
                LabelOperator.Text = "2";
            else
                LabelOperator.Text = "10";
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(LabelOperator);
        }

        public void InterfaceConvertionBinaireDecimal()
        {
            EntryNumber1.Keyboard = Keyboard.Numeric;
            LabelOperator.VerticalOptions = LayoutOptions.End;
            LabelOperator.FontSize = 20;
           if (_Operateur == "b>d" || _Operateur == "b>h")
                LabelOperator.Text = "2";
            else if(_Operateur == "d>h" || _Operateur == "d>b")
                LabelOperator.Text = "10";
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(LabelOperator);
        }

        public void InterfaceExponentielle()
        {
            LabelOperator.Text = "e";
            LabelOperator.FontSize = 70;
            EntryNumber1.VerticalOptions = LayoutOptions.Start;
            EntryNumber1.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry));
            stack.Children.Add(LabelOperator);
            stack.Children.Add(EntryNumber1);

        }

        public void InterfaceLogarithme()
        {
            LabelOperator.Text = "Log(";
            LabelOperator.VerticalOptions = LayoutOptions.End;
            Label a = base.labelElement(")", 40, LayoutOptions.End);
            stack.Children.Add(LabelOperator);
            stack.Children.Add(EntryNumber1);
            stack.Children.Add(a);
        }
        public StackLayout operateurStackLayout()
        {
            if (_Operateur == "+" || _Operateur == "-" ||
                _Operateur == "x" || _Operateur == "/" || _Operateur == "=")
                InterfaceAddLessMulitplieDivisionEgal();
            else if (_Operateur == "x²")
                InterfacePowerSquared();
            else if (_Operateur == "√")
                InterfaceRacine();
            else if (_Operateur == "%")
                InterfacePoucentage();
            else if (_Operateur == "f(x)")
                InterfaceFunction();
            else if (_Operateur == "ax²+bx+c")
                InterfaceFunction2x();
            else if (_Operateur == "x^(n)")
                InterfacePowerN();
            else if (_Operateur == "h>d" || _Operateur == "h>b")
                InterfaceConvertionHexadecimal();
            else if (_Operateur == "d>h" || _Operateur == "d>b" || _Operateur == "b>h" || _Operateur == "b>d")
                InterfaceConvertionBinaireDecimal();
            else if (_Operateur == "exp(x)")
                InterfaceExponentielle();
            else if (_Operateur == "log(x)")
                InterfaceLogarithme();
            return stack;
        }
    }
}
