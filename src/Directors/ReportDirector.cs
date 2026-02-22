using src.Builders;
using src.Entities;
using src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Directors
{
    public class ReportDirector
    {
        public SalesReport BuildMonthlySalesReport(IFluentReportBuilder builder)
        {
            return builder
                .WithTitle("Vendas Mensais")
                .WithFormat("PDF")
                .WithStartDate(new DateTime(2024, 1, 1))
                .WithEndDate(new DateTime(2024, 1, 31))
                .WithHeader()
                .WithHeaderText("Relatório de Vendas")
                .WithFooter()
                .WithFooterText("Confidencial")
                .WithCharts()
                .WithChartType("Bar")
                .WithSummary()
                .WithColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                .WithFilters(new List<string> { "Status=Ativo" })
                .WithSortBy("Valor")
                .WithGroupBy("Categoria")
                .WithTotals()
                .WithOrientation("Portrait")
                .WithPageSize("A4")
                .WithPageNumbers()
                .WithCompanyLogo("logo.png")
                .WithWaterMark("Confidencial")
                .Build();
        }

        public SalesReport BuildQuarterlySalesReport(IFluentReportBuilder builder)
        {
            return builder
                              .WithTitle("Relatório Trimestral")
                              .WithFormat("Excel")
                              .WithStartDate(new DateTime(2024, 1, 1))
                              .WithEndDate(new DateTime(2024, 3, 31))
                              .WithColumns(new List<string> { "Vendedor", "Região", "Total" })
                              .WithCharts()
                              .WithChartType("Line")
                              .WithHeader()
                              .WithHeaderText("Relatório Trimestral")
                              .WithGroupBy("Região")
                              .WithTotals()
                              .Build();
        }

        public SalesReport BuildAnnualSalesReport(IFluentReportBuilder builder)
        {
            return builder
                .WithTitle("Vendas Anuais")
                .WithFormat("PDF")
                .WithStartDate(new DateTime(2024, 1, 1))
                .WithEndDate(new DateTime(2024, 12, 31))
                .WithHeader()
                .WithHeaderText("Relatório de Vendas")
                .WithFooter()
                .WithFooterText("Confidencial")
                .WithCharts()
                .WithChartType("Pie")
                .WithColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                .WithTotals()
                .WithOrientation("Landscape")
                .WithPageSize("A4")
                .Build();
        }
    }
}