using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatSpammer
{
    public partial class Form1 : Form
    {
        bool textToSpeech = true;
        bool doEndless = false;
        int curSpeed = 0;

        public Form1()
        {
            InitializeComponent();
            Properties.Settings settings = new Properties.Settings();
            readInSettings(settings);
        }

        int convertTickToMs()
        {
            //Largest tick is 20, we want that to be the 'max' value of 500 ms
            switch (speedTrackBar.Value)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 5;
                case 3:
                    return 10;
                case 4:
                    return 15;
                case 5:
                    return 20;
                case 6:
                    return 35;
                case 7:
                    return 45;
                case 8:
                    return 50;
                case 9:
                    return 60;
                case 10:
                    return 70;
                case 11:
                    return 80;
                case 12:
                    return 90;
                case 13:
                    return 100;
                case 14:
                    return 200;
                case 15:
                    return 250;
                case 16:
                    return 300;
                case 17:
                    return 350;
                case 18:
                    return 400;
                case 19:
                    return 450;
                case 20:
                    return 500;
            }
            return 0;
        }

        private void readInSettings(Properties.Settings settings)
        {
            this.TopMost = settings.alwaysOnTop;
            
            textToSpeech = settings.textToSpeech;
            doEndless = settings.doEndless;
            speedTrackBar.Value = settings.lastTickPosition;
            opacityTrackBar.Value = settings.lastOpacityPosition;
            opacityTrackBar.Update();
            updateTransLabel();
            convertTickToMs();
            curSpeedMs.Text = string.Format("{0}ms", convertTickToMs());
            curSpeed = convertTickToMs();
        }
        private void resetSettings()
        {
            ChatSpammer.Properties.Settings settings = new Properties.Settings();
            settings.Reset();
        }
        private void saveSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.textToSpeech = textToSpeech;
            settings.lastOpacityPosition = opacityTrackBar.Value;
            settings.lastTickPosition = speedTrackBar.Value;
            settings.doEndless = doEndless;
            settings.Save();
        }
        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            curSpeedMs.Text = string.Format("{0}ms", convertTickToMs());
            curSpeed = convertTickToMs();
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void updateTransLabel()
        {

            transLabel.Text = String.Format("{0}%", this.Opacity * 100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void opacityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            #region yikes
            switch (opacityTrackBar.Value)
            {
                case 0:
                    this.Opacity = (double)1.0;
                    break;
                case 1:
                    this.Opacity = (double).95;
                    break;
                case 2:
                    this.Opacity = (double).9;
                    break;
                case 3:
                    this.Opacity = (double).85;
                    break;
                case 4:
                    this.Opacity = (double).8;
                    break;
                case 5:
                    this.Opacity = (double).75;
                    break;
                case 6:
                    this.Opacity = (double).70;
                    break;
                case 7:
                    this.Opacity = (double).65;
                    break;
                case 8:
                    this.Opacity = (double).6;
                    break;
                case 9:
                    this.Opacity = (double).55;
                    break;
                case 10:
                    this.Opacity = (double).5;
                    break;
                case 11:
                    this.Opacity = (double).45;
                    break;
                case 12:
                    this.Opacity = (double).4;
                    break;
                case 13:
                    this.Opacity = (double).35;
                    break;
                case 14:
                    this.Opacity = (double).3;
                    break;
                case 15:
                    this.Opacity = (double).25;
                    break;
                case 16:
                    this.Opacity = (double).2;
                    break;
            }
            #endregion
            updateTransLabel();
        }
    }
}
