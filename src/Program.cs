// DESAFIO: Gerador de Relatórios Complexos
// PROBLEMA: Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML)
// com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros)
// O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios
using src.Builders;
using src.Directors;
using src.Entities;
using src.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatternChallenge
{

    // Contexto: Sistema de BI que gera relatórios customizados para diferentes departamentos
    // Cada relatório pode ter dezenas de configurações opcionais

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Relatórios ===");

            var director = new ReportDirector();

            var monthlySalesReportBuilder = new FluentReportBuilder();
            var monthlySalesReport = director.BuildMonthlySalesReport(monthlySalesReportBuilder);
            monthlySalesReport.Generate();

            var quarterlySalesReportBuilder = new FluentReportBuilder();
            var quarterlySalesReport = director.BuildQuarterlySalesReport(quarterlySalesReportBuilder);
            quarterlySalesReport.Generate();

            var annualSalesReportBuilder = new FluentReportBuilder();
            var annualSalesReport = director.BuildAnnualSalesReport(annualSalesReportBuilder);
            annualSalesReport.Generate();

        }
    }
}


