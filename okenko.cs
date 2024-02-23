using System.Drawing.Text;

namespace GrafickaKalkulackaUkol
{
    public partial class okenko : Form
    {
        string vstup1;
        string vstup2;
        string znamenko;
        double cislo1;
        double cislo2;

        bool ZadavamDalsiCislo = false;
        public void OverZnamenko()
        {
            if (ZadavamDalsiCislo == true)
            {
                vystup.Text = "";
                ZadavamDalsiCislo = false;
            }
        }
        private void PridejCislici(string cislo)
        {
            vystup.Text = vystup.Text + cislo;
        }

        public okenko()
        {
            InitializeComponent();
        }

        private void buttonNula_Click(object sender, EventArgs e)
        {
            string tlacitko0 = "0";
            OverZnamenko();
            PridejCislici(tlacitko0);

        }

        private void buttonJedna_Click(object sender, EventArgs e)
        {
            string tlacitko1 = "1";
            OverZnamenko();
            PridejCislici(tlacitko1);

        }

        private void buttonDva_Click(object sender, EventArgs e)
        {
            string tlacitko2 = "2";
            OverZnamenko();
            PridejCislici(tlacitko2);

        }

        private void buttonTri_Click(object sender, EventArgs e)
        {
            string tlacitko3 = "3";
            OverZnamenko();
            PridejCislici(tlacitko3);
        }

        private void buttonCtyri_Click(object sender, EventArgs e)
        {
            string tlacitko4 = "4";
            OverZnamenko();
            PridejCislici(tlacitko4);
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            string tlacitko5 = "5";
            OverZnamenko();
            PridejCislici(tlacitko5);
        }

        private void buttonSest_Click(object sender, EventArgs e)
        {
            string tlacitko6 = "6";
            OverZnamenko();
            PridejCislici(tlacitko6);
        }

        private void buttonSedm_Click(object sender, EventArgs e)
        {
            string tlacitko7 = "7";
            OverZnamenko();
            PridejCislici(tlacitko7);
        }

        private void buttonOsm_Click(object sender, EventArgs e)
        {
            string tlacitko8 = "8";
            OverZnamenko();
            PridejCislici(tlacitko8);
        }

        private void buttonDevet_Click(object sender, EventArgs e)
        {
            string tlacitko9 = "9";
            OverZnamenko();
            PridejCislici(tlacitko9);
        }

        private void buttonSoucet_Click(object sender, EventArgs e)
        {
            znamenko = "+";
            vstup1 = vystup.Text;
            vystup.Text = znamenko;
            ZadavamDalsiCislo = true;
        }

        private void buttonRozdil_Click(object sender, EventArgs e)
        {
            znamenko = "-";
            vstup1 = vystup.Text;
            vystup.Text = znamenko;
            ZadavamDalsiCislo = true;
        }

        private void buttonSoucin_Click(object sender, EventArgs e)
        {
            znamenko = "*";
            vstup1 = vystup.Text;
            vystup.Text = znamenko;
            ZadavamDalsiCislo = true;
        }

        private void buttonPodil_Click(object sender, EventArgs e)
        {
            znamenko = "/";
            vstup1 = vystup.Text;
            vystup.Text = znamenko;
            ZadavamDalsiCislo = true;
        }

        private void buttonRovnitko_Click(object sender, EventArgs e)
        {
            cislo1 = double.Parse(vstup1);
            vstup2 = vystup.Text;
            cislo2 = double.Parse(vstup2);
            kalkulacka mojeKalkulacka = new kalkulacka();
            mojeKalkulacka.vysledek = cislo1;
            mojeKalkulacka.ProvedVypocet(znamenko, cislo2);  
            vystup.Text = mojeKalkulacka.vysledek.ToString();
           
        }

    }

}

