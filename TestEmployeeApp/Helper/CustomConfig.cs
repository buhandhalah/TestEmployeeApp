using TestEmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TestEmployeeApp.Helper
{
    public class CustomConfig
    {


        public string Doc_upload_path = "";

        //

        public CustomConfig()
        {
            try
            {

                Doc_upload_path = "~/Uploads1/docs/";
            }
            catch (Exception ex)
            {

            }
        }
    }

}
