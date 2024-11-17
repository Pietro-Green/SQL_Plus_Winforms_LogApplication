using BorNaplo.model;
using System;
using System.Windows.Forms;

namespace BorNaplo
{
    public partial class FoMenu : Form
    {
        private readonly Adatbazis _db;

        public FoMenu()
        {
            InitializeComponent();
            _db = new Adatbazis();
        }

        //Ezutan jon(nek) a segedfuggvenye(i)m ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void KijelzoAktualizalas()
        {
            List<BorNaplo> borNaploElemek = _db.BorNaplos.OrderBy(b => b.Id).ToList(); // BorNaplo elemek az adatbazisbol (novekvo ID szerint)

            Kijelzo.Items.Clear(); // Urites betoltes elott

            // Betoltes listboxba
            foreach (var elem in borNaploElemek)    //foreachben a var nem undorit, mert erre van a generikus tipus eleve
            {
                // Nem szeretnem a napnal pontosabban kijelezni a kostolas idopontjat, mert ugyis datetimepickert hasznalunk az adatbevitelre (az adatbazis felallitasakor ezt meg nem tudtam)
                //DateOnly KostolasDateOnly = new DateOnly(elem.KostolasIdopont.Year, elem.KostolasIdopont.Month, elem.KostolasIdopont.Day); //Valamiert hibauzenetet dob, ha nem ellenorizzuk, hogy nullerteku e, mielott atadjuk az adatot a kurtitott verzionak
                DateOnly KostolasDateOnly = elem.KostolasIdopont.HasValue ? new DateOnly(elem.KostolasIdopont.Value.Year, elem.KostolasIdopont.Value.Month, elem.KostolasIdopont.Value.Day) : default;   //A default amugy is null, ugyhogy semmi ertelme AAA

                // Tenyleges kimeneti sor:
                string sor = $"{elem.Id} | {elem.BorNev} | {elem.BorFajta} | {elem.EvJarat} | {elem.SzoloFajta} | {elem.PinceszetNev} | {KostolasDateOnly} | {elem.KostolasHelyszin} | {elem.RovidJellemzes} | {elem.Ertekeles}";
                Kijelzo.Items.Add(sor); // Mehet is a kijelzore
            }

            if (Kijelzo.Items.Count > 0) //Ha van benne egyáltalán bármi
            {
                Kijelzo.SelectedIndex = Kijelzo.Items.Count - 1;    //Az utolsó legyen a kiválasztott
            }
        }

        //Ezutan jonnek a gombok ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Betoltes_Click(object sender, EventArgs e)
        {
            KijelzoAktualizalas();
        }

        private void Kijelzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ha van kivalasztott elem (ez talan mindig igaz, de jobb felni)
            if (Kijelzo.SelectedItem != null)
            {
                // Kikotorjuk a szoveget
                string selectedRow = Kijelzo.SelectedItem.ToString();   //WARNING: azt hiszi, lehet ures, de a design miatt nem

                // Feldaraboljuk a | -k menten (eredetileg nem ezert raktam bele, de jo ilyen barbar megoldashoz is)
                string[] elements = selectedRow.Split('|');             //WARNING: szinten

                // Ertek atadas a forms elemeknek jobboldalt
                BorNeve.Text = elements[1].Trim();
                BorFajtaja.Text = elements[2].Trim();
                BorEvjarata.Value = Convert.ToDateTime(elements[3].Trim());
                SzoloFajtaja.Text = elements[4].Trim();
                PinceszetNeve.Text = elements[5].Trim();
                KostolasIdopontja.Value = Convert.ToDateTime(elements[6].Trim());
                KostolasHelyszine.Text = elements[7].Trim();
                RovidErtekeles.Text = elements[8].Trim();
                trackBar1.Value = int.Parse(elements[9].Trim());
            }
        }

