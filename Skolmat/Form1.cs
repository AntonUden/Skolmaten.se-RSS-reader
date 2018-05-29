using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using Microsoft.Win32;

namespace Skolmat
{
    public partial class Form1 : Form
    {
        public string feedURL = "https://skolmaten.se/backadalsgymnasiet/rss/";

        public string[] days = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag" };
        public string[] food;
        public string[] weeks;

        public Form1()
        {
            InitializeComponent();
            String fURL = getDataFromRegistry("feedURL");

            if(fURL == null)
            {
                Console.WriteLine("adding default registry key");
                writeDataToRegistry("https://skolmaten.se/backadalsgymnasiet/rss/", "feedURL");
                fURL = getDataFromRegistry("feedURL");
            }
            if (!(fURL == null))
            {
                feedURL = fURL;
                URLBox.Text = feedURL;
            } else
            {
                Console.WriteLine("adding default registry key -");
                writeDataToRegistry("https://skolmaten.se/backadalsgymnasiet/rss/", "feedURL");
                fURL = getDataFromRegistry("feedURL");
                feedURL = fURL;
                URLBox.Text = feedURL;
            }
            update();
        }

        public int getNumbersFromString(string str)
        {
            string intStr = "";

            for(int i = 0; i < str.Length; i++)
            {
                string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                for(int j = 0; j < numbers.Length; j++)
                {
                    string ts = str.ToArray()[i] + "";
                    if (ts.Equals(numbers[j]))
                    {
                        intStr = intStr + numbers[j];
                    }
                }
            }

            try
            {
                int result = Int32.Parse(intStr);
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public void writeDataToRegistry(string str, string key)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Zeeraa\apps\Skolmat", key, str);
        }

        public string getDataFromRegistry(string key)
        {
            try
            {
                return Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Zeeraa\apps\Skolmat", key, null).ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("!!!!!   " + e.Message);
            }
            return null;
        }

        public void writeData()
        {
            FoodList.Items.Clear();
            ListViewItem lviB = new ListViewItem("  ");
            FoodList.Items.Add(lviB);

            for (int i = 0; i < days.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(days[i]);
                Console.WriteLine(weeks[i]);
                lvi.SubItems.Add(weeks[i]);
                lvi.SubItems.Add(food[i]);

                FoodList.Items.Add(lvi);
            }
        }

        public void update()
        {
            Console.WriteLine("updating feed");
            try
            {
                feedURL = URLBox.Text;

                food = new string[5];
                for (int j = 0; j < food.Length; j++)
                {
                    food[j] = "";
                }

                weeks = new string[5];
                for (int k = 0; k < weeks.Length; k++)
                {
                    weeks[k] = "";
                }

                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(feedURL));

                int i = 0;
                foreach (SyndicationItem item in feed.Items)
                {
                    Console.WriteLine(item.Title.Text);

                    Console.WriteLine(item.Summary.Text);

                    string w = "" + getNumbersFromString(item.Title.Text);

                    string f00d = item.Summary.Text.Replace("<br/>", " Eller ");

                    weeks[i] = w;
                    food[i] = f00d;

                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            writeData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {
            writeDataToRegistry(URLBox.Text, "feedURL");
        }
    }
}
