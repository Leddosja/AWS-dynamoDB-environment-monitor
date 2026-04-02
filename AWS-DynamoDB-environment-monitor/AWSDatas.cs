using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWS_DynamoDB___Monitoraggio_ambientale
{
    public static class AWSDatas
    {
        //public static string awsAccessKeyId { get { return "YOUR_ACCESS_KEY"; } set { awsAccessKeyId = value; } }
        //public static string awsSecretAccessKey { get { return "YOUR_SECRET_KEY"; } set { awsSecretAccessKey = value; } }

        public static AmazonDynamoDBClient client { get; set; }

        //Inizializzazione della connessione
        public static void Start(ComboBox comboBoxTables, ComboBox comboBoxSensors)
        {
            try
            {
                client = new AmazonDynamoDBClient(AWSDatas.awsAccessKeyId,
                AWSDatas.awsSecretAccessKey, Amazon.RegionEndpoint.EUWest3);
                MessageBox.Show("Connessione avviata");
                TablesName(comboBoxTables);
                SensorsName(comboBoxSensors);
            }
            catch (Exception)
            {
                MessageBox.Show("Connessione fallita");
            }
        }

        //Funzione che ritorna le tabelle create presenti nel DB
        public static void TablesName(ComboBox comboBox)
        {
            ListTablesResponse response = client.ListTablesAsync().Result;
            foreach (string tableName in response.TableNames)
            {
                comboBox.Items.Add(tableName);
            }
        }

        //Funzione che ritorna tutti i sensori presenti nella table
        public static void SensorsName(ComboBox comboBox)
        {
            ScanRequest request = new ScanRequest
            {
                TableName = "MonitoraggioAmbientale",
                ProjectionExpression = "sensoreId"
            };
            ScanResponse response = client.ScanAsync(request).Result;
            List<Dictionary<string, AttributeValue>> items = response.Items;
            foreach (Dictionary<string, AttributeValue> item in items)
            {
                string value = item["sensoreId"].S;
                if (!comboBox.Items.Contains(value))
                {
                    comboBox.Items.Add(value);
                }
            }
        }

        //Funzione che ritorna tutte le location presenti nella table
        public static void LocationsName(ComboBox comboBox)
        {
            // Creazione di un oggetto tipo ScanRequest per specificare i parametri della scansione
            var request = new ScanRequest
            {
                TableName = "MonitoraggioAmbientale",
                ProjectionExpression = "location"
            };
            var response = client.ScanAsync(request).Result;
            var locations = new List<string>();
            foreach (var item in response.Items)
            {
                string location = item["location"].S;
                if (!locations.Contains(location))
                {
                    locations.Add(location);
                }
            }
            comboBox.DataSource = locations;
        }

        //Funzione che traduce il tipo della Partition Key e della Sort Key
        public static string TranslateType(ComboBox comboBox)
        {
            string output = "";
            switch (comboBox.Text)
            {
                case "String":
                    output = "S";
                    break;
                case "Number":
                    output = "N";
                    break;
                case "Binary":
                    output = "B";
                    break;
                default:
                    break;
            }
            return output;
        }

        public static async Task<List<MonitoraggioAmbientale>> GetSensorData(string sensorId, DateTime startTime, DateTime endTime)
        {
            // Query per recuperare i dati del sensore specificato
            QueryRequest request = new QueryRequest
            {
                TableName = "MonitoraggioAmbientale",
                KeyConditionExpression = "sensoreId = :v_sensorId and data between :v_startTime and :v_endTime",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":v_sensorId", new AttributeValue { S = sensorId } },
                    { ":v_startTime", new AttributeValue { S = startTime.ToString("dddd dd MMMM yyyy") } },
                    { ":v_endTime", new AttributeValue { S = endTime.ToString("dddd dd MMMM yyyy") } }
                }
            };

            // Esegue la query
            QueryResponse response = client.QueryAsync(request).Result;

            // Crea una lista di oggetti MonitoraggioAmbientale per contenere i risultati della query
            List<MonitoraggioAmbientale> results = new List<MonitoraggioAmbientale>();

            foreach (Dictionary<string, AttributeValue> item in response.Items)
            {
                MonitoraggioAmbientale misure = new MonitoraggioAmbientale
                {
                    sensoreId = item["sensoreId"].S,
                    data = item["data"].S,
                    luogo = item["location"].S,
                    temperatura = double.Parse(item["temperatura"].N),
                    umidita = double.Parse(item["umidita"].N)
                };
                results.Add(misure);
            }
            return results;
        }
    }
}
