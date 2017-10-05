using Knn.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knn.Data
{
    public class Adult
    {
        public int Age { get; private set; }

        public Workclass Workclass { get; private set; }

        public int Fnlwgt { get; set; }

        public Education Education { get; set; }

        public int EducationNum { get; set; }

        public MartialStatus MartialStatus { get; set; }

        public Occupation Occupation { get; set; }

        public Relationship Relationship { get; set; }

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public int CapitalGain { get; set; }

        public int CapitalLoss { get; set; }

        public int HoursPerWeek { get; set; }

        public NativeCountry NativeCountry { get; set; }

        public Adult()
        {

        }

        public Adult(string text)
        {
            string[] textSplitted = text.Split(new string[] { ", " }, StringSplitOptions.None);

            Age = int.Parse(textSplitted[0]);
            Workclass = ParseEnum<Workclass>(textSplitted[1]);
            Fnlwgt = int.Parse(textSplitted[2]);
            Education = ParseEnum<Education>(textSplitted[3]);
            EducationNum = int.Parse(textSplitted[4]);
            MartialStatus = ParseEnum<MartialStatus>(textSplitted[5]);
            Occupation = ParseEnum<Occupation>(textSplitted[6]);
            Relationship = ParseEnum<Relationship>(textSplitted[7]);
            Race = ParseEnum<Race>(textSplitted[8]);
            Sex = ParseEnum<Sex>(textSplitted[9]);
            CapitalGain = int.Parse(textSplitted[10]);
            CapitalLoss = int.Parse(textSplitted[11]);
            HoursPerWeek = int.Parse(textSplitted[12]);
            NativeCountry = ParseEnum<NativeCountry>(textSplitted[13]);
        }


        static T ParseEnum<T>(string stringValue) 
        {
            var newValue = stringValue
                .Replace("-", "_")
                .Replace("(", "")
                .Replace(")", "")
                .Replace("&", "_");

            if (Char.IsDigit(newValue[0]))
                newValue = "_" + newValue;


            if (newValue == "?")
                newValue = "None";

            return (T)Enum.Parse(typeof(T), newValue, true);
        }

    }
}
