using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinContacts.Models;

namespace XamarinContacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactInformationPage : ContentPage
    {
        public string PageTitle { get; set; }
        public ContactInformationPage()
        {
            InitializeComponent();

            // set the page title to the contact name
            if (BindingContext != null)
            {
                var contact = BindingContext as Contact;

                PageTitle = contact.LastName + ", " + contact.FirstName;
            }
            else
            {
                PageTitle = "New Contact";
            }

            Page.Title = PageTitle;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


        }

        public void OnUploadImageClicked(object sender, EventArgs e)
        {

        }
    }
}