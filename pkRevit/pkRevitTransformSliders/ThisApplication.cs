﻿/*
 * Created by SharpDevelop.
 * User: Joshua.Lumley
 * Date: 28/04/2019
 * Time: 5:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System.Collections.Generic;
using System.Linq;

namespace RevitTransformSliders
{
	public partial class ThisApplication2
	{

        public string messageConst { get; set; }
        //this is is the method that invoked from outside

            //this is is the method that invoked from outside
            public Result OpenWindowForm(ExternalCommandData commandData, ref string message, ElementSet elements)
            {
                messageConst = message;

                try
            {
                Window1 myWindow1 = new Window1(commandData, this)  ;
                myWindow1.Show();
            }

            #region catch and finally
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            #endregion

            return Result.Succeeded;
        }


	}
}