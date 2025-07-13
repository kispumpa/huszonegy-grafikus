// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) Matula Marton. All rights reserved.
// </copyright>
namespace Huszonegy
{
    using System;
    using System.Windows.Forms;

    /// <summary>Class for Form communicating.</summary>
    public partial class Huszonegy : Form
    {
        private int[] szamok = { 2, 3, 4, 7, 8, 9, 10, 11 };
        private Random random = new Random();

        private bool nemkerekClicked = false;
        private bool kapcsolo = false;

        private int nehezseg = 0;
        private int osszeg = 0;
        private int robotalap = 0;
        private int robot = 0;
        private int randomszam = 0;
        private int x = 0;
        private int[] eredmenydontes = new int[10000];

        /// <summary>Initializes a new instance of the <see cref="Huszonegy"/> class.</summary>
        public Huszonegy()
        {
            this.InitializeComponent();
        }

        /// <summary>It clears the screen and change values to default.</summary>
        public void Clear()
        {
            this.lbl_kiiras.Text = string.Empty;
            this.lbl_kiiras.Refresh();
            this.lbl_kor.Text = string.Empty;
            this.lbl_kor.Refresh();
            this.osszeg = 0;
            this.robotalap = 0;
            this.randomszam = 0;
            this.x = 0;
            this.robot = 0;
            this.nemkerekClicked = false;
            this.btn_kerekmeg.Enabled = false;
            this.btn_nemkerek.Enabled = false;
            this.btn_ujjatek.Text = "Start";
            this.lbl_kor.Visible = false;
            this.kapcsolo = true;
        }

        /// <summary>Controls a new game's appearance.</summary>
        public void Starter()
        {
            if (this.btn_ujjatek.Text == "Start")
            {
                this.randomszam = this.random.Next(0, 8);
                this.osszeg += this.szamok[this.randomszam];
                this.lbl_kor.Text = $"{this.x + 1}. kör";
                this.lbl_kiiras.Text = $"Lapjaid összege: {this.osszeg}" +
                    "\nHa kérsz még lapot, nyomd meg a Kérek még gombot!" +
                    "\nHa nem kérsz lapot, nyomd meg a Nem kérek gombot!";
                this.eredmenydontes[this.x] = this.osszeg;
                this.x++;
                this.btn_kerekmeg.Enabled = true;
                this.btn_nemkerek.Enabled = true;
                this.btn_ujjatek.Text = "Új játék";
                this.lbl_kor.Visible = true;
                this.kapcsolo = false;
            }
        }

        private void KonnyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Clear();

            this.nehezseg = 1;
            this.robot = this.random.Next(16, 31);
            this.robotalap = this.random.Next(0, 8);
            this.osszeg += this.szamok[this.robotalap];

            this.lbl_nehezseg.Text = "Nehézségi szint: könnyű";

            string cim = "Fokozat: könnyű";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void KozepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Clear();

            this.nehezseg = 2;
            this.robot = this.random.Next(16, 27);
            this.robotalap = this.random.Next(0, 8);
            this.osszeg += this.szamok[this.robotalap];

            this.lbl_nehezseg.Text = "Nehézségi szint: közepes";

            string cim = "Fokozat: közepes";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void NehezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Clear();

            this.nehezseg = 3;
            this.robot = this.random.Next(16, 23);
            this.robotalap = this.random.Next(0, 8);
            this.osszeg += this.szamok[this.robotalap];

            this.lbl_nehezseg.Text = "Nehézségi szint: nehéz";

            string cim = "Fokozat: nehéz";
            string uzenet = "Ellenfeled (robot) eredménye minimum 16, maximum 22 lehet, és ő az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void Btn_kerekmeg_Click(object sender, EventArgs e)
        {
            this.randomszam = this.random.Next(0, 8);
            this.osszeg += this.szamok[this.randomszam];
            this.lbl_kor.Text = $"{this.x + 1}. kör";
            this.lbl_kiiras.Text = $"Lapjaid összege: {this.osszeg} " +
            "\nHa kérsz még lapot, nyomd meg a Kérek még gombot!" +
            "\nHa nem kérsz lapot, nyomd meg a Nem kérek gombot!";
            this.eredmenydontes[this.x] = this.osszeg;
            this.x++;
        }

