using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examenSyntra1NielsAdriaenssens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        //IN SOME OF THE EXERCISES I GIVE DIFFERENT SOLUTIONS
        //THE SOLUTION IN COMMENT SEEMS IS THE MOST LOGIC SOLUTION FOR ME
        //ALSO I DID SOME STEP BY STEP EXPLANATION SO YOU CAN SEE I UNDERSTAND WATH HAPPENS IN THE SHORTCODES
        //I WROTE EVERYTHING IN ENGLISH SO EVERYONE CAN READ MY CODE
        //IN EXERCISE 6 AND 14 MY ANSWER IS DIFFERENT AS THE EXAMPLE. CAUSE THE WAY I SEE 3 THROUGH 7 (3,4,5,6,7) ARE 5 DIGITS.


        //1.UPPERCASE
        private void btnUpperCase_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE

            txtUpperCase.Text = txtInput.Text.ToUpper();

            ////SOLUTION 2 ALL STEPS
            ////INPUT 

            //string input = txtInput.Text;

            ////TO UPPER

            //string inputUpper = input.ToUpper();

            ////OUTPUT

            //txtUpperCase.Text = inputUpper;
        }


        //2.LOWERCASE
        private void btnLowerCase_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE

            txtLowerCase.Text = txtInput.Text.ToLower();

            ////SOLUTION 2 ALL STEPS
            ////INPUT 

            //string input = txtInput.Text;

            ////TO LOWERCASE

            //string inputLow=input.ToLower(); 
            ////OUTPUT

            //txtLowerCase.Text = inputLow;
        }


        //3.STRING COUNT
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE

            txtCount.Text = Convert.ToString(txtInput.Text.Length);

            ////SOLUTION 2 STEP BY STEP
            ////INPUT

            //string input = txtInput.Text;

            ////COUNT 

            //int Count = input.Length;
            
            ////CONVERT TO STRING 

            //string CountString = Convert.ToString(Count);

            ////OUTPUT

            //txtCount.Text = CountString;
        }


        //4.FIRST LETTER
        //I DID A TRIM IN THE START TO REMOVE ANY SPACING. CAUSE SPACING IS NO LETTER.
        private void btnFirstLetter_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE

            txtFirstLetter.Text = txtInput.Text.TrimStart().Substring(0,1);

            ////SOLUTION 2 STEP BY STEP
            ////INPUT

            //string input = txtInput.Text;

            ////REMOVE ANY SPACING BEFORE THE STRING

            //string inputTrim =input.Trim();

            ////SELECT FIRST LETTER

            //string inputFirstLetter = inputTrim.Substring(0,1);

            ////OUTPUT

            //txtFirstLetter.Text = inputFirstLetter;
        }


        //5.LAST LETTER
        //I DID A TRIM IN THE END TO REMOVE ANY SPACING. CAUSE SPACING IS NO LETTER.
        private void btnLastLetter_Click(object sender, RoutedEventArgs e)
        {
            ////SOLUTION 1 SHORTESTCODE NO TRIM

            //txtLastLetter.Text = txtInput.Text.Substring(txtInput.Text.Length - 1);

            //SOLUTION 2 WITH TRIMMING ON THE END STEP BY STEP
            //INPUT

            string input = txtInput.Text;

            //REMOVE SPACING

            string inputTrim = input.TrimEnd();

            //SELECT LAST LETTER

            string inputLast = inputTrim.Substring(inputTrim.Length - 1);

            //OUTPUT

            txtLastLetter.Text = inputLast;
        }


        //6.LETTER 3 THROUGH 7
        //I REMOVED ANY SPACING. SO IT WILL ALWAYS START COUNTING FROM THE FIRST LETTER
        private void btn3Through7_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE 

            txt3Through7.Text = txtInput.Text.TrimStart().Substring(2,5);

            ////SOLUTIION 2 STEP BY STEP 

            ////INPUT

            //string input = txtInput.Text;

            ////TRIM 

            //string inputTrim = input.TrimStart();

            ////SELECT LETTERS

            //string inputLetters = inputTrim.Substring(2, 5);

            ////OUTPUT

            //txt3Through7.Text = inputLetters;
        }


        //7.DELETE FRONT SPACING
        private void btnDeleteFrontSpace_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE
            txtDeleteFrontSpace.Text = txtInput.Text.TrimStart();

            ////SOLUTION 2 STEP BY STEP
            ////INPUT
            //string input = txtInput.Text;
            ////REMOVE FRONT SPACING
            //string inputTrim = input.TrimStart();
            ////OUTPUT
            //txtDeleteFrontSpace.Text = inputTrim;
        }


        //8.DELETE END SPACING
        private void btnDeleteEndSpace_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE
            txtDeleteEndSpace.Text = txtInput.Text.TrimStart();

            ////SOLUTION 2 STEP BY STEP
            ////INPUT
            //string input = txtInput.Text;
            ////REMOVE FRONT SPACING
            //string inputTrim = input.TrimEnd();
            ////OUTPUT
            //txtDeleteEndSpace.Text = inputTrim;
        }


        //9.DELETE SPACING
        private void btnDeleteSpaces_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE
            txtDeleteSpaces.Text = txtInput.Text.Trim();

            ////SOLUTION 2 STEP BY STEP
            ////INPUT
            //string input = txtInput.Text;
            ////REMOVE FRONT SPACING
            //string inputTrim = input.Trim();
            ////OUTPUT
            //txtDeleteSpaces.Text = inputTrim;
        }


        //10.DELETE .NET
        private void btnDeleteNET_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 

            txtDeleteNET.Text = txtInput.Text.Replace(".net", "");



            //SOLUTION 2 STEP BY STEP

            ////INPUT
            //string input = txtInput.Text;
            ////DELETE
            //string inputDelete = input.Replace(".net","");
            ////OUTPUT
            //txtDeleteNET.Text = inputDelete;



            ////SOLUTION 3
            ////The uppercase and lowercase converting needed to be done, because you asked for .NET (UPPERCASE) and the string sended it lowercase. 

            ////INPUT

            //string input = txtInput.Text;

            //////EMPTY VAR

            //string ModifiedString = string.Empty;

            ////CONVERT TO UPPERCASE

            //string upper = input.ToUpper();

            ////DELETE PROCES

            //if (upper.Contains(".NET"))
            //{
            //    // OUTPUT WITHOUT .NET
            //    ModifiedString = upper.Remove(upper.IndexOf(".NET"), ".NET".Length);
            //    txtDeleteNET.Text = ModifiedString.ToLower();
            //}
            //else
            //{
            //    txtDeleteNET.Text = input;
            //}
        }


        //11.ADD ___
        private void btnAddNET_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 

            txtAddNET.Text = txtInput.Text.Replace(".net", "___.net");



            //SOLUTION 2 STEP BY STEP

            ////INPUT
            //string input = txtInput.Text;
            ////DELETE
            //string inputDelete = input.Replace(".net","___.net");
            ////OUTPUT
            //txtAddNET.Text = inputDelete;
        }


        //12.REPLACE WORDS
        private void btnReplaceWords_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION 1 SHORTCODE

            txtReplaceWords.Text = txtInput.Text.ToLower().Replace("visual basic.net", "C#");


            ////SOLUTION 2
            ////INPUT
            //string input = txtInput.Text;
            ////CONVERT TO LOWERCASE
            //string inputlow = input.ToLower();
            ////REPLACE WORDS
            //string inputReplace = inputlow.Replace("visual basic.net", "C#");
            ////OUTPUT
            //txtReplaceWords.Text = inputReplace;


            ////SOLUTION 3
            ////INPUT

            //string input = txtInput.Text;

            ////EMPTY STRING

            //string replacedString = string.Empty;

            ////STRING WITHOUT SPACING

            //string trimSpacing = input.Trim();

            ////REPLACE PROCESS

            //if(trimSpacing.Contains("visual basic.net"))
            //{
            //    //REPLACED OUTPUT
            //    replacedString = trimSpacing.Replace("visual basic.net", "C#");
            //    txtReplaceWords.Text = replacedString;
            //}
            //else
            //{
            //    //OUTPUT
            //    txtReplaceWords.Text = input;
            //}
        }


        //13.SELECT SENTENCE
        private void btnSelectSentence_Click(object sender, RoutedEventArgs e)
        {
            //INPUT

            string input = txtInput.Text;

            //OUTPUT
            this.txtSelectSentence.Text = input;
            //SELECTION 
            this.txtSelectSentence.Focus();
            this.txtSelectSentence.SelectionStart = 0;
            this.txtSelectSentence.SelectionLength = input.Length;

        }


        //14.SELECT LETTERS
        private void btnSelectLetters_Click(object sender, RoutedEventArgs e)
        {
            //INPUT

            string input = txtInput.Text.Trim();
             
            //OUTPUT
            this.txtSelectLetters.Text = input;
            //SELECTION COUNT WITHOUT FRONT SPACE
            this.txtSelectLetters.Focus();
            this.txtSelectLetters.SelectionStart = 2;
            this.txtSelectLetters.SelectionLength = 5;
        }


        //15.REVERSE STRING
        private void btnReverseString_Click(object sender, RoutedEventArgs e)
        {
            //INPUT,CREATING ARRAY AND REVERSE
            
            string input = new string(txtInput.Text.ToCharArray().Reverse().ToArray());

            //OUTPUT

            txtReverseString.Text = input;
        }


        //16.FIRST CHARACTER IN SENTENCE UPPERCASE
        private void btnFirstUpperCase_Click(object sender, RoutedEventArgs e)
        {
            //INPUT ,LOWERCASE AND TRIMMING FRONT SPACES

            string inputLow = txtInput.Text.ToLower().TrimStart();

            //CHECK IF TEXTBOX IS EMPTY
            if (txtFirstUpperCase == null)
            {
                //WHEN EMPTY. OUTPUT AND CONVERT FIRST LETTER TO UPPERCASE AND THE REST TO LOWERCASE
                txtFirstUpperCase.Text += char.ToUpper(inputLow[0]) + inputLow.Substring(1);
            }
            else
            {
                //WHEN NOT EMPTY. CLEAR TEXTBOX
                txtFirstUpperCase.Text = "";
                //OUTPUT AND CONVERT FIRST LETTER TO UPPERCASE AND THE REST TO LOWERCASE
                txtFirstUpperCase.Text += char.ToUpper(inputLow[0]) + inputLow.Substring(1);
            }
        }


        //17.EVERY WORD UPPERCASE
        private void btnWordUpperCase_Click(object sender, RoutedEventArgs e)
        {
            //SOLUTION1
            //INPUT AND CONVERT TO LOWER

            string inputLow = txtInput.Text.ToLower().Trim();

            //ARRAY BUILD
            string[] inputArray = inputLow.Split(' ');

            //CHECK IF TEXTBOX IS EMPTY 
            if (txtWordUppercase == null)
            {
                //RUNDOWN ARRAY
                foreach (string i in inputArray)
                {
                    //PUT WORD IN STRING,CHANGE FIRST LETTER TO UPPERCASE AND ADD A SPACE
                    string word = char.ToUpper(i[0]) + i.Substring(1) + " ";
                    //OUTPUT
                    txtWordUppercase.Text += word;
                }
            }
            else
            {
                //CLEAR TEXTBOX WHEN NOT TEXTBOX IS NOT EMPTYT
                txtWordUppercase.Text = "";
                //RUNDOWN ARRAY
                foreach (string i in inputArray)
                {
                    //PUT WORD IN STRING,CHANGE FIRST LETTER TO UPPERCASE AND ADD A SPACE
                    string word = char.ToUpper(i[0]) + i.Substring(1) + " ";
                    //OUTPUT
                    txtWordUppercase.Text += word;
                }
            }


            ////SOLUTION2
            ////INPUT

            //string input = txtInput.Text;

            ////OUTPUT

            //txtWordUppercase.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }


        //18.VOWEL UPPERCASE
        private void btnVowelUpperCfase_Click(object sender, RoutedEventArgs e)
        {
            //INPUT AND CONVERT TO LOWERCASE

            string inputlow = txtInput.Text.ToLower();

            //ARRAY BUILD

            char[] charArray = new char[inputlow.Length];

            //PUTTING CHARACTERS IN ARRAY

            for (int i = 0; i < inputlow.Length; i++)
            {
                charArray[i] = inputlow[i];
            }

            //CONTROLLER IF EMPTY
            if (txtVowelUppercase == null)
            {   
                //WHEN EMPTY CONTROL RUNDOWN ARRAY
                foreach (char c in charArray)
                {   
                    //CHECK IF CHARACTER IS A VOWEL
                    if (c == 'a' || c == 'e' || c == 'u' || c == 'i' || c == 'o')
                    {   
                        //WHEN VOWEL CONVERT TO STRING AND UPPERCASE. 
                        txtVowelUppercase.Text += c.ToString().ToUpper();
                    }
                    else
                    {
                        //WHEN CONSONENT CONVERT TO STRING
                        txtVowelUppercase.Text += c.ToString();
                    }
                }
            }
            else
            {   
                //WHEN NOT EMPTY. CLEAR THE TEXTBOX
                txtVowelUppercase.Text = "";
                //RUNDOWN ARRAY
                foreach (char c in charArray)
                {   //WHEN VOWEL CONVERT TO STRING AND UPPERCASE. 
                    if (c == 'a' || c == 'e' || c == 'u' || c == 'i' || c == 'o')
                    {
                        txtVowelUppercase.Text += c.ToString().ToUpper();
                    }
                    else
                    {
                        //WHEN CONSONENT CONVERT TO STRING
                        txtVowelUppercase.Text += c.ToString();
                    }
                }

            }
        }


        //19.REVERSE STRING 2
        private void btnReverseString2_Click(object sender, RoutedEventArgs e)
        {
            //INPUT
            
            string input = txtInput.Text;

            //ARRAY BUILD
            char[] charArray = new char[input.Length];

            //PUT CHARACTERS IN ARRAY 
            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[i];
            }

            //IF TEXTBOX IS EMPTY
            if (txtReverseString2 == null)
            {
                //REVERSE ARRAY LOOP
                for (int i = charArray.Length - 1; i > -1; i--)
                {   //OUTPUT 
                    txtReverseString2.Text += charArray[i];
                }
            }
            //WHEN THERE IS CONTENT IN THE TEXTBOX
            else
            {
                //CLEAR TEXTBOX
                txtReverseString2.Text = "";
                //REVERSE ARRAY LOOP
                for (int i = charArray.Length - 1; i > -1; i--)
                {
                    //OUTPUT
                    txtReverseString2.Text += charArray[i];
                }
            }

        }



        //20.RANDOM STRING
        private void btnRandomString_Click(object sender, RoutedEventArgs e)
        {
            //INPUT 
            string input = txtInput.Text;

            //RANDOM
            Random r = new Random();

           //ARRAY BUILD
            char[] charArray = new char[input.Length];

            //PUT CHARACTER IN ARRAY
            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[i];
            }

            //RANDOMIZE ARRAY
            charArray = charArray.OrderBy(x => r.Next()).ToArray();

            //CHECK IF TEXTBOX IS EMPTY
            if (txtRandomString == null)
            {
                //RUN THROUGH ARRAY
                for (int i = 0; i < charArray.Length; i++)
                {
                    //OUTPUT
                    txtRandomString.Text += charArray[i];
                }
            }
            else
            {   
                //CLEAR CONTENT FROM TEXTBOX
                txtRandomString.Text = "";
                //RUN THROUGH ARRAY
                for (int i = 0; i < charArray.Length; i++)
                {
                    //OUTPUT
                    txtRandomString.Text += charArray[i];
                }
            }

        } 
    }
}
