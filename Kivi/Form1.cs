using Kivi.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Kivi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            for (int i = 1; i <= 49; i++)
            {
                Button button = Controls.Find("button" + i, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.Click += HandleButtonClick;

                    buttonClickStates.Add(button, false);
                }
            }

        }


        int turn = 0;
        int roll2;

        List<Dice> dice = new List<Dice>();

        Dictionary<(int, int), (int, string)> gridAndColors = new Dictionary<(int, int), (int, string)>();

        List<Label> availableRedStones = new List<Label>();
        List<Label> availableBlueStones = new List<Label>();

        Dictionary<Button, bool> buttonClickStates = new Dictionary<Button, bool>();


        public void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 2; i <= 11; i++)
            {
                Label label = Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                if (label != null)
                {
                    Styler.Stone(label, Color.Red, Color.FromArgb(255, 255, 200, 200));
                    availableRedStones.Add(label);
                }
            }

            for (int i = 12; i <= 21; i++)
            {
                Label label = Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                if (label != null)
                {
                    Styler.Stone(label, Color.Blue, Color.FromArgb(255, 173, 216, 230));
                    availableBlueStones.Add(label);
                }
            }
            // Populate the grid and colors
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    gridAndColors[(i, j)] = (0, "neutral");
                }
            }

        }

        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region dice
        private void Dice6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[5].RolledValue;
                string resourceKey = "die" + (dice[5].Locked ? "White" : "Red") + "_border" + roll2;
                Dice6.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[5].Locked = !dice[5].Locked;
            }
            catch { }

        }

        private void Dice5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[4].RolledValue;
                string resourceKey = "die" + (dice[4].Locked ? "White" : "Red") + "_border" + roll2;
                Dice5.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[4].Locked = !dice[4].Locked;
            }
            catch { }

        }

        private void Dice4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[3].RolledValue;
                string resourceKey = "die" + (dice[3].Locked ? "White" : "Red") + "_border" + roll2;
                Dice4.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[3].Locked = !dice[3].Locked;
            }
            catch { }

        }

        private void Dice3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[2].RolledValue;
                string resourceKey = "die" + (dice[2].Locked ? "White" : "Red") + "_border" + roll2;
                Dice3.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[2].Locked = !dice[2].Locked;
            }
            catch { }

        }

        private void Dice2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[1].RolledValue;
                string resourceKey = "die" + (dice[1].Locked ? "White" : "Red") + "_border" + roll2;
                Dice2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[1].Locked = !dice[1].Locked;
            }
            catch { }

        }

        private void Dice1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer selectSound = new System.Media.SoundPlayer(Properties.Resources.select_sound_121244);
            selectSound.Play();
            try
            {
                int roll2 = dice[0].RolledValue;
                string resourceKey = "die" + (dice[0].Locked ? "White" : "Red") + "_border" + roll2;
                Dice1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);
                dice[0].Locked = !dice[0].Locked;
            }
            catch { }

        }
        #endregion

        #region useless
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label22_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> diceValues = dice.Select(item => item.RolledValue).ToList();

            Styler.ButtonShine(button1, Logic.AABB(diceValues), buttonClickStates[button1]);
            Styler.ButtonShine(button2, Logic.ABCDE(diceValues), buttonClickStates[button2]);
            Styler.ButtonShine(button3, Logic.SumIsLessThanOrEqualTo12(diceValues), buttonClickStates[button3]);
            Styler.ButtonShine(button4, Logic.AAA(diceValues), buttonClickStates[button4]);
            Styler.ButtonShine(button5, Logic.AllValuesAreOdd(diceValues), buttonClickStates[button5]);
            Styler.ButtonShine(button6, Logic.AllValuesAreEven(diceValues), buttonClickStates[button6]);
            Styler.ButtonShine(button7, Logic.AAA(diceValues), buttonClickStates[button7]);

            Styler.ButtonShine(button8, Logic.AllValuesAreEven(diceValues), buttonClickStates[button8]);
            Styler.ButtonShine(button9, Logic.AAAABB(diceValues), buttonClickStates[button9]);
            Styler.ButtonShine(button10, Logic.AAA(diceValues), buttonClickStates[button10]);
            Styler.ButtonShine(button11, Logic.AABBCC(diceValues), buttonClickStates[button11]);
            Styler.ButtonShine(button12, Logic.ABCD(diceValues), buttonClickStates[button12]);
            Styler.ButtonShine(button13, Logic.AAABBB(diceValues), buttonClickStates[button13]);
            Styler.ButtonShine(button14, Logic.SumIsGreaterThanOrEqualTo30(diceValues), buttonClickStates[button14]);

            Styler.ButtonShine(button15, Logic.ABCD(diceValues), buttonClickStates[button15]);
            Styler.ButtonShine(button16, Logic.AAAA(diceValues), buttonClickStates[button16]);
            Styler.ButtonShine(button17, Logic.SumIsGreaterThanOrEqualTo30(diceValues), buttonClickStates[button17]);
            Styler.ButtonShine(button18, Logic.ABCDE(diceValues), buttonClickStates[button18]);
            Styler.ButtonShine(button19, Logic.AAAABB(diceValues), buttonClickStates[button19]);
            Styler.ButtonShine(button20, Logic.AllValuesAreOdd(diceValues), buttonClickStates[button20]);
            Styler.ButtonShine(button21, Logic.AAABB(diceValues), buttonClickStates[button21]);

            Styler.ButtonShine(button22, Logic.SumIsLessThanOrEqualTo12(diceValues), buttonClickStates[button22]);
            Styler.ButtonShine(button23, Logic.AAABB(diceValues), buttonClickStates[button23]);
            Styler.ButtonShine(button24, Logic.AllValuesAreEven(diceValues), buttonClickStates[button24]);
            Styler.ButtonShine(button25, Logic.AAABBB(diceValues), buttonClickStates[button25]);
            Styler.ButtonShine(button26, Logic.SumIsLessThanOrEqualTo12(diceValues), buttonClickStates[button26]);
            Styler.ButtonShine(button27, Logic.AABB(diceValues), buttonClickStates[button27]);
            Styler.ButtonShine(button28, Logic.ABCDE(diceValues), buttonClickStates[button28]);

            Styler.ButtonShine(button29, Logic.AAA(diceValues), buttonClickStates[button29]);
            Styler.ButtonShine(button30, Logic.ABCDE(diceValues), buttonClickStates[button30]);
            Styler.ButtonShine(button31, Logic.AABBCC(diceValues), buttonClickStates[button31]);
            Styler.ButtonShine(button32, Logic.AllValuesAreOdd(diceValues), buttonClickStates[button32]);
            Styler.ButtonShine(button33, Logic.AAAA(diceValues), buttonClickStates[button33]);
            Styler.ButtonShine(button34, Logic.SumIsGreaterThanOrEqualTo30(diceValues), buttonClickStates[button34]);
            Styler.ButtonShine(button35, Logic.AABB(diceValues), buttonClickStates[button35]);

            Styler.ButtonShine(button36, Logic.AllValuesAreOdd(diceValues), buttonClickStates[button36]);
            Styler.ButtonShine(button37, Logic.AAABBB(diceValues), buttonClickStates[button37]);
            Styler.ButtonShine(button38, Logic.ABCD(diceValues), buttonClickStates[button38]);
            Styler.ButtonShine(button39, Logic.AAAABB(diceValues), buttonClickStates[button39]);
            Styler.ButtonShine(button40, Logic.AAABB(diceValues), buttonClickStates[button40]);
            Styler.ButtonShine(button41, Logic.AABBCC(diceValues), buttonClickStates[button41]);
            Styler.ButtonShine(button42, Logic.SumIsLessThanOrEqualTo12(diceValues), buttonClickStates[button42]);

            Styler.ButtonShine(button43, Logic.ABCD(diceValues), buttonClickStates[button43]);
            Styler.ButtonShine(button44, Logic.SumIsGreaterThanOrEqualTo30(diceValues), buttonClickStates[button44]);
            Styler.ButtonShine(button45, Logic.AAAA(diceValues), buttonClickStates[button45]);
            Styler.ButtonShine(button46, Logic.AABB(diceValues), buttonClickStates[button46]);
            Styler.ButtonShine(button47, Logic.AllValuesAreOdd(diceValues), buttonClickStates[button47]);
            Styler.ButtonShine(button48, Logic.AAAA(diceValues), buttonClickStates[button48]);
            Styler.ButtonShine(button49, Logic.AAABB(diceValues), buttonClickStates[button49]);

            if (turn == 0)
            {
                labelTurn.ForeColor = Color.Red;
            }
            else
            {
                labelTurn.ForeColor = Color.Blue;
            }



        }
        //Functions
        private Label GetAvailableStone(List<Label> availableStones)
        {
            if (availableStones.Count > 0)
            {
                // Get the first available stone
                Label stone = availableStones[0];
                // Remove the stone from the available list
                availableStones.RemoveAt(0);
                return stone;
            }
            else
            {
                // No available stone
                return null;
            }
        }
        private void HandleButtonClick(object sender, EventArgs e)
        {
            (new System.Media.SoundPlayer(Properties.Resources.Menu_Selection_Sound_Effect__mp3cut_net_)).Play();
            Button clickedButton = sender as Button;

            
            string[] buttonNameParts = clickedButton.Name.Split('n');
            int buttonNumber = int.Parse(buttonNameParts[1]);
            int buttonRow = (buttonNumber - 1) / 7;
            int buttonColumn = (buttonNumber - 1) % 7;
            string color = (turn == 0) ? "red" : "blue";
            int buttonPoints;
            switch (buttonNumber)
            {
                case 1:
                case 4:
                case 7:
                case 10:
                case 12:
                case 15:
                case 21:
                case 23:
                case 27:
                case 29:
                case 35:
                case 38:
                case 40:
                case 43:
                case 46:
                case 49:
                    buttonPoints = 1; break;
                case 2:
                case 3:
                case 5:
                case 6:
                case 8:
                case 14:
                case 16:
                case 17:
                case 18:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                case 30:
                case 32:
                case 33:
                case 34:
                case 36:
                case 42:
                case 44:
                case 45:
                case 47:
                case 48:
                    buttonPoints = 2; break;

                default: buttonPoints = 3; break;
            }
            gridAndColors[(buttonRow, buttonColumn)] = (buttonPoints, color);

            listBox1.Items.Add($"{buttonRow} {buttonColumn} = {buttonPoints} {color}");
            Label selectedStone = GetAvailableStone(turn == 0 ? availableRedStones : availableBlueStones);
            if (selectedStone != null)
            {
                selectedStone.Location = new Point(clickedButton.Location.X + clickedButton.Width / 2 - selectedStone.Width / 2, clickedButton.Location.Y + clickedButton.Height / 2 - selectedStone.Height / 2);
                turn = 1 - turn;
            }

            foreach (Control control in Controls)
            {
                if (control is Button button && button.Name.StartsWith("Dice") && int.TryParse(button.Name.Replace("Dice", ""), out int number) && number >= 1 && number <= 6)
                {
                    button.BackgroundImage = null;
                }
            }
            dice.Clear();
            rerollsCounter = 5;

            
            buttonClickStates[clickedButton] = true;
        }
        int rerollsCounter = 5;

        private void Reroll_Click(object sender, EventArgs e)
        {

            if (rerollsCounter <= -1)
            {

                for (int i = 0; i < 6; i++)
                {
                    roll2 = dice[i].RolledValue;
                    string resourceName = $"dieRed_border{roll2}"; // Assuming your resource name matches this format
                    Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
                    Controls["Dice" + (i + 1)].BackgroundImage = image;


                }
                return;
            }


            Random random = new Random();
            // Assuming you've added your audio files as "dieThrow1" and "dieThrow2" in resources
            var soundPlayer = new System.Media.SoundPlayer(random.Next(2) == 0 ? Properties.Resources.dieThrow1 : Properties.Resources.dieThrow2);
            soundPlayer.Play();



            label1.Text = $"Rerolls left: {rerollsCounter--}";

            for (int i = 0; i < 6; i++)
            {
                int roll = random.Next(1, 7);
                if (dice.Count != 6)
                    dice.Add(new Dice(false, roll));

                if (!dice[i].Locked)
                {
                    dice[i].RolledValue = roll;
                    string resourceName = $"dieWhite_border{roll}"; // Assuming your resource name matches this format
                    Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
                    Controls["Dice" + (i + 1)].BackgroundImage = image;
                }
            }

        }



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {


        }
    }
}

