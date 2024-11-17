using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BorNaplo.model;

namespace BorNaplo
{
    public partial class Form3 : Form
    {
        private readonly FoMenu _parentForm;
        private readonly List<BorNaplo> _records;

        public Form3(FoMenu parentForm, List<BorNaplo> records)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _records = records;
        }

        //Ezutan jon(nek) a segedfuggvenye(i)m ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void SzurtListazas(List<BorNaplo> records)
        {
            Kijelzo.Items.Clear();

            foreach (var record in records)
            {
                bool kivalasztott = false;   //Ha ki van toltve valamelyik mezo, akkor aszerint szurunk, ha nincs, akkor az a szuro mindent atenged

                if (string.IsNullOrEmpty(Pinceszet.Text) || record.PinceszetNev == Pinceszet.Text) { if (string.IsNullOrEmpty(BorFajta.Text) || record.BorFajta == BorFajta.Text) { if (string.IsNullOrEmpty(SzoloFajta.Text) || record.SzoloFajta == SzoloFajta.Text) { if (Ertekeles.Value == 0 || record.Ertekeles == Ertekeles.Value) { kivalasztott = true; } } } }    //Szebb lenne tobb sorban, de igy mokasabb

                if (kivalasztott)           // Csakis az leszend a kivalasztott, ki kiallandotta az 4 probat vala (vagy kevesebbet, ha kevesebb mezo van kitoltve)
                {
                    DateOnly kostolasDateOnly = record.KostolasIdopont.HasValue ? new DateOnly(record.KostolasIdopont.Value.Year, record.KostolasIdopont.Value.Month, record.KostolasIdopont.Value.Day) : default;
                    string sor = $"{record.Id} | {record.BorNev} | {record.BorFajta} | {record.EvJarat} | {record.SzoloFajta} | {record.PinceszetNev} | {kostolasDateOnly} | {record.KostolasHelyszin} | {record.RovidJellemzes} | {record.Ertekeles}";
                    Kijelzo.Items.Add(sor);
                }
            }
        }

        //Ezutan jonnek a gombok ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Form3_Load(object sender, EventArgs e) //Azert nem szurt listazunk itt, mert a csuszka mindig be van allitva valamire, es szeretnenk, ha eloszor minden ki lenne jelezve
        {
            this.TopMost = true;

            Kijelzo.Items.Clear();

            foreach (var record in _records)
            {
                DateOnly kostolasDateOnly = record.KostolasIdopont.HasValue ? new DateOnly(record.KostolasIdopont.Value.Year, record.KostolasIdopont.Value.Month, record.KostolasIdopont.Value.Day) : default;

                string sor = $"{record.Id} | {record.BorNev} | {record.BorFajta} | {record.EvJarat} | {record.SzoloFajta} | {record.PinceszetNev} | {kostolasDateOnly} | {record.KostolasHelyszin} | {record.RovidJellemzes} | {record.Ertekeles}";
                Kijelzo.Items.Add(sor);
            }
        }

        private void Pinceszet_TextChanged(object sender, EventArgs e)
        {
            SzurtListazas(_records);
        }

        private void BorFajta_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzurtListazas(_records);
        }

        private void SzoloFajta_TextChanged(object sender, EventArgs e)
        {
            SzurtListazas(_records);
        }

        private void Ertekeles_Scroll(object sender, EventArgs e)
        {
            SzurtListazas(_records);
        }

        private void FoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}