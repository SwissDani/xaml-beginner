﻿using RestaurantManager.Models;
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
	public sealed partial class ExpeditePage : Page {

		public ExpeditePage() {
			this.InitializeComponent();
		}
		
		private void btnHome_Click(object sender, RoutedEventArgs e) {
			Frame.Navigate(typeof(MainPage));
		}

		private void btnClear_Click(object sender, RoutedEventArgs e) {
			DataManager dataMgr = Application.Current.Resources["DataManager"] as DataManager;
			dataMgr.OrderItems.Clear();
		}
	}
}
