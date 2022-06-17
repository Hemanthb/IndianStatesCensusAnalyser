using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Indian_States_CensusAnalyser
{
    public class StateCensusAnalyser
    {

        public int AnalyseStateCensus(string file)
        {
            List<CSVStateCensus> stateCensus = new List<CSVStateCensus>();
            int csvRowCount;
            try {
                if (Path.GetExtension(file) == ".csv")
                {
                    if (File.Exists(file))
                    {
                        using (var reader = new StreamReader(file))
                        using (var csvReader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                        {
                            var list = csvReader.GetRecords<CSVStateCensus>().ToList();
                            csvRowCount = list.Count;
                            Console.WriteLine("RowCount is -" + csvRowCount);

                        }
                        return csvRowCount;
                    }
                    throw new CustomException(CustomException.ExceptionType.INVALID_FILE, "Invalid File");
                }
                throw new CustomException(CustomException.ExceptionType.INVALID_EXTENSION, "Invalid File Extension");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
                
            }
    }
    }
}
