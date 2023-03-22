using System.Net;
using NBitcoin;
using QBitNinja;
using QBitNinja.Client;

namespace NbitcoinWallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var privatekey = new Key();
            var btcprivatekey = privatekey.GetWif(Network.Main).ToString();
            lblPrivateKey.Text = btcprivatekey;

            // generate a public key from our private key
            var btcpublickey = privatekey.PubKey.ToString();

            // generate btc address from our public key
            var btcaddress1 = privatekey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lblPrivateKeyAddress.Text = btcaddress1.ToString();

            decimal balance1 = CheckBalance(btcaddress1.ToString());
            lblbalance1.Text = balance1.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPrivateKey_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateSeed_Click(object sender, EventArgs e)
        {
            var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
            lblMnemonic.Text = mnemo.ToString();

            var hdroot = mnemo.DeriveExtKey();
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0/0'"));
            var address = pkey.PrivateKey.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lblAddressMnemonic.Text = address.ToString();

            decimal balance2 = CheckBalance(address.ToString());
            lblbalance2.Text = balance2.ToString();
        }

        /*public decimal CheckBalance(string address)
        {
            QBitNinjaClient client = new QBitNinjaClient(Network.Main);
            var balancemode1 = client.GetBalance(address, false).Result;
            decimal addressbalance = 0;
            if (balancemode1.Operations.Count == 0)
            {
                addressbalance = 0;
            }
            else
            {
                var unspentcoins = new List<Coin>();
                foreach (var operation in balancemode1.Operations)
                {
                    unspentcoins.AddRange(collection: operation.ReceivedCoins.Select(Coin => Coin as Coin));
                    addressbalance = unspentcoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                }
            }
            return addressbalance;
        }*/

        public decimal CheckBalance(string address)
        {
            try
            {
                QBitNinjaClient client = new QBitNinjaClient(Network.Main);
                var btcAddress = BitcoinAddress.Create(address, Network.Main);
                var balancemode1 = client.GetBalance(btcAddress, false).Result;
                decimal addressBalance = 0;
                if (balancemode1.Operations.Count > 0)
                {
                    var unspentCoins = new List<Coin>();
                    foreach (var operation in balancemode1.Operations)
                    {
                        unspentCoins.AddRange(operation.ReceivedCoins.Select(coin => coin as Coin));
                        addressBalance = unspentCoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                    }
                }
                return addressBalance;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while checking the balance of address {address}: {ex.Message}");
                return 0;
            }
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}