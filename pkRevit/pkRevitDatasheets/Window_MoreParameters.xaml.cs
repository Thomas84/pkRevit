﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
using static pkRevitDatasheets.MainWindow;

namespace pkRevitDatasheets
{
    /// <summary>
    /// Interaction logic for Window_MoreParameters.xaml
    /// </summary>
    public partial class Window_MoreParameters : Window
    {
        MainWindow mainWindow { get; set; }

        public Window_MoreParameters(MainWindow mW)
        {
            mainWindow = mW;
            InitializeComponent();
        }

        private void lv_Result_BuiltIn_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int eL = -1;

            try
            {
                int int_Key = ((KeyValuePair<int, NameAndValue>)lv_Result_BuiltIn.SelectedItem).Key;
                
                List<int> list_IntFindMax = new List<int>();
                list_IntFindMax.AddRange(mainWindow.dict_SortOrdered_Shared.Keys);
                list_IntFindMax.AddRange(mainWindow.dict_SortOrdered_BuiltIn.Keys);
                int int_NewMax = list_IntFindMax.Max() + 1;

                mainWindow.lv_ReorderThis.Items.Add(new Tuple<int, string, string, bool>(int_NewMax, mainWindow.dictParameters_BuiltInt[int_Key].sName, mainWindow.dictParameters_BuiltInt[int_Key].sValue, true));
                mainWindow.dict_SortOrdered_BuiltIn.Add(int_NewMax, int_Key);

                Stream stream = new FileStream(mainWindow.string_Default_Parameters_BuiltIn, FileMode.Create, FileAccess.Write);
                DataContractSerializer serializer = new DataContractSerializer(typeof(Dictionary<int, int>));  //four of four
                serializer.WriteObject(stream, mainWindow.dict_SortOrdered_BuiltIn); stream.Close();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("lv_Result_BuiltIn_PreviewMouseDoubleClick, error line:" + eL + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void lv_Result_Shared_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int eL = -1;

            try
            {
                Guid Guid_Key = ((KeyValuePair<Guid, NameAndValue>)lv_Result_Shared.SelectedItem).Key;

                // lv_ReorderThis.Items.Add(dictParameters_Shared[Guid_Key]);

                List<int> list_IntFindMax = new List<int>();
                list_IntFindMax.AddRange(mainWindow.dict_SortOrdered_Shared.Keys);
                list_IntFindMax.AddRange(mainWindow.dict_SortOrdered_BuiltIn.Keys);
                int int_NewMax = list_IntFindMax.Max() + 1;

                mainWindow.lv_ReorderThis.Items.Add(new Tuple<int, string, string, bool>(int_NewMax, mainWindow.dictParameters_Shared[Guid_Key].sName, mainWindow.dictParameters_Shared[Guid_Key].sValue, false));
                mainWindow.dict_SortOrdered_Shared.Add(int_NewMax, Guid_Key);

                Stream stream = new FileStream(mainWindow.string_Default_Parameters_Shared, FileMode.Create, FileAccess.Write);
                DataContractSerializer serializer = new DataContractSerializer(typeof(Dictionary<int, Guid>));  //four of four
                serializer.WriteObject(stream, mainWindow.dict_SortOrdered_Shared); stream.Close();
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("lv_Result_Shared_PreviewMouseDoubleClick, error line:" + eL + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int eL = -1;

            try
            {
                Hide();
                e.Cancel = true;
            }

            #region catch and finally
            catch (Exception ex)
            {
                _952_PRLoogleClassLibrary.DatabaseMethods.writeDebug("Window_Closing, error line:" + eL + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException, true);
            }
            finally
            {
            }
            #endregion
        }
    }
}