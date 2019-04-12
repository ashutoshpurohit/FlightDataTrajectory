using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = folderBrowserDialog1.ShowDialog();
            if(dg == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                String[] files = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.csv");

                foreach(String sf in files)
                {
                    AddFlights(sf);
                }

            }
            
            
        }

        private void AddFlights(string airfile)
        {
            string path = airfile;
            AirFlight af = new AirFlight();
            af.Source = "Bengaluru";
            af.Destination = "Delhi";
            List<FlightPath> flightpath = new List<FlightPath>();
            af.AirFlightPath = flightpath;
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.CommentTokens = new string[] { "#" };
                parser.SetDelimiters(new string[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

                // Skip over header line.
                parser.ReadLine();
                int i = 0;


                while (!parser.EndOfData)
                {
                    FlightPath fpath = new FlightPath();
                    string[] fields = parser.ReadFields();
                    if (i == 0)
                    {
                        af.FlightId = fields[2];
                    }
                    fpath.TimeStamp = double.Parse(fields[0]);
                    DateTime fdate = DateTime.Parse(fields[1]);
                    af.FlightDate = fdate.Date;
                    af.FlightDateStr = (fdate.Day - 1).ToString().PadLeft(2, '0') + "-" + fdate.Month.ToString().PadLeft(2, '0') + "-" + fdate.Year.ToString();
                    fpath.TimeSlice = fdate.Hour.ToString() + ":" + fdate.Minute.ToString() + ":" + fdate.Second.ToString();
                    string[] pos = fields[3].Split(',');
                    fpath.Latitude = double.Parse(pos[0]);
                    fpath.Longitude = double.Parse(pos[1]);
                    fpath.Altitude = double.Parse(fields[4]);
                    fpath.Speed = double.Parse(fields[5]);
                    fpath.Direction = double.Parse(fields[6]);


                    flightpath.Add(fpath);


                }
            }

           

            string json = JsonConvert.SerializeObject(af);

            GeneralResponse resp = new DataManager().AddAirFlighty(af);

            System.IO.File.AppendAllText(airfile + ".json" , json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirFlight[] flights = new DataManager().GetAirFlight();

            DataTable dt = new DataTable();
            int i = 0;
            int flighttrajectorymaxlength = 0;
            foreach(AirFlight af in flights)
            {
                if(af.AirFlightPath.Count > flighttrajectorymaxlength)
                {
                    flighttrajectorymaxlength = af.AirFlightPath.Count;
                }
                i++;
                dt.Columns.Add(af.FlightId + " " + af.FlightDate.ToShortDateString() + " " + i.ToString(), typeof(System.String));
            }
            foreach (AirFlight af in flights)
            {
                int pathcount = af.AirFlightPath.Count;
                if(pathcount < flighttrajectorymaxlength)
                {
                    int diff = flighttrajectorymaxlength - pathcount;
                    for(int z =0; z < diff; z++)
                    {
                        af.AirFlightPath.Add(af.AirFlightPath[pathcount - 1]);
                    }
                }
            }

                for (int j =0; j <= flighttrajectorymaxlength; j++)
            {
                object[] o = new String[flights.Length];
                
                for(int z =0; z < flights.Length; z++)
                {
                    try
                    {
                        o[z] = flights[z].AirFlightPath[j].ToString();
                    }
                    catch(Exception) { }
                }

                dt.Rows.Add(o);
            }

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.DataSource = dt;
            for(int k =0; k < dataGridView1.Columns.Count; k++)
               dataGridView1.Columns[k].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
    }
}