        private void HozzaAdas_Click(object sender, EventArgs e)
        {
            // Ha nincs ures mezo
            if (string.IsNullOrWhiteSpace(BorNeve.Text) ||
                string.IsNullOrWhiteSpace(BorFajtaja.Text) ||
                string.IsNullOrWhiteSpace(SzoloFajtaja.Text) ||
                string.IsNullOrWhiteSpace(PinceszetNeve.Text) ||
                string.IsNullOrWhiteSpace(KostolasHelyszine.Text) ||
                string.IsNullOrWhiteSpace(RovidErtekeles.Text))     //Rossz nevet adtam neki, de igy is mukodik sebaj
            {
                MessageBox.Show("A hozzadashoz szukseges minden mezo kitoltese!\n\n\n\t\t\t(ง •̀_•́)ง");
                return;
            }

            // Es az eloirtnal nem hosszabb a rovid leiras
            if (RovidErtekeles.Text.Length > 1000)
            {
                MessageBox.Show("A rovid jellemzes nem lehet hosszabb, mint 1000 karakter!\n\n\n\t\t\t(ง •̀_•́)ง");
                return;
            }

            // Es eltarolhato datumokat valasztottak (azt hiszem 1753 utaniak jok csak)
            if (BorEvjarata.Value < DateTime.MinValue || KostolasIdopontja.Value < DateTime.MinValue ||
                BorEvjarata.Value > DateTime.MaxValue || KostolasIdopontja.Value > DateTime.MaxValue)
            {
                MessageBox.Show("A datumok nem megfeleloek!\n\n\n\t\t\t(ง •̀_•́)ง");
                return;
            }

            // Akkor letrehozzuk az uj adatrekordot a bemeneti adatok (es a generalt id) alapjan
            List<int> borNaploIdk = _db.BorNaplos.Select(b => b.Id).ToList();   //var-al is mukodik, de en igy szeretem
            int maxId = borNaploIdk.Any() ? borNaploIdk.Max() : 0; //Ultrameno ertekadasos switchcase nemnull eseten
            BorNaplo ujBorNaplo = new BorNaplo
            {
                Id = maxId + 1,
                BorNev = BorNeve.Text,
                BorFajta = BorFajtaja.Text,
                EvJarat = new DateOnly(BorEvjarata.Value.Year, BorEvjarata.Value.Month, BorEvjarata.Value.Day),
                SzoloFajta = SzoloFajtaja.Text,
                PinceszetNev = PinceszetNeve.Text,
                KostolasIdopont = KostolasIdopontja.Value,
                KostolasHelyszin = KostolasHelyszine.Text,
                RovidJellemzes = RovidErtekeles.Text,
                Ertekeles = Convert.ToByte(trackBar1.Value)
            };

            // Rogzitjuk a bazisban, es elmentjuk
            _db.BorNaplos.Add(ujBorNaplo);
            _db.SaveChanges();

            MessageBox.Show("Kostolas sikeresen hozzaadva!\n\n\n\t\t\t✔ ( ͡^ ͜ʖ ͡^ ) ✔");

            KijelzoAktualizalas();
        }

