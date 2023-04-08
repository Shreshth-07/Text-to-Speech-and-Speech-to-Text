using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace TextToSpeechDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        private SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        private void SpeechButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    synth.SelectVoice(VoiceComboBox.Text);
                    synth.SpeakAsync(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Please Enter Something...");
                }
            }
            catch
            {
                MessageBox.Show("Please Select Voice...");
            }
        }

        private void SoundTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                synth.Volume = SoundTrackBar.Value;
            }
            catch
            {
            }
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                synth.Rate = SpeedTrackBar.Value;
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in synth.GetInstalledVoices())
            {
                VoiceComboBox.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PauseButton1(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Speaking)
            {
                try
                {
                    synth.Pause();
                }
                catch { }
            }
        }

        private void ResumeButton1(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Paused)
            {
                try
                {
                    synth.Resume();
                }
                catch { }
            }
        }

        private void StopButton1(object sender, EventArgs e)
        {
            try
            {
                synth.Dispose();
                synth = new SpeechSynthesizer();
            }
            catch { }
        }

        private void VoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListenButton(object sender, EventArgs e)
        {
            Listen.Enabled = false;
            StopListen.Enabled = true;
            Grammar words = new DictationGrammar();

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(words);
                rec.SpeechRecognized += rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mic Not Found....");
            }

        }

        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox2.Text = textBox2.Text + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void Stop_listen(object sender, EventArgs e)
        {
            rec.RecognizeAsyncStop();
            Listen.Enabled = true;
            StopListen.Enabled = false;

        }

        private void ClearButton1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter Something...");
            }
        }
    }
}