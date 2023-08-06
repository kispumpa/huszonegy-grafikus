using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace huszonegy
{
    public partial class Huszonegy : Form
    {
        public Huszonegy()
        {
            InitializeComponent();
        }

        int[] szamok = { 2, 3, 4, 7, 8, 9, 10, 11 };
        Random random = new Random();
        int korszam = 0;

        private bool konnyuClicked = false;
        private bool kozepesClicked = false;
        private bool nehezClicked = false;
        private bool nemkerekClicked = false;
        bool kapcsolo = false;

        int osszeg = 0;
        int robotkonnyu = 0;
        int robotalap = 0;
        int robotkozepes = 0;
        int robotnehez = 0;
        int randomszam = 0;
        int x = 0; 
        int[] eredmenydontes = new int[10000];
        

        private void konnyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konnyuClicked = true;
            kozepesClicked = false;
            nehezClicked = false;
            Clear();

            robotkonnyu = random.Next(16, 31);
            robotalap = random.Next(0, 8);
            osszeg += szamok[robotalap];

            lbl_nehezseg.Text = "Nehézségi szint: könnyű";

            string cim = "Fokozat: könnyű";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void kozepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konnyuClicked = false;
            kozepesClicked = true;
            nehezClicked = false;
            Clear();
            
            robotkozepes = random.Next(16, 27);
            robotalap = random.Next(0, 8);
            osszeg += szamok[robotalap];

            lbl_nehezseg.Text = "Nehézségi szint: közepes";

            string cim = "Fokozat: közepes";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void nehezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konnyuClicked = false;
            kozepesClicked = false;
            nehezClicked = true;
            Clear();

            robotnehez = random.Next(16, 23);
            robotalap = random.Next(0, 8);
            osszeg += szamok[robotalap];

            lbl_nehezseg.Text = "Nehézségi szint: nehéz";

            string cim = "Fokozat: nehéz";
            string uzenet = "Ellenfeled (robot) eredménye minimum 16, maximum 22 lehet, és ő az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void btn_kerekmeg_Click(object sender, EventArgs e)
        {
            randomszam = random.Next(0, 8);
            osszeg += szamok[randomszam];
            lbl_kor.Text = korszam + ". kör";
            lbl_kiiras.Text = "Lapjaid összege: " + osszeg +
            "\nHa kérsz még lapot, nyomd meg a Kérek még gombot!" +
            "\nHa nem kérsz lapot, nyomd meg a Nem kérek gombot!";
            eredmenydontes[x] = osszeg;
            korszam++;
            x++;
        }

        private void btn_nemkerek_Click(object sender, EventArgs e)
        {
            btn_kerekmeg.Enabled = false;
            btn_nemkerek.Enabled = false;
            nemkerekClicked = true;
            if (konnyuClicked)
            {
                if (eredmenydontes[0] == 22 || (osszeg >= 16 && osszeg < 22 && robotkonnyu > 22) || (osszeg >= 16 && osszeg < 22 && robotkonnyu < osszeg) || (osszeg >= 16 && osszeg < 22 && robotkonnyu == osszeg))
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotkonnyu +
                            "\nNYERTÉL! :D" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
                else
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotkonnyu +
                            "\nVESZTETTÉL! :C" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
            }
            if (kozepesClicked)
            {
                if (eredmenydontes[0] == 22 || (osszeg >= 16 && osszeg < 22 && robotkozepes > 22) || (osszeg >= 16 && osszeg < 22 && robotkozepes < osszeg) || (osszeg >= 16 && osszeg < 22 && robotkozepes == osszeg))
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotkozepes +
                            "\nNYERTÉL! :D" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
                else
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotkozepes +
                            "\nVESZTETTÉL! :C" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
            }
            if (nehezClicked)
            {
                if ((osszeg >= 16 && osszeg < 22 && robotnehez > 22) || (osszeg >= 16 && osszeg < 22 && robotnehez < osszeg))
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotnehez +
                            "\nNYERTÉL! :D" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
                else
                {
                    lbl_kiiras.Text = "Végeredmény: " + osszeg + "/" + robotnehez +
                            "\nVESZTETTÉL! :C" +
                            "\nÚj játékhoz nyomd meg az Új játék gombot!" +
                            "\nNehezebb kihívásra vágysz? Válassz nehézséget!";
                }
            }
        }

        private void btn_ujjatek_Click(object sender, EventArgs e)
        {
            
            if (konnyuClicked == false && kozepesClicked == false && nehezClicked == false)
            {
                MessageBox.Show("Kérlek válassz nehézséget!", "Huszonegy");
            }
            else if (konnyuClicked)
            {
                if (nemkerekClicked == true || kapcsolo == false)
                {
                    Clear();
                }
                else
                {
                    Clear();

                    osszeg = 0;
                    robotkonnyu = random.Next(16, 31);
                    robotalap = random.Next(0, 8);
                    osszeg += szamok[robotalap];

                    lbl_nehezseg.Text = "Nehézségi szint: könnyű";
                    Starter();
                } 
            }
            else if (kozepesClicked)
            {
                if (nemkerekClicked == true)
                {
                    Clear();
                }
                else
                {
                    Clear();

                    osszeg = 0;
                    robotkozepes = random.Next(16, 27);
                    robotalap = random.Next(0, 8);
                    osszeg += szamok[robotalap];

                    lbl_nehezseg.Text = "Nehézségi szint: közepes";
                    Starter();
                }
            }
            else if (nehezClicked)
            {
                if (nemkerekClicked == true)
                {
                    Clear();
                }
                else
                {
                    Clear();

                    osszeg = 0;
                    robotnehez = random.Next(16, 23);
                    robotalap = random.Next(0, 8);
                    osszeg += szamok[robotalap];

                    lbl_nehezseg.Text = "Nehézségi szint: nehéz";
                    Starter();
                }
            }
        }

        //infóablakok
        private void konnyuJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Könnyű játék";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void kozepesJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Közepes játék";
            string uzenet = "Ellenfeled (robot) eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void nehezJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cim = "Nehéz játék";
            string uzenet = "Ellenfeled (robot) eredménye minimum 16, maximum 22 lehet, és ő az osztó.";
            MessageBox.Show(uzenet, cim);
        }

        private void altalanosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Huszonegy (magyar kártyajáték) " +
                "\nKészítette: Matula Márton " +
                "\nElső változat: 2022. 05. 25. " +
                "\nLegutóbbi (4.) változat: 2023. 08. 06.";

            string title = "A játékról";
            MessageBox.Show(message, title);
        }
        //

        //segédmetódusok
        public void Clear()
        {
            lbl_kiiras.Text = "";
            lbl_kiiras.Refresh();
            lbl_kor.Text = "";
            lbl_kor.Refresh();
            korszam = 1;
            osszeg = 0;
            robotkonnyu = 0;
            robotalap = 0;
            robotkozepes = 0;
            robotnehez = 0;
            randomszam = 0;
            x = 0;
            nemkerekClicked = false;
            btn_kerekmeg.Enabled = false;
            btn_nemkerek.Enabled = false;
            btn_ujjatek.Text = "Start";
            lbl_kor.Visible = false;
            kapcsolo = true;
        }

        public void Starter()
        {
            if (btn_ujjatek.Text == "Start")
            {
                randomszam = random.Next(0, 8);
                osszeg += szamok[randomszam];
                lbl_kor.Text = korszam + ". kör";
                lbl_kiiras.Text = "Lapjaid összege: " + osszeg +
                    "\nHa kérsz még lapot, nyomd meg a Kérek még gombot!" +
                    "\nHa nem kérsz lapot, nyomd meg a Nem kérek gombot!";
                eredmenydontes[x] = osszeg;
                korszam++;
                x++;
                btn_kerekmeg.Enabled = true;
                btn_nemkerek.Enabled = true;
                btn_ujjatek.Text = "Új játék";
                lbl_kor.Visible = true;
                kapcsolo = false;
            }
        }
        //
    }
}
/* 22.5.25
   22.5.27
   22.5.28
   23.8.6 */