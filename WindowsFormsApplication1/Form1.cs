using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Timers;

////International Morse code is composed of five elements:
//short mark, dot or 'dit' (·) — 'dot duration' is one unit long
//longer mark, dash or 'dah' (–) — three units long
//inter-element gap between the dots and dashes within a character — one dot duration or one unit long
//short gap (between letters) — three units long
//medium gap (between words) — seven units long[1]
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //morseCode m;
        morseLib morse;
        System.Timers.Timer timer;
        int letterIndex;
        Form2 debug = new Form2();
        public Form1()
        {
            InitializeComponent();
            notationStyle.SelectedIndex = 0;
            playButton.Enabled = false;
            //this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;  
           //m = new morseCode();
           morse = new morseLib();
          // morse.outputString1();
           //outputBox.Text = morse.outputString1();
          
        }

        public Form1(int threads)
        {
           
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
           // Console.WriteLine(dog);
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void twoHundred_CheckedChanged(object sender, EventArgs e)
        {
            freq = 200;
        }

        private void fourHundred_CheckedChanged(object sender, EventArgs e)
        {
            freq = 400;
        }



        //http://blog.scosby.com/post/2010/02/11/Validation-in-Windows-Forms.aspx
        //http://blogs.msdn.com/b/dawate/archive/2009/06/24/intro-to-audio-programming-part-3-synthesizing-simple-wave-audio-using-c.aspx
        //http://www.homeandlearn.co.uk/csharp/csharp_s13p1.html
        //http://naudio.codeplex.com/
        //http://www.youtube.com/watch?v=6XvWRzWzgNI&feature=relmfu
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            Console.WriteLine(frequencyBox.Text);
        }


        private void comboBox1_Leave(object sender, EventArgs e)
        {
            freq = Convert.ToInt32(frequencyBox.Text);
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void speedBox_Leave(object sender, EventArgs e)
        {
             // equation for the duration of one dot 
             // T = 1200 / W
           
            wordsPerMin = Convert.ToInt32(speedBox.Text);
           // double s = 1200.00 / wordsPerMin;
            duration = (int)Math.Ceiling(1200.00/wordsPerMin);
            Console.WriteLine("int(ceiling) " + duration);
            Console.WriteLine("double " + 1200.00 / wordsPerMin);
            timer = new System.Timers.Timer(duration);
            //MessageBox.Show(speedBox.Text);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Console.Beep(freq, duration);
            Console.Beep(freq, duration);
            Console.Beep(freq, duration);

            Console.Beep(freq, duration * 3);
            Console.Beep(freq, duration * 3);
            Console.Beep(freq, duration * 3);

            Console.Beep(freq, duration);
            Console.Beep(freq, duration);
            Console.Beep(freq, duration);

            Console.WriteLine(duration);
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            //http://www.dotnetperls.com/stringbuilder 
            //http://msdn.microsoft.com/en-us/library/2549tw02.aspx
            //http://stackoverflow.com/questions/981776/using-an-enum-as-an-array-index-in-c-sharp
            // location where I found the morsecode font http://www.fontspace.com/morten-l-t/morso-kode
            //http://www.codeproject.com/Articles/18520/Vista-Core-Audio-API-Master-Volume-Control
            //http://www.albahari.com/threading/
           // MessageBox.Show(inputBox.Text);

            StringBuilder input = new StringBuilder(inputBox.Text);
            StringBuilder output = new StringBuilder();
            StringBuilder tO = new StringBuilder();
            string outputString;
            int styleType = notationStyle.SelectedIndex;
            Console.WriteLine("The length of input is: " + input.Length);
          //  Console.WriteLine(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                outputString = input[i].ToString().ToUpper();
                if(morse.keyCheck(outputString) || string.IsNullOrWhiteSpace(outputString) == true)
                {
                    if (string.IsNullOrWhiteSpace(outputString) == false)
                    {
                        int keyValue = morse.getKey(outputString);
                        tO.AppendLine("Key value is: " + keyValue);
                        letterIndex = morse.getKey(outputString);
                        tO.AppendLine("The index of: " + outputString + " is : " + letterIndex);
                        tO.AppendLine("The morsecode value of : " + outputString + " is : " + morse.getSequence(letterIndex, styleType));
                        tO.AppendLine("-------------------------------------------------");
                        if ((i + 1 != input.Length) && string.IsNullOrWhiteSpace(input[i + 1].ToString()) == true)
                        {
                          Console.WriteLine("i = " + i);
                            output.Append(morse.getSequence(letterIndex, styleType)).Append(" ");
                        }
                        else
                        {
                            //Console.WriteLine("i = " + i);
                            if (i + 1 == input.Length)
                            {
                                Console.WriteLine("i = " + i);
                                tO.AppendLine("End of the string");
                                tO.AppendLine("-------------------------------------------------");
                            }
                            //Console.WriteLine("i = " + i);
                            output.Append(morse.getSequence(letterIndex, styleType)).Append("/");
                        }
                    }
                    else
                    {
                      Console.WriteLine("i = " + i);
                        
                        tO.AppendLine("Blank space");
                        tO.AppendLine("-------------------------------------------------");
                       // letterIndex = -1;
                    }

                }
                else if (morse.keyCheck(outputString) == false)
                {
                    MessageBox.Show(outputString + " is an invalid character!!");
                   // Console.WriteLine(outputString+" is an invalid character!!");
                }
                //int keyValue = morse.getKey(outputString);
                //Console.WriteLine("Key value is: " + keyValue);
                //if (string.IsNullOrWhiteSpace(outputString) == false && keyValue != -1)
                //{
                //    Console.WriteLine("mors.f(outputString) = " + morse.getKey(outputString));
                //    letterIndex = morse.getKey(outputString);
                //    Console.WriteLine("The index of: " + outputString + " is : " + letterIndex);
                //    Console.WriteLine("The morsecode value of : " + outputString + " is : " + morse.getSequence(letterIndex,styleType));
                    
                //    if ((i + 1 != input.Length) && string.IsNullOrWhiteSpace(input[i + 1].ToString()) == true)
                //    {
                //        output.Append(morse.getSequence(letterIndex, styleType)).Append("   ");
                //    }
                //    else
                //    {
                //        output.Append(morse.getSequence(letterIndex, styleType)).Append("/");
                //    }
                    
                //}
                //else
                //{
                //    letterIndex = -1;
                //    //output.Append(" ");
                //}
             //  letterIndex = morse.f(outputString);
              
               
            }
            //The quick brown fox jumps over the lazy dog
            debug.Show();
            debug.SetDesktopLocation(this.Location.X + this.Size.Width + 2, this.Location.Y);
         
            debug.addText(tO.ToString());
           // MessageBox.Show(tO.ToString());
            outputBox.Text = output.ToString() ;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
           
            new Thread(go).Start();      // Call Go() on a new thread
            
            
           
        }

        private void frequencyBox_Validating(object sender, CancelEventArgs e)
        {
            Console.Write("poop");
        }

        private void frequencyBox_Validated(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
        }

       
        static void go()
        {
            for (int cycles = 0; cycles < 5; cycles++) Console.Write ('?');
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
