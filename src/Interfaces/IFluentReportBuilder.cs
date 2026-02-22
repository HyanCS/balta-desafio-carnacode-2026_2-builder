using src.Builders;
using src.Entities;

namespace src.Interfaces
{
    public interface IFluentReportBuilder
    {
        FluentReportBuilder WithTitle(string title);
        FluentReportBuilder WithFormat(string format);
        FluentReportBuilder WithStartDate(DateTime startDate);
        FluentReportBuilder WithEndDate(DateTime endDate);
        FluentReportBuilder WithHeader();
        FluentReportBuilder WithFooter();
        FluentReportBuilder WithHeaderText(string headerText);
        FluentReportBuilder WithFooterText(string footerText);
        FluentReportBuilder WithCharts();
        FluentReportBuilder WithChartType(string chartType);
        FluentReportBuilder WithSummary();
        FluentReportBuilder WithColumns(List<string> columns);
        FluentReportBuilder WithFilters(List<string> filters);
        FluentReportBuilder WithSortBy(string sortBy);
        FluentReportBuilder WithGroupBy(string groupBy);
        FluentReportBuilder WithTotals();
        FluentReportBuilder WithOrientation(string orientation);
        FluentReportBuilder WithPageSize(string pageSize);
        FluentReportBuilder WithPageNumbers();
        FluentReportBuilder WithCompanyLogo(string companyLogo);
        FluentReportBuilder WithWaterMark(string waterMark);
        SalesReport Build();
    }
}