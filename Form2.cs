using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BorNaplo.model;

namespace BorNaplo
{
    public partial class Form2 : Form
    {
        private readonly FoMenu _parentForm;
        private readonly List<BorNaplo> _records;

        public Form2(FoMenu parentForm, List<BorNaplo> records) //A parentformot is adatatadas miatt adtam a kmonstruktorhoz, de mar nem emlekszem miert nem mukodott
        {
            InitializeComponent();
            _parentForm = parentForm;
            _records = records;
        }

        //Ezutan jon(nek) a segedfuggvenye(i)m ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void KorDiagramAktualizalas(DateTime kezdetDatum, DateTime vegDatum)
        {
            BorKategoriaMegoszlas.Titles.Clear();
            BorKategoriaMegoszlas.Series[0].Points.Clear();                                         // Ures grafikonhoz adunk majd adatokat

            Dictionary<string, int> adatok = new Dictionary<string, int>();                         // Ebbe toltjuk bele a Pie Chart adatait

            foreach (var record in _records)                                                        //Vegigmegyunk minden adatrekordon
            {
                if (record.KostolasIdopont >= kezdetDatum && record.KostolasIdopont <= vegDatum)    //Ha a megadott intervallumba esik, csak akkor dolgozunk vele
                {
                    string borFajta = record.BorFajta;
                    if (adatok.ContainsKey(borFajta))
                    {
                        adatok[borFajta]++;                                                         //Es ha ismeros a borfajta, akkor hozzaadjuk a szamlalojahoz
                    }
                    else
                    {
                        adatok.Add(borFajta, 1);                                                    //Ha nem, akkor viszont uj szamlalot kezdunk 1rol
                    }
                }
            }

            var novekvoSorrend = adatok.OrderByDescending(x => x.Value);                            //csak hogy kevesbe legyen kaotikus a grafikon

            foreach (var adat in novekvoSorrend)
            {
                BorKategoriaMegoszlas.Series[0].Points.AddXY(adat.Key, adat.Value);                 // Az igy kinyert szamlalokat (a nevukkel egyutt) atadjuk a diagrammnak
                BorKategoriaMegoszlas.Series[0].Points.Last().Label = $"{adat.Key}: #VALY";         // A korcikkekhez tartozo cimkeknek is atadjuk a szamot, kategorianevet hogy megjelenitse
            }

            BorKategoriaMegoszlas.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;  //Borosabb szinvilag, mint az eredeti grafikonon
            BorKategoriaMegoszlas.Series[0]["PieLabelStyle"] = "Inside";                                                        //Belul vannak a nevek, igy tobb hely marad a grafikonnak
            BorKategoriaMegoszlas.Series[0].IsValueShownAsLabel = true;
            BorKategoriaMegoszlas.Series[0].Font = new System.Drawing.Font("Comic Sans MS", 9, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            BorKategoriaMegoszlas.Series[0].LabelBackColor = Color.Black;
            BorKategoriaMegoszlas.Series[0].LabelForeColor = Color.White; // Cimkek szine

            // Cimsor
            int osszeg = adatok.Values.Sum();
            if (osszeg > 0) { BorKategoriaMegoszlas.Titles.Add($"A megadott idointervallumban osszesen megkostolt borok: {osszeg} db.");                                  }
            else            { BorKategoriaMegoszlas.Titles.Add(" A megadott idointervallumban nem tortent borkostolas!\n(vagy veg utani kezdet van megadva lol)");  }
            BorKategoriaMegoszlas.Titles[0].Font = new System.Drawing.Font("Comic Sans MS", 12, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            BorKategoriaMegoszlas.Titles[0].ForeColor = Color.White; // Szöveg színe

            BorKategoriaMegoszlas.Invalidate(); //A vegen a diagrammot frissitjuk (a jelenlegi verzioba nem fontos igazan)
        }

        //Ezutan jonnek a gombok ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Form2_Load(object sender, EventArgs e)
        {
            //_parentForm.Close();  //  Sehogy nem tudom megoldani, hogy az eredeti bezaruljon, de ez nyitva maradjon
            this.TopMost = true;    //  Igy legalabb csak 1db Form2-t tud megnyitni a felhasznalo

            KorDiagramAktualizalas(Kezdet.Value, Veg.Value);
        }

        private void Kezdet_ValueChanged(object sender, EventArgs e)
        {
            KorDiagramAktualizalas(Kezdet.Value, Veg.Value);
        }

        private void Veg_ValueChanged(object sender, EventArgs e)
        {
            KorDiagramAktualizalas(Kezdet.Value, Veg.Value);
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}