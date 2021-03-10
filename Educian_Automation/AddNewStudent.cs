using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Educian_Automation
{
    class AddNewStudent
    {
        public static void StudentAddNew()
        {
            CustomControls.click("a[data-action='Students']", propertytype.CssSelector);
            CustomControls.click("#studentSaveStudent", propertytype.CssSelector);
            //Personal Information
            CustomControls.Entertext("#first_name","dennis",propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#last_Name", "richi", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#dob", "04032006", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("#student_gender_male", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Selectdropdown("#student_category", "General", propertytype.CssSelector);
            delayfor.delay();

            //Phone
            CustomControls.Selectdropdown("#classname", "4th", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Selectdropdown("#section", "A", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#phoneNumber", "5678903424567", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#emailId", "richi@gmail.com", propertytype.CssSelector);
            delayfor.delay();

            //Parent Details
            CustomControls.Entertext("//input[@id='father_first_name']", "austin", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#father_last_name", "rchi", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("//input[@id='mother_first_name']", "Rl", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#mother_last_name", "Sim", propertytype.CssSelector);
            delayfor.delay();

            //Address
            CustomControls.Entertext("#addressline1Physical", "Green View Avuenue", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#cityPhysical", "Adamsville", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#statePhysical", "Alabama", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#pinPhysical", "132908", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.Entertext("#countryPhysical", "United States", propertytype.CssSelector);
            delayfor.delay();

            //Click Event
            CustomControls.click("#sameAsPhysical", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[name = 'save']", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click(" button[name = 'submit']", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click(" //button[normalize-space()='Ok']", propertytype.XPath);

        }

    }
}
