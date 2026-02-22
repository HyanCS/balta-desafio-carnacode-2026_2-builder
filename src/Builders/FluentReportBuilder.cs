using src.Entities;
using src.Interfaces;

namespace src.Builders
{
    public class FluentReportBuilder : IFluentReportBuilder
    {
        private readonly SalesReport _report = new();
        public FluentReportBuilder WithTitle(string title)
        {
            _report.Title = title;
            return this;
        }
        public FluentReportBuilder WithFormat(string format)
        {
            _report.Format = format;
            return this;
        }
        public FluentReportBuilder WithStartDate(DateTime startDate)
        {
            _report.StartDate = startDate;
            return this;
        }
        public FluentReportBuilder WithEndDate(DateTime endDate)
        {
            _report.EndDate = endDate;
            return this;
        }
        public FluentReportBuilder WithHeader()
        {
            _report.IncludeHeader = true;
            return this;
        }
        public FluentReportBuilder WithFooter()
        {
            _report.IncludeFooter = true;
            return this;
        }
        public FluentReportBuilder WithHeaderText(string headerText)
        {
            _report.HeaderText = headerText;
            return this;
        }
        public FluentReportBuilder WithFooterText(string footerText)
        {
            _report.FooterText = footerText;
            return this;
        }
        public FluentReportBuilder WithCharts()
        {
            _report.IncludeCharts = true;
            return this;
        }
        public FluentReportBuilder WithChartType(string chartType)
        {
            _report.ChartType = chartType;
            return this;
        }
        public FluentReportBuilder WithSummary()
        {
            _report.IncludeSummary = true;
            return this;
        }
        public FluentReportBuilder WithColumns(List<string> columns)
        {
            _report.Columns = columns;
            return this;
        }
        public FluentReportBuilder WithFilters(List<string> filters)
        {
            _report.Filters = filters;
            return this;
        }
        public FluentReportBuilder WithSortBy(string sortBy)
        {
            _report.SortBy = sortBy;
            return this;
        }
        public FluentReportBuilder WithGroupBy(string groupBy)
        {
            _report.GroupBy = groupBy;
            return this;
        }
        public FluentReportBuilder WithTotals()
        {
            _report.IncludeTotals = true;
            return this;
        }
        public FluentReportBuilder WithOrientation(string orientation)
        {
            _report.Orientation = orientation;
            return this;
        }
        public FluentReportBuilder WithPageSize(string pageSize)
        {
            _report.PageSize = pageSize;
            return this;
        }
        public FluentReportBuilder WithPageNumbers()
        {
            _report.IncludePageNumbers = true;
            return this;
        }
        public FluentReportBuilder WithCompanyLogo(string companyLogo)
        {
            _report.CompanyLogo = companyLogo;
            return this;
        }
        public FluentReportBuilder WithWaterMark(string waterMark)
        {
            _report.WaterMark = waterMark;
            return this;
        }
        public SalesReport Build()
        {
            Validate();
            return _report;
        }
        private void Validate()
        {
            var errors = new List<string>();

            if (_report.IncludeHeader && string.IsNullOrEmpty(_report.HeaderText))
                errors.Add("HeaderText is required when IncludeHeader is true");

            if (_report.IncludeFooter && string.IsNullOrEmpty(_report.FooterText))
                errors.Add("FooterText is required when IncludeFooter is true");

            if (_report.StartDate > _report.EndDate)
                errors.Add("StartDate must be before EndDate");

            if (_report.IncludeCharts && string.IsNullOrEmpty(_report.ChartType))
                errors.Add("ChartType is required when IncludeCharts is true");

            if (errors.Any())
            {
                Console.WriteLine("⚠️ Report configuration warnings:");
                foreach (var error in errors)
                    Console.WriteLine($"  - {error}");
            }
        }
    }
}