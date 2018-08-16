using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App_PetPooling.Usuarios
{
    class Registration
    {

        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string code { get; set; }
        public bool car { get; set; }
        public string password { get; set; }
        public string passwordConfirmation { get; set; }

    }
}