        private void Modositas_Click(object sender, EventArgs e)
        {
            // Kb ugyanaz, mint a hozzaadas, csak id-t nem kell adni neki
            if (Kijelzo.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(BorNeve.Text) ||
                    string.IsNullOrWhiteSpace(BorFajtaja.Text) ||
                    string.IsNullOrWhiteSpace(SzoloFajtaja.Text) ||
                    string.IsNullOrWhiteSpace(PinceszetNeve.Text) ||
                    string.IsNullOrWhiteSpace(KostolasHelyszine.Text) ||
                    string.IsNullOrWhiteSpace(RovidErtekeles.Text))
                {
                    MessageBox.Show("A hozzadashoz szukseges minden mezo kitoltese!\n\n\n\t\t\t(ง •̀_•́)ง");
                    return;
                }

                if (RovidErtekeles.Text.Length > 1000)
                {
                    MessageBox.Show("A rovid jellemzes nem lehet hosszabb, mint 1000 karakter!\n\n\n\t\t\t(ง •̀_•́)ง");
                    return;
                }

                if (BorEvjarata.Value < DateTime.MinValue || KostolasIdopontja.Value < DateTime.MinValue ||
                    BorEvjarata.Value > DateTime.MaxValue || KostolasIdopontja.Value > DateTime.MaxValue)
                {
                    MessageBox.Show("A datumok nem megfeleloek!\n\n\n\t\t\t(ง •̀_•́)ง");
                    return;
                }

                // A kivalasztott sor szovegebol kiszedjuk az id
                int id = int.Parse(Kijelzo.SelectedItem.ToString().Split('|')[0].Trim());   //Ezt eloszor 3 sorban csinaltam, aztan rajottem, hogyha osszefuzom okosabbnak tunik hehe //WARNING: azt hiszi, lehet ures, de nem
                BorNaplo borNaplo = _db.BorNaplos.FirstOrDefault(b => b.Id == id);          //WARNING: Ez lehetne bugos, ha ures az adatbazis, de olyankor meg se lehet hivva ez a resz a legfelso if miatt

                // es az annak megfelelo adatrekordot szerkesztjuk a user input szerint
                borNaplo.BorNev = BorNeve.Text;                                             //WARNING: otletemsincs ez miert zavarja, ha az alattalevok nem
                borNaplo.BorFajta = BorFajtaja.Text;
                borNaplo.EvJarat = new DateOnly(BorEvjarata.Value.Year, BorEvjarata.Value.Month, BorEvjarata.Value.Day);
                borNaplo.SzoloFajta = SzoloFajtaja.Text;
                borNaplo.PinceszetNev = PinceszetNeve.Text;
                borNaplo.KostolasIdopont = KostolasIdopontja.Value;
                borNaplo.KostolasHelyszin = KostolasHelyszine.Text;
                borNaplo.RovidJellemzes = RovidErtekeles.Text;
                borNaplo.Ertekeles = Convert.ToByte(trackBar1.Value);

                // Vegul elmentjuk
                _db.SaveChanges();
                MessageBox.Show("Kostolas sikeresen modositva!\n\n\n\t\t\t✔ ( ͡^ ͜ʖ ͡^ ) ✔");
                KijelzoAktualizalas();
            }
            else
            {
                MessageBox.Show("Nincs elem kivalasztva, amit modosithatnank!\n\n\n\t\t\t(ง •̀_•́)ง");
            }
        }

        private void Torles_Click(object sender, EventArgs e)
        {
            // Ha van kivalasztva elem
            if (Kijelzo.SelectedItem != null)
            {
                // A sorokat id-vel kezdem, ugyhogy konnyu visszakotorni beloluk
                int id;
                if (int.TryParse( ( (string)Kijelzo.SelectedItem ).Split('|')[0].Trim(), out id)) //Megprobaljuk a kivalaszttott sor elejéről az id-t kiszedni (NULLRA KEZELNI KELLHET)
                {
                    BorNaplo borNaplo = _db.BorNaplos.FirstOrDefault(b => b.Id == id); ////WARNING: A most megszerzett Id-t megkeressuk az adatbazisban (ez se lehet null a legfelso if miatt)
                    if (borNaplo != null)
                    {
                        _db.BorNaplos.Remove(borNaplo);
                        _db.SaveChanges();
                        MessageBox.Show("A kiválasztott BorNaplo elem törölve lett az adatbázisból!\n\n\n\t\t\t✔ ( ͡^ ͜ʖ ͡^ ) ✔");
                        KijelzoAktualizalas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs elem kivalasztva a torleshez!\n\n\n\t\t\t(ง •̀_•́)ง");
            }
        }

        private void EloszlasGrafikon_Click(object sender, EventArgs e) //3 Fele keppen is megprobaltam adatot atadni, de vegre sikerult
        {
            List<BorNaplo> AllRecords = _db.BorNaplos.ToList(); // Hogy a form2-bol is el tudjam erni az adatbazis tartalmat (onnan szerencsere nem szerkesztunk, csak lekerdezunk)

            //KijelzoAktualizalas(); //Ha meg nem lett volna betoltve, de szeretnek belole adatot kinyerni a masik Form megniytasa utan

            this.WindowState = FormWindowState.Minimized;
            Form2 newForm = new Form2(this, AllRecords);    // Parameterkent atadja magat, hogy abbol is el tudjuk erni dolgokat
            newForm.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void Lekerdezesek_Click(object sender, EventArgs e)
        {
            List<BorNaplo> AllRecords = _db.BorNaplos.ToList();

            this.WindowState = FormWindowState.Minimized;
            Form3 newForm = new Form3(this, AllRecords);
            newForm.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void BorNeve_TextChanged(object sender, EventArgs e) //Veletlen hoztam letre, nem hagyja torolni lol
        {

        }
    }
}

// Nem hagytam var-t a kodban, mert lassufelfogasukent neheziti a kod megerteset irasanak masnapjan
// Ettol tobb lett a warning, de nincs valodi baj