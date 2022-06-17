namespace ReadStateCensusCSVTest
{
    public class Tests
    {

        [Test]
        public void GivenCsvReport_FetchAllData_ReturnRowCount()
        {
            string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\StateCensusData.csv";
            Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
            int actualCount = stateCensus.AnalyseStateCensus(file);
            Assert.AreEqual(29, actualCount);

        }
        [Test]
        public void GivenWrongCsvReport_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\StateCensusData.csv";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch(Exception e)
            {
                Assert.AreEqual("Invalid File", e.Message);
            }

        }
        [Test]
        public void GivenWrongFileExtn_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\StateCensusData.cs";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid File Extension", e.Message);
            }

        }
        [Test]
        public void GivenWrongDelimiter_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\semicolonDelimiterData.csv";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid Delimiter", e.Message);
            }

        }
        [Test]
        public void GivenWrongHeaders_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\InvalidHeadersReport.csv";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid Headers", e.Message);
            }

        }
        [Test]
        public void GivenStateCodeCsvReport_FetchAllData_ReturnRowCount()
        {
            string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\Reports\StateCode.csv";
            Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
            int actualCount = stateCensus.AnalyseStateCodes(file);
            Assert.AreEqual(37, actualCount);

        }
        [Test]
        public void GivenWrongStateCsvReport_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\Report\StateCensusData.csv";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid File", e.Message);
            }
        }
        [Test]
        public void GivenWrongStateCodeFileExtn_HandleException_ThrowsException()
        {
            try
            {
                string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\Report\StateCode.cs";
                Indian_States_CensusAnalyser.StateCensusAnalyser stateCensus = new Indian_States_CensusAnalyser.StateCensusAnalyser();
                int actualCount = stateCensus.AnalyseStateCensus(file);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid File Extension", e.Message);
            }

        }

    }
    }