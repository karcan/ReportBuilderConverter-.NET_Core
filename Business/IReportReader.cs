using ReportBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public interface IReportReader
    {
        public List<Parameter> Parameters();
        public List<DataSource> DataSources();
        public List<DataSet> DataSets();
    }
}
