﻿using AlbumLieux.ViewModels;
using Storm.Mvvm.Forms;
using Xamarin.Forms;

namespace AlbumLieux
{
	public partial class MainPage : BaseContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
		}

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (BindingContext is MainViewModel mainViewModel)
			{
				mainViewModel.ItemSelectedCommand.Execute(e.Item);
			}
		}
	}
}
