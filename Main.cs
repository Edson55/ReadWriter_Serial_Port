using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ReadWriter_Serial_Port
{
    public partial class Main : Form
    {
       
        SerialPorts SerialPorts = new SerialPorts();
        SerialPort CodeReader;
        public static SerialDataReceivedEventHandler CodeReaderHandler;
        public static string ReadedConcat;
        public Main()
        {
            InitializeComponent();
        
        }

        private void Main_Load(object sender, EventArgs e)
        {
            openConection();
            loadCOMs();
            string[] Portas = SerialPort.GetPortNames();
            cbx_Ports.Sorted = true;
            foreach (var prts in Portas)
            {
                cbx_Ports.Items.Add(prts);
            }

        }

        private void loadCOMs()
        {
            txbUrl.Text= Properties.Settings.Default.url ;
            cbxBaudRate.Text= Properties.Settings.Default.baudRate.ToString();
            txtCOM.Text = Properties.Settings.Default.nameCOM;
            CbxParity.DataSource= Enum.GetValues(typeof(System.IO.Ports.Parity));
            CbxParity.Text= Properties.Settings.Default.parity.ToString();
            cbxDataBit.Text = Properties.Settings.Default.dataBit.ToString();
            cbxStation.SelectedIndex = Properties.Settings.Default.idStation;



        }
        private void openConection()
        {
            try
            {

            if(Properties.Settings.Default.nameCOM !="")
            {
            SerialPorts.OpenConection(ref CodeReader, Properties.Settings.Default.nameCOM, Properties.Settings.Default.baudRate, Properties.Settings.Default.parity, Properties.Settings.Default.dataBit);
            CodeReader.DataReceived += new SerialDataReceivedEventHandler(ReaderCOde_Event);
             }
            else
            {
                MessageBox.Show("Selecione uma Porta COM" ,"Porta Serial");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReaderCOde_Event(object sender, EventArgs e)
        {
           
            BeginInvoke((MethodInvoker)(() => txtRead.Clear()));
           string GetReader = SerialPorts.ReadSerialPort(ref CodeReader);
           
           
          
            if (!GetReader.Contains("\r"))
            {
                ReadedConcat = ReadedConcat + GetReader;
            }
            else
            {
              BeginInvoke((MethodInvoker)(() => txtRead.Text += ReadedConcat + GetReader));
            PostScan(ReadedConcat+ GetReader);
              ReadedConcat = string.Empty;
            }
        }

        private void btnSelCOM_Click(object sender, EventArgs e)
        {
            Parity parity = new Parity();
          
            try
            {

            Properties.Settings.Default.url = txbUrl.Text;
            Properties.Settings.Default.baudRate = Convert.ToInt32(cbxBaudRate.SelectedItem);
            Properties.Settings.Default.nameCOM = cbx_Ports.SelectedItem.ToString();
            Properties.Settings.Default.parity =(Parity)CbxParity.SelectedItem;
            Properties.Settings.Default.dataBit = Convert.ToInt32( cbxDataBit.SelectedItem);
            Properties.Settings.Default.idStation = cbxStation.SelectedIndex;
            Properties.Settings.Default.Save();
                if (CodeReader.IsOpen)
                {
                    CodeReader.Close();
                    loadCOMs();
                    openConection();
                }
                else
                {
                    loadCOMs();
                    openConection();
                }
       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao Salvar Configuração" + ex.Message, "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async void PostScan(string readed)
        {
            try
            {

            string send = readed.Replace("\r", "").Replace("\n", "");
            string URI = Properties.Settings.Default.url + "/ScannerSend";
            SerialProperts serial = new SerialProperts() { id = 0, scannerInput = send };
             
                using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(serial);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao enviar dados do Scanner para o servidor:\n" + ex.Message, "Falha Scaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
