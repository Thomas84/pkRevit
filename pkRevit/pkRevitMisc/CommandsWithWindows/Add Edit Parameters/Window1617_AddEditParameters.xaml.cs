﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.ExtensibleStorage;
using _952_PRLoogleClassLibrary;
using pkRevitMisc.EntryPoints;

namespace pkRevitMisc.CommandsWithWindows.Add_Edit_Parameters
{
    /// <summary>
    /// Interaction logic for Window1617_AddEditParameters.xaml
    /// </summary>
    public partial class Window1617_AddEditParameters : Window
    {
        public ExternalCommandData commandData { get; set; }
        //////public Entry_0170_pkRevitMisc myWindow1 { get; set; }


        public EE16_AddSharedParameters_InVariousWays myEE16_AddSharedParameters_InVariousWays { get; set; }
        public ExternalEvent myExternalEvent_EE16_AddSharedParameters_InVariousWays { get; set; }

        public EE17_Edit_StringBasedParameters myEE17_Edit_StringBasedParameters { get; set; }
        public ExternalEvent myExternalEvent_EE17_Edit_StringBasedParameters { get; set; }




        //////////////public bool myBool_AddToProject { get; set; } = true;



        public partial class aBuiltInParameter_and_Name
        {
            public BuiltInParameter theBIP { get; set; }
            public string theParameterName { get; set; }   //Note DisplayMemberPath doesn't work unless it is an auto-implementing field (uses get;set)
            public bool theIsBuiltInParameter { get; set; }
        }

