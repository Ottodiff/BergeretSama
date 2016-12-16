using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SADOWSKI_MCDs
{
    public class Question
    {
        private string _q1;
        private string _r1;
        private string _r2;
        private string _r3;
        private string _r4;
        private List<string> _rep;

        public List<string> Rep
        {
            get { return _rep; }
            set { _rep = value; }
        }

        public string Q1
        {
            get { return _q1; }
            set { _q1 = value; }
        }

        public string R1
        {
            get { return _r1; }
            set { _r1 = value; }
        }

        public string R2
        {
            get { return _r2; }
            set { _r2 = value; }
        }

        public string R3
        {
            get { return _r3; }
            set { _r3 = value; }
        }

        public string R4
        {
            get { return _r4; }
            set { _r4 = value; }
        }

        public Question()
        {

        }

        public Question(string q1, string r1, string r2, string r3, string r4)
        {
            this.Q1 = q1;
            this.R1 = r1;
            this.R2 = r2;
            this.R3 = r3;
            this.R4 = r4;
        }

        public void recupererQuestion()
        {
            int nb = 0;

            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= MCDs.db");
            sqlconnection.Open();

            string CommandText = "SELECT listQuestion FROM questions WHERE idQuestion = '" + Q1.ToString() + "'";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
               // this.Rep.Add();
                nb++;
            }
            nb = 0;
            
            this.R1 = this.Rep[0];
            this.R2 = this.Rep[1];
            this.R3 = this.Rep[2];
            this.R4 = this.Rep[3];
        }
    }
}
