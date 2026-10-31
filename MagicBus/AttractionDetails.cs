using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MagicBus
{
    public partial class AttractionDetails : Form
    {
        private SpeechSynthesizer? speaker;
        public AttractionDetails()
        {
            InitializeComponent();
            FormClosed += (_, _) =>
            {
                speaker?.SpeakAsyncCancelAll();
                speaker?.Dispose();
            };
        }
        public AttractionDetails(string attraction) : this()
        {
            lblTitle.Text = attraction;

            txtDescription.Text = attraction switch
            {
                "Λευκός Πύργος" =>
                    "Ο Λευκός Πύργος είναι ένα από τα πιο αναγνωρίσιμα "
                    + "μνημεία της Θεσσαλονίκης. Βρίσκεται στην παραλία "
                    + "και αποτελεί χαρακτηριστικό σημείο συνάντησης.",

                "Πλατεία Αριστοτέλους" =>
                    "Η πλατεία Αριστοτέλους είναι μια κεντρική πλατεία "
                    + "της Θεσσαλονίκης, με θέα προς τον Θερμαϊκό κόλπο. "
                    + "Γύρω της θα βρείτε καφέ και χώρους περιπάτου.",

                "Άγιος Δημήτριος" =>
                    "Ο ναός του Αγίου Δημητρίου είναι αφιερωμένος "
                    + "στον πολιούχο της Θεσσαλονίκης και αποτελεί "
                    + "σημαντικό θρησκευτικό και ιστορικό μνημείο.",

                "Ροτόντα" =>
                    "Η Ροτόντα είναι ένα ιστορικό μνημείο "
                    + "με κυκλική αρχιτεκτονική. Βρίσκεται κοντά "
                    + "στην Καμάρα, στο κέντρο της Θεσσαλονίκης.",

                "Καμάρα" =>
                    "Η Καμάρα, γνωστή και ως Αψίδα του Γαλερίου, "
                    + "είναι μνημείο της ρωμαϊκής περιόδου και "
                    + "δημοφιλές σημείο συνάντησης στην πόλη.",

                _ => "Δεν υπάρχει διαθέσιμη περιγραφή."
            };
            picAttraction.Image = attraction switch
            {
                "Λευκός Πύργος" => Properties.Resources.whiteTower,
                "Πλατεία Αριστοτέλους" => Properties.Resources.aristotelous,
                "Άγιος Δημήτριος" => Properties.Resources.agiosDimitrios,
                "Ροτόντα" => Properties.Resources.rotunda,
                "Καμάρα" => Properties.Resources.kamara,
                _ => null
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                speaker ??= new SpeechSynthesizer();

                var greekVoice = speaker.GetInstalledVoices()
                    .FirstOrDefault(v => v.Enabled &&
                        v.VoiceInfo.Culture.TwoLetterISOLanguageName == "el");

                if (greekVoice == null)
                {
                    MessageBox.Show("Δεν βρέθηκε εγκατεστημένη ελληνική φωνή.");
                    return;
                }

                speaker.SpeakAsyncCancelAll();
                speaker.SelectVoice(greekVoice.VoiceInfo.Name);
                speaker.SpeakAsync(txtDescription.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Δεν ήταν δυνατή η ανάγνωση: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speaker?.SpeakAsyncCancelAll();
        }
    }
}
