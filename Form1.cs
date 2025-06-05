﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAE3_Checksum
{
    public partial class FORM_Calcul : Form
    {
        // Calcule le checksum selon l'algorithme IP (16 bits avec report)
        static uint CalculateChecksum(List<ushort> header)
        {
            if (header.Count != 9)
                throw new ArgumentException("L'entête doit contenir exactement 9 mots (16 bits chacun)");

            uint sum = 0;

            foreach (ushort value in header)
            {
                sum += value;

                // Si la somme dépasse 16 bits, on ajoute la retenue
                if (sum > 0xFFFF)
                    sum = (sum & 0xFFFF) + 1;
            }

            return ~sum; // Retourne la négation binaire sur 16 bits
        }

        public FORM_Calcul()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Calcul_Click(object sender, EventArgs e)
        {
            try
            {
                List<ushort> entete = new List<ushort>();
                string[] motsSaisis = TB_Entete.Text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (motsSaisis.Length != 9)
                {
                    MessageBox.Show("Veuillez entrer exactement 9 valeurs hexadécimales séparées par des espaces.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (string hex in motsSaisis)
                {
                    if (!ushort.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out ushort valeur))
                    {
                        MessageBox.Show($"Valeur hexadécimale invalide : \"{hex}\"", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    entete.Add(valeur);
                }

                ushort sommeControle = (ushort)CalculateChecksum(entete);
                TB_Resultat.Text = sommeControle.ToString("X4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
