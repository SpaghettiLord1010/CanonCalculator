using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Print_Price_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "CSV-file (*.csv)|*.csv";
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "CSV-file (*.csv)|*.csv";
            saveFileDialog1.RestoreDirectory = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void butt_outputfile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtBox_printerfile.Text = openFileDialog1.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtBox_outputfile.Text = saveFileDialog1.FileName;
        }

        List<string> papername = new List<string>(); //Media-Type
        List<string> cost = new List<string>(); //entire cost
        List<string> printstatus = new List<string>();
        List<string> papercost = new List<string>();
        List<string> inkconsumed = new List<string>();
        List<string> inkcost = new List<string>();
        List<string> paperconsumed = new List<string>();

        List<string> paperarray = new List<string>();
        List<string> costarray = new List<string>();
        List<string> papercostarray = new List<string>();
        List<string> inkcostarray = new List<string>();
        List<string> totalpaperarray = new List<string>();
        List<string> totalpapercostarray = new List<string>();
        List<string> totalinkarray = new List<string>();
        List<string> totalinkcostarray = new List<string>();
        List<string> entrynumberarray = new List<string>();
        List<string> costpersqfeetarray = new List<string>();

        private void butt_generate_Click(object sender, EventArgs e)
        {

            foreach (string curfilepath in openFileDialog1.FileNames)
            {
                using (var reader = new StreamReader(curfilepath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        papername.Add(values[2]);
                        cost.Add(values[0]);
                        paperconsumed.Add(values[3]);
                        printstatus.Add(values[1]);
                        papercost.Add(values[18]);
                        inkconsumed.Add(values[17]);
                        inkcost.Add(values[19]);
                    }
                }
            }



            string csvcontent = null;

            string outputpath = txtBox_outputfile.Text;

            //Output: Paper Name  |  Cost per sq. ft  | Paper cost per sq. ft | Ink cost per sq ft. | Total sq. ft paper used  | Total ink used (ml)

            csvcontent = "Paper Name,Cost per sq. ft,Paper cost per sq. ft,Ink cost per sq ft.,Total sq. ft paper used,Total ink used (ml)" + Environment.NewLine;



            int currentlinenumber = 0;
            string k = ",";

            //for checking if string
            //
            bool parseresult;
            float parsecost;

            IFormatProvider culture = CultureInfo.CreateSpecificCulture("en-US");


            foreach (string currentprocess in papername)
            {
                if (currentlinenumber == 0 || papername[currentlinenumber].Contains("Media Type"))
                {
                    currentlinenumber++;
                }
                else
                {
                    string cleancost = cost[currentlinenumber].ToString().Replace("\"", "").Replace("\\", "");
                    string cleanink = inkconsumed[currentlinenumber].ToString().Replace("\"", "").Replace("\\", "");
                    string cleanpapercost = papercost[currentlinenumber].ToString().Replace("\"", "").Replace("\\", "");
                    string cleaninkcost = inkcost[currentlinenumber].ToString().Replace("\"", "").Replace("\\", "");
                    string cleanpaperconsumed = paperconsumed[currentlinenumber].ToString().Replace("\"", "").Replace("\\", "");

                    parseresult = (float.TryParse(cleancost, out parsecost));

                    if (parseresult)
                    {
                        if(parsecost != 0 && printstatus[currentlinenumber] != "Canceled")
                        {
                            int papernamearrayindex = 0;
                            entrynumberarray = null;

                            if (paperarray.Contains(papername[currentlinenumber]))
                            {
                                papernamearrayindex = paperarray.IndexOf(papername[currentlinenumber]);
                                totalinkarray[papernamearrayindex] = (float.Parse(totalinkarray[papernamearrayindex].Replace("\"", "").Replace("\\", "")) + float.Parse(cleanink)).ToString();
                                totalinkcostarray[papernamearrayindex] = (float.Parse(totalinkcostarray[papernamearrayindex].Replace("\"", "").Replace("\\", "")) + float.Parse(cleaninkcost)).ToString();
                                totalpaperarray[papernamearrayindex] = (float.Parse(totalpaperarray[papernamearrayindex].Replace("\"", "").Replace("\\", "")) + float.Parse(cleanpaperconsumed)).ToString();
                                totalpapercostarray[papernamearrayindex] = (float.Parse(totalpapercostarray[papernamearrayindex].Replace("\"", "").Replace("\\", "")) + float.Parse(cleanpapercost)).ToString();
                                costarray[papernamearrayindex] = (float.Parse(costarray[papernamearrayindex].Replace("\"", "").Replace("\\", "")) + float.Parse(cleancost)).ToString();
                                costpersqfeetarray[papernamearrayindex] = "";
                            }
                            else
                            {
                                paperarray.Add(papername[currentlinenumber]);
                                papernamearrayindex = paperarray.IndexOf(papername[currentlinenumber]);
                                totalinkarray.Add(cleanink.ToString());
                                totalinkcostarray.Add(cleaninkcost.ToString());
                                totalpaperarray.Add(cleanpaperconsumed.ToString());
                                totalpapercostarray.Add(cleanpapercost.ToString());
                                costarray.Add(cleancost.ToString());
                                costpersqfeetarray.Add("");
                            }



                            //Output: Paper Name  |  Cost per sq. ft  | Paper cost per sq. ft | Ink cost per sq ft. | Total sq. ft paper used  | Total ink used (ml)
                        }
                    }
                    currentlinenumber++;
                }
            }
            foreach(string currentpapername in paperarray)
            {
                totalpaperarray[paperarray.IndexOf(currentpapername)] = (float.Parse(totalpaperarray[paperarray.IndexOf(currentpapername)]) * 10.76391042).ToString();
                totalinkcostarray[paperarray.IndexOf(currentpapername)] = ((float.Parse(totalinkarray[paperarray.IndexOf(currentpapername)])) / (float.Parse(totalpaperarray[paperarray.IndexOf(currentpapername)]))).ToString();
                totalpapercostarray[paperarray.IndexOf(currentpapername)] = ((float.Parse(totalpapercostarray[paperarray.IndexOf(currentpapername)])) / (float.Parse(totalpaperarray[paperarray.IndexOf(currentpapername)]))).ToString();
                costpersqfeetarray[paperarray.IndexOf(currentpapername)] = ((float.Parse(totalinkcostarray[paperarray.IndexOf(currentpapername)]) + float.Parse(totalpapercostarray[paperarray.IndexOf(currentpapername)]))).ToString();
                csvcontent += paperarray[paperarray.IndexOf(currentpapername)] + k + costpersqfeetarray[paperarray.IndexOf(currentpapername)] + k + totalpapercostarray[paperarray.IndexOf(currentpapername)] + k + totalinkcostarray[paperarray.IndexOf(currentpapername)] + k + totalpaperarray[paperarray.IndexOf(currentpapername)] + k + totalinkarray[paperarray.IndexOf(currentpapername)] + Environment.NewLine;
            }
            File.WriteAllText(outputpath.ToString(), csvcontent);
        }
    }
}
