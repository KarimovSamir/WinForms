using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textTranslateFrom_TextChanged(object sender, EventArgs e)
        {            
            string languageFrom;
            string languageTo;
            if (this.fromLanguage.SelectedIndex == 0)
            {
                languageFrom = "en";
            }
            else if (this.fromLanguage.SelectedIndex == 1)
            {
                languageFrom = "fr";
            }
            else if (this.fromLanguage.SelectedIndex == 2)
            {
                languageFrom = "az";
            }
            else
            {
                return;
            }

            if (this.toLanguage.SelectedIndex == 0)
            {
                languageTo = "en";
            }
            else if (this.toLanguage.SelectedIndex == 1)
            {
                languageTo = "fr";
            }
            else if (this.toLanguage.SelectedIndex == 2)
            {
                languageTo = "az";
            }
            else
            {
                return;
            }
            TranslateRequest translate = new TranslateRequest() { source = languageFrom, target = languageTo, format = "text" };
            translate.q = textTranslateFrom.Text;

            WebClient web = new WebClient();
            string url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyCqwaXLLd9JraElDHNGKFIN2zfbSAgAHms";
            string answer = web.UploadString(url, JsonConvert.SerializeObject(translate));
            var response = JsonConvert.DeserializeObject<TranslateResponse>(answer);
            textTranslateTo.Text = Encoding.GetEncoding("utf-8").GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1251), Encoding.UTF8.GetBytes(response.data.translations[0].translatedText)));
        }
    }
}
