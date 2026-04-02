using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DynamoDB___Monitoraggio_ambientale
{
    //Oggetto utilizzato come variabile di appoggio per i dati reperiti dal DB
    public class MonitoraggioAmbientale
    {
        public string sensoreId { get; set; }
        public string data { get; set; }
        public string luogo { get; set; }
        public double temperatura { get; set; }
        public double umidita { get; set; }
    }
}
