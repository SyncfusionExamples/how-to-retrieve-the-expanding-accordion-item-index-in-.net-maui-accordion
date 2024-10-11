﻿using Syncfusion.Maui.Accordion;
using Syncfusion.Maui.Core.Carousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccordionMaui
{
    public class Behavior : Behavior<SfAccordion>
    {
        #region Fields

        SfAccordion? Accordion;

        #endregion

        #region Overrides

        protected override void OnAttachedTo(SfAccordion bindable)
        {
            Accordion = bindable;
            Accordion.Expanding += Accordion_Expanding;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfAccordion bindable)
        {
            Accordion!.Expanding -= Accordion_Expanding;
            Accordion = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Events

        private void Accordion_Expanding(object? sender, ExpandingAndCollapsingEventArgs e)
        {
            App.Current!.MainPage!.DisplayAlert("", "AccordionItem expanded at index " + e.Index, "Ok");
        }
        #endregion
    }
}