        public Window1617_AddEditParameters(ExternalCommandData cD)
        {
            commandData = cD;

            InitializeComponent();


            myEE16_AddSharedParameters_InVariousWays = new EE16_AddSharedParameters_InVariousWays();
           // myEE16_AddSharedParameters_InVariousWays.myWindow1 = this;
            myExternalEvent_EE16_AddSharedParameters_InVariousWays = ExternalEvent.Create(myEE16_AddSharedParameters_InVariousWays);

            myEE17_Edit_StringBasedParameters = new EE17_Edit_StringBasedParameters();
            //myEE17_Edit_StringBasedParameters.myWindow1 = this;
            myExternalEvent_EE17_Edit_StringBasedParameters = ExternalEvent.Create(myEE17_Edit_StringBasedParameters);


            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            if (uidoc.Selection.GetElementIds().Count != 0)
            {
                myIntegerUpDown.Value = uidoc.Selection.GetElementIds().First().IntegerValue;

                Element myElement = doc.GetElement(uidoc.Selection.GetElementIds().First());
                myLabel_Type.Content = myElement.Name;
                myLabel_Family.Content = myElement.get_Parameter(BuiltInParameter.ELEM_FAMILY_PARAM).AsValueString();
            }

            if (true)
            {
                BuiltInParameter myBIP = BuiltInParameter.ALL_MODEL_TYPE_COMMENTS;
                string myParameterName = "ALL_MODEL_TYPE_COMMENTS";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theBIP = myBIP, theParameterName = myParameterName, theIsBuiltInParameter = true };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }
            if (/*hash out x2,*HASH OUT IN *.txt* ______ x2, and this -> x 5*/true) //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE 
            {
                BuiltInParameter myBIP = BuiltInParameter.ALL_MODEL_DESCRIPTION; //ALL_MODEL_DESCRIPTION
                string myParameterName = "ALL_MODEL_DESCRIPTION";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theBIP = myBIP, theParameterName = myParameterName, theIsBuiltInParameter = true };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }
            if (true)
            {
                BuiltInParameter myBIP = BuiltInParameter.ALL_MODEL_MANUFACTURER;
                string myParameterName = "ALL_MODEL_MANUFACTURER";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theBIP = myBIP, theParameterName = myParameterName, theIsBuiltInParameter = true };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }
            if (true)
            {
                string myParameterName = "Manufacturer Alternative1";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }
            if (/*hash out x2,*HASH OUT IN *.txt* ______ x2, and this -> x 5*/true) //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE 
            {
                string myParameterName = "Manufacturer Alternative2";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }
            if (/*hash out x2,*HASH OUT IN *.txt* ______ x2, and this -> x 5*/true) //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE 
            {
                string myParameterName = "Manufacturer Alternative3";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxTypeParameters.Items.Add(myBIP_and_IsStance);
            }

            if (true)
            {
                BuiltInParameter myBIP = BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS;
                string myParameterName = "ALL_MODEL_INSTANCE_COMMENTS";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theBIP = myBIP, theParameterName = myParameterName, theIsBuiltInParameter = true };
                myListBoxInstanceParameters.Items.Add(myBIP_and_IsStance);
            }
            if (true)
            {
                string myParameterName = "Comments1";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxInstanceParameters.Items.Add(myBIP_and_IsStance);
            }
            if (/*hash out x2,*HASH OUT IN *.txt* ______ x2, and this -> x 5*/true) //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE 
            {
                string myParameterName = "Comments2";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxInstanceParameters.Items.Add(myBIP_and_IsStance);
            }
            if (/*hash out x2,*HASH OUT IN *.txt* ______ x2, and this -> x 5*/true) //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE //make false make FALSE make FALSE 
            {
                string myParameterName = "Comments3";

                aBuiltInParameter_and_Name myBIP_and_IsStance = new aBuiltInParameter_and_Name() { theParameterName = myParameterName, theIsBuiltInParameter = false };
                myListBoxInstanceParameters.Items.Add(myBIP_and_IsStance);
            }

            myListBoxTypeParameters.SelectedIndex = -1;
            myListBoxInstanceParameters.SelectedIndex = -1;

        }

        private void MyButtonAcquireSelected_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;

                if (uidoc.Selection.GetElementIds().Count != 1)
                {
                    MessageBox.Show("Please select an element first.");
                    return;
                }

                Element myElement = doc.GetElement(uidoc.Selection.GetElementIds().First());

                myIntegerUpDown.Value = uidoc.Selection.GetElementIds().First().IntegerValue;
                myLabel_Type.Content = myElement.Name;
                myLabel_Family.Content = myElement.get_Parameter(BuiltInParameter.ELEM_FAMILY_PARAM).AsValueString();

                myTextBoxPrevious.Text = "";
                myTextBoxNew.Text = "";
                myListBoxInstanceParameters.SelectedIndex = -1;
                myListBoxTypeParameters.SelectedIndex = -1;
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("MyButtonAcquireSelected_Click" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        public bool myBool_StayDown { get; set; } = false;

        private void myListBoxInstanceParameters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!myBool_StayDown) myTextBoxNew.IsEnabled = true;
                myBool_StayDown = false;

                if (myListBoxInstanceParameters.SelectedIndex == -1) return;

                myTextBoxPrevious.Text = "";
                myTextBoxNew.Text = "";
                // myTextBoxNew.IsEnabled = true;

                myListBoxTypeParameters.SelectedIndex = -1;

                if (myListBoxInstanceParameters.SelectedItems.Count != 1) return;

                if (myIntegerUpDown.Value.Value == -1)
                {
                    myTextBoxPrevious.Text = "";
                    myTextBoxNew.Text = "";
                    myListBoxInstanceParameters.SelectedIndex = -1;
                    myListBoxTypeParameters.SelectedIndex = -1;

                    MessageBox.Show("Please select and 'Acquire' an entity.");
                    return;
                }

                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;

                Element myElement = doc.GetElement(new ElementId(myIntegerUpDown.Value.Value));

                if (myElement == null)
                {
                    myIntegerUpDown.Value = -1;
                    return;
                }

                Parameter myParameter = null;

                if (((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxInstanceParameters.SelectedItem).theIsBuiltInParameter)
                {
                    myParameter = myElement.get_Parameter(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxInstanceParameters.SelectedItem).theBIP);  //myListBoxTypeParameters
                }
                else
                {
                    if (myElement.LookupParameter(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxInstanceParameters.SelectedItem).theParameterName) == null) return;

                    myParameter = myElement.GetParameters(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxInstanceParameters.SelectedItem).theParameterName)[0];
                }

                if (myParameter == null) return;

                myTextBoxPrevious.Text = myParameter.AsString();
                myTextBoxNew.Text = myParameter.AsString();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myListBoxInstanceParameters_SelectionChanged" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void myListBoxTypeParameters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (!myBool_StayDown) myTextBoxNew.IsEnabled = true;
                myBool_StayDown = false;

                if (myListBoxTypeParameters.SelectedIndex == -1) return;


                myTextBoxPrevious.Text = "";
                myTextBoxNew.Text = "";


                myListBoxInstanceParameters.SelectedIndex = -1;

                if (myListBoxTypeParameters.SelectedItems.Count != 1) return;

                if (myIntegerUpDown.Value.Value == -1)
                {
                    myTextBoxPrevious.Text = "";
                    myTextBoxNew.Text = "";
                    myListBoxInstanceParameters.SelectedIndex = -1;
                    myListBoxTypeParameters.SelectedIndex = -1;

                    MessageBox.Show("Please select and 'Acquire' an entity.");
                    return;
                }

                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;

                Element myElement = doc.GetElement(new ElementId(myIntegerUpDown.Value.Value));

                if (myElement == null)
                {
                    myIntegerUpDown.Value = -1;

                    return;
                }

                myElement = doc.GetElement(myElement.GetTypeId());

                Parameter myParameter = null;

                if (((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxTypeParameters.SelectedItem).theIsBuiltInParameter)
                {
                    myParameter = myElement.get_Parameter(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxTypeParameters.SelectedItem).theBIP);  //myListBoxTypeParameters
                }
                else
                {
                    if (myElement.LookupParameter(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxTypeParameters.SelectedItem).theParameterName) == null) return;

                    myParameter = myElement.GetParameters(((Window1617_AddEditParameters.aBuiltInParameter_and_Name)myListBoxTypeParameters.SelectedItem).theParameterName)[0];
                }

                if (myParameter == null) return;

                myTextBoxPrevious.Text = myParameter.AsString();
                myTextBoxNew.Text = myParameter.AsString();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myListBoxTypeParameters_SelectionChanged" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void myButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (myListBoxTypeParameters.SelectedIndex == -1 & myListBoxInstanceParameters.SelectedIndex == -1) return;

                myEE17_Edit_StringBasedParameters.myWindow2 = this;
                myExternalEvent_EE17_Edit_StringBasedParameters.Raise();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myButtonSave_Click" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void myButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myButtonCancel_Click" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void myButtonAddParametersToProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myEE16_AddSharedParameters_InVariousWays.myWindow2 = this;
                myEE16_AddSharedParameters_InVariousWays.myBool_AddToProject = true;
                myExternalEvent_EE16_AddSharedParameters_InVariousWays.Raise();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myButtonAddParametersToProject_Click" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void myButtonAddParametersToFamily_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myEE16_AddSharedParameters_InVariousWays.myWindow2 = this;
                myEE16_AddSharedParameters_InVariousWays.myBool_AddToProject = false;
                myExternalEvent_EE16_AddSharedParameters_InVariousWays.Raise();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("myButtonAddParametersToFamily_Click" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }
    }
}
