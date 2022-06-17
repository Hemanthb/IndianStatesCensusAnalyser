using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using MissingFieldException = CsvHelper.MissingFieldException;

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
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
                return 0;
                
            }
            catch (MissingFieldException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_DELIMITER, "Invalid Delimiter");
            }
            catch (HeaderValidationException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_HEADER, "Invalid Headers");
            }
        }

        public int AnalyseStateCodes(string file)
        {
            //List<StateCodes> stateCode = new List<StateCodes>();
            int csvRowCount;
            using (var reader = new StreamReader(file))
                        using (var csvReader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                        {
                            var list = csvReader.GetRecords<StateCodes>().ToList();
                            csvRowCount = list.Count;
                            Console.WriteLine("RowCount is -" + csvRowCount);

                        }
                        return csvRowCount;
                   
        }
    }
}
