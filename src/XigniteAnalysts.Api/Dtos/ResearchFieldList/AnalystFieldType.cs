namespace XigniteAnalysts.Api.Dtos.ResearchFieldList
{
	public enum AnalystFieldTypes
	{

		/// <remarks/>
		Security_Ticker,

		/// <remarks/>
		Security_CIK,

		/// <remarks/>
		Security_Cusip,

		/// <remarks/>
		Security_ISIN,

		/// <remarks/>
		Security_CompanyName,

		/// <remarks/>
		Security_Market,

		/// <remarks/>
		Security_CategoryOrIndustry,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongBuysCurrent,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongBuys1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongBuys2MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongBuys3MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateBuysCurrent,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateBuys1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateBuys2MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateBuys3MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfHoldsCurrent,

		/// <remarks/>
		AnalystRecommendations_NumberOfHolds1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfHolds2MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfHolds3MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateSellsCurrent,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateSells1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateSells2MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfModerateSells3MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongSellsCurrent,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongSells1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongSells2MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_NumberOfStrongSells3MonthsAgo,

		/// <remarks/>
		AnalystRecommendations_MeanRecommendationCurrent,

		/// <remarks/>
		AnalystRecommendations_MeanRecommendation1MonthAgo,

		/// <remarks/>
		AnalystRecommendations_MeanRecommendation2MonthAgo,

		/// <remarks/>
		AnalystRecommendations_MeanRecommendation3MonthAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_FileProductionDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_MostRecentFiscalYearEnd,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_MostRecentFiscalQuarterEnd,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterStandardDeviation,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterStandardDeviation,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearStandardDeviation,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearStandardDeviation,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthStandardDeviation,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterMedian,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterMedian,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearMedian,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearMedian,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthMedian,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterNumberRevisionsUpLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterNumberRevisionsDownLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterNumberRevisionsUpLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterNumberRevisionsDownLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearNumberRevisionsUpLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearNumberRevisionsDownLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearNumberRevisionsUpLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearNumberRevisionsDownLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterNumberRevisionsUpLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentQuarterNumberRevisionsDownLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterNumberRevisionsUpLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextQuarterNumberRevisionsDownLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearNumberRevisionsUpLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_CurrentFiscalYearNumberRevisionsDownLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearNumberRevisionsUpLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NextFiscalYearNumberRevisionsDownLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendationCurrent,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendation7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendation14DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendation21DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendation28DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ConsensusRecommendation35DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_ExchangeCode,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthNumberRevisionsUpLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthNumberRevisionsDownLast7Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthNumberRevisionsUpLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_LongTermGrowthNumberRevisionsDownLast30Days,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NumberOfStrongBuyRecommendations7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NumberOfModerateBuyRecommendations7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NumberOfHoldRecommendations7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NumberOfModerateSellRecommendations7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_NumberOfStrongSellRecommendations7DaysAgo,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_SourceCodeForCurrentQuarterExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_SourceCodeForNextQuarterExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_SourceCodeForCurrentFiscalYearExpectedReportDate,

		/// <remarks/>
		AnalystRecommendationsAndHistogram_SourceCodeForNextFiscalYearExpectedReportDate,

		/// <remarks/>
		CurrentSalesConsensus_DataIdentificationCode,

		/// <remarks/>
		CurrentSalesConsensus_ZacksMasterCode,

		/// <remarks/>
		CurrentSalesConsensus_ZacksExpandedIndustryCode,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_CurrentFiscalYearDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_NextFiscalYearDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_CurrentQuarterDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_TwoQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_ThreeQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_FourQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_FiveQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_SixQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_SevenQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutHighSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutLowSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutMeanSalesEstimate,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutStandardDeviation,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutNumberOfEstimatesInConsensus,

		/// <remarks/>
		CurrentSalesConsensus_EightQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_DataIdentificationCode,

		/// <remarks/>
		CurrentSalesConsensusChange_ZacksMasterCode,

		/// <remarks/>
		CurrentSalesConsensusChange_ZacksExpandedIndustryCode,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYear1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYear1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYear3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentFiscalYearDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYear1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYear1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYear3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_NextFiscalYearDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarter1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarter1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarter3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_CurrentQuarterDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_TwoQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_ThreeQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FourQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_FiveQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SixQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_SevenQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutPeriodDate,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutMeanEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOut1WeekPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesIncreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesDecreased1WeekToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOut1MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesIncreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesDecreased1MonthToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOut3MonthPercentageChangeInConsensusMean,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesIncreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutNumberAnalystsEstimatesDecreased3MonthsToCurrent,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutMedianEstimate,

		/// <remarks/>
		CurrentSalesConsensusChange_EightQuartersOutDateOfLatestEstimate,

		/// <remarks/>
		SummaryCurrentStatistics_CurrencyIdentificationCode,

		/// <remarks/>
		SummaryCurrentStatistics_DateOfEstimateData,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentFiscalYearStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentFiscalYearNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentFiscalYearStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentFiscalYearNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_NextFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatistics_NextFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_NextFiscalYearStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_NextFiscalYearNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentQuarterDateOfQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentQuarterMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentQuarterStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentQuarterNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentQuarterDateOfQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentQuarterMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentQuarterStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_CurrentQuarterNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_TwoQuartersOutDateOfQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatistics_TwoQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_TwoQuartersOutStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_TwoQuartersOutNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_ThreeQuartersOutDateOfQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatistics_ThreeQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_ThreeQuartersOutStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_ThreeQuartersOutNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_FourQuartersOutDateOfQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatistics_FourQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_FourQuartersOutStandardDeviation,

		/// <remarks/>
		SummaryCurrentStatistics_FourQuartersOutNumberOfEstimates,

		/// <remarks/>
		SummaryCurrentStatistics_DateOfMostRecentChange,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentQuarterReportFlag,

		/// <remarks/>
		SummaryCurrentStatistics_MostRecentFiscalYearReportFlag,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrencyIdentificationCode,

		/// <remarks/>
		SummaryCurrentStatisticsChange_DateOfEstimateData,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYear1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYear1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYear3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYear1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYear1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYear3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearDateOfFiscalYearEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYear1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYear1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYear3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterDateOfFiscalQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarter1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarter1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarter3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterDateOfFiscalQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarter1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarter1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarter3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutDateOfFiscalQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOut1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOut1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOut3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutDateOfFiscalQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOut1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOut1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOut3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutDateOfFiscalQuarterEnd,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutMeanOfEstimates,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOut1WeekPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesIncreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesDecreased1WeekCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOut1MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesIncreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesDecreased1MonthCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOut3MonthPercentageChangeInMean,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesIncreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutNumberAnalystsEstimatesDecreased3MonthsCurrent,

		/// <remarks/>
		SummaryCurrentStatisticsChange_DateOfMostRecentChange,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterReportFlag,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearReportFlag,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentFiscalYearMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentFiscalYearMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_NextFiscalYearMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_MostRecentQuarterMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_CurrentQuarterMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_TwoQuartersOutMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_ThreeQuartersOutMedianEstimate,

		/// <remarks/>
		SummaryCurrentStatisticsChange_FourQuartersOutMedianEstimate,
	}
}
