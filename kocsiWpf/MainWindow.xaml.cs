﻿using System.Diagnostics.Metrics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kocsiWpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Kocsi> kocsik = new();
		public MainWindow()
		{
			InitializeComponent();
			var adatok = File.ReadAllLines(@"..\..\..\src\forras.txt");
			foreach (var item in adatok)
			{
				var sor = item.Split("; ");
				string nev = sor[0];
				string tip = sor[1];
				string uz = sor[2];
				int ev = int.Parse(sor[3]);
				string kep = sor[4];

				kocsik.Add(new Kocsi(nev, tip, uz, ev, kep));
			}

			foreach (var item in kocsik)
			{
				kocsikLista.Items.Add(item.Nev);
			}

			kocsikLista.SelectionChanged += change;


		}
		private void change(object sender, SelectionChangedEventArgs e)
		{
			if (kocsikLista.SelectedItem != null)
			{
				update();
			}
		}
		private void update()
		{
            if (kocsikLista.SelectedItem != null)
            {
                foreach (var item in kocsik)
                {
					NevLabel.Content = item.Nev;
					//név
					//tipus
					//üzemanyag
					//évjárat
					//kép
					TipusLabel.Content = item.Tipus;
					uzemanyagLabel.Content = item.Uzemanyag;
					
				}
			}
        }
			//- - T Ö R L É S - -
			private void torles_Click(object sender, RoutedEventArgs e)
		{
            if (kocsikLista.SelectedItem != null)
            {
                kocsikLista.Items.Remove(kocsikLista.SelectedItem);
            }
        }
	}
}