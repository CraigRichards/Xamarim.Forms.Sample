using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarim.Forms.Sample.Models;
using Xamarim.Forms.Sample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarim.Forms.Sample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}