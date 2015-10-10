using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace RestaurantManager.UniversalWindows {
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class OrderPage : Page {

		public OrderPage() {
			this.InitializeComponent();
		}

		private void btnHome_Click(object sender, RoutedEventArgs e) {
			Frame.Navigate(typeof(MainPage));
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e) {
			if (this.lsvItems.SelectedItem != null) {
				DataManager dataMgr = Application.Current.Resources["DataManager"] as DataManager;
				dataMgr.CurrentlySelectedMenuItems.Add(this.lsvItems.SelectedItem.ToString());
			}
		}

		private void btnSubmit_Click(object sender, RoutedEventArgs e) {
			if (this.lsvOrderItems.Items.Count > 0) {
				DataManager dataMgr = Application.Current.Resources["DataManager"] as DataManager;
				dataMgr.OrderItems.Add(string.Join(", ",this.lsvOrderItems.Items));
				dataMgr.CurrentlySelectedMenuItems.Clear();
            }
		}
	}
}
