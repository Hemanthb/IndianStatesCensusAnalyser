﻿Indian_States_CensusAnalyser.StateCensusAnalyser censusAnalyser = new Indian_States_CensusAnalyser.StateCensusAnalyser();
string file = @"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\StateCensusData.csv";
censusAnalyser.AnalyseStateCensus(file);
censusAnalyser.AnalyseStateCodes(@"D:\blabz_fellowship\IndianStatesCensusAnalyser\Indian_States_CensusAnalyser\Indian_States_CensusAnalyser\Reports\StateCode.csv");