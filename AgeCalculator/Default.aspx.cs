using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgeCalculator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateAge(object sender, EventArgs e)
        {
            CalculateAgeFunction ageCalc = new CalculateAgeFunction();
            string age = ageCalc.AgeCalculator(DOB.Text);

            Age.InnerHtml = "Your Current age:<br>"+age;


        }


    }
}