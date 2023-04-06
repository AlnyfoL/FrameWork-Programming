using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BmiScore { get; set; }
        public string Result { get; set; }

        public BMIResult(int id, string name, double height, double weight, double bmiScore, string result)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Height = height;
            BmiScore = bmiScore;
            Result = result;
        }
    }
}
