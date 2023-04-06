using IUP_BMI_Calculator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQLite.SQLite3;
using System.Xml.Linq;

namespace IUP_BMI_Calculator.Repository
{
    public class BMIResultRepository
    {
        string _dbPath;

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BMIResult>();
        }

        public BMIResultRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewBMIResult(string name, double height, double weight, double BMIScore, string BMIResult)
        {
            /*BMIResult bmiResult = new BMIResult
            {
                Name = name,
                Weight = weight,
                Height = height,
                BmiScore = BMIScore,
                //BmiResult = BMIResult
            };

            // Use the BMIResultRepository to add the new BMIResult to the database */
            string connectionString = "your_connection_string_here";
            BMIResultRepository repository = new BMIResultRepository(connectionString);
            //repository.Add(bmiResult);
        }
    }
}
