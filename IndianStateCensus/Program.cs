using IndianCensusAnalyzerPrgm.DTO;
using IndianCensusAnalyzerPrgm.UsingCode;
using System;

namespace IndianCensusAnalyzerPrgm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IndianStatesCensusAnalyser ");
            string filePathStateCensus = @"C:\Users\RJ EMPIRE\Desktop\New folder\IndianCensusAnalyser\IndianStateCensus\IndianStateCensus\DTO\StateCensus.csv";
            string filePath = @"C:\Users\RJ EMPIRE\Desktop\New folder\IndianCensusAnalyser\IndianStateCensus\IndianStateCensus\UsingCode\StateCode.csv";

            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusRecords == censusRecords)
                Console.WriteLine("Number of records match");

            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filePath);
            CSVStateCensus stateCode = new CSVStateCensus();
            int codeRecords = stateCode.ReadStateCodeData(filePath);
            if (StateCodeRecords == codeRecords)
                Console.WriteLine("Number of records match");
        }
    }
}