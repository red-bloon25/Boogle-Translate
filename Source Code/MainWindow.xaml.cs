using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Boogle_Translate;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void DoTheTranslating(object? sender, RoutedEventArgs e)
    {
        // this would take the input of Entry and use the Method "transES" to Translate it then, return it via show textbox or a label
        string input = Input.Text;
        string check = ToLanguage.Text;
        CheckFromLangStat();
        Console.WriteLine(ToLanguage.Text);
        if (check == "Silly" && AMERICAN)
        {
            string AMERICANOUTPUT= SillySpeak(input) +"🦅🦅🗽🦅🗽🤠🤠🤠🤠";
            Output.Text = AMERICANOUTPUT;
        }
        else if (check == "Silly")
        {
            string translated=SillySpeak(input);
            Output.Text=translated;
        }
        else if (check=="Spanish"&&AMERICAN)
        {
            string AMERICANOUTPUT= TranslateES(input) +"🦅🦅🗽🦅🗽🤠🤠🤠🤠";
            Output.Text=AMERICANOUTPUT;
        }
        else if (check=="Spanish" && !AMERICAN)
        {
            string OUTPUT= TranslateES(input);
            Output.Text=OUTPUT;
        }
        else
        {
            MessageBox.Show("Choose a Language to translate to","CHOOSE A LANGUAGE",MessageBoxButton.OK,MessageBoxImage.Warning);
        }
       

    }

    public bool espanol = false;
    public bool AMERICAN = false;
    // just add the new words to the list and the common english word list
    public List<string> PrepWord = [ "a","of", "or", "and", "why","but","because","with","in","to"];
    public List<string> EspanWordd = [ "de", "o", "y", "por qué", "pero", "porque", "con", "in", "a"];
    public List<string> CommonEngWord = ["hi", "hello", "hey","bye","goodbye","friend","friends","buddy","bud","welcome","your welcome","you're welcome","yes","yea","sure","yuh uh", "yuh-uh","yuhuh","no","nah","nuh uh","nuh-uh","nuhuh","please","pls","i","me","bro","brother","sis","sister","guys"];
    public List<string> Hi = ["hi", "hello", "hey"];
    public List<string> Bye = ["bye","goodbye"];
    public List<string> Friend = ["friend","friends","buddy","bud","bro","bother","sis","sister","guys"];
    public List<string> Welcome = ["welcome","your welcome","you're welcome"];
    public List<string> Yes = ["yes","yea","sure","yuh uh", "yuh-uh","yuhuh"];
    public List<string> No = ["no","nah","nuh uh","nuh-uh","nuhuh"];
    public List<string> Pls = ["please", "pls"];
    public string final = "idk bro";
    public string TranslateES(String jim)
    {
        //try to figure out on own before googling
        // got it by googling " what string.split does"," how to use a for loop", and "what is a for loop"  still better than I though :D

        string OG = jim.ToLower();
        if (OG.Contains(" ") || OG.Length >0)
        {
            int indexnum = 0;
            List<string> words = OG.Split(' ',StringSplitOptions.TrimEntries).ToList();
            foreach (string word in words.ToList())
            { // puts each word in a list btw it starts at 0 bc computer -_-
                // IT TOOK ME 30MIN TO FIGURE OUT WHY IT WASNT WORK, TO REALISE THAT I WAS JUST SETTING IT TO 0 ALL OVER >:[ 
                // int indexnum=0 <= THAT WAS THE CODE THAT WAS KILLING MY MENTAL .д.
                Console.WriteLine($"The word is //{word}\\\\ and number is {indexnum}");
                int rannum = RanNum();
                //todo make into function/method for easier reading or not I don't care :3
                if (PrepWord.Contains(word))
                {// this is for the prep words like "a, of, or" ect
                    Console.WriteLine("is a prep word");
                    Console.WriteLine(rannum);
                    if (rannum == 1)
                    {// 
                        if (word=="a")
                        {
                            int rannum2 = RanNum();
                            Console.WriteLine($"this is ran2 {rannum2}");
                            if (rannum2 == 1)
                            {
                                string Translated = "un";
                                words[indexnum] = Translated;
                            }
                            else
                            {
                                string Translated = "una";
                                words[indexnum] = Translated;
                            }
                        }
                        else
                        {
                            string TranslatedSwitch = "nothing";
                            switch (word)
                            {
                                    
                                case("of"):
                                    TranslatedSwitch = "de";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("or"):
                                    TranslatedSwitch = "o";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("and"):
                                    TranslatedSwitch = "y";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("why"):
                                    TranslatedSwitch = "por que";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("but"):
                                    TranslatedSwitch = "pero";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("because"):
                                    TranslatedSwitch = "porque";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("with"):
                                    TranslatedSwitch = "con";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("in"):
                                    TranslatedSwitch = "en";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                                case("to"):
                                    TranslatedSwitch = "a";
                                    words[indexnum] = TranslatedSwitch;
                                    break;
                            }
                        }
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("do nothing");
                    }
                    
                }
                // this is for the other words
                else
                {
                    if (CommonEngWord.Contains(word))
                    {
                        if (Hi.Contains(word))
                        {
                            string translated = "hola";
                            words[indexnum] = translated;
                        }
                        else if (Bye.Contains(word))
                        {
                            string translated = "adios";
                            words[indexnum] = translated;
                        }
                        else if (No.Contains(word))
                        {
                            string translated = "no";
                            words[indexnum] = translated;
                        }
                        else if (Yes.Contains(word))
                        {
                            string translated = "si";
                            words[indexnum] = translated;
                        }
                        else if (Friend.Contains(word))
                        {
                            string translated = "amigo";
                            words[indexnum] = translated;
                        }
                        else if (Welcome.Contains(word))
                        {
                            string translated = "de nada";
                            words[indexnum] = translated;
                        }
                        else if (Pls.Contains(word))
                        {
                            string translated = "por favor";
                            words[indexnum] = translated;
                        }
                        else if (word == "i")
                        {
                            string translated = "yo";
                            words[indexnum] = translated;
                        }
                        else if (word == "me")
                        {
                            string translated = "me";
                            words[indexnum] = translated;
                        }
                        
                    }
                    else
                    {
                        int rannum3= RanNum();
                        if (rannum3 == 1)
                        {
                            string translated = word + "o";
                            words[indexnum] = translated;
                        }
                        else
                        {
                            string translated = word + "a";
                            words[indexnum] = translated;
                        }
                    }
                    
                }
                Console.WriteLine("this is the full list: ");
                indexnum++;
                foreach (var x in words)
                {
                    Console.WriteLine(x);
                }
            }
            final = string.Join(' ', words);
        }

        
        return final;
    }
    
    public int RanNum()
    {
        //range 1-2 aka 50%
        Random ran = new Random();
        int num = ran.Next(1, 3);
        return num;
    }
    
    private void TitleImage_OnImageFailed(object? sender, ExceptionRoutedEventArgs e)
    {
        MessageBox.Show("Image failed","Image failed :(",MessageBoxButton.OK,MessageBoxImage.Error);
    }

    private void SetBackground(object sender, RoutedEventArgs e)
    {
        String URIA = "pack://application:,,,/Images/BackGroundA.jpg";
        String URIB = "pack://application:,,,/Images/BackGroundB.jpg";
        String URIC = "pack://application:,,,/Images/BackGroundC.jpg";
        String URID = "pack://application:,,,/Images/BackGroundD.jpg";
        String URIE = "pack://application:,,,/Images/BackGroundE.jpg";
        String URIF = "pack://application:,,,/Images/BackGroundF.png";
        ImageBrush brush = new ImageBrush();
        Random ran = new Random();
        int num = ran.Next(1, 7);
        switch (num)
        {
            case 1:
                brush.ImageSource = new BitmapImage(new Uri(URIA));
                grid.Background = brush;
                BGNUM.Content = "BG:1";
                break;
            case 2:
                brush.ImageSource = new BitmapImage(new Uri(URIB));
                grid.Background = brush;
                BGNUM.Content = "BG:2";
                break;
            case 3:
                brush.ImageSource = new BitmapImage(new Uri(URIC));
                grid.Background = brush;
                BGNUM.Content = "BG:3";
                break;
            case 4:
                brush.ImageSource = new BitmapImage(new Uri(URID));
                grid.Background = brush;
                BGNUM.Content = "BG:4";
                break;
            case 5:
                brush.ImageSource = new BitmapImage(new Uri(URIE));
                grid.Background = brush;
                BGNUM.Content = "BG:5";
                break;
            case 6:
                brush.ImageSource = new BitmapImage(new Uri(URIF));
                grid.Background = brush;
                BGNUM.Content = "BG:6";
                break;
            
        }
    }

    private void UNSETbg(object sender, RoutedEventArgs e)
    {
        ImageBrush brush = new ImageBrush();
        String URIA = "pack://application:,,,/Images/BackGroundA.jpg";
        brush.ImageSource = new BitmapImage(new Uri(URIA));
        grid.Background = brush;
        BGNUM.Content = "BG:1";
    }

    

    

    private void FromLanguage_OnDropDownClosed(object? sender, EventArgs e)
    {
        string words = FromLanguage.Text;
        Console.WriteLine(words);
        if (FromLanguage.Text== "AMEIRCAN")
        {
            AMERICAN = true;
            Console.WriteLine("AMERICAN 2");
        }
        else
        {
            AMERICAN = false;
            Console.WriteLine("ENGLISH 2");
        }
    }
    private void ToLanguage_OnDropDownClosed(object? sender, EventArgs e)
    {
        string words = ToLanguage.Text;
        Console.WriteLine(words);
        if (FromLanguage.Text== "Spanish")
        {
            AMERICAN = true;
            Console.WriteLine("Spansh 2");
        }
        else
        {
            Console.WriteLine("SILLY 2");
        }
    }

    private void Input_OnKeyDown(object sender, KeyEventArgs e)
    {
        string input = Input.Text;
        if (e.Key == Key.Enter)
        {
            if (AMERICAN == false)
            {
                string translated= TranslateES(input);
                Output.Text=translated;
            }
            else
            {
                string translated= TranslateES(input);
                string AMERICANOUTPUT= TranslateES(input) +"🦅🦅🦅🦅🦅🦅🦅🦅🦅🦅🦅🦅";
                Output.Text=AMERICANOUTPUT;
            }
        }
        

    }

    private void ClearText(object sender, KeyboardFocusChangedEventArgs e)
    {
        string words = FromLanguage.Text;
        Console.WriteLine(words);
        if (Input.Text == "Enter Text" || Input.Text==""|| Input.Text==" ")
        {
            Input.Text = "";
            Output.Text = "";
        }
    }

    public string SillySpeak(string og)
    {
        Console.WriteLine(og);
        List<string> silly = [];
        int length= og.Length;
        Console.WriteLine(length);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"This is I: {i}");
            int num=RanNum();
            silly.Add(":3");
            if (num == 1)
            {
                silly.Add(";3");
            }
            else
            {
                silly.Add(">W<");
            }
        }
        Console.WriteLine(silly);
        final = string.Join("  ", silly.ToArray());
        Console.WriteLine(final);
        
        return final;
    }

    public void CheckFromLangStat()
    {
        string check = FromLanguage.Text;
        Console.WriteLine($"This is check var: {check}");
        if (check=="")
        {
            MessageBox.Show("Choose a Language to translate from","CHOOSE A LANGUAGE",MessageBoxButton.OK,MessageBoxImage.Warning);
        }
    }
}