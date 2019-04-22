using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string hashedValue, plainText, hashedDictionary;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            hashedValue = textBox3.Text;
            
        }

       
       


    public string calculateHash(string input)
    {
        try
        {

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }



        catch (Exception ex)
        {
            if (ex.Source != null)
                Console.WriteLine("IOException source: {0}", ex.Source);
            throw;

        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void button3_Click(object sender, EventArgs e)
    {
           // Read Dictionary and findout encrypt value of dictionary
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
            // Use a tab to indent each line of the file.
           // plainText = "password";
            hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
            {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if(textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getDoubleWords();
            }
        }



        public void getDoubleWords()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary1.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
               getTripleWords();
            }
        }


        public void getTripleWords()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary2.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getNumberPrefixWord();
            }
        }

        public void getNumberPrefixWord()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary2.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getNumberSufixWord();
            }
        }

        public void getNumberSufixWord()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary3.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getNumberPermutations();
            }
        }

        public void getNumberPermutations()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary4.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getSameNumberCombinations();
            }
        }

        public void getSameNumberCombinations()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary5.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
            if (textBox1.Text == "Not Found")
            {
                // Try combinations of two words from dictionary
                getSpecialCharacterWordCombinations();
            }
        }

        public void getSpecialCharacterWordCombinations()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mallul\Downloads\dictionary5.txt");

            //// Display the file contents by using a foreach loop.

            foreach (string plainText in lines)
            {
                // Use a tab to indent each line of the file.
                // plainText = "password";
                hashedDictionary = calculateHash(plainText);

                if (string.Equals(hashedValue, hashedDictionary, StringComparison.CurrentCultureIgnoreCase))//.Equals(hashedDictionary)
                {
                    Console.WriteLine("Matched password is " + plainText);
                    textBox1.Text = plainText;
                    break;
                }
                else
                {
                    Console.WriteLine("Not Matching");
                    textBox1.Text = "Not Found";
                }

            }
           
        }



    }
}
