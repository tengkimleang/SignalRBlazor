using Microsoft.Reporting.NETCore;
using Newtonsoft.Json;
using System.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

public class ReportLayout
{
    public ReportLayout()
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
    }

    //public Task<PrintViewLayoutResponse> CallViewLayout(string Code, string docEntry/*, IWebAssemblyHostEnvironment _webHostEnvironment*/)
    //{
    //    try
    //    {
    //        var reportSetup = GetParamaterLayout(Code).Result;
    //        string rootpath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot");
    //        var path = $"{rootpath}\\Report\\{reportSetup.Rows[0]["FILENAME"]}";
    //        var type = getTypeExport(reportSetup.Rows[0]["EXPORTTYPE"].ToString()!);
    //        var tes1 = reportSetup.Rows[0]["PROPERTIES"].ToString();
    //        var reportBody = JsonConvert.DeserializeObject<List<ReportBodyResponse>>(reportSetup.Rows[0]["PROPERTIES"].ToString());
    //        Dictionary<string, string> parameters = new Dictionary<string, string>();
    //        LocalReport lr = new LocalReport();
    //        Stream reportDefinition = System.IO.File.OpenRead(path);
    //        lr.LoadReportDefinition(reportDefinition);
    //        foreach (var a in reportBody)
    //        {
    //            DataTable dt = GetValueFromStore(a.TypeOfParameter.ToString()!, docEntry).Result;
    //            lr.DataSources.Add(new ReportDataSource(a.DataSetName.ToString()!, dt));
    //        }
    //        lr.Refresh();
    //        var result = lr.Render(reportSetup.Rows[0]["EXPORTTYPE"].ToString()!);
    //        return Task.FromResult(new PrintViewLayoutResponse
    //        {
    //            ErrorCode = 0,
    //            ErrorMessage = "",
    //            Data = result,
    //            ApplicationType = type.Item2,
    //            FileName = type.Item3
    //        });
    //    }
    //    catch (Exception ex)
    //    {
    //        return Task.FromResult(new PrintViewLayoutResponse
    //        {
    //            ErrorCode = ex.GetHashCode(),
    //            ErrorMessage = ex.Message
    //        });
    //    }
    //}
    private Tuple<string, string, string> getTypeExport(string type)
    {
        if (type == "PDF")
        {
            return Tuple.Create("PDF", "application/pdf", "");
        }
        else if (type == "WORD")
        {
            return Tuple.Create("WORD", "application/msword", "word.doc");
        }
        else if (type == "EXCEL")
        {
            return Tuple.Create("EXCEL", "application/xlsx", "excel.xls");
        }
        return Tuple.Create("PDF", "application/pdf", "");
    }
    //private Task<DataTable> GetValueFromStore(string type, string docEntry)
    //{
    //    return Task.FromResult(new GetRecordByDataTable(
    //                     GetRecordByDataTable.StoreType.Layout,
    //                     type,
    //                     docEntry,
    //                     "",
    //                     "",
    //                     "",
    //                     "").GetResultDataTable());
    //}
    //private Task<DataTable> GetParamaterLayout(string Code)
    //{
    //    return Task.FromResult(new GetRecordByDataTable(
    //                     GetRecordByDataTable.StoreType.Config,
    //                     Configure.LayoutPrintType!,
    //                     Code,
    //                     "",
    //                     "",
    //                     "",
    //                     "").GetResultDataTable());
    //}
}