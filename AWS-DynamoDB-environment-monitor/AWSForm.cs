using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AWS_DynamoDB___Monitoraggio_ambientale
{
    public partial class AWSForm : System.Windows.Forms.Form
    {
        public AWSForm()
        {
            InitializeComponent();
            AWSDatas.Start(comboTableNames, comboBoxSensore); //Inizializzazione
            AWSDatas.SensorsName(comboSensoreScelto);
            AWSDatas.SensorsName(comboSensoreDelete);
            //AWSDatas.LocationsName(comboLuogoDelete);
        }

        // Gestione dell'evento "Crea tabella" del form di inserimento dei dati.
        private void buttonInsertTable_Click(object sender, EventArgs e)
        {
            // Specifica il nome della tabella.
            string tableName = txtNomeTabella.Text;

            // Specifica le colonne e le chiavi di partizione e di clustering della tabella.
            List<KeySchemaElement> keySchema = new List<KeySchemaElement>
            {
                new KeySchemaElement
                {
                    AttributeName = txtPartitionKey.Text,
                    KeyType = "HASH" // Partition key
                },
                new KeySchemaElement
                {
                    AttributeName = txtSortKey.Text,
                    KeyType = "RANGE" // Sort key
                }
            };

            List<AttributeDefinition> attributeDefinitions = new List<AttributeDefinition>
            {
                new AttributeDefinition
                {
                    AttributeName = txtPartitionKey.Text,
                    AttributeType = AWSDatas.TranslateType(comboPartitionType)
                },
                new AttributeDefinition
                {
                    AttributeName = txtSortKey.Text,
                    AttributeType = AWSDatas.TranslateType(comboSortType)
                }
            };

            // Crea la tabella.
            CreateTableRequest request = new CreateTableRequest
            {
                TableName = tableName,
                KeySchema = keySchema,
                AttributeDefinitions = attributeDefinitions,
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5
                }
            };

            try
            {
                CreateTableResponse response = AWSDatas.client.CreateTableAsync(request).Result;
                MessageBox.Show("Tabella creata con successo");
                AWSDatas.TablesName(comboTableNames);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella creazione della tabella: " + ex.Message);
            }
        }

        // Gestisci l'evento "Inserisci dato" del form di inserimento dei dati
        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            if (comboTableNames.Text == "")
            {
                MessageBox.Show("Seleziona una tabella");
                return;
            }
            string tableName = comboTableNames.Text;
            string sensorId = comboBoxSensore.Text;
            string location = textBoxLuogo.Text;
            

            if (sensorId.Equals("") || location.Equals("") || textBoxTemperature.Text.Equals("")
                || textBoxHumidity.Text.Equals(""))
            {
                MessageBox.Show("Errore: sono presenti campi vuoti");
                return;
            }
            double temperature = Convert.ToDouble(textBoxTemperature.Text);
            double humidity = Convert.ToDouble(textBoxHumidity.Text);
            string data = dateTimePicker.Text;

            //Creazione un nuovo elemento con i valori specificati
            Dictionary<string, AttributeValue> item = new Dictionary<string, AttributeValue>
            {
                { "sensoreId", new AttributeValue { S = sensorId } },
                { "location", new AttributeValue { S = location.ToString() } },
                { "temperatura", new AttributeValue { N = temperature.ToString() } },
                { "umidita", new AttributeValue { N = humidity.ToString() } },
                { "data", new AttributeValue { S = data.ToString() } }
            };
            
            //Inserimento l'elemento nella tabella.
            PutItemRequest request = new PutItemRequest
            {
                TableName = tableName,
                Item = item
            };

            try
            {
                PutItemResponse response = AWSDatas.client.PutItemAsync(request).Result;
                MessageBox.Show("Dato aggiunto correttamente");
                AWSDatas.SensorsName(comboBoxSensore);
                textBoxLuogo.Text = "";
                comboBoxSensore.Text = "";
                textBoxTemperature.Text = "";
                textBoxHumidity.Text = "";
                dateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'aggiunta del dato: " + ex.Message);
            }
        }

        //Funzione collegata alla X per uscire dall'applicazione
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funzione del bottone per eseguire una query
        //che restituisce tutti i dati di un sensore specifico in un determinato intervallo di tempo
        private void btnIntervalloSensore_Click(object sender, EventArgs e)
        {
            try
            {
                string sensorId = comboSensoreScelto.Text;
                DateTime startTime = datePickerInizio.Value;
                DateTime endTime = datePickerFine.Value;
                MessageBox.Show("Il bottone è collegato alla funzione GetSensorData ma c'è un errore " +
                    "che blocca tutto. Guardare la funzione GetSensorData()");
                List<MonitoraggioAmbientale> data = AWSDatas.GetSensorData(sensorId, startTime, endTime).Result;
                dataGridInfo.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il recupero dei dati: " + ex.Message);
            }
        }

        //Funzione collegata al bottone per stampare a video tutti i dati presenti nel DB
        private void btnStampaTutto_Click(object sender, EventArgs e)
        {
            // Crea una richiesta di scan per recuperare tutti gli elementi nella tabella "MonitoraggioAmbientale"
            ScanRequest request = new ScanRequest
            {
                TableName = "MonitoraggioAmbientale"
            };

            // Esegue la scan per recuperare tutti gli elementi nella tabella
            ScanResponse response = AWSDatas.client.ScanAsync(request).Result;

            // Crea una lista di oggetti "MonitoraggioAmbientale"
            List<MonitoraggioAmbientale> data = new List<MonitoraggioAmbientale>();
            foreach (Dictionary<string, AttributeValue> item in response.Items)
            {
                MonitoraggioAmbientale ambientale = new MonitoraggioAmbientale();
                ambientale.sensoreId = item["sensoreId"].S;
                ambientale.data = item["data"].S;
                ambientale.luogo = item["location"].S;
                ambientale.temperatura = double.Parse(item["temperatura"].N);
                ambientale.umidita = double.Parse(item["umidita"].N);
                data.Add(ambientale);
            }
            dataGridInfo.DataSource = data;
        }

        //Funzione del bottone che elimina il dato dal DB fornendo il sensore e la data in cui
        //è stata fatta la misurazione
        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string sensorId = comboSensoreDelete.Text;
            DateTime date = datePickerDelete.Value;
            //string location = comboLuogoDelete.Text;

            // Eliminazione dati
            var request = new DeleteItemRequest
            {
                TableName = "MonitoraggioAmbientale",
                Key = new Dictionary<string, AttributeValue>
                {
                    { "sensoreId", new AttributeValue { S = sensorId } },
                    { "data", new AttributeValue { S = date.ToString("dddd dd MMMM yyyy") } },
                    //{ "location", new AttributeValue { S = location} }
                }
            };
            //Esegue l'operazione di eliminazione
            var response = AWSDatas.client.DeleteItemAsync(request);
            if (response.IsCompletedSuccessfully)
            {
                MessageBox.Show("Dato eliminato correttamente");
            }
            else
            {
                MessageBox.Show("Errore eliminazione: " + response);
            }
            if (response.Result.HttpStatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show("Non è stato trovato il dato");
            }
        }
    }
}