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

    }
}