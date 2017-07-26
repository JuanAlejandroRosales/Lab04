using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            /* Creamos la instancia del código compartido
            y le inyectamos la dependencia. */
            var Validator = new PCLProyect.AppValidator(new AndroidDialog(this));
            /* Aquí podríamos establecer los valores de las propiedades
            * EMail, Password y Device*/
            // Realizamos la validación
            //Validator.Validate();

            /* Aquí podríamos establecer los valores de las propiedades
            * EMail, Password y Device*/
            Validator.EMail = "jarc_software@hotmail.com";
            Validator.Password = "Jrosales23";
            Validator.Device =
            Android.Provider.Settings.Secure.GetString(
            ContentResolver,
            Android.Provider.Settings.Secure.AndroidId);
            // Realizamos la validación
            Validator.Validate();

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

