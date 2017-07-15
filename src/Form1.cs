using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace HostedDomains_Spoofer
{
    public partial class Form1 : Form
    {
        ///datamarket.azure.com/account/keys
        private const string BING_API_KEY_NAME = "MyApp";
        private const string BING_API_KEY_VALUE = "5/rll/RgJiFxxSut4sRYLim00MFUr3UITyMAh7JETng=";
        private const int resultsNumber = 400; //// MAX 50 results per query
        
        
        //this is incremental step - $skip step - Love declarations
        private int skipResults = 0;
        private int remaining_results = resultsNumber;
        private string keyword = null;

        BackgroundWorker bw = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            remaining_results = resultsNumber;
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }
        bool continua = false;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.hostIpTextBox.Enabled = this.hostIpRadioButton.Checked;
        }

        private void sitenameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sitenameTextBox.Enabled = this.sitenameRadioButton.Checked;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string ipAddr = null;
            continua = false;

            this.resultBox.Clear();
            if (this.hostIpRadioButton.Checked == true)
            {
                if (IsValidIp(this.hostIpTextBox.Text))
                {
                    ipAddr = this.hostIpTextBox.Text;
                    continua = true;
                }
                else
                    MessageBox.Show("Bad ip address!", "Error!");
            }
            else if (this.sitenameRadioButton.Checked == true)
            {
                if (IsValidSitename(this.sitenameTextBox.Text))
                {
                    setStatus("Resolving domain name...");
                    IPAddress resultIp = null;
                    if (GetResolvedConnecionIPAddress(this.sitenameTextBox.Text, out resultIp))
                    {
                        ipAddr = resultIp.ToString();
                        continua = true;
                    }
                    else
                    {
                        MessageBox.Show("Can't get website ip, maybe server is not responding to pings, try to add the ip address manually!", "Error!");
                        setStatus("Ready...");                        
                    }
                }
                else
                    MessageBox.Show("Invalid sitename!", "Error!");
            }
            else
                MessageBox.Show("Please select an option above!!!", "Error!");
            keyword = "ip:" + ipAddr;
            
            if(continua)
            {
                continua = false;
                setStatus("Getting bing results..");              
                if(bw.IsBusy != true)
                {
                    bw.RunWorkerAsync();
                }
                else
                    MessageBox.Show("Working right now, wait to finish this task!");
            }
        }

        public bool IsValidIp(string addr)
        {
            IPAddress ip;
            bool result = !string.IsNullOrEmpty(addr) && IPAddress.TryParse(addr, out ip);
            
            return result;
        }

        public bool IsValidSitename(string sitename)
        {
            if (Uri.IsWellFormedUriString(sitename, UriKind.Relative))
                return true;
            return false;
        }

        public static bool GetResolvedConnecionIPAddress(string serverNameOrURL, out IPAddress resolvedIPAddress)
        {
            bool isResolved = false;
            IPHostEntry hostEntry = null;
            IPAddress resolvIP = null;
            try
            {
                if (!IPAddress.TryParse(serverNameOrURL, out resolvIP))
                {
                    hostEntry = Dns.GetHostEntry(serverNameOrURL);

                    if (hostEntry != null && hostEntry.AddressList != null
                                 && hostEntry.AddressList.Length > 0)
                    {
                        if (hostEntry.AddressList.Length == 1)
                        {
                            resolvIP = hostEntry.AddressList[0];
                            isResolved = true;
                        }
                        else
                        {
                            foreach (IPAddress var in hostEntry.AddressList)
                            {
                                if (var.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    resolvIP = var;
                                    isResolved = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    isResolved = true;
                }
            }
            catch (Exception)
            {
                isResolved = false;
                resolvIP = null;
            }
            finally
            {
                resolvedIPAddress = resolvIP;
            }

            return isResolved;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            continua = false;
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
                MessageBox.Show("Operation canceled!");
                setStatus("Ready...");
            }
            else
                MessageBox.Show("Operation cannot be canceled!");
        }

        private void getBingResults(string query, int results, int skipResults)
        {
            // Create a Bing container.
            string rootUrl = "https://api.datamarket.azure.com/Bing/Search/";
            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUrl));
            // The market to use.
            string market = "en-us";

            // Configure bingContainer to use your credentials.
            bingContainer.Credentials = new NetworkCredential(BING_API_KEY_NAME, BING_API_KEY_VALUE);


            // Build the query, limiting to 10 results.
            var webQuery = bingContainer.Web(query, null, null, market, null, null, null, null);
            webQuery = webQuery.AddQueryOption("$top", results);
            webQuery = webQuery.AddQueryOption("$skip", skipResults);


            // Run the query and display the results.
            var webResults = webQuery.Execute();

            foreach (var result in webResults)
            {
                Application.DoEvents();
                Invoke(new Action(() => this.resultBox.AppendText(result.Url.ToString() + Environment.NewLine)));
            }
        }

        private void setStatus(string status)
        {
            Application.DoEvents();
            this.statusLabel.Text = status;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            getBingResults(keyword, remaining_results, skipResults);
            skipResults += 50;
            remaining_results = resultsNumber - skipResults;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (remaining_results >= 0)
            {
                if (bw.IsBusy != true)
                        bw.RunWorkerAsync();
            }
            else
            {
                setStatus("Job finished!");
                MessageBox.Show("Finish!");
                setStatus("Ready...");
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            this.resultsCountLabel.Text = "Lines: " + this.resultBox.Lines.Count().ToString();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            setStatus("Exporting list");
            string name = null;
            string host = null;

            if(hostIpRadioButton.Checked == true)
            {
                if (!String.IsNullOrEmpty(this.hostIpTextBox.Text))
                    name = this.hostIpTextBox.Text;
            }
            else if(this.sitenameRadioButton.Checked == true)
            {
                if (!String.IsNullOrEmpty(this.sitenameTextBox.Text))
                    name = this.sitenameTextBox.Text;
            }

            if (!String.IsNullOrEmpty(name) || !String.IsNullOrWhiteSpace(name))
            {
                host = name;
                name += "_websites_hosted-";
            }
            name += DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.ToString("HH-mm");

            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text Files|*.txt";
            saveFile1.FileName = name;

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                //this.richTextBox1.SaveFile(name, RichTextBoxStreamType.PlainText);
                System.IO.File.WriteAllText(saveFile1.FileName, "List of websites on server: " + host + Environment.NewLine + Environment.NewLine);
                System.IO.File.AppendAllLines(saveFile1.FileName, this.resultBox.Lines);

                MessageBox.Show("List sccessfully exported!", "Sucess!");
            }
            setStatus("Ready");
        }

        private void removeDuplicatesButton_Click(object sender, EventArgs e)
        {
            this.resultBox.Lines = this.resultBox.Lines.Distinct().ToArray();
        }

        private void keepDomainNamesOnlyButton_Click(object sender, EventArgs e)
        {
            List<string> sanitizedList = new List<string>();   
            foreach(string line in this.resultBox.Lines)
            {
                string relativeUrl = GetDomainPart(line);                
                sanitizedList.Add(relativeUrl);
            }

            this.resultBox.Lines = sanitizedList.ToArray();
        }

        string GetDomainPart(string url)
        {
            var doubleSlashesIndex = url.IndexOf("://");
            var start = doubleSlashesIndex != -1 ? doubleSlashesIndex + "://".Length : 0;
            var end = url.IndexOf("/", start);
            if (end == -1)
                end = url.Length;

            string trimmed = url.Substring(start, end - start);
            if (trimmed.StartsWith("www."))
                trimmed = trimmed.Substring("www.".Length);
            return trimmed;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.yougetsignal.com/tools/web-sites-on-web-server/");
        }
    
    }
}
