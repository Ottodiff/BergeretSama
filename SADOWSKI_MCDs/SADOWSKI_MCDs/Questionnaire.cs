using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SADOWSKI_MCDs
{
    public class Questionnaire
    {
        Form1 frm;



        private List<Question> _listQuestion;

        public List<Question> ListQuestion
        {
            get { return _listQuestion; }
            set { _listQuestion = value; }
        }

        public Questionnaire(Form1 tfrm)
        {
            frm = tfrm;
        }

        public void recupererQuestionnaire()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= MCDs.db");
            sqlconnection.Open();

            string CommandText = "SELECT idQuestion  FROM composer WHERE idQuestionnaire = '" + frm.IdQuestionnaire + "'";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                Question tempQuestion = new Question();
                tempQuestion.Q1 = sqldr["idQuestion"].ToString();

                tempQuestion.recupererQuestion();

                this.ListQuestion.Add(tempQuestion);
            }
        }
    }
}
