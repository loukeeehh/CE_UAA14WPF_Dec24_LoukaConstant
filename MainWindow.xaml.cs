using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CE_UAA14WPF_Dec24_LoukaConstant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Matrice pour les différents "jeux"
        Button[,] Marelle = new Button[6,6];
        Button[,] Solitaire = new Button[8,8];

        public MainWindow()
        {
            InitializeComponent();
            QuadrillageMarelle();
            QuadrillageSolitaire();
            //Marelle(); // fonction marelle
            //Solitaire(); // fonction solitaire
            //Solitaire3clics(); //fonction solitaire3Clics
        }

        public void QuadrillageMarelle() // quadrillage de la matrice Marelle
        {
            ColumnDefinition[] coldef = new ColumnDefinition[Marelle.GetLength(0)];

            for (int i = 0; i < coldef.Length; i++)
            {
                coldef[i] = new ColumnDefinition();
            }

            for (int i = 0;i < coldef.Length; i++)
            {
                grdMain.ColumnDefinitions.Add(coldef[i]);
            }

            RowDefinition[] rowDef = new RowDefinition[Marelle.GetLength(0)];

            for ( int i = 0; i < rowDef.GetLength(0); i++)
            {
                rowDef[i] = new RowDefinition();
            }

            for ( int i = 0; i < rowDef.GetLength(0); i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            for ( int i = 0;i < Marelle.GetLength(0) ; i++)
            {
                for (int j = 0; j < Marelle.GetLength(1); i++)
                {

                    Marelle[i, j] = new Button();
                }
            }
        }

        public void QuadrillageSolitaire() // quadrillage de la matrice solitaire
        {
            ColumnDefinition[] coldef = new ColumnDefinition[Solitaire.GetLength(0)]; //colonnes

            for (int i = 0; i < coldef.Length; i++)
            {
                coldef[i] = new ColumnDefinition();
            }

            for (int i = 0; i < coldef.Length; i++)
            {
                grdMain.ColumnDefinitions.Add(coldef[i]);
            }

            RowDefinition[] rowDef = new RowDefinition[Solitaire.GetLength(0)]; //lignes

            for (int i = 0; i < rowDef.GetLength(0); i++)
            {
                rowDef[i] = new RowDefinition();
            }

            for (int i = 0; i < rowDef.GetLength(0); i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            for (int i = 0; i < Solitaire.GetLength(0); i++)
            {
                for (int j = 0; j < Solitaire.GetLength(1); i++)
                {
                    Solitaire[i, j] = new Button();
                }
            }
        }

       

        


        }
        //private void RadioButton_Click(object sender, RoutedEventArgs e)
        //{

        //}
    
}
