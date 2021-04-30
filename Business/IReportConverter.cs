using ReportBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public interface IReportConverter
    {

        public byte[] toByte(string reportFilePath, ReportExtension fileExtension);
        public byte[] toByte(string reportFilePath, ReportExtension fileExtension, IDictionary<string, string> paramValues); 
    }
}