        private void Btn_nemkerek_Click(object sender, EventArgs e)
        {
            this.btn_kerekmeg.Enabled = false;
            this.btn_nemkerek.Enabled = false;
            this.nemkerekClicked = true;

            if (this.YouWin(this.osszeg, this.robot, this.nehezseg, this.x))
            {
                this.lbl_kiiras.Text = "Végeredmény: " + this.osszeg + "/" + this.robot +
                        "\nNYERTÉL! :D" +
                        "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                        "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
            }
            else
            {
                this.lbl_kiiras.Text = "Végeredmény: " + this.osszeg + "/" + this.robot +
                        "\nVESZTETTÉL! :C" +
                        "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                        "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
            }
        }

        private void Btn_ujjatek_Click(object sender, EventArgs e)
        {
            if (this.nehezseg == 0)
            {
                MessageBox.Show("Kérlek válassz nehézséget!", "Huszonegy");
            }

            if (this.nemkerekClicked == true || this.kapcsolo == false)
            {
                this.Clear();
            }
            else
            {
                this.Clear();

                this.osszeg = 0;
                this.robotalap = this.random.Next(0, 8);
                this.osszeg += this.szamok[this.robotalap];
                switch (this.nehezseg)
                {
                    case 1:
                        this.robot = this.random.Next(16, 31);
                        this.lbl_nehezseg.Text = "Nehézségi szint: könnyű";
                        break;
                    case 2:
                        this.robot = this.random.Next(16, 27);
                        this.lbl_nehezseg.Text = "Nehézségi szint: közepes";
                        break;
                    case 3:
                        this.robot = this.random.Next(16, 23);
                        this.lbl_nehezseg.Text = "Nehézségi szint: nehéz";
                        break;
                    default:
                        break;
                }

                this.Starter();
            }
        }

        private void AltalanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Játékszabály";
            string uzenet = "- A huszonegy nevezetű kártyajáték lényege, hogy a kézben levő kártyák összege megközelítse, optimális esetben elérje a 21-et, de túllépni nem szabad." +
                "\n- 16 összegű eredménynél már meg lehet állni, vagy lehet kockáztatni azzal, hogy új kártyát húzol." +
                "\n- Ellenfeled egy robot lesz; az a játékos nyer, akinek nagyobb összegű lapja lesz a kör végén." +
                "\n- A 0. körben két lappal kezdesz, a két lap összege fog megjelenni a képernyőn." +
                "\n- Abban az esetben, ha egyenlő a két szám, az osztóé fog nyerni." +
                "\n- Ha a 0. körben 22 pontod van, ergo az első két kártyád 11-et és 11-et ér, akkor azzal is lehet nyerni, sőt, az a huszonegy Joker-e." +
                "\n- Az alap játékszabály változhat bizonyos nehézségi szinteken.";
            MessageBox.Show(uzenet, cim);
        }

        private void KonnyuJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Könnyű játék";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void KozepesJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Közepes játék";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void NehezJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Nehéz játék";
            string uzenet = "Ellenfeled (robot) eredménye minimum 16, maximum 22 lehet, és ő az osztó.";
            MessageBox.Show(uzenet, cim);
        }


        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Huszonegy (magyar kártyajáték) " +
                "\nKészítette: Matula Márton " +
                "\nElső változat: 2022. 05. 25. " +
                "\nLegutóbbi (4.) változat: 2023. 08. 06.";

            string title = "A játékról";
            MessageBox.Show(message, title);
        }

        private bool YouWin(int osszeg, int robot, int diff, int x)
        {
            if ((osszeg >= 16 && osszeg < 22 && (robot > 22 || robot < osszeg || (robot == osszeg && diff < 3))) || (x == 0 && osszeg == 22 && (diff < 3 || (diff == 3 && robot != osszeg))))
            {
                return true;
            }

            return false;
        }
    }
}