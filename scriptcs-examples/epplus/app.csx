using System.IO;
using System.IO.File;
using System.Linq;
using OfficeOpenXml;

var fileinfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "Book1.xlsx"));
Console.WriteLine(fileinfo);

ExcelPackage pck = new ExcelPackage(fileinfo);
var ws = pck.Workbook.Worksheets.First();
var sum = 0;
for(var i = 2; i<ws.Dimension.End.Row + 1; i++){
	Console.WriteLine(string.Format("Name {0} - Price {1}", 
									ws.Cells[i, 1].Value,
									ws.Cells[i, 2].Value));
	sum += int.Parse(ws.Cells[i, 2].Value.ToString());
}
Console.WriteLine(sum);
Console.ReadKey();
