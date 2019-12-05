using System.Collections.Generic;

namespace Common_Layer.INlogService
{
    public interface INlogService
    {
        void TraceLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
        void DebugLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
        void InfoLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
        void WarnLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
        void ErrorLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
        void FatalLogger(string logMessage, List<KeyValuePair<object, object>> keyValuesList = null);
    }
}
