using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OperatorMaths
{
    public class element
    {
        protected Entry entryElement(int width)
        {
            Entry EntryNumber1 = new Entry
            {
                MaxLength = 8,
                Text = "",
                Placeholder = "0",
                Keyboard = Keyboard.Numeric,
                FontSize = 40,
                WidthRequest=width,
                VerticalOptions = LayoutOptions.End,
                HorizontalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold
            };

            return EntryNumber1;
        }
        protected Label labelElement(string operateur, int taille, LayoutOptions verticalOption)
        {
            Label LabelOperator = new Label
            {
                Text = operateur,
                FontSize = taille,
                VerticalOptions = verticalOption
            };

            return LabelOperator;
        }
        protected StackLayout stackLayoutElement(StackOrientation orientation, LayoutOptions options)
        {
            StackLayout sl = new StackLayout()
            {
                Orientation = orientation,
                HorizontalOptions = options,
                Children =
                {
                }
            };

            return sl;
        }
    }

